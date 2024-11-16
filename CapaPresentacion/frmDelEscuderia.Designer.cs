namespace CapaPresentacion
{
    partial class frmDelEscuderia
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F);
            label1.Location = new Point(14, 78);
            label1.Name = "label1";
            label1.Size = new Size(176, 17);
            label1.TabIndex = 0;
            label1.Text = "Selecciona una escuderia";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(193, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 25);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 11.25F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(136, 142);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 2;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmDelEscuderia
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(367, 181);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Font = new Font("Arial", 11.25F);
            ForeColor = Color.Transparent;
            Name = "frmDelEscuderia";
            Text = "frmDelEscuderia";
            Load += frmDelEscuderia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
    }
}