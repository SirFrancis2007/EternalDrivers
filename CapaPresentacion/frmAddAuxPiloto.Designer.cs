namespace CapaPresentacion
{
    partial class frmAddAuxPiloto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            TbnombreCorredor1 = new TextBox();
            tbPais = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Añadir Piloto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 103);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 149);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Nacionalidad";
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(129, 247);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(129, 194);
            button2.Name = "button2";
            button2.Size = new Size(135, 23);
            button2.TabIndex = 4;
            button2.Text = "Añadir imagen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 198);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 5;
            label4.Text = "Imagen piloto";
            // 
            // TbnombreCorredor1
            // 
            TbnombreCorredor1.Location = new Point(129, 100);
            TbnombreCorredor1.Name = "TbnombreCorredor1";
            TbnombreCorredor1.Size = new Size(134, 23);
            TbnombreCorredor1.TabIndex = 6;
            // 
            // tbPais
            // 
            tbPais.Location = new Point(129, 146);
            tbPais.Name = "tbPais";
            tbPais.Size = new Size(134, 23);
            tbPais.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(129, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 54);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Escuderia";
            // 
            // frmAddAuxPiloto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 282);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(tbPais);
            Controls.Add(TbnombreCorredor1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddAuxPiloto";
            Text = "frmAddAuxPiloto";
            Load += frmAddAuxPiloto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private TextBox TbnombreCorredor1;
        private TextBox tbPais;
        private ComboBox comboBox1;
        private Label label5;
    }
}