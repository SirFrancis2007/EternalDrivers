﻿namespace CapaPresentacion
{
    partial class frmAddMonoplaza
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
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBoxVMonoplaza = new TextBox();
            textBoxHPMotor = new TextBox();
            label6 = new Label();
            textBoxDMotor = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Añadir Monoplaza";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 54);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Version";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 113);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Potencia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 169);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Imagen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 218);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 4;
            label5.Text = "Descripcion";
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(149, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(126, 169);
            button2.Name = "button2";
            button2.Size = new Size(149, 23);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxVMonoplaza
            // 
            textBoxVMonoplaza.Location = new Point(124, 54);
            textBoxVMonoplaza.Name = "textBoxVMonoplaza";
            textBoxVMonoplaza.Size = new Size(151, 23);
            textBoxVMonoplaza.TabIndex = 7;
            // 
            // textBoxHPMotor
            // 
            textBoxHPMotor.Location = new Point(124, 113);
            textBoxHPMotor.Name = "textBoxHPMotor";
            textBoxHPMotor.Size = new Size(106, 23);
            textBoxHPMotor.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 116);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 9;
            label6.Text = "HP.";
            // 
            // textBoxDMotor
            // 
            textBoxDMotor.Location = new Point(45, 246);
            textBoxDMotor.Multiline = true;
            textBoxDMotor.Name = "textBoxDMotor";
            textBoxDMotor.Size = new Size(280, 152);
            textBoxDMotor.TabIndex = 10;
            // 
            // frmAddMonoplaza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(textBoxDMotor);
            Controls.Add(label6);
            Controls.Add(textBoxHPMotor);
            Controls.Add(textBoxVMonoplaza);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddMonoplaza";
            Text = "frmAddMonoplaza";
            Load += frmAddMonoplaza_Load;
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
        private TextBox textBoxVMonoplaza;
        private TextBox textBoxHPMotor;
        private Label label6;
        private TextBox textBoxDMotor;
    }
}