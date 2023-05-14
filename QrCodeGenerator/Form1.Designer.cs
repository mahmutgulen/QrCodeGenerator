namespace QrCodeGenerator
{
    partial class Form1
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
            this.btn_generate = new System.Windows.Forms.Button();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.pic_qr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qr)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(12, 38);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(300, 45);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "Generate Qr Code";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // txt_link
            // 
            this.txt_link.Location = new System.Drawing.Point(12, 12);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(300, 20);
            this.txt_link.TabIndex = 1;
            // 
            // pic_qr
            // 
            this.pic_qr.Location = new System.Drawing.Point(12, 89);
            this.pic_qr.Name = "pic_qr";
            this.pic_qr.Size = new System.Drawing.Size(300, 300);
            this.pic_qr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_qr.TabIndex = 2;
            this.pic_qr.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 395);
            this.Controls.Add(this.pic_qr);
            this.Controls.Add(this.txt_link);
            this.Controls.Add(this.btn_generate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.PictureBox pic_qr;
    }
}

