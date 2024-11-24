namespace CapaPresentacion
{
    partial class frmAddGranPremio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddGranPremio));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lbNombreGP = new TextBox();
            lbPais = new TextBox();
            lbLongitud = new TextBox();
            lbDescripcion = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 22);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Gran Premio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(32, 50);
            label2.Name = "label2";
            label2.Size = new Size(147, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre Gran Premio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(32, 100);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 2;
            label3.Text = "Pais de origen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F);
            label4.Location = new Point(32, 156);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 3;
            label4.Text = "Longitud";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F);
            label5.Location = new Point(32, 210);
            label5.Name = "label5";
            label5.Size = new Size(130, 17);
            label5.TabIndex = 4;
            label5.Text = "Imagen del circuito";
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 11.25F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(66, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Arial", 11.25F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(147, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(180, 208);
            button3.Name = "button3";
            button3.Size = new Size(118, 23);
            button3.TabIndex = 7;
            button3.Text = "Añadir imagen";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lbNombreGP
            // 
            lbNombreGP.Location = new Point(180, 49);
            lbNombreGP.Name = "lbNombreGP";
            lbNombreGP.Size = new Size(118, 23);
            lbNombreGP.TabIndex = 8;
            // 
            // lbPais
            // 
            lbPais.Location = new Point(180, 100);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(118, 23);
            lbPais.TabIndex = 9;
            // 
            // lbLongitud
            // 
            lbLongitud.Location = new Point(180, 155);
            lbLongitud.Name = "lbLongitud";
            lbLongitud.Size = new Size(118, 23);
            lbLongitud.TabIndex = 10;
            // 
            // lbDescripcion
            // 
            lbDescripcion.Location = new Point(32, 278);
            lbDescripcion.Multiline = true;
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(244, 117);
            lbDescripcion.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F);
            label6.Location = new Point(32, 249);
            label6.Name = "label6";
            label6.Size = new Size(86, 17);
            label6.TabIndex = 12;
            label6.Text = "Descripcion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(304, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 459);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 234);
            label7.Name = "label7";
            label7.Size = new Size(192, 15);
            label7.TabIndex = 14;
            label7.Text = "Solo se admiten archivo.png (PNG)";
            // 
            // frmAddGranPremio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 450);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(lbDescripcion);
            Controls.Add(lbLongitud);
            Controls.Add(lbPais);
            Controls.Add(lbNombreGP);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAddGranPremio";
            Text = "EternalDrivers | GranPremio";
            Load += frmAddGranPremio_Load;
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
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox lbNombreGP;
        private TextBox lbPais;
        private TextBox lbLongitud;
        private TextBox lbDescripcion;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
    }
}