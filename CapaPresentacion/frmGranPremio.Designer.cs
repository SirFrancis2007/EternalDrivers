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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGranPremio));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBoxGranPremio = new PictureBox();
            dataGridView1 = new DataGridView();
            lbTituloGp = new Label();
            lbDescripcion = new Label();
            lbPais = new Label();
            lbLongitud = new Label();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGranPremio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(38, 344);
            label2.Name = "label2";
            label2.Size = new Size(93, 18);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(38, 302);
            label3.Name = "label3";
            label3.Size = new Size(71, 18);
            label3.TabIndex = 2;
            label3.Text = "Longitud";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(38, 250);
            label4.Name = "label4";
            label4.Size = new Size(38, 18);
            label4.TabIndex = 3;
            label4.Text = "Pais";
            // 
            // pictureBoxGranPremio
            // 
            pictureBoxGranPremio.Location = new Point(38, 64);
            pictureBoxGranPremio.Name = "pictureBoxGranPremio";
            pictureBoxGranPremio.Size = new Size(274, 156);
            pictureBoxGranPremio.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGranPremio.TabIndex = 4;
            pictureBoxGranPremio.TabStop = false;
            pictureBoxGranPremio.Click += pictureBoxGranPremio_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(25, 25, 25);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Maroon;
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 25, 25);
            dataGridViewCellStyle2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.FromArgb(25, 25, 25);
            dataGridView1.Location = new Point(347, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(420, 324);
            dataGridView1.TabIndex = 5;
            // 
            // lbTituloGp
            // 
            lbTituloGp.AutoSize = true;
            lbTituloGp.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloGp.ForeColor = Color.Transparent;
            lbTituloGp.Location = new Point(38, 19);
            lbTituloGp.Name = "lbTituloGp";
            lbTituloGp.Size = new Size(83, 22);
            lbTituloGp.TabIndex = 6;
            lbTituloGp.Text = "Nombre";
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Font = new Font("Arial", 11.25F);
            lbDescripcion.ForeColor = Color.Transparent;
            lbDescripcion.Location = new Point(38, 380);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(111, 17);
            lbDescripcion.TabIndex = 7;
            lbDescripcion.Text = "datodescripcion";
            // 
            // lbPais
            // 
            lbPais.AutoSize = true;
            lbPais.Font = new Font("Arial", 11.25F);
            lbPais.ForeColor = Color.Transparent;
            lbPais.Location = new Point(128, 250);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(63, 17);
            lbPais.TabIndex = 7;
            lbPais.Text = "datopais";
            // 
            // lbLongitud
            // 
            lbLongitud.AutoSize = true;
            lbLongitud.Font = new Font("Arial", 11.25F);
            lbLongitud.ForeColor = Color.Transparent;
            lbLongitud.Location = new Point(128, 302);
            lbLongitud.Name = "lbLongitud";
            lbLongitud.Size = new Size(63, 17);
            lbLongitud.TabIndex = 8;
            lbLongitud.Text = "datopais";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(223, 302);
            label1.Name = "label1";
            label1.Size = new Size(38, 18);
            label1.TabIndex = 9;
            label1.Text = "Mts.";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Maroon;
            statusStrip1.Dock = DockStyle.Right;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(783, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(17, 450);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.TextDirection = ToolStripTextDirection.Vertical270;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(15, 87);
            toolStripStatusLabel1.Text = "Copyrigth 2024";
            // 
            // frmGranPremio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(label1);
            Controls.Add(lbLongitud);
            Controls.Add(lbPais);
            Controls.Add(lbDescripcion);
            Controls.Add(lbTituloGp);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBoxGranPremio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmGranPremio";
            Text = "EternalDrivers | GranPremio";
            Load += frmGranPremio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxGranPremio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBoxGranPremio;
        private DataGridView dataGridView1;
        private Label lbTituloGp;
        private Label lbDescripcion;
        private Label lbPais;
        private Label lbLongitud;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}