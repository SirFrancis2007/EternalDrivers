namespace CapaPresentacion
{
    partial class frmMenuEscuderias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuEscuderias));
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button8 = new Button();
            button10 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            label1 = new Label();
            panel1 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Location = new Point(388, 44);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(320, 394);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 27);
            label2.TabIndex = 6;
            label2.Text = "Escuderias";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(317, 27);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.Controls.Add(button7);
            flowLayoutPanel2.Controls.Add(button9);
            flowLayoutPanel2.Controls.Add(button8);
            flowLayoutPanel2.Controls.Add(button10);
            flowLayoutPanel2.Location = new Point(61, 45);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(318, 276);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(152, 89);
            button6.TabIndex = 0;
            button6.Text = "Agregar Escuderia";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(161, 3);
            button7.Name = "button7";
            button7.Size = new Size(153, 89);
            button7.TabIndex = 1;
            button7.Text = "Eliminar Escuderia";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            button9.ForeColor = Color.White;
            button9.Location = new Point(3, 98);
            button9.Name = "button9";
            button9.Size = new Size(153, 88);
            button9.TabIndex = 3;
            button9.Text = "Traspaso de pìlotos";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkCyan;
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(162, 98);
            button8.Name = "button8";
            button8.Size = new Size(153, 88);
            button8.TabIndex = 2;
            button8.Text = "Salir";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button10
            // 
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            button10.ForeColor = Color.White;
            button10.Location = new Point(3, 192);
            button10.Name = "button10";
            button10.Size = new Size(152, 88);
            button10.TabIndex = 4;
            button10.Text = "Eliminar Piloto";
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Maroon;
            statusStrip1.Dock = DockStyle.Right;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(783, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(17, 450);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.TextDirection = ToolStripTextDirection.Vertical270;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(15, 87);
            toolStripStatusLabel1.Text = "Copyrigth 2024";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(64, 354);
            label1.Name = "label1";
            label1.Size = new Size(131, 27);
            label1.TabIndex = 4;
            label1.Text = "Escuderias";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Location = new Point(64, 384);
            panel1.Name = "panel1";
            panel1.Size = new Size(139, 8);
            panel1.TabIndex = 5;
            // 
            // frmMenuEscuderias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenuEscuderias";
            Text = "frmMenuGranPremio";
            Load += frmMenuEscuderias_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button6;
        private Button button7;
        private Button button8;
        private StatusStrip statusStrip1;
        private Button button9;
        private Button button10;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label1;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label2;
    }
}