namespace CapaPresentacion
{
    partial class frmAddPuntosGranPremio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPuntosGranPremio));
            dataGridViewResultados = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            comboBoxPilotos = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            txtPosicion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultados).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResultados
            // 
            dataGridViewResultados.AllowUserToAddRows = false;
            dataGridViewResultados.AllowUserToDeleteRows = false;
            dataGridViewResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultados.Location = new Point(353, 13);
            dataGridViewResultados.Name = "dataGridViewResultados";
            dataGridViewResultados.ReadOnly = true;
            dataGridViewResultados.Size = new Size(348, 417);
            dataGridViewResultados.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 27);
            label1.Name = "label1";
            label1.Size = new Size(266, 22);
            label1.TabIndex = 1;
            label1.Text = "Resultados del gran Premio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(28, 93);
            label2.Name = "label2";
            label2.Size = new Size(142, 17);
            label2.TabIndex = 2;
            label2.Text = "Selecciona Corredor";
            // 
            // comboBoxPilotos
            // 
            comboBoxPilotos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPilotos.FormattingEnabled = true;
            comboBoxPilotos.Location = new Point(176, 87);
            comboBoxPilotos.Name = "comboBoxPilotos";
            comboBoxPilotos.Size = new Size(133, 23);
            comboBoxPilotos.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 11.25F);
            button1.Location = new Point(109, 196);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 4;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(36, 148);
            label3.Name = "label3";
            label3.Size = new Size(129, 17);
            label3.TabIndex = 5;
            label3.Text = "Ingrese la posicion";
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(176, 147);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(133, 23);
            txtPosicion.TabIndex = 6;
            // 
            // frmAddPuntosGranPremio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(714, 450);
            Controls.Add(txtPosicion);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(comboBoxPilotos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewResultados);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAddPuntosGranPremio";
            Text = "frmAddPuntosGranPremio";
            Load += frmAddPuntosGranPremio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewResultados;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxPilotos;
        private Button button1;
        private Label label3;
        private TextBox txtPosicion;
    }
}