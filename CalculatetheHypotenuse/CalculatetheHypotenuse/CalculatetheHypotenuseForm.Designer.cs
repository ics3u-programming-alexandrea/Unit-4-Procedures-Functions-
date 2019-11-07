namespace CalculatetheHypotenuse
{
    partial class FrmCalculatetheHypotenuse
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOpposite = new System.Windows.Forms.Label();
            this.lblAdjacent = new System.Windows.Forms.Label();
            this.txtOpposite = new System.Windows.Forms.TextBox();
            this.txtAdjacent = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(285, 236);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 75);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate the Hypotenuse";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblOpposite
            // 
            this.lblOpposite.AutoSize = true;
            this.lblOpposite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpposite.Location = new System.Drawing.Point(21, 73);
            this.lblOpposite.Name = "lblOpposite";
            this.lblOpposite.Size = new System.Drawing.Size(432, 24);
            this.lblOpposite.TabIndex = 1;
            this.lblOpposite.Text = "Enter the value of the Opposite of the triangle";
            // 
            // lblAdjacent
            // 
            this.lblAdjacent.AutoSize = true;
            this.lblAdjacent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjacent.Location = new System.Drawing.Point(48, 154);
            this.lblAdjacent.Name = "lblAdjacent";
            this.lblAdjacent.Size = new System.Drawing.Size(395, 24);
            this.lblAdjacent.TabIndex = 2;
            this.lblAdjacent.Text = "Enter the value of Adjacent of the triangle";
            // 
            // txtOpposite
            // 
            this.txtOpposite.Location = new System.Drawing.Point(459, 78);
            this.txtOpposite.Name = "txtOpposite";
            this.txtOpposite.Size = new System.Drawing.Size(100, 20);
            this.txtOpposite.TabIndex = 3;
            // 
            // txtAdjacent
            // 
            this.txtAdjacent.Location = new System.Drawing.Point(459, 159);
            this.txtAdjacent.Name = "txtAdjacent";
            this.txtAdjacent.Size = new System.Drawing.Size(100, 20);
            this.txtAdjacent.TabIndex = 4;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(123, 353);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(395, 24);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "Enter the value of Adjacent of the triangle";
            // 
            // frmCalculatetheHypotenuse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtAdjacent);
            this.Controls.Add(this.txtOpposite);
            this.Controls.Add(this.lblAdjacent);
            this.Controls.Add(this.lblOpposite);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmCalculatetheHypotenuse";
            this.Text = "Calculate the Hypotenuse";
            this.Load += new System.EventHandler(this.FrmCalculatetheHypotenuse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblOpposite;
        private System.Windows.Forms.Label lblAdjacent;
        private System.Windows.Forms.TextBox txtOpposite;
        private System.Windows.Forms.TextBox txtAdjacent;
        private System.Windows.Forms.Label lblAnswer;
    }
}

