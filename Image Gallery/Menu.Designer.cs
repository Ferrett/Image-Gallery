
namespace Image_Gallery
{
    partial class Menu
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
            this.openDirectoryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openGalleryButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.openDirectoryButton.Location = new System.Drawing.Point(181, 168);
            this.openDirectoryButton.Name = "button1";
            this.openDirectoryButton.Size = new System.Drawing.Size(138, 41);
            this.openDirectoryButton.TabIndex = 0;
            this.openDirectoryButton.Text = "Open Directory";
            this.openDirectoryButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.exitButton.Location = new System.Drawing.Point(181, 227);
            this.exitButton.Name = "button2";
            this.exitButton.Size = new System.Drawing.Size(138, 41);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.openGalleryButton.Location = new System.Drawing.Point(155, 102);
            this.openGalleryButton.Name = "button3";
            this.openGalleryButton.Size = new System.Drawing.Size(189, 43);
            this.openGalleryButton.TabIndex = 2;
            this.openGalleryButton.Text = "Open Gallery";
            this.openGalleryButton.UseVisualStyleBackColor = true;
            this.openGalleryButton.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(462, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.ReadOnly = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 280);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.openGalleryButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.openDirectoryButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openDirectoryButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button openGalleryButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}