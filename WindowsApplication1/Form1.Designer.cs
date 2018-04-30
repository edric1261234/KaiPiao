namespace WindowsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_kaipiao = new System.Windows.Forms.Button();
            this._btn_bscl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(680, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 78);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kaipiao
            // 
            this.btn_kaipiao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kaipiao.BackgroundImage")));
            this.btn_kaipiao.Location = new System.Drawing.Point(457, 438);
            this.btn_kaipiao.Name = "btn_kaipiao";
            this.btn_kaipiao.Size = new System.Drawing.Size(244, 24);
            this.btn_kaipiao.TabIndex = 1;
            this.btn_kaipiao.UseVisualStyleBackColor = true;
            this.btn_kaipiao.Visible = false;
            this.btn_kaipiao.Click += new System.EventHandler(this.btn_kaipiao_Click);
            // 
            // _btn_bscl
            // 
            this._btn_bscl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btn_bscl.BackgroundImage")));
            this._btn_bscl.Location = new System.Drawing.Point(144, 47);
            this._btn_bscl.Name = "_btn_bscl";
            this._btn_bscl.Size = new System.Drawing.Size(70, 58);
            this._btn_bscl.TabIndex = 2;
            this._btn_bscl.UseVisualStyleBackColor = true;
            this._btn_bscl.Click += new System.EventHandler(this._btn_bscl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 691);
            this.Controls.Add(this._btn_bscl);
            this.Controls.Add(this.btn_kaipiao);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_kaipiao;
        private System.Windows.Forms.Button _btn_bscl;
    }
}

