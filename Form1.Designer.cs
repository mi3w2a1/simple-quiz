namespace SimpleQuiz
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelChoices1 = new System.Windows.Forms.Label();
            this.labelChoices2 = new System.Windows.Forms.Label();
            this.labelChoices3 = new System.Windows.Forms.Label();
            this.labelChoices4 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.BackColor = System.Drawing.Color.Yellow;
            this.labelQuestion.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelQuestion.Location = new System.Drawing.Point(34, 22);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(475, 23);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "labelQuestion";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChoices1
            // 
            this.labelChoices1.BackColor = System.Drawing.Color.Blue;
            this.labelChoices1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelChoices1.ForeColor = System.Drawing.Color.White;
            this.labelChoices1.Location = new System.Drawing.Point(34, 69);
            this.labelChoices1.Name = "labelChoices1";
            this.labelChoices1.Size = new System.Drawing.Size(475, 23);
            this.labelChoices1.TabIndex = 1;
            this.labelChoices1.Text = "labelChoices1";
            this.labelChoices1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChoices2
            // 
            this.labelChoices2.BackColor = System.Drawing.Color.Blue;
            this.labelChoices2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelChoices2.ForeColor = System.Drawing.Color.White;
            this.labelChoices2.Location = new System.Drawing.Point(34, 103);
            this.labelChoices2.Name = "labelChoices2";
            this.labelChoices2.Size = new System.Drawing.Size(475, 23);
            this.labelChoices2.TabIndex = 2;
            this.labelChoices2.Text = "labelChoices2";
            this.labelChoices2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChoices3
            // 
            this.labelChoices3.BackColor = System.Drawing.Color.Blue;
            this.labelChoices3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelChoices3.ForeColor = System.Drawing.Color.White;
            this.labelChoices3.Location = new System.Drawing.Point(34, 138);
            this.labelChoices3.Name = "labelChoices3";
            this.labelChoices3.Size = new System.Drawing.Size(475, 23);
            this.labelChoices3.TabIndex = 3;
            this.labelChoices3.Text = "labelChoices3";
            this.labelChoices3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChoices4
            // 
            this.labelChoices4.BackColor = System.Drawing.Color.Blue;
            this.labelChoices4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelChoices4.ForeColor = System.Drawing.Color.White;
            this.labelChoices4.Location = new System.Drawing.Point(34, 171);
            this.labelChoices4.Name = "labelChoices4";
            this.labelChoices4.Size = new System.Drawing.Size(475, 23);
            this.labelChoices4.TabIndex = 4;
            this.labelChoices4.Text = "labelChoices4";
            this.labelChoices4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResult.Location = new System.Drawing.Point(34, 220);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(475, 23);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "labelResult";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(135, 276);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(116, 23);
            this.buttonPrev.TabIndex = 6;
            this.buttonPrev.Text = "前へ";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(291, 276);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(116, 23);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "次へ";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 336);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelChoices4);
            this.Controls.Add(this.labelChoices3);
            this.Controls.Add(this.labelChoices2);
            this.Controls.Add(this.labelChoices1);
            this.Controls.Add(this.labelQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelChoices1;
        private System.Windows.Forms.Label labelChoices2;
        private System.Windows.Forms.Label labelChoices3;
        private System.Windows.Forms.Label labelChoices4;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
    }
}

