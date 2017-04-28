namespace Example3
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.tbxNum = new System.Windows.Forms.TextBox();
            this.btnCaLc = new System.Windows.Forms.Button();
            this.LbLAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxNum
            // 
            this.tbxNum.Location = new System.Drawing.Point(20, 50);
            this.tbxNum.Name = "tbxNum";
            this.tbxNum.Size = new System.Drawing.Size(100, 19);
            this.tbxNum.TabIndex = 0;
            this.tbxNum.Text = "ALignRight";
            // 
            // btnCaLc
            // 
            this.btnCaLc.AutoSize = true;
            this.btnCaLc.Location = new System.Drawing.Point(150, 48);
            this.btnCaLc.Name = "btnCaLc";
            this.btnCaLc.Size = new System.Drawing.Size(75, 23);
            this.btnCaLc.TabIndex = 1;
            this.btnCaLc.Text = "× 10 ＝";
            this.btnCaLc.UseVisualStyleBackColor = true;
            this.btnCaLc.Click += new System.EventHandler(this.btnCaLc_Click);
            // 
            // LbLAns
            // 
            this.LbLAns.AutoSize = true;
            this.LbLAns.Location = new System.Drawing.Point(240, 53);
            this.LbLAns.Name = "LbLAns";
            this.LbLAns.Size = new System.Drawing.Size(17, 12);
            this.LbLAns.TabIndex = 2;
            this.LbLAns.Text = "？";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.LbLAns);
            this.Controls.Add(this.btnCaLc);
            this.Controls.Add(this.tbxNum);
            this.Name = "Form1";
            this.Text = "変数の利用";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNum;
        private System.Windows.Forms.Button btnCaLc;
        private System.Windows.Forms.Label LbLAns;
    }
}

