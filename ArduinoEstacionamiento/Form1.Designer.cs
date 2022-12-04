namespace ArduinoEstacionamiento
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
            this.lblMedida = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblon = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picAutoR = new System.Windows.Forms.PictureBox();
            this.tmrMov = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picLED = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLED)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedida
            // 
            this.lblMedida.BackColor = System.Drawing.Color.PowderBlue;
            this.lblMedida.Font = new System.Drawing.Font("Open 24 Display St", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMedida.Location = new System.Drawing.Point(580, 12);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(147, 70);
            this.lblMedida.TabIndex = 0;
            this.lblMedida.Text = "0";
            this.lblMedida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApagar);
            this.groupBox1.Controls.Add(this.lblon);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(102, 31);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(79, 29);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblon
            // 
            this.lblon.AutoSize = true;
            this.lblon.Location = new System.Drawing.Point(187, 39);
            this.lblon.Name = "lblon";
            this.lblon.Size = new System.Drawing.Size(27, 13);
            this.lblon.TabIndex = 1;
            this.lblon.Text = "OFF";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(17, 31);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(79, 29);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM9";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ArduinoEstacionamiento.Properties.Resources.car1;
            this.pictureBox1.Location = new System.Drawing.Point(508, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // picAutoR
            // 
            this.picAutoR.BackColor = System.Drawing.Color.Transparent;
            this.picAutoR.Image = ((System.Drawing.Image)(resources.GetObject("picAutoR.Image")));
            this.picAutoR.Location = new System.Drawing.Point(0, 216);
            this.picAutoR.Name = "picAutoR";
            this.picAutoR.Size = new System.Drawing.Size(425, 188);
            this.picAutoR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAutoR.TabIndex = 4;
            this.picAutoR.TabStop = false;
            // 
            // tmrMov
            // 
            this.tmrMov.Enabled = true;
            this.tmrMov.Tick += new System.EventHandler(this.tmrMov_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Open 24 Display St", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 70);
            this.label1.TabIndex = 5;
            this.label1.Text = "La distancia es:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Open 24 Display St", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 70);
            this.label2.TabIndex = 6;
            this.label2.Text = "cm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLED
            // 
            this.picLED.BackColor = System.Drawing.Color.Transparent;
            this.picLED.Image = global::ArduinoEstacionamiento.Properties.Resources.farolgris;
            this.picLED.Location = new System.Drawing.Point(638, 85);
            this.picLED.Name = "picLED";
            this.picLED.Size = new System.Drawing.Size(69, 55);
            this.picLED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLED.TabIndex = 11;
            this.picLED.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArduinoEstacionamiento.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(940, 436);
            this.Controls.Add(this.picLED);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAutoR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMedida);
            this.Name = "Form1";
            this.Text = "Estacionamiento con medidor de distancia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLED)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblon;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picAutoR;
        private System.Windows.Forms.Timer tmrMov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLED;
    }
}

