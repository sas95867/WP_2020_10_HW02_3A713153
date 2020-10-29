namespace WP_2020_01_HW02_3A713153
{
    partial class frmGame
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
            this.btnGO = new System.Windows.Forms.Button();
            this.rtbGO = new System.Windows.Forms.RichTextBox();
            this.labLog = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGO
            // 
            this.btnGO.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGO.Location = new System.Drawing.Point(434, 30);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(233, 105);
            this.btnGO.TabIndex = 0;
            this.btnGO.Text = "麻煩點我抽牌可以嗎";
            this.btnGO.UseVisualStyleBackColor = true;
            // 
            // rtbGO
            // 
            this.rtbGO.Location = new System.Drawing.Point(63, 124);
            this.rtbGO.Name = "rtbGO";
            this.rtbGO.Size = new System.Drawing.Size(214, 247);
            this.rtbGO.TabIndex = 1;
            this.rtbGO.Text = "1\n2\n3\n";
            // 
            // labLog
            // 
            this.labLog.AutoSize = true;
            this.labLog.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLog.Location = new System.Drawing.Point(61, 45);
            this.labLog.Name = "labLog";
            this.labLog.Size = new System.Drawing.Size(156, 64);
            this.labLog.TabIndex = 2;
            this.labLog.Text = "歷程";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(434, 141);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(233, 230);
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.labLog);
            this.Controls.Add(this.rtbGO);
            this.Controls.Add(this.btnGO);
            this.Name = "frmGame";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.RichTextBox rtbGO;
        private System.Windows.Forms.Label labLog;
        private System.Windows.Forms.PictureBox pic;
    }
}

