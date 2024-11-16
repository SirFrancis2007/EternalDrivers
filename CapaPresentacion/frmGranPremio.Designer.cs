namespace CapaPresentacion
{
    partial class frmGranPremio
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
            label4 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            lbTituloGp = new Label();
            lbDescripcion = new Label();
            lbPais = new Label();
            lbLongitud = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(38, 28);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(38, 344);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(38, 302);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Longitud";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(38, 250);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Pais";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(38, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(356, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(411, 324);
            dataGridView1.TabIndex = 5;
            // 
            // lbTituloGp
            // 
            lbTituloGp.AutoSize = true;
            lbTituloGp.ForeColor = Color.Transparent;
            lbTituloGp.Location = new Point(114, 28);
            lbTituloGp.Name = "lbTituloGp";
            lbTituloGp.Size = new Size(51, 15);
            lbTituloGp.TabIndex = 6;
            lbTituloGp.Text = "Nombre";
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.ForeColor = Color.Transparent;
            lbDescripcion.Location = new Point(38, 380);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(92, 15);
            lbDescripcion.TabIndex = 7;
            lbDescripcion.Text = "datodescripcion";
            // 
            // lbPais
            // 
            lbPais.AutoSize = true;
            lbPais.ForeColor = Color.Transparent;
            lbPais.Location = new Point(128, 250);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(52, 15);
            lbPais.TabIndex = 7;
            lbPais.Text = "datopais";
            // 
            // lbLongitud
            // 
            lbLongitud.AutoSize = true;
            lbLongitud.ForeColor = Color.Transparent;
            lbLongitud.Location = new Point(128, 302);
            lbLongitud.Name = "lbLongitud";
            lbLongitud.Size = new Size(52, 15);
            lbLongitud.TabIndex = 8;
            lbLongitud.Text = "datopais";
            // 
            // frmGranPremio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(800, 450);
            Controls.Add(lbLongitud);
            Controls.Add(lbPais);
            Controls.Add(lbDescripcion);
            Controls.Add(lbTituloGp);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmGranPremio";
            Text = "frmGranPremio";
            Load += frmGranPremio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label lbTituloGp;
        private Label lbDescripcion;
        private Label lbPais;
        private Label lbLongitud;
    }
}