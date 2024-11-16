namespace CapaPresentacion
{
    partial class frmDelPiloto
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
            comboBoxEscuderias = new ComboBox();
            comboBoxPilotos = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxEscuderias
            // 
            comboBoxEscuderias.FormattingEnabled = true;
            comboBoxEscuderias.Location = new Point(139, 41);
            comboBoxEscuderias.Name = "comboBoxEscuderias";
            comboBoxEscuderias.Size = new Size(121, 23);
            comboBoxEscuderias.TabIndex = 0;
            comboBoxEscuderias.SelectedIndexChanged += comboBoxEscuderias_SelectedIndexChanged;
            // 
            // comboBoxPilotos
            // 
            comboBoxPilotos.FormattingEnabled = true;
            comboBoxPilotos.Location = new Point(139, 94);
            comboBoxPilotos.Name = "comboBoxPilotos";
            comboBoxPilotos.Size = new Size(121, 23);
            comboBoxPilotos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(17, 44);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione escuderia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(17, 97);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 3;
            label2.Text = "Seleccione corredor";
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(115, 129);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmDelPiloto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(317, 164);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxPilotos);
            Controls.Add(comboBoxEscuderias);
            Name = "frmDelPiloto";
            Text = "frmDelPiloto";
            Load += frmDelPiloto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxEscuderias;
        private ComboBox comboBoxPilotos;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}