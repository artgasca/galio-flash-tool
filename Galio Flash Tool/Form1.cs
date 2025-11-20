using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Galio_Flash_Tool
{
   

    public partial class Form1 : Form
    {
        public bool nextLine = false; //bandera para enviar siguiente linea
        public bool terminal = false;
        public bool textMode = true;
        public bool bootmode = false;
        private string firmwareFullPath = "";
        System.Threading.Thread firmwareSender;
        private readonly ManualResetEventSlim _lineAckEvent = new ManualResetEventSlim(false);

        public delegate void updateDebugCallback(string str);
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "HEX/BIN Files (*.hex;*.bin)|*.hex;*.bin";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Guardas la ruta completa para uso interno
                firmwareFullPath = openFile.FileName;

                // Solo muestras el nombre del archivo
                txtFirmwareFile.Text = Path.GetFileName(openFile.FileName);

                // Pasas la ruta completa a tu parser actual
                readHexInfo(firmwareFullPath);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cb_port_Click(object sender, EventArgs e)
        {
            cb_port.Items.Clear();
            foreach (string SPort in System.IO.Ports.SerialPort.GetPortNames())
            {
                cb_port.Items.Add(SPort.Trim());
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (btn_connect.Text == "Disconnect")
            {
                if (sp1.IsOpen)
                {
                    sp1.Close();
                }
                btn_connect.Text = "Connect";
                //pictureBox_off.Visible = true;
                //pictureBox_On.Visible = false;
                //groupBox.Enabled = false;
                //groupBoxUpload.Enabled = false;
                //groupBox_Received.Enabled = false;
                //groupBox_SendData.Enabled = false;
                groupBox_hwInfo.Enabled = false;
                groupBox_fwFile.Enabled = false;
                groupBox_uploadProgress.Enabled = false;
                initApp();
            }
            else
            {
                try
                {
                    if (cb_port.Text == "")
                    {

                        MessageBox.Show("COM not selected", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        sp1.BaudRate = Int32.Parse(cb_baud.Text);
                        sp1.PortName = cb_port.Text;
                        sp1.Parity = Parity.None;
                        sp1.DataBits = 8;
                        sp1.ReadTimeout = -1;
                        sp1.Open();
                        btn_connect.Text = "Disconnect";
                        CheckForIllegalCrossThreadCalls = false;
                        //pictureBox_off.Visible = false;
                        //pictureBox_On.Visible = true;
                        //groupBox_Firmware.Enabled = true;
                        //groupBoxUpload.Enabled = true;
                        //groupBox_Received.Enabled = true;
                        //groupBox_SendData.Enabled = true;
                        //groupBox_info.Enabled = true;
                        groupBox_hwInfo.Enabled = true;
                        groupBox_fwFile.Enabled = true;
                        groupBox_uploadProgress.Enabled = true;
                        // 1) Forzar modo boot
                        EnterBootloaderMode(sp1);

                    }


                }
                catch (Exception)
                {

                    MessageBox.Show(cb_port.Text + " is already open", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (txtFirmwareFile.Text == "")
            {
                MessageBox.Show("Firmware not selected", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                if (sp1.IsOpen)
                {
                    try
                    {

                        bootmode = true;
                        firmwareSender = new System.Threading.Thread(sendFirmware);
                        firmwareSender.IsBackground = true;
                        firmwareSender.Start();
                        //sendFirmware();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Serial Port Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        sp1.Close();
                        initApp();

                    }
                }
                else
                {

                    MessageBox.Show("Serial Port Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    initApp();
                }


                //new Thread(serialFirmware).Start();
            }

        }


        private void stopSendingFirmware()
        {
            //issending = false;
            if (firmwareSender.Join(200) == false)
            {
                firmwareSender.Abort();
            }
            firmwareSender = null;
        }

        private void sendFirmware()
        {
            const int ackTimeoutMs = 2000; // 2 s por línea, ajusta a gusto
            int counter = 0;

            // Validación rápida: que sí haya archivo seleccionado
            if (string.IsNullOrEmpty(firmwareFullPath))
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Firmware file not selected.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
                return;
            }

            try
            {
                // Deshabilitar UI mientras se envía
                Invoke(new Action(() =>
                {
                    tabControl1.Enabled = false;
                    progressBar1.Value = 0;
                    lbl_transferLines.Text = "0";
                }));

                // ⬅️ AQUÍ es donde cambiamos: usamos firmwareFullPath en lugar de txtFirmwareFile.Text
                using (var fileToSend = new StreamReader(firmwareFullPath))
                {
                    string line;

                    while ((line = fileToSend.ReadLine()) != null)
                    {
                        // Solo líneas Intel HEX que empiezan con ':'
                        if (string.IsNullOrEmpty(line) || line[0] != ':')
                            continue;

                        // Enviar línea + CR
                        byte[] fin = { 0x0D };
                        sp1.Write(line);
                        sp1.Write(fin, 0, 1);

                        // Preparar espera de ACK
                        nextLine = false;
                        _lineAckEvent.Reset();

                        // Esperar ACK del PIC
                        if (!_lineAckEvent.Wait(ackTimeoutMs))
                        {
                            // Timeout
                            Invoke(new Action(() =>
                            {
                                MessageBox.Show("Not response from PIC", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cleanVariablesUpload();
                            }));
                            return; // salimos de la función
                        }

                        // ACK recibido, actualizar progreso
                        counter++;
                        Invoke(new Action(() =>
                        {
                            progressBar1.Value = counter;
                            lbl_transferLines.Text = counter.ToString();
                        }));
                    }
                }

                // Si llegamos aquí, no hubo timeout
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Firmware Uploaded", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bootmode = false;
                    cleanVariablesUpload();
                }));
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Error sending firmware:\r\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cleanVariablesUpload();
                }));
            }
            finally
            {
                Invoke(new Action(() =>
                {
                    tabControl1.Enabled = true;
                }));

                stopSendingFirmware();
            }
        }

        //private void sendFirmware()
        //{
        //    tabControl1.Enabled = false;
        //    string line;
        //    int counter = 0;
        //    //Se abre el archivo de nuevo para escribirlo en el serial
        //    System.IO.StreamReader fileToSend = new System.IO.StreamReader(txtFirmwareFile.Text);
        //    uint j = 0;
        //    uint limite = 829496729;

        //    while ((line = fileToSend.ReadLine()) != null)
        //    {
        //        if (line[0] == ':')
        //        {
        //            byte[] fin = { 0x0D };
        //            sp1.Write(line);
        //            sp1.Write(fin, 0, 1);
        //            j = 0;
        //            while (!nextLine && j != limite) j++; //Se cicla esperando bandera o timeout (contador j)

        //            if (j == limite)
        //            {
        //                MessageBox.Show("Not response from PIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                cleanVariablesUpload();

        //                break;
        //            }
        //            progressBar1.Value = ++counter; // Se va sumando el contador de la barra
        //            nextLine = false;
        //            lbl_transferLines.Text = counter.ToString();

        //        }
        //    }
        //    if (j != limite) //Significa que no hubo timeout
        //    {

        //        MessageBox.Show("Firmware Uploaded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        bootmode = false;
        //    }


        //    fileToSend.Close(); //cerramos el archivo
        //    cleanVariablesUpload(); //limpiamos variables
        //    tabControl1.Enabled = true;
        //    stopSendingFirmware();



        //}
        private void initApp()
        {
            btn_connect.Text = "Connect";
            txtFirmwareFile.Text = "";
            lbl_created.Text = "-";
            lbl_microcontroller.Text = "-";
            lbl_totalLines.Text = "0";
            lbl_transferLines.Text = "0";
            groupBox_fwFile.Enabled = false;
            groupBox_uploadProgress.Enabled = false;
         
            //groupBox_SendData.Enabled = false;
            //groupBox_info.Enabled = false;
            //pictureBox_off.Visible = true;
            //pictureBox_On.Visible = false;

            lbl_hwInfoDate.Text = "----";
            lbl_hwInfoName.Text = "----";
            lbl_hwInfoTime.Text = "----";
            lbl_hwInfoVersion.Text = "----";

            //richTextBox_received.Clear();
            //txtbox_dataSend.Clear();




        }

        private void EnterBootloaderMode(SerialPort port)
        {
            if (!port.IsOpen)
                port.Open();

            // ser.setDTR(True)
            // ser.setRTS(True)
            port.DtrEnable = true;
            port.RtsEnable = true;
            Thread.Sleep(500);   // time.sleep(2)

            // ser.setDTR(False)   # RESET en HIGH
            // ser.setRTS(True)    # BOOT en LOW
            port.DtrEnable = false;
            port.RtsEnable = true;
            Thread.Sleep(100);    // time.sleep(0.1)

            // ser.setDTR(True)    # RESET en LOW
            // ser.setRTS(False)   # BOOT en HIGH
            port.DtrEnable = true;
            port.RtsEnable = false;
            Thread.Sleep(200);    // time.sleep(0.2)

            // ser.setDTR(False)   # BOOT EN HIGH, end
            port.DtrEnable = false;
            // RTS lo dejamos como esté según tu diseño
        }


        private void cleanVariablesUpload()
        {
            progressBar1.Value = 0;
            lbl_transferLines.Text = "0";
        }

        private void readHexInfo(string fullPath)
        {
            int counter = 0;
            int maxlines;
            string line;
            //string device;
            //string created;
            int found = 0;
            System.IO.StreamReader file = new StreamReader(fullPath);
            // lbl_total_lines.Text = "0%";
            progressBar1.Value = 0;
            while ((line = file.ReadLine()) != null)
                if (line[0] == ':')
                {
                    counter++;
                }
                else if (line[0] == ';')
                {
                    if (line.Contains("CREATED"))
                    {
                        found = line.IndexOf("CREATED=");
                        lbl_created.Text = line.Substring(found + 8);
                        //created = line;
                        //lbl_created.Text = line.Substring("CREATED=");
                    }
                    else
                    {

                        lbl_microcontroller.Text = line.Substring(1);
                    }
                }



            file.Close();
            //lbl_microcontroller.Text = device;
            //lbl_created.Text = created;

            progressBar1.Maximum = counter;
            maxlines = counter;
            lbl_totalLines.Text = counter.ToString();
            counter = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string SPort in System.IO.Ports.SerialPort.GetPortNames())
            {
                cb_port.Items.Add(SPort.Trim());
            }
        }

        private void sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if ((sp1.IsOpen))
            {
                try
                {

                    if (terminal) // MODO TERMINAL
                    {
                        int bytesReceived = sp1.BytesToRead;
                        byte[] bufferReceived = new byte[bytesReceived];
                        sp1.Read(bufferReceived, 0, bytesReceived);

                        if (textMode) //En modo texto buscamos cada byte por el salto de linea
                        {
                            string str = Encoding.ASCII.GetString(bufferReceived, 0, bytesReceived);
                            //updateTerminal(str);
                        }
                        else // MODO HEXADECIMAL en modo hex se formatean los datos en hex
                        {
                            //updateTerminal(ByteArrayToHexString(bufferReceived));
                        }
                    }
                    else if (bootmode) //MODO BOOTLOADER
                    {
                        int bytes = sp1.BytesToRead;
                        byte[] buffer = new byte[bytes];
                        sp1.Read(buffer, 0, bytes);

                        for (int i = 0; i < bytes; i++)
                        {
                            if (buffer[i] == 0x06) // ACK
                            {
                                nextLine = true;
                                _lineAckEvent.Set();   // despierta al hilo de envío
                                break;
                            }
                        }

                    }
                    else
                    {
                        String info = sp1.ReadLine();
                        Console.WriteLine(info);
                        if (info.Contains("name") && info.Contains("version"))
                        {
                            string[] info_s = info.Split('=', ',');
                            Console.WriteLine("llego");
                            lbl_hwInfoName.Text = info_s[1].ToString();
                            lbl_hwInfoVersion.Text = info_s[3].ToString();
                            lbl_hwInfoDate.Text = info_s[5].ToString();
                            lbl_hwInfoTime.Text = info_s[7].ToString();

                        }


                    }

                }
                catch (TimeoutException)
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
