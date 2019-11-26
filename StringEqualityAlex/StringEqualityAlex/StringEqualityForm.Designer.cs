namespace StringEqualityAlex
{
    partial class frmStringEquality
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
            this.lblString1 = new System.Windows.Forms.Label();
            this.lblCases = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblString2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblString1
            // 
            this.lblString1.AutoSize = true;
            this.lblString1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString1.Location = new System.Drawing.Point(74, 89);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(77, 20);
            this.lblString1.TabIndex = 0;
            this.lblString1.Text = "String 1:";
            // 
            // lblCases
            // 
            this.lblCases.AutoSize = true;
            this.lblCases.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCases.Location = new System.Drawing.Point(188, 53);
            this.lblCases.Name = "lblCases";
            this.lblCases.Size = new System.Drawing.Size(165, 21);
            this.lblCases.TabIndex = 1;
            this.lblCases.Text = "(Cases doesn\'t Matter)";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(83, 20);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(388, 24);
            this.lblEnter.TabIndex = 2;
            this.lblEnter.Text = "Enter two Strings to see if they are Equal";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(171, 182);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(88, 38);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(268, 91);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(212, 20);
            this.txtString1.TabIndex = 4;
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(268, 149);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(212, 20);
            this.txtString2.TabIndex = 5;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(116, 234);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(57, 20);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "label4";
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString2.Location = new System.Drawing.Point(74, 149);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(77, 20);
            this.lblString2.TabIndex = 8;
            this.lblString2.Text = "String 2:";
            // 
            // frmStringEquality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 280);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lblCases);
            this.Controls.Add(this.lblString1);
            this.Name = "frmStringEquality";
            this.Text = "String Equality by Alex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblString1;
        private System.Windows.Forms.Label lblCases;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblString2;
    }
}

