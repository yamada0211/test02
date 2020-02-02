namespace WindowTransitionTest001
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._labelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _timer
            // 
            this._timer.Enabled = true;
            this._timer.Interval = 500;
            this._timer.Tick += new System.EventHandler(this._timer_Tick);
            // 
            // _labelCount
            // 
            this._labelCount.Font = new System.Drawing.Font("MS UI Gothic", 28F);
            this._labelCount.Location = new System.Drawing.Point(37, 87);
            this._labelCount.Name = "_labelCount";
            this._labelCount.Size = new System.Drawing.Size(306, 118);
            this._labelCount.TabIndex = 2;
            this._labelCount.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 292);
            this.Controls.Add(this._labelCount);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.Label _labelCount;
    }
}

