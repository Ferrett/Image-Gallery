using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private int currentImageID = 0;
        private const int previewImagesOnScreen = 8;
        public Form1()
        {
            InitializeComponent();

            GetImagesFromFile();
            CreatePreviewImg();
            SetImage();
        }
        private void SetImage()
        {
            imgPanel.BackgroundImage = Image.FromFile(imagePath[currentImageID]);

        }

        private void GetImagesFromFile()
        {
            string rootdir = @"C:\Users\User\source\repos\Image Gallery\Image Gallery\bin\Debug\Images";

            
            imagePath = Directory.GetFiles(rootdir, "*", SearchOption.AllDirectories).ToList();
        }
        private void AddPanel(int i)
        {
            previewImg.Add(new Panel()
            {
                BackgroundImage = Image.FromFile(imagePath[i]),
                BackgroundImageLayout = ImageLayout.Zoom,
                BackColor = Color.Black,
                Size = new Size(80, 55),
                Location = new Point(24 + i * 97, 400),
                Name = i.ToString()
            });

            Controls.Add(previewImg[previewImg.Count - 1]);
        }

        private void CreatePreviewImg()
        {
            if (imagePath.Count >= previewImagesOnScreen)
            {
                for (int i = 0; i < previewImagesOnScreen; i++)
                {
                    AddPanel(i);
                }
            }
            else
            {
                for (int i = 0; i < imagePath.Count; i++)
                {
                    AddPanel(i);
                }
            }
        }
    }
}
