namespace Bingo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelEnhanced1 = new Bingo.PanelEnhanced();
            this.labLuck5 = new System.Windows.Forms.Label();
            this.labLuck4 = new System.Windows.Forms.Label();
            this.labLuck3 = new System.Windows.Forms.Label();
            this.labLuck2 = new System.Windows.Forms.Label();
            this.labLuck1 = new System.Windows.Forms.Label();
            this.labFormMin = new System.Windows.Forms.Label();
            this.labNum = new System.Windows.Forms.Label();
            this.panelEnhanced1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEnhanced1
            // 
            this.panelEnhanced1.BackgroundImage = global::Bingo.Properties.Resources._333;
            this.panelEnhanced1.Controls.Add(this.labLuck5);
            this.panelEnhanced1.Controls.Add(this.labLuck4);
            this.panelEnhanced1.Controls.Add(this.labLuck3);
            this.panelEnhanced1.Controls.Add(this.labLuck2);
            this.panelEnhanced1.Controls.Add(this.labLuck1);
            this.panelEnhanced1.Controls.Add(this.labFormMin);
            this.panelEnhanced1.Controls.Add(this.labNum);
            this.panelEnhanced1.Location = new System.Drawing.Point(12, 12);
            this.panelEnhanced1.Name = "panelEnhanced1";
            this.panelEnhanced1.Size = new System.Drawing.Size(960, 419);
            this.panelEnhanced1.TabIndex = 4;
            // 
            // labLuck5
            // 
            this.labLuck5.BackColor = System.Drawing.Color.Transparent;
            this.labLuck5.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.labLuck5.Location = new System.Drawing.Point(815, 73);
            this.labLuck5.Name = "labLuck5";
            this.labLuck5.Size = new System.Drawing.Size(90, 300);
            this.labLuck5.TabIndex = 4;
            this.labLuck5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labLuck4
            // 
            this.labLuck4.BackColor = System.Drawing.Color.Transparent;
            this.labLuck4.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.labLuck4.Location = new System.Drawing.Point(719, 73);
            this.labLuck4.Name = "labLuck4";
            this.labLuck4.Size = new System.Drawing.Size(90, 300);
            this.labLuck4.TabIndex = 4;
            this.labLuck4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labLuck3
            // 
            this.labLuck3.BackColor = System.Drawing.Color.Transparent;
            this.labLuck3.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.labLuck3.Location = new System.Drawing.Point(623, 73);
            this.labLuck3.Name = "labLuck3";
            this.labLuck3.Size = new System.Drawing.Size(90, 300);
            this.labLuck3.TabIndex = 4;
            this.labLuck3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labLuck2
            // 
            this.labLuck2.BackColor = System.Drawing.Color.Transparent;
            this.labLuck2.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.labLuck2.Location = new System.Drawing.Point(527, 73);
            this.labLuck2.Name = "labLuck2";
            this.labLuck2.Size = new System.Drawing.Size(90, 300);
            this.labLuck2.TabIndex = 4;
            this.labLuck2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labLuck1
            // 
            this.labLuck1.BackColor = System.Drawing.Color.Transparent;
            this.labLuck1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.labLuck1.Location = new System.Drawing.Point(431, 73);
            this.labLuck1.Name = "labLuck1";
            this.labLuck1.Size = new System.Drawing.Size(90, 300);
            this.labLuck1.TabIndex = 4;
            this.labLuck1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labFormMin
            // 
            this.labFormMin.BackColor = System.Drawing.Color.Transparent;
            this.labFormMin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFormMin.Location = new System.Drawing.Point(907, 11);
            this.labFormMin.Name = "labFormMin";
            this.labFormMin.Size = new System.Drawing.Size(35, 25);
            this.labFormMin.TabIndex = 0;
            this.labFormMin.Text = "—";
            this.labFormMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labFormMin.Click += new System.EventHandler(this.label1_Click);
            // 
            // labNum
            // 
            this.labNum.BackColor = System.Drawing.Color.Transparent;
            this.labNum.Font = new System.Drawing.Font("微软雅黑", 120F, System.Drawing.FontStyle.Bold);
            this.labNum.Location = new System.Drawing.Point(24, 73);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(300, 300);
            this.labNum.TabIndex = 2;
            this.labNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.panelEnhanced1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelEnhanced1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labFormMin;
        private System.Windows.Forms.Label labNum;
        private PanelEnhanced panelEnhanced1;
        private System.Windows.Forms.Label labLuck1;
        private System.Windows.Forms.Label labLuck5;
        private System.Windows.Forms.Label labLuck4;
        private System.Windows.Forms.Label labLuck3;
        private System.Windows.Forms.Label labLuck2;
    }
}

