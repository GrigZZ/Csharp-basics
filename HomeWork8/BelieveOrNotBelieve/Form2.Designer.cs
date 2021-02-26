
namespace BelieveOrNotBelieve
{
    partial class Form2
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
            this.btnQuestionEditor = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnOpenQuestionList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuestionEditor
            // 
            this.btnQuestionEditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuestionEditor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuestionEditor.Location = new System.Drawing.Point(342, 12);
            this.btnQuestionEditor.Name = "btnQuestionEditor";
            this.btnQuestionEditor.Size = new System.Drawing.Size(155, 23);
            this.btnQuestionEditor.TabIndex = 0;
            this.btnQuestionEditor.Text = "Редактор вопросов";
            this.btnQuestionEditor.UseVisualStyleBackColor = true;
            this.btnQuestionEditor.Click += new System.EventHandler(this.btnQuestionEditor_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(12, 101);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(485, 99);
            this.textBox.TabIndex = 1;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 47);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Начать игру";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnYes
            // 
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.Enabled = false;
            this.btnYes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYes.Location = new System.Drawing.Point(147, 220);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(87, 49);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "Да";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.Enabled = false;
            this.btnNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNo.Location = new System.Drawing.Point(281, 220);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(87, 49);
            this.btnNo.TabIndex = 4;
            this.btnNo.Text = "Нет";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnOpenQuestionList
            // 
            this.btnOpenQuestionList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenQuestionList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenQuestionList.Location = new System.Drawing.Point(418, 41);
            this.btnOpenQuestionList.Name = "btnOpenQuestionList";
            this.btnOpenQuestionList.Size = new System.Drawing.Size(79, 54);
            this.btnOpenQuestionList.TabIndex = 5;
            this.btnOpenQuestionList.Text = "Загрузить список вопросов";
            this.btnOpenQuestionList.UseVisualStyleBackColor = true;
            this.btnOpenQuestionList.Click += new System.EventHandler(this.btnOpenQuestionList_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 289);
            this.Controls.Add(this.btnOpenQuestionList);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnQuestionEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Верю - не верю";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuestionEditor;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnOpenQuestionList;
    }
}