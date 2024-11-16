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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button8 = new Button();
            statusStrip1 = new StatusStrip();
            button10 = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Location = new Point(388, 44);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(320, 394);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(98, 90);
            button1.TabIndex = 0;
            button1.Text = "Ferrari";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(107, 3);
            button2.Name = "button2";
            button2.Size = new Size(98, 90);
            button2.TabIndex = 1;
            button2.Text = "Red Bull";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(211, 3);
            button3.Name = "button3";
            button3.Size = new Size(98, 90);
            button3.TabIndex = 2;
            button3.Text = "Williams";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(3, 99);
            button4.Name = "button4";
            button4.Size = new Size(98, 90);
            button4.TabIndex = 3;
            button4.Text = "Mclaren";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(107, 99);
            button5.Name = "button5";
            button5.Size = new Size(98, 90);
            button5.TabIndex = 4;
            button5.Text = "Mercedes";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
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
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(152, 78);
            button6.TabIndex = 0;
            button6.Text = "Agregar Escuderia";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(161, 3);
            button7.Name = "button7";
            button7.Size = new Size(153, 78);
            button7.TabIndex = 1;
            button7.Text = "Eliminar Escuderia";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Location = new Point(3, 87);
            button9.Name = "button9";
            button9.Size = new Size(153, 78);
            button9.TabIndex = 3;
            button9.Text = "Traspaso de pìlotos";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(162, 87);
            button8.Name = "button8";
            button8.Size = new Size(153, 78);
            button8.TabIndex = 2;
            button8.Text = "Salir";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.Right;
            statusStrip1.Location = new Point(776, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(24, 450);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // button10
            // 
            button10.Location = new Point(3, 171);
            button10.Name = "button10";
            button10.Size = new Size(152, 77);
            button10.TabIndex = 4;
            button10.Text = "Eliminar Piloto";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // frmMenuEscuderias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "frmMenuEscuderias";
            Text = "frmMenuGranPremio";
            Load += frmMenuEscuderias_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button6;
        private Button button7;
        private Button button8;
        private StatusStrip statusStrip1;
        private Button button9;
        private Button button10;
    }
}