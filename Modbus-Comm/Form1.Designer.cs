namespace Modbus_Comm
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ComboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.ComboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.ComboBoxParity = new System.Windows.Forms.ComboBox();
            this.ComboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.ComboBoxSerialComm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonConnect);
            this.panel1.Controls.Add(this.ComboBoxStopBit);
            this.panel1.Controls.Add(this.ComboBoxDataBits);
            this.panel1.Controls.Add(this.ComboBoxParity);
            this.panel1.Controls.Add(this.ComboBoxBaudRate);
            this.panel1.Controls.Add(this.ComboBoxSerialComm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(529, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 355);
            this.panel1.TabIndex = 3;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConnect.Location = new System.Drawing.Point(63, 279);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(137, 31);
            this.ButtonConnect.TabIndex = 4;
            this.ButtonConnect.Text = "Conectar";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ComboBoxStopBit
            // 
            this.ComboBoxStopBit.FormattingEnabled = true;
            this.ComboBoxStopBit.Items.AddRange(new object[] {
            "1 Stop bit",
            "2 Stop bit"});
            this.ComboBoxStopBit.Location = new System.Drawing.Point(3, 226);
            this.ComboBoxStopBit.Name = "ComboBoxStopBit";
            this.ComboBoxStopBit.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxStopBit.TabIndex = 5;
            // 
            // ComboBoxDataBits
            // 
            this.ComboBoxDataBits.FormattingEnabled = true;
            this.ComboBoxDataBits.Items.AddRange(new object[] {
            "7 Data bits",
            "8 Data bits"});
            this.ComboBoxDataBits.Location = new System.Drawing.Point(3, 141);
            this.ComboBoxDataBits.Name = "ComboBoxDataBits";
            this.ComboBoxDataBits.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxDataBits.TabIndex = 4;
            // 
            // ComboBoxParity
            // 
            this.ComboBoxParity.FormattingEnabled = true;
            this.ComboBoxParity.Items.AddRange(new object[] {
            "None Parity",
            "Odd Parity",
            "Even Parity"});
            this.ComboBoxParity.Location = new System.Drawing.Point(3, 183);
            this.ComboBoxParity.Name = "ComboBoxParity";
            this.ComboBoxParity.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxParity.TabIndex = 3;
            // 
            // ComboBoxBaudRate
            // 
            this.ComboBoxBaudRate.FormattingEnabled = true;
            this.ComboBoxBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "230400",
            "256000"});
            this.ComboBoxBaudRate.Location = new System.Drawing.Point(3, 101);
            this.ComboBoxBaudRate.Name = "ComboBoxBaudRate";
            this.ComboBoxBaudRate.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxBaudRate.TabIndex = 2;
            // 
            // ComboBoxSerialComm
            // 
            this.ComboBoxSerialComm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxSerialComm.IntegralHeight = false;
            this.ComboBoxSerialComm.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.ComboBoxSerialComm.Location = new System.Drawing.Point(3, 56);
            this.ComboBoxSerialComm.Name = "ComboBoxSerialComm";
            this.ComboBoxSerialComm.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxSerialComm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuração Serial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ComboBoxStopBit;
        private System.Windows.Forms.ComboBox ComboBoxDataBits;
        private System.Windows.Forms.ComboBox ComboBoxParity;
        private System.Windows.Forms.ComboBox ComboBoxBaudRate;
        private System.Windows.Forms.ComboBox ComboBoxSerialComm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonConnect;

        ModbusManager modbusmanger;
    }
}

