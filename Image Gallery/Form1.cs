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
    public partial class Form1 : Form
    {
        private List<Panel> previewImg = new List<Panel>();
        private List<string> imagePath = new List<string>();

        const int previewImagesOnScreen = 8;
        public Form1()
        {
            InitializeComponent();

            CreatePreviewImg();
        }

        private void CreatePreviewImg()
        {
            if (imagePath.Count >= previewImagesOnScreen)
            {
                for (int i = 0; i < previewImagesOnScreen; i++)
                {
                    previewImg.Add(new Panel() { BackColor = Color.White, Size = new Size(80, 55), Location = new Point(24 + i * 97, 380), Name = i.ToString() });
                    Controls.Add(previewImg[previewImg.Count - 1]);
                }
            }
            else
            {
                for (int i = 0; i < imagePath.Count; i++)
                {
                    previewImg.Add(new Panel() { BackColor = Color.White, Size = new Size(80, 55), Location = new Point(24 + i * 97, 400), Name = i.ToString() });
                    Controls.Add(previewImg[previewImg.Count - 1]);
                }
            }
        }
    }
}
