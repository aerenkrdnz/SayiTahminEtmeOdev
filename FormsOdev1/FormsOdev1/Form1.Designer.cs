namespace FormsOdev1
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
            btnTahminEt = new Button();
            txtTahmin = new TextBox();
            SuspendLayout();
            // 
            // btnTahminEt
            // 
            btnTahminEt.BackColor = Color.Salmon;
            btnTahminEt.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnTahminEt.ForeColor = Color.Gold;
            btnTahminEt.Location = new Point(67, 83);
            btnTahminEt.Name = "btnTahminEt";
            btnTahminEt.Size = new Size(137, 40);
            btnTahminEt.TabIndex = 0;
            btnTahminEt.Text = "button1";
            btnTahminEt.UseVisualStyleBackColor = false;
            btnTahminEt.Click += btnTahminEt_Click;
            // 
            // txtTahmin
            // 
            txtTahmin.BackColor = Color.YellowGreen;
            txtTahmin.ForeColor = SystemColors.WindowText;
            txtTahmin.Location = new Point(67, 54);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(137, 23);
            txtTahmin.TabIndex = 1;
            txtTahmin.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(265, 158);
            Controls.Add(txtTahmin);
            Controls.Add(btnTahminEt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTahminEt;
        private TextBox txtTahmin;
    }
}