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
        private List<Image> images = new List<Image>();
        private List<string> imagePath = new List<string>();

        private const int previewImagesOnScreen = 8;
        private int previewImageID = 0;
        private int mainImageId = 0;
        private int showImageProgress=0;
        private bool closeTheForm = false;
        private string directoryPath;
        private Timer timer = new Timer();
        public Form1(string path)
        {
            InitializeComponent();
            directoryPath = path;

            rightButton.Click += RightButton_Click;
            leftButton.Click += LeftButton_Click;

            GetImagesFromFile();
            if (closeTheForm == false)
            {
                CreatePreviewImg();
                SetMainImage();
                LoadImages();

                timer.Interval = 20;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            else
                this.Close();
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

            int currentId = previewImageID % imagePath.Count;
            foreach (var item in previewImg)
            {
                if (currentId >= 0)
                {
                    if (currentId == imagePath.Count)
                        currentId = 0;
                    item.BackgroundImage = images[currentId];
                }
                else
                    item.BackgroundImage = images[imagePath.Count + currentId];

                currentId++;
            }
            SetMainImage();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            showImageProgress = 0;
            previewImageID++;

            int currentId = previewImageID % imagePath.Count;
            foreach (var item in previewImg)
            {
                if (currentId < imagePath.Count)
                {
                    if (currentId < 0)
                        item.BackgroundImage = images[imagePath.Count + currentId];
                    else
                        item.BackgroundImage = images[currentId];
                }
                else
                    item.BackgroundImage = images[currentId - imagePath.Count];

                currentId++;
            }
            SetMainImage();
        }

        private void SetMainImage()
        {
            imgPanel.BackgroundImage = previewImg[mainImageId].BackgroundImage;
        }

        private void GetImagesFromFile()
        {
            //string rootdir = @"C:\Users\User\source\repos\Image Gallery\Image Gallery\bin\Debug\Images";

            try
            {
                imagePath.AddRange(Directory.GetFiles(directoryPath, "*png", SearchOption.AllDirectories).ToList());
                imagePath.AddRange(Directory.GetFiles(directoryPath, "*jpg", SearchOption.AllDirectories).ToList());
            }
            catch (Exception)
            {
                MessageBox.Show("Don't have permission to open Directory. Try launch with admin rights");
                closeTheForm = true;
                
            }
            if(imagePath.Count == 0)
            {
                MessageBox.Show("This Directory have no images");
                closeTheForm = true;
            }
           
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
