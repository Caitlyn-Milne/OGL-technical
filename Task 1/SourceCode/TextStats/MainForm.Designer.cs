
namespace TextStats {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.BrowseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BrowseBtn.Location = new System.Drawing.Point(110, 95);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.BrowseBtn.TabIndex = 0;
            this.BrowseBtn.Text = "browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtnClick);
            // 
            // ContentLabel
            // 
            this.ContentLabel.Location = new System.Drawing.Point(12, 121);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(271, 222);
            this.ContentLabel.TabIndex = 2;
            this.ContentLabel.Text = "No file selected";
            this.ContentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 77);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(295, 352);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.BrowseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "TextStats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

