namespace CapaPresentacion
{
    partial class frmUpdTraspaso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdTraspaso));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxNombreCorredorA = new ComboBox();
            comboBoxNombreCorredorB = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            dataGridViewPilotos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPilotos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(33, 18);
            label1.Name = "label1";
            label1.Size = new Size(195, 24);
            label1.TabIndex = 0;
            label1.Text = "Traspaso escuderia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 11.25F);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(33, 80);
            label2.Name = "label2";
            label2.Size = new Size(159, 17);
            label2.TabIndex = 1;
            label2.Text = "Seleccione un corredor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 11.25F);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(33, 170);
            label3.Name = "label3";
            label3.Size = new Size(159, 17);
            label3.TabIndex = 2;
            label3.Text = "Seleccione un corredor";
            // 
            // comboBoxNombreCorredorA
            // 
            comboBoxNombreCorredorA.BackColor = Color.White;
            comboBoxNombreCorredorA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNombreCorredorA.FormattingEnabled = true;
            comboBoxNombreCorredorA.Location = new Point(198, 79);
            comboBoxNombreCorredorA.Name = "comboBoxNombreCorredorA";
            comboBoxNombreCorredorA.Size = new Size(142, 23);
            comboBoxNombreCorredorA.TabIndex = 3;
            // 
            // comboBoxNombreCorredorB
            // 
            comboBoxNombreCorredorB.BackColor = Color.White;
            comboBoxNombreCorredorB.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNombreCorredorB.FormattingEnabled = true;
            comboBoxNombreCorredorB.Location = new Point(198, 170);
            comboBoxNombreCorredorB.Name = "comboBoxNombreCorredorB";
            comboBoxNombreCorredorB.Size = new Size(142, 23);
            comboBoxNombreCorredorB.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(56, 399);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 6;
            button1.Text = "Traspasar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(167, 399);
            button2.Name = "button2";
            button2.Size = new Size(105, 23);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridViewPilotos
            // 
            dataGridViewPilotos.AllowUserToAddRows = false;
            dataGridViewPilotos.AllowUserToDeleteRows = false;
            dataGridViewPilotos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPilotos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPilotos.BackgroundColor = Color.White;
            dataGridViewPilotos.BorderStyle = BorderStyle.None;
            dataGridViewPilotos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewPilotos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPilotos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPilotos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPilotos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPilotos.EnableHeadersVisualStyles = false;
            dataGridViewPilotos.Location = new Point(369, 29);
            dataGridViewPilotos.Name = "dataGridViewPilotos";
            dataGridViewPilotos.ReadOnly = true;
            dataGridViewPilotos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPilotos.RowHeadersVisible = false;
            dataGridViewPilotos.Size = new Size(366, 394);
            dataGridViewPilotos.TabIndex = 8;
            // 
            // frmUpdTraspaso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(765, 450);
            Controls.Add(dataGridViewPilotos);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxNombreCorredorB);
            Controls.Add(comboBoxNombreCorredorA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmUpdTraspaso";
            Text = "EternalDrivers | Traspaso";
            Load += frmUpdTraspaso_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPilotos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxNombreCorredorA;
        private ComboBox comboBoxNombreCorredorB;
        private Button button1;
        private Button button2;
        private DataGridView dataGridViewPilotos;
    }
}