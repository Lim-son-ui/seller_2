
namespace seller
{
    partial class UserControl_賣家總覽
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picb_賣家總覽 = new System.Windows.Forms.PictureBox();
            this.rtb_賣家總覽 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picb_賣家總覽)).BeginInit();
            this.SuspendLayout();
            // 
            // picb_賣家總覽
            // 
            this.picb_賣家總覽.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb_賣家總覽.Location = new System.Drawing.Point(3, 3);
            this.picb_賣家總覽.Name = "picb_賣家總覽";
            this.picb_賣家總覽.Size = new System.Drawing.Size(233, 170);
            this.picb_賣家總覽.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb_賣家總覽.TabIndex = 0;
            this.picb_賣家總覽.TabStop = false;
            // 
            // rtb_賣家總覽
            // 
            this.rtb_賣家總覽.Location = new System.Drawing.Point(3, 188);
            this.rtb_賣家總覽.Name = "rtb_賣家總覽";
            this.rtb_賣家總覽.Size = new System.Drawing.Size(233, 116);
            this.rtb_賣家總覽.TabIndex = 1;
            this.rtb_賣家總覽.Text = "";
            // 
            // UserControl_賣家總覽
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtb_賣家總覽);
            this.Controls.Add(this.picb_賣家總覽);
            this.Name = "UserControl_賣家總覽";
            this.Size = new System.Drawing.Size(248, 312);
            ((System.ComponentModel.ISupportInitialize)(this.picb_賣家總覽)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picb_賣家總覽;
        private System.Windows.Forms.RichTextBox rtb_賣家總覽;
    }
}
