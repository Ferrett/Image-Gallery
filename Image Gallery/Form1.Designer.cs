
namespace Image_Gallery
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.imgPanel = new System.Windows.Forms.Panel();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.progressPanel2 = new System.Windows.Forms.Panel();
            this.outlinePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rightButton
            // 
            this.rightButton.BackColor = System.Drawing.Color.Black;
            this.rightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.rightButton.ForeColor = System.Drawing.Color.White;
            this.rightButton.Location = new System.Drawing.Point(956, 25);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(52, 468);
            this.rightButton.TabIndex = 0;
            this.rightButton.Text = "🡺";
            this.rightButton.UseVisualStyleBackColor = false;
            // 
            // leftButton
            // 
            this.leftButton.BackColor = System.Drawing.Color.Black;
            this.leftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.leftButton.ForeColor = System.Drawing.Color.White;
            this.leftButton.Location = new System.Drawing.Point(12, 25);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(52, 468);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "🡸";
            this.leftButton.UseVisualStyleBackColor = false;
            // 
            // imgPanel
            // 
            this.imgPanel.BackColor = System.Drawing.Color.Black;
            this.imgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgPanel.Location = new System.Drawing.Point(84, 25);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(850, 452);
            this.imgPanel.TabIndex = 2;
            // 
            // progressPanel
            // 
            this.progressPanel.BackColor = System.Drawing.Color.Black;
            this.progressPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.progressPanel.Location = new System.Drawing.Point(84, 483);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(850, 10);
            this.progressPanel.TabIndex = 3;
            // 
            // progressPanel2
            // 
            this.progressPanel2.BackColor = System.Drawing.Color.LightGreen;
            this.progressPanel2.Location = new System.Drawing.Point(86, 485);
            this.progressPanel2.Name = "progressPanel2";
            this.progressPanel2.Size = new System.Drawing.Size(0, 6);
            this.progressPanel2.TabIndex = 3;
            // 
            // outlinePanel
            // 
            this.outlinePanel.BackColor = System.Drawing.Color.Red;
            this.outlinePanel.Location = new System.Drawing.Point(0, 0);
            this.outlinePanel.Name = "outlinePanel";
            this.outlinePanel.Size = new System.Drawing.Size(200, 100);
            this.outlinePanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1020, 618);
            this.Controls.Add(this.progressPanel2);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.imgPanel);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.rightButton);
            this.Name = "Form1";
            this.Text = "Gallery";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Panel imgPanel;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.Panel outlinePanel;
        private System.Windows.Forms.Panel progressPanel2;
    }
}

