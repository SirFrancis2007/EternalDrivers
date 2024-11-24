namespace CapaPresentacion
{
    partial class frmAddEscuderia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEscuderia));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxNombreEscuderia = new TextBox();
            textBoxPais = new TextBox();
            textBoxJefeEquipo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 22);
            label1.TabIndex = 0;
            label1.Text = "Nueva Escuderia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(41, 73);
            label2.Name = "label2";
            label2.Size = new Size(128, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre escuderia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(41, 128);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 2;
            label3.Text = "Pais de origen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F);
            label4.Location = new Point(41, 185);
            label4.Name = "label4";
            label4.Size = new Size(102, 17);
            label4.TabIndex = 3;
            label4.Text = "Jefe de equipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F);
            label5.Location = new Point(41, 236);
            label5.Name = "label5";
            label5.Size = new Size(128, 17);
            label5.TabIndex = 4;
            label5.Text = "Escudo Escuderia";
            // 
            // textBoxNombreEscuderia
            // 
            textBoxNombreEscuderia.Location = new Point(175, 72);
            textBoxNombreEscuderia.Name = "textBoxNombreEscuderia";
            textBoxNombreEscuderia.Size = new Size(130, 23);
            textBoxNombreEscuderia.TabIndex = 5;
            // 
            // textBoxPais
            // 
            textBoxPais.Location = new Point(175, 122);
            textBoxPais.Name = "textBoxPais";
            textBoxPais.Size = new Size(130, 23);
            textBoxPais.TabIndex = 6;
            // 
            // textBoxJefeEquipo
            // 
            textBoxJefeEquipo.Location = new Point(175, 185);
            textBoxJefeEquipo.Name = "textBoxJefeEquipo";
            textBoxJefeEquipo.Size = new Size(130, 23);
            textBoxJefeEquipo.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(175, 234);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 8;
            button1.Text = "Añadir imagen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OliveDrab;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Arial", 11.25F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(70, 394);
            button2.Name = "button2";
            button2.Size = new Size(88, 23);
            button2.TabIndex = 9;
            button2.Text = "Añadir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Arial", 11.25F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(164, 394);
            button3.Name = "button3";
            button3.Size = new Size(86, 23);
            button3.TabIndex = 10;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(322, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // frmAddEscuderia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(583, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxJefeEquipo);
            Controls.Add(textBoxPais);
            Controls.Add(textBoxNombreEscuderia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEscuderia";
            Text = "EternalDrivers | GranPremio";
            Load += frmAddEscuderia_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxNombreEscuderia;
        private TextBox textBoxPais;
        private TextBox textBoxJefeEquipo;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}