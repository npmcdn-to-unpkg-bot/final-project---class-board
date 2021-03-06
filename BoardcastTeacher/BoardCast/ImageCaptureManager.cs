﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Image = System.Drawing.Image;
using Orientation = System.Windows.Forms.Orientation;

namespace BoardCast
{
    /// <summary>
    /// Class that manage the screen capture - Singletone
    /// </summary>
    public class ImageCaptureManager
    {
        public List<StackPanel> m_ThumbnailsList;
        public List<System.Windows.Controls.Image> m_StrokeThumbnailsList;
        public static string date;
        public int m_iLastSelectedStroke;
        public event EventHandler LoadPreviousStorke;

        private static ImageCaptureManager instance;

        private ImageCaptureManager() { }

        /// <summary>
        /// Singletone
        /// </summary>
        public static ImageCaptureManager Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new ImageCaptureManager();
                    instance.m_ThumbnailsList = new List<StackPanel>();
                    instance.m_StrokeThumbnailsList = new List<System.Windows.Controls.Image>();
                }
                return instance;
            }
        }

        /// <summary>
        /// Capture the screen and saves as image
        /// </summary>
        /// <returns> The creted image filename</returns>
        public string CaptureScreen()
        {
            date = DateTime.Now.ToString("ddMMyyyy");
            string fileName = DateTime.Now.ToString("hhmmss");
            int ix, iy, iw, ih;
            ix = Convert.ToInt32(Screen.PrimaryScreen.Bounds.X);
            iy = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Y);
            iw = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width);
            ih = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height);
            Bitmap image = new Bitmap(iw, ih,
                   System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(image);
            g.CopyFromScreen(ix, iy, ix, iy,
                     new System.Drawing.Size(iw, ih),
                     CopyPixelOperation.SourceCopy);
            try
            {
                if (Directory.Exists(GlobalContants.screenshotFolderPath))
                    image.Save(Path.Combine(GlobalContants.screenshotFolderPath, fileName + ".jpeg"), ImageFormat.Jpeg);
                else
                {
                    Directory.CreateDirectory(GlobalContants.screenshotFolderPath);
                    image.Save(Path.Combine(GlobalContants.screenshotFolderPath, fileName + ".jpeg"), ImageFormat.Jpeg);
                }
            }
            catch (Exception) { }
            return fileName;
        }

        /// <summary>
        /// Generate thumbnail from image and add it to last shots taken menu
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public StackPanel CreatePreviewThumbnail(string path)
        {
            StackPanel sp = new StackPanel();
            sp.Orientation = System.Windows.Controls.Orientation.Horizontal;
            System.Windows.Controls.Image Img = new System.Windows.Controls.Image();
            Img.Width = 150;
            Img.Height = 150;
            Img.Source = new BitmapImage(new Uri(path));
            sp.Children.Add(Img);
            sp.Margin = new Thickness(2, 0, 2, 50);
            Img.MouseDown += new MouseButtonEventHandler(OnThumbnailsClick);
            m_ThumbnailsList.Add(sp);
            return sp;
        }

        /// <summary>
        /// Generate thumbnail from image and add it to last Storkes taken menu
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public StackPanel CreatePreviewStrokeThumbnail(string path)
        {
            StackPanel sp = new StackPanel();
            sp.Orientation = System.Windows.Controls.Orientation.Horizontal;
            System.Windows.Controls.Image Img = new System.Windows.Controls.Image();
            Img.Width = 150;
            Img.Height = 150;
            Img.Source = new BitmapImage(new Uri(path));
            sp.Children.Add(Img);
            sp.Margin = new Thickness(2, 0, 2, 50);
            Img.MouseDown += new MouseButtonEventHandler(OnStrokeThumbnailsClick);
            m_StrokeThumbnailsList.Add(Img);
            return sp;
        }

        /// <summary>
        /// Trigger when clicked on load last storkes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnStrokeThumbnailsClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                var image = sender as System.Windows.Controls.Image;
                for (int i = 0; i < m_StrokeThumbnailsList.Count; i++)
                {
                    if (image.Source == m_StrokeThumbnailsList[i].Source)
                    {
                        m_iLastSelectedStroke = i;
                        if (LoadPreviousStorke != null)
                        {
                            LoadPreviousStorke.Invoke(new object(), new EventArgs());
                        }
                        return;
                    }
                }
                
            }
        }

        /// <summary>
        /// Open selected image from last screenshot taken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnThumbnailsClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                var image = sender as System.Windows.Controls.Image;
                // MessageBox.Show(image.Source.ToString());
                //_mProcessManager.GenerateProcess(image.Source.ToString(), true);
                ProcessManager.Instance.GenerateProcess(image.Source.ToString(),true);
               /* ProcessStartInfo startInfo = new ProcessStartInfo(image.Source.ToString());
                startInfo.Verb = "edit";
                startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                Process.Start(startInfo);*/
                Thread.Sleep(1000);
                SendKeys.SendWait("{F11}");
            }
        }

        /// <summary>
        /// Delete all thumbnails
        /// </summary>
        public void DeleteAllThumbnails()
        {
            for (int i = 0; i < m_ThumbnailsList.Count; i++)
            {
                m_ThumbnailsList[i].Children.RemoveAt(0);
            }
        }
    }
}
