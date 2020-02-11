namespace CursorMage
{
    partial class CMage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMage));
            this.CenterButton = new System.Windows.Forms.Button();
            this.xNum = new System.Windows.Forms.NumericUpDown();
            this.yNum = new System.Windows.Forms.NumericUpDown();
            this.OKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNum)).BeginInit();
            this.SuspendLayout();
            // 
            // CenterButton
            // 
            this.CenterButton.Location = new System.Drawing.Point(80, 96);
            this.CenterButton.Name = "CenterButton";
            this.CenterButton.Size = new System.Drawing.Size(75, 23);
            this.CenterButton.TabIndex = 0;
            this.CenterButton.Text = "Center";
            this.CenterButton.UseVisualStyleBackColor = true;
            this.CenterButton.Click += new System.EventHandler(this.CenterButton_Click);
            // 
            // xNum
            // 
            this.xNum.Location = new System.Drawing.Point(73, 41);
            this.xNum.Name = "xNum";
            this.xNum.Size = new System.Drawing.Size(41, 20);
            this.xNum.TabIndex = 3;
            // 
            // yNum
            // 
            this.yNum.Location = new System.Drawing.Point(120, 41);
            this.yNum.Name = "yNum";
            this.yNum.Size = new System.Drawing.Size(41, 20);
            this.yNum.TabIndex = 4;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(80, 67);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CMage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.yNum);
            this.Controls.Add(this.xNum);
            this.Controls.Add(this.CenterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CMage";
            this.Text = "CursorMage";
            this.Load += new System.EventHandler(this.CMage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CenterButton;
        private System.Windows.Forms.NumericUpDown xNum;
        private System.Windows.Forms.NumericUpDown yNum;
        private System.Windows.Forms.Button OKButton;
    }
}

