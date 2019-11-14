namespace RoundingProgramAlex
{
    partial class frmRoundingProgram
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.nudDecimals = new System.Windows.Forms.NumericUpDown();
            this.btnRound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimals)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(12, 34);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(217, 24);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter a decimal number:";
            // 
            // txtDecimal
            // 
            this.txtDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimal.Location = new System.Drawing.Point(267, 38);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(161, 24);
            this.txtDecimal.TabIndex = 1;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(6, 117);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(438, 24);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "How many decimal places do you want to round to:";
            // 
            // nudDecimals
            // 
            this.nudDecimals.Location = new System.Drawing.Point(450, 117);
            this.nudDecimals.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDecimals.Name = "nudDecimals";
            this.nudDecimals.Size = new System.Drawing.Size(72, 20);
            this.nudDecimals.TabIndex = 3;
            // 
            // btnRound
            // 
            this.btnRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRound.Location = new System.Drawing.Point(199, 172);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(105, 33);
            this.btnRound.TabIndex = 4;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.BtnRound_Click);
            // 
            // frmRoundingProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 260);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.nudDecimals);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.lblEnter);
            this.Name = "frmRoundingProgram";
            this.Text = "Rounding Program";
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.NumericUpDown nudDecimals;
        private System.Windows.Forms.Button btnRound;
    }
}

