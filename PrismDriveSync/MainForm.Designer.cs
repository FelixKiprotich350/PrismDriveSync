
namespace PrismDriveSync
{
    partial class MainForm
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
            this.Btn_Upload = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Select = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Btn_Upload
            // 
            this.Btn_Upload.Location = new System.Drawing.Point(515, 76);
            this.Btn_Upload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Upload.Name = "Btn_Upload";
            this.Btn_Upload.Size = new System.Drawing.Size(112, 35);
            this.Btn_Upload.TabIndex = 0;
            this.Btn_Upload.Text = "Upload";
            this.Btn_Upload.UseVisualStyleBackColor = true;
            this.Btn_Upload.Click += new System.EventHandler(this.Btn_Upload_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(640, 26);
            this.textBox1.TabIndex = 1;
            // 
            // Btn_Select
            // 
            this.Btn_Select.Location = new System.Drawing.Point(101, 76);
            this.Btn_Select.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(112, 35);
            this.Btn_Select.TabIndex = 2;
            this.Btn_Select.Text = "Select";
            this.Btn_Select.UseVisualStyleBackColor = true;
            this.Btn_Select.Click += new System.EventHandler(this.Btn_Select_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(75, 134);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(591, 262);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(75, 417);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(591, 31);
            this.progressBar1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 482);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Btn_Select);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Upload);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Upload;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_Select;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

