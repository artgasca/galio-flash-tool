namespace Galio_Flash_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_port = new System.Windows.Forms.GroupBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.cb_baud = new System.Windows.Forms.ComboBox();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProgram = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.lbl_uploadStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_totalLines = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_transferLines = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_created = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_microcontroller = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPageTerminal = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_autoReset = new System.Windows.Forms.CheckBox();
            this.lbl_hwInfoVersion = new System.Windows.Forms.Label();
            this.lbl_hwInfoName = new System.Windows.Forms.Label();
            this.lbl_hwInfoDate = new System.Windows.Forms.Label();
            this.lbl_hwInfoTime = new System.Windows.Forms.Label();
            this.groupBox_port.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageProgram.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_port
            // 
            this.groupBox_port.Controls.Add(this.checkBox_autoReset);
            this.groupBox_port.Controls.Add(this.btn_connect);
            this.groupBox_port.Controls.Add(this.cb_baud);
            this.groupBox_port.Controls.Add(this.cb_port);
            this.groupBox_port.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox_port.Location = new System.Drawing.Point(12, 13);
            this.groupBox_port.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_port.Name = "groupBox_port";
            this.groupBox_port.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_port.Size = new System.Drawing.Size(249, 69);
            this.groupBox_port.TabIndex = 0;
            this.groupBox_port.TabStop = false;
            this.groupBox_port.Text = "COM Port";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(140, 11);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(95, 33);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            // 
            // cb_baud
            // 
            this.cb_baud.FormattingEnabled = true;
            this.cb_baud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cb_baud.Location = new System.Drawing.Point(73, 15);
            this.cb_baud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_baud.Name = "cb_baud";
            this.cb_baud.Size = new System.Drawing.Size(61, 23);
            this.cb_baud.TabIndex = 2;
            this.cb_baud.Text = "115200";
            // 
            // cb_port
            // 
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(6, 15);
            this.cb_port.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(61, 23);
            this.cb_port.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageProgram);
            this.tabControl1.Controls.Add(this.tabPageTerminal);
            this.tabControl1.Location = new System.Drawing.Point(12, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(431, 341);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageProgram
            // 
            this.tabPageProgram.Controls.Add(this.groupBox3);
            this.tabPageProgram.Controls.Add(this.groupBox2);
            this.tabPageProgram.Controls.Add(this.groupBox1);
            this.tabPageProgram.Location = new System.Drawing.Point(4, 24);
            this.tabPageProgram.Name = "tabPageProgram";
            this.tabPageProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProgram.Size = new System.Drawing.Size(423, 313);
            this.tabPageProgram.TabIndex = 0;
            this.tabPageProgram.Text = "Program";
            this.tabPageProgram.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_upload);
            this.groupBox2.Controls.Add(this.lbl_uploadStatus);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl_totalLines);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbl_transferLines);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(11, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upload Progress";
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(299, 45);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(95, 33);
            this.btn_upload.TabIndex = 7;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            // 
            // lbl_uploadStatus
            // 
            this.lbl_uploadStatus.AutoSize = true;
            this.lbl_uploadStatus.Location = new System.Drawing.Point(245, 45);
            this.lbl_uploadStatus.Name = "lbl_uploadStatus";
            this.lbl_uploadStatus.Size = new System.Drawing.Size(48, 15);
            this.lbl_uploadStatus.TabIndex = 6;
            this.lbl_uploadStatus.Text = "Waiting";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Status:";
            // 
            // lbl_totalLines
            // 
            this.lbl_totalLines.AutoSize = true;
            this.lbl_totalLines.Location = new System.Drawing.Point(86, 41);
            this.lbl_totalLines.Name = "lbl_totalLines";
            this.lbl_totalLines.Size = new System.Drawing.Size(13, 15);
            this.lbl_totalLines.TabIndex = 4;
            this.lbl_totalLines.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "/";
            // 
            // lbl_transferLines
            // 
            this.lbl_transferLines.AutoSize = true;
            this.lbl_transferLines.Location = new System.Drawing.Point(49, 41);
            this.lbl_transferLines.Name = "lbl_transferLines";
            this.lbl_transferLines.Size = new System.Drawing.Size(13, 15);
            this.lbl_transferLines.TabIndex = 2;
            this.lbl_transferLines.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lines:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(388, 16);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_created);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_microcontroller);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(11, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firmware File";
            // 
            // lbl_created
            // 
            this.lbl_created.AutoSize = true;
            this.lbl_created.Location = new System.Drawing.Point(228, 58);
            this.lbl_created.Name = "lbl_created";
            this.lbl_created.Size = new System.Drawing.Size(30, 15);
            this.lbl_created.TabIndex = 5;
            this.lbl_created.Text = "--:--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Compiled:";
            // 
            // lbl_microcontroller
            // 
            this.lbl_microcontroller.AutoSize = true;
            this.lbl_microcontroller.Location = new System.Drawing.Point(49, 58);
            this.lbl_microcontroller.Name = "lbl_microcontroller";
            this.lbl_microcontroller.Size = new System.Drawing.Size(17, 15);
            this.lbl_microcontroller.TabIndex = 3;
            this.lbl_microcontroller.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Device:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(299, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(95, 33);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 23);
            this.textBox1.TabIndex = 0;
            // 
            // tabPageTerminal
            // 
            this.tabPageTerminal.Location = new System.Drawing.Point(4, 24);
            this.tabPageTerminal.Name = "tabPageTerminal";
            this.tabPageTerminal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTerminal.Size = new System.Drawing.Size(423, 313);
            this.tabPageTerminal.TabIndex = 1;
            this.tabPageTerminal.Text = "Terminal";
            this.tabPageTerminal.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_hwInfoTime);
            this.groupBox3.Controls.Add(this.lbl_hwInfoDate);
            this.groupBox3.Controls.Add(this.lbl_hwInfoName);
            this.groupBox3.Controls.Add(this.lbl_hwInfoVersion);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(11, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 76);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hardware Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Version:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Time:";
            // 
            // checkBox_autoReset
            // 
            this.checkBox_autoReset.AutoSize = true;
            this.checkBox_autoReset.Checked = true;
            this.checkBox_autoReset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autoReset.Location = new System.Drawing.Point(6, 43);
            this.checkBox_autoReset.Name = "checkBox_autoReset";
            this.checkBox_autoReset.Size = new System.Drawing.Size(80, 19);
            this.checkBox_autoReset.TabIndex = 3;
            this.checkBox_autoReset.Text = "Auto boot";
            this.checkBox_autoReset.UseVisualStyleBackColor = true;
            // 
            // lbl_hwInfoVersion
            // 
            this.lbl_hwInfoVersion.AutoSize = true;
            this.lbl_hwInfoVersion.Location = new System.Drawing.Point(68, 46);
            this.lbl_hwInfoVersion.Name = "lbl_hwInfoVersion";
            this.lbl_hwInfoVersion.Size = new System.Drawing.Size(27, 15);
            this.lbl_hwInfoVersion.TabIndex = 7;
            this.lbl_hwInfoVersion.Text = "----";
            // 
            // lbl_hwInfoName
            // 
            this.lbl_hwInfoName.AutoSize = true;
            this.lbl_hwInfoName.Location = new System.Drawing.Point(68, 22);
            this.lbl_hwInfoName.Name = "lbl_hwInfoName";
            this.lbl_hwInfoName.Size = new System.Drawing.Size(27, 15);
            this.lbl_hwInfoName.TabIndex = 8;
            this.lbl_hwInfoName.Text = "----";
            // 
            // lbl_hwInfoDate
            // 
            this.lbl_hwInfoDate.AutoSize = true;
            this.lbl_hwInfoDate.Location = new System.Drawing.Point(223, 22);
            this.lbl_hwInfoDate.Name = "lbl_hwInfoDate";
            this.lbl_hwInfoDate.Size = new System.Drawing.Size(27, 15);
            this.lbl_hwInfoDate.TabIndex = 9;
            this.lbl_hwInfoDate.Text = "----";
            // 
            // lbl_hwInfoTime
            // 
            this.lbl_hwInfoTime.AutoSize = true;
            this.lbl_hwInfoTime.Location = new System.Drawing.Point(223, 46);
            this.lbl_hwInfoTime.Name = "lbl_hwInfoTime";
            this.lbl_hwInfoTime.Size = new System.Drawing.Size(27, 15);
            this.lbl_hwInfoTime.TabIndex = 10;
            this.lbl_hwInfoTime.Text = "----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 451);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox_port);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galio Flash Tool v1.0";
            this.groupBox_port.ResumeLayout(false);
            this.groupBox_port.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageProgram.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox_port;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ComboBox cb_baud;
        private System.Windows.Forms.ComboBox cb_port;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageProgram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPageTerminal;
        private System.Windows.Forms.Label lbl_microcontroller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_created;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_uploadStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_totalLines;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_transferLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_autoReset;
        private System.Windows.Forms.Label lbl_hwInfoTime;
        private System.Windows.Forms.Label lbl_hwInfoDate;
        private System.Windows.Forms.Label lbl_hwInfoName;
        private System.Windows.Forms.Label lbl_hwInfoVersion;
    }
}

