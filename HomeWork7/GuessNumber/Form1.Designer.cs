
namespace GuessNumber
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
            this.lblGameRules = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtUserAnswer = new System.Windows.Forms.TextBox();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lblMoreLess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGameRules
            // 
            this.lblGameRules.AutoSize = true;
            this.lblGameRules.Location = new System.Drawing.Point(125, 32);
            this.lblGameRules.Name = "lblGameRules";
            this.lblGameRules.Size = new System.Drawing.Size(146, 13);
            this.lblGameRules.TabIndex = 0;
            this.lblGameRules.Text = "Угадайте число от 1 до 100";
            this.lblGameRules.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(177, 93);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(84, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Введите число:";
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.Enabled = false;
            this.txtUserAnswer.Location = new System.Drawing.Point(267, 90);
            this.txtUserAnswer.MaxLength = 3;
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtUserAnswer.TabIndex = 2;
            this.txtUserAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserAnswer_KeyDown);
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(32, 188);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(75, 48);
            this.btnEasy.TabIndex = 3;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(164, 188);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 48);
            this.btnNormal.TabIndex = 4;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(292, 188);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(75, 48);
            this.btnHard.TabIndex = 5;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Location = new System.Drawing.Point(41, 93);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(55, 13);
            this.lblAttempts.TabIndex = 6;
            this.lblAttempts.Text = "Попыток:";
            // 
            // lblMoreLess
            // 
            this.lblMoreLess.AutoSize = true;
            this.lblMoreLess.Location = new System.Drawing.Point(126, 132);
            this.lblMoreLess.Name = "lblMoreLess";
            this.lblMoreLess.Size = new System.Drawing.Size(0, 13);
            this.lblMoreLess.TabIndex = 7;
            this.lblMoreLess.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.lblMoreLess);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblGameRules);
            this.Name = "Form1";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameRules;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtUserAnswer;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Label lblMoreLess;
    }
}

