namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số a:";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(140, 97);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(369, 45);
            this.txta.TabIndex = 2;
            this.txta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tính toán";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(140, 167);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(369, 45);
            this.txtb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số b:";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(140, 243);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(369, 45);
            this.txtKetqua.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết quả:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 423);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Tính toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txta;
        private Label label2;
        private TextBox txtb;
        private Label label3;
        private TextBox txtKetqua;
        private Label label4;
    }
}