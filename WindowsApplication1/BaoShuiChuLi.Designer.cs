namespace Kaipiao
{
    partial class BaoShuiChuLi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoShuiChuLi));
            this.btn_sbhz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sbhz
            // 
            this.btn_sbhz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sbhz.BackgroundImage")));
            this.btn_sbhz.Location = new System.Drawing.Point(175, 95);
            this.btn_sbhz.Name = "btn_sbhz";
            this.btn_sbhz.Size = new System.Drawing.Size(70, 74);
            this.btn_sbhz.TabIndex = 0;
            this.btn_sbhz.UseVisualStyleBackColor = true;
            this.btn_sbhz.Click += new System.EventHandler(this.btn_sbhz_Click);
            // 
            // BaoShuiChuLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 441);
            this.Controls.Add(this.btn_sbhz);
            this.Name = "BaoShuiChuLi";
            this.Text = "BaoShuiChuLi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sbhz;
    }
}