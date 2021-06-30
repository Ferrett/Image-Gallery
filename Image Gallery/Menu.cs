using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Gallery
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            exitButton.Click += ExitButton_Click;
            openGalleryButton.Click += OpenGalleryButton_Click;
            openDirectoryButton.Click += OpenDirectoryButton_Click;
        }

        private void OpenDirectoryButton_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog dialog = new FolderBrowserDialog())
            { 
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.textBox1.Text = dialog.SelectedPath;
                    this.openGalleryButton.Visible = true;  
                }
            }
        }

        private void OpenGalleryButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form = new Form1(textBox1.Text);
            try
            {
                form.ShowDialog();
            }
            catch (Exception)
            {

               
            }
            
            this.Visible = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
