# ⚡ Galio Flash Tool – Firmware Loader para dispositivos Protolink

<img width="337" height="367" alt="GalioFlashTool-Program" src="https://github.com/user-attachments/assets/4356c24c-9b1e-44b2-b755-87fd9915d3c2" />

Galio Flash Tool es una herramienta ligera y profesional diseñada para cargar firmware en dispositivos **Protolink**, desarrollada por **Galio Electronics**.  
Incluye un bootloader robusto, comunicación serial optimizada y una terminal integrada para depuración.

---

## 🚀 Características principales

### 🔥 Bootloader integrado
- Envío del archivo `.hex` o `.bin` con ACK por hardware.
- Detección de errores de comunicación.
- Barra de progreso + porcentaje en tiempo real.
- Entrada automática a modo boot (DTR / RTS toggle).

<img width="337" height="367" alt="GalioFlashTool-Boot" src="https://github.com/user-attachments/assets/449e45cd-ecb5-4716-b614-6a6610687b34" />

---

### 🖥️ Terminal serial profesional
- Recepción en **ASCII** o **RAW/HEX**.
- Formato con **timestamp** opcional.
- Autoscroll automático.
- Envío en **ASCII / HEX**, con opción `NL/CR`.
- Vista limpia y minimalista.

<img width="337" height="367" alt="GalioFlashTool-Terminal" src="https://github.com/user-attachments/assets/f99d13ac-8f20-4720-879a-0ce1ffc63b37" />


---

## 🧩 Requisitos

- **Windows 10/11**
- **.NET Framework 4.7.2**  
  (preinstalado en la mayoría de PCs modernas)

---

## 📥 Descarga

Ve a la sección de **Releases** para descargar la última versión:

👉 https://github.com/<usuario>/<repo>/releases

Descarga el archivo:
GalioFlashTool_vX.Y.Z.zip


Descomprime y ejecuta:

Galio Flash Tool.exe


No requiere instalación.

---

## 🔧 Cómo usar

### 1️⃣ Conectar dispositivo
1. Conecta el equipo Protolink mediante USB o convertidor TTL/USB.
2. Elige:
   - **COM Port**
   - **Baud Rate**
3. Presiona **Connect**.

---

### 2️⃣ Cargar firmware
1. En el tab **Bootloader**, selecciona el archivo `.hex`.
2. Presiona **Upload**.
3. El software:
   - Entra automáticamente a modo bootloader.
   - Envía el firmware línea por línea.
   - Espera `ACK (0x06)` por cada línea.
   - Muestra progreso y porcentaje.

Al finalizar verás:


<img width="337" height="367" alt="image" src="https://github.com/user-attachments/assets/fccb7b26-367e-454a-bad1-09737640cf5d" />



---

### 3️⃣ Usar la terminal serial
1. Cambia al tab **Terminal**.
2. Elige:
   - Modo de recepción: **Text** o **Raw**
   - Modo de envío: **ASCII** o **HEX**
3. Escribe comandos y presiona **Send**.

Ideal para depurar sensores, Protolink o tus PIC.

---

## 🛡️ Seguridad y robustez

- Comunicación serial no bloqueante (ReadExisting).
- Buffer inteligente para evitar tramas truncadas.
- Manejo seguro de hilos (Invoke/BeginInvoke).
- Cancelación limpia al cerrar el COM.
- Protección contra cuelgues del bootloader.

---




