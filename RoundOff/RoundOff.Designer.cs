namespace RoundOff
{
    partial class frmRoundOff
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtNumberInput = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnRound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(21, 25);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(161, 16);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter a number to round it:";
            // 
            // txtNumberInput
            // 
            this.txtNumberInput.Location = new System.Drawing.Point(50, 54);
            this.txtNumberInput.Name = "txtNumberInput";
            this.txtNumberInput.Size = new System.Drawing.Size(100, 20);
            this.txtNumberInput.TabIndex = 1;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(85, 116);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 16);
            this.lblAnswer.TabIndex = 2;
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(50, 80);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(100, 23);
            this.btnRound.TabIndex = 3;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // frmRoundOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 151);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtNumberInput);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmRoundOff";
            this.Text = "Round Off";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtNumberInput;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnRound;
    }
}

