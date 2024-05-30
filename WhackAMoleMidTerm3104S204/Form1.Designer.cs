namespace WhackAMoleMidTerm3104S204
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblScore.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Bold);
            this.lblScore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblScore.Location = new System.Drawing.Point(442, 75);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 48);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "0";
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("新細明體", 24F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(265, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "得分";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label2;
    }
}

