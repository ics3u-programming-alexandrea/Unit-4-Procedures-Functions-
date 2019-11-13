namespace PasssByReferenceAlex
{
    partial class frmPassByReference
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblClick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.Image = global::PasssByReferenceAlex.Properties.Resources.QS;
            this.picImage.Location = new System.Drawing.Point(3, 88);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(388, 452);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.PicImage_Click);
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClick.Location = new System.Drawing.Point(77, 41);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(271, 24);
            this.lblClick.TabIndex = 1;
            this.lblClick.Text = "Click the Image to Change it";
            // 
            // frmPassByReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 561);
            this.Controls.Add(this.lblClick);
            this.Controls.Add(this.picImage);
            this.Name = "frmPassByReference";
            this.Text = "Pass By Reference";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblClick;
    }
}

