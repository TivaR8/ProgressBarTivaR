namespace ProgressBarTivaR
{
    partial class frmProgressBar
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
            this.prbProgress = new System.Windows.Forms.ProgressBar();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prbProgress
            // 
            this.prbProgress.Location = new System.Drawing.Point(12, 122);
            this.prbProgress.Name = "prbProgress";
            this.prbProgress.Size = new System.Drawing.Size(337, 51);
            this.prbProgress.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(97, 51);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(148, 43);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // frmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 264);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.prbProgress);
            this.Name = "frmProgressBar";
            this.Text = "Progress Bar By Tiva Rait";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbProgress;
        private System.Windows.Forms.Button btnGo;
    }
}

