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
        private int previewImageID = 0;
        private int mainImageId = 0;
        private List<Image> images = new List<Image>();
        private const int previewImagesOnScreen = 8;
        Timer timer = new Timer();
        int showImageProgress=0;
        public Form1()
        {
            InitializeComponent();

            rightButton.Click += RightButton_Click;
            leftButton.Click += LeftButton_Click;
            GetImagesFromFile();
            CreatePreviewImg();
            SetMainImage();
            LoadImages();

            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressPanel2.Size = new Size(showImageProgress, progressPanel2.Height);
            showImageProgress++;

            if (progressPanel2.Width == progressPanel.Width - 5) 
            {
                RightButton_Click(null, null);
            }
        }

        private void LoadImages()
        {
            for (int i = 0; i < imagePath.Count; i++)
            {
                images.Add(Image.FromFile(imagePath[i]));
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            showImageProgress = 0;
            previewImageID--;

            int a = previewImageID % imagePath.Count;
            foreach (var item in previewImg)
            {
                if (a >= 0)
                {
                    if (a == imagePath.Count)
                        a = 0;
                    item.BackgroundImage = images[a];
                }
                else
                    item.BackgroundImage = images[imagePath.Count + a];

                a++;
            }
            SetMainImage();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            showImageProgress = 0;
            previewImageID++;

            int a = previewImageID % imagePath.Count;
            foreach (var item in previewImg)
            {
                if (a < imagePath.Count)
                {
                    if (a < 0)
                        item.BackgroundImage = images[imagePath.Count + a];
                    else
                        item.BackgroundImage = images[a];
                }
                else
                    item.BackgroundImage = images[a - imagePath.Count];

                a++;
            }
            SetMainImage();
        }

        private void SetMainImage()
        {

            imgPanel.BackgroundImage = previewImg[mainImageId].BackgroundImage;

        }

        private void GetImagesFromFile()
        {
            string rootdir = @"C:\Users\User\source\repos\Image Gallery\Image Gallery\bin\Debug\Images";


            imagePath.AddRange(Directory.GetFiles(rootdir, "*png", SearchOption.AllDirectories).ToList());
            imagePath.AddRange(Directory.GetFiles(rootdir, "*jpg", SearchOption.AllDirectories).ToList());
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
                Name = i.ToString(),
                BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
                mainImageId = 4;
            }
            else
            {
                for (int i = 0; i < imagePath.Count; i++)
                {
                    AddPanel(i);
                    previewImg[previewImg.Count - 1].Location = new Point(24 + i * 97 + ((previewImagesOnScreen - imagePath.Count) * 40), 400);

                }
                mainImageId = (int)(imagePath.Count / 2);
            }
            SelectedPanelOutline();
        }

        private void SelectedPanelOutline()
        {
            outlinePanel.Location = new Point(previewImg[mainImageId].Location.X-5, previewImg[mainImageId].Location.Y-5) ;
            outlinePanel.Size = new Size(previewImg[mainImageId].Width + 10, previewImg[mainImageId].Height + 10);

            this.Controls.Add(this.outlinePanel);
        }
    }
}
