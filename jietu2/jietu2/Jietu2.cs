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

namespace jietu2
{
    public partial class Jietu2 : Form
    {
        public Jietu2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.txtBoxPath.Text.Trim().Length == 0)
            {
                MessageBox.Show("parent Path is not null");
                return;
            }
            if (this.txtBoxM12.Text.Trim().Length == 0)
            {
                MessageBox.Show("SN is not null");
                return;
            }




            //获得当前屏幕的分辨率            
            Screen scr = Screen.PrimaryScreen;
            Rectangle rc = scr.Bounds;
            int iWidth = rc.Width;
            int iHeight = rc.Height;
            //创建一个和屏幕一样大的Bitmap            
            Image myImage = new Bitmap(iWidth, iHeight);
            //从一个继承自Image类的对象中创建Graphics对象            
            Graphics g = Graphics.FromImage(myImage);
            //抓屏并拷贝到myimage里            
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(iWidth, iHeight));
            //保存为文件         
            string parentPath = this.txtBoxPath.Text.Trim();
            string timefolder = DateTime.Now.ToString("mmddss");
            string timefolder2 = DateTime.Now.ToString("MMdd");
            string snnumber = this.txtBoxM12.Text.Trim();



            DateTime dt = DateTime.Now;
            string dateStr1 = "20:00:00";
            string dateStr2 = dt.ToString("HH:mm:ss");
            DateTime t1 = Convert.ToDateTime(dateStr1);
            DateTime t2 = Convert.ToDateTime(dateStr2);
            int compNum = DateTime.Compare(t1, t2);
            if (compNum > 0)
            {
                //继续创建第二天（当天的）的文件夹，并且往里面加上图片
                string saveRealPath = parentPath + "\\M12\\" + timefolder2 + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\M12\\" + timefolder2;
                if (this.txtChildM12.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildM12.Text.Trim();
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\M12\\" + timefolder2 + "\\" + this.txtChildM12.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxM12.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    myImage.Save(saveRealPath);
                    this.txtBoxM12.Text = "";
                }
            }
            if (compNum == 0)
            {
            }
            if (compNum < 0)
            {

                //创建第二天的文件夹，并且往里面加上图片
                string tommorm = DateTime.Now.AddDays(+1).ToString("MMdd");
                string saveRealPath = parentPath + "\\M12\\" + tommorm + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\M12\\" + tommorm;
                if (this.txtChildM12.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildM12.Text.Trim();
                    Console.WriteLine(filepaht);
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\M12\\" + tommorm + "\\" + this.txtChildM12.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxM12.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }

                    myImage.Save(saveRealPath);
                    this.txtBoxM12.Text = "";
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.txtBoxPath.Text.Trim().Length == 0)
            {
                MessageBox.Show("parent Path is not null");
                return;
            }
            if (this.txtBoxL12.Text.Trim().Length == 0)
            {
                MessageBox.Show("SN is not null");
                return;
            }




            //获得当前屏幕的分辨率            
            Screen scr = Screen.PrimaryScreen;
            Rectangle rc = scr.Bounds;
            int iWidth = rc.Width;
            int iHeight = rc.Height;
            //创建一个和屏幕一样大的Bitmap            
            Image myImage = new Bitmap(iWidth, iHeight);
            //从一个继承自Image类的对象中创建Graphics对象            
            Graphics g = Graphics.FromImage(myImage);
            //抓屏并拷贝到myimage里            
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(iWidth, iHeight));
            //保存为文件         
            string parentPath = this.txtBoxPath.Text.Trim();
            string timefolder = DateTime.Now.ToString("mmddss");
            string timefolder2 = DateTime.Now.ToString("MMdd");
            string snnumber = this.txtBoxL12.Text.Trim();



            DateTime dt = DateTime.Now;
            string dateStr1 = "20:00:00";
            string dateStr2 = dt.ToString("HH:mm:ss");
            DateTime t1 = Convert.ToDateTime(dateStr1);
            DateTime t2 = Convert.ToDateTime(dateStr2);
            int compNum = DateTime.Compare(t1, t2);
            if (compNum > 0)
            {
                //继续创建第二天（当天的）的文件夹，并且往里面加上图片
                string saveRealPath = parentPath + "\\L12\\" + timefolder2 + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\L12\\" + timefolder2;
                if (this.txtChildL12.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildL12.Text.Trim();
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\L12\\" + timefolder2 + "\\" + this.txtChildL12.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxL12.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    myImage.Save(saveRealPath);
                    this.txtBoxL12.Text = "";
                }
            }
            if (compNum == 0)
            {
            }
            if (compNum < 0)
            {

                //创建第二天的文件夹，并且往里面加上图片
                string tommorm = DateTime.Now.AddDays(+1).ToString("MMdd");
                string saveRealPath = parentPath + "\\L12\\" + tommorm + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\L12\\" + tommorm;
                if (this.txtChildL12.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildL12.Text.Trim();
                    Console.WriteLine(filepaht);
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\L12\\" + tommorm + "\\" + this.txtChildL12.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxL12.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }

                    myImage.Save(saveRealPath);
                    this.txtBoxL12.Text = "";
                }

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.txtBoxPath.Text.Trim().Length == 0)
            {
                MessageBox.Show("parent Path is not null");
                return;
            }
            if (this.txtBoxL22.Text.Trim().Length == 0)
            {
                MessageBox.Show("SN is not null");
                return;
            }




            //获得当前屏幕的分辨率            
            Screen scr = Screen.PrimaryScreen;
            Rectangle rc = scr.Bounds;
            int iWidth = rc.Width;
            int iHeight = rc.Height;
            //创建一个和屏幕一样大的Bitmap            
            Image myImage = new Bitmap(iWidth, iHeight);
            //从一个继承自Image类的对象中创建Graphics对象            
            Graphics g = Graphics.FromImage(myImage);
            //抓屏并拷贝到myimage里            
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(iWidth, iHeight));
            //保存为文件         
            string parentPath = this.txtBoxPath.Text.Trim();
            string timefolder = DateTime.Now.ToString("mmddss");
            string timefolder2 = DateTime.Now.ToString("MMdd");
            string snnumber = this.txtBoxL22.Text.Trim();



            DateTime dt = DateTime.Now;
            string dateStr1 = "20:00:00";
            string dateStr2 = dt.ToString("HH:mm:ss");
            DateTime t1 = Convert.ToDateTime(dateStr1);
            DateTime t2 = Convert.ToDateTime(dateStr2);
            int compNum = DateTime.Compare(t1, t2);
            if (compNum > 0)
            {
                //继续创建第二天（当天的）的文件夹，并且往里面加上图片
                string saveRealPath = parentPath + "\\L22\\" + timefolder2 + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\L22\\" + timefolder2;
                if (this.txtChildL22.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildL22.Text.Trim();
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\L22\\" + timefolder2 + "\\" + this.txtChildL22.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxL22.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    myImage.Save(saveRealPath);
                    this.txtBoxL22.Text = "";
                }
            }
            if (compNum == 0)
            {
            }
            if (compNum < 0)
            {

                //创建第二天的文件夹，并且往里面加上图片
                string tommorm = DateTime.Now.AddDays(+1).ToString("MMdd");
                string saveRealPath = parentPath + "\\L22\\" + tommorm + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\L22\\" + tommorm;
                if (this.txtChildL22.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildL22.Text.Trim();
                    Console.WriteLine(filepaht);
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\L22\\" + tommorm + "\\" + this.txtChildL22.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxL22.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }

                    myImage.Save(saveRealPath);
                    this.txtBoxL22.Text = "";
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.txtBoxPath.Text.Trim().Length == 0)
            {
                MessageBox.Show("parent Path is not null");
                return;
            }
            if (this.txtBoxK12.Text.Trim().Length == 0)
            {
                MessageBox.Show("SN is not null");
                return;
            }




            //获得当前屏幕的分辨率            
            Screen scr = Screen.PrimaryScreen;
            Rectangle rc = scr.Bounds;
            int iWidth = rc.Width;
            int iHeight = rc.Height;
            //创建一个和屏幕一样大的Bitmap            
            Image myImage = new Bitmap(iWidth, iHeight);
            //从一个继承自Image类的对象中创建Graphics对象            
            Graphics g = Graphics.FromImage(myImage);
            //抓屏并拷贝到myimage里            
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(iWidth, iHeight));
            //保存为文件         
            string parentPath = this.txtBoxPath.Text.Trim();
            string timefolder = DateTime.Now.ToString("mmddss");
            string timefolder2 = DateTime.Now.ToString("MMdd");
            string snnumber = this.txtBoxK12.Text.Trim();



            DateTime dt = DateTime.Now;
            string dateStr1 = "20:00:00";
            string dateStr2 = dt.ToString("HH:mm:ss");
            DateTime t1 = Convert.ToDateTime(dateStr1);
            DateTime t2 = Convert.ToDateTime(dateStr2);
            int compNum = DateTime.Compare(t1, t2);
            if (compNum > 0)
            {
                //继续创建第二天（当天的）的文件夹，并且往里面加上图片
                string saveRealPath = parentPath + "\\K12\\" + timefolder2 + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\K12\\" + timefolder2;
                if (this.txtChildK12.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildK12.Text.Trim();
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\K12\\" + timefolder2 + "\\" + this.txtChildK12.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxK12.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    myImage.Save(saveRealPath);
                    this.txtBoxK12.Text = "";
                }
            }
            if (compNum == 0)
            {
            }
            if (compNum < 0)
            {

                //创建第二天的文件夹，并且往里面加上图片
                string tommorm = DateTime.Now.AddDays(+1).ToString("MMdd");
                string saveRealPath = parentPath + "\\K12\\" + tommorm + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\K12\\" + tommorm;
                if (this.txtChildK12.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildK12.Text.Trim();
                    Console.WriteLine(filepaht);
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\K12\\" + tommorm + "\\" + this.txtChildK12.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxK12.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }

                    myImage.Save(saveRealPath);
                    this.txtBoxK12.Text = "";
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (this.txtBoxPath.Text.Trim().Length == 0)
            {
                MessageBox.Show("parent Path is not null");
                return;
            }
            if (this.txtBoxK22.Text.Trim().Length == 0)
            {
                MessageBox.Show("SN is not null");
                return;
            }




            //获得当前屏幕的分辨率            
            Screen scr = Screen.PrimaryScreen;
            Rectangle rc = scr.Bounds;
            int iWidth = rc.Width;
            int iHeight = rc.Height;
            //创建一个和屏幕一样大的Bitmap            
            Image myImage = new Bitmap(iWidth, iHeight);
            //从一个继承自Image类的对象中创建Graphics对象            
            Graphics g = Graphics.FromImage(myImage);
            //抓屏并拷贝到myimage里            
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(iWidth, iHeight));
            //保存为文件         
            string parentPath = this.txtBoxPath.Text.Trim();
            string timefolder = DateTime.Now.ToString("mmddss");
            string timefolder2 = DateTime.Now.ToString("MMdd");
            string snnumber = this.txtBoxK22.Text.Trim();



            DateTime dt = DateTime.Now;
            string dateStr1 = "20:00:00";
            string dateStr2 = dt.ToString("HH:mm:ss");
            DateTime t1 = Convert.ToDateTime(dateStr1);
            DateTime t2 = Convert.ToDateTime(dateStr2);
            int compNum = DateTime.Compare(t1, t2);
            if (compNum > 0)
            {
                //继续创建第二天（当天的）的文件夹，并且往里面加上图片
                string saveRealPath = parentPath + "\\K22\\" + timefolder2 + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\K22\\" + timefolder2;
                if (this.txtChildK22.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildK22.Text.Trim();
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\K22\\" + timefolder2 + "\\" + this.txtChildK22.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxK22.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    myImage.Save(saveRealPath);
                    this.txtBoxK22.Text = "";
                }
            }
            if (compNum == 0)
            {
            }
            if (compNum < 0)
            {

                //创建第二天的文件夹，并且往里面加上图片
                string tommorm = DateTime.Now.AddDays(+1).ToString("MMdd");
                string saveRealPath = parentPath + "\\K22\\" + tommorm + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\K22\\" + tommorm;
                if (this.txtChildK22.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildK22.Text.Trim();
                    Console.WriteLine(filepaht);
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\K22\\" + tommorm + "\\" + this.txtChildK22.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxK22.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }

                    myImage.Save(saveRealPath);
                    this.txtBoxK22.Text = "";
                }

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.txtBoxPath.Text.Trim().Length == 0)
            {
                MessageBox.Show("parent Path is not null");
                return;
            }
            if (this.txtBoxI12.Text.Trim().Length == 0)
            {
                MessageBox.Show("SN is not null");
                return;
            }




            //获得当前屏幕的分辨率            
            Screen scr = Screen.PrimaryScreen;
            Rectangle rc = scr.Bounds;
            int iWidth = rc.Width;
            int iHeight = rc.Height;
            //创建一个和屏幕一样大的Bitmap            
            Image myImage = new Bitmap(iWidth, iHeight);
            //从一个继承自Image类的对象中创建Graphics对象            
            Graphics g = Graphics.FromImage(myImage);
            //抓屏并拷贝到myimage里            
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(iWidth, iHeight));
            //保存为文件         
            string parentPath = this.txtBoxPath.Text.Trim();
            string timefolder = DateTime.Now.ToString("mmddss");
            string timefolder2 = DateTime.Now.ToString("MMdd");
            string snnumber = this.txtBoxI12.Text.Trim();



            DateTime dt = DateTime.Now;
            string dateStr1 = "20:00:00";
            string dateStr2 = dt.ToString("HH:mm:ss");
            DateTime t1 = Convert.ToDateTime(dateStr1);
            DateTime t2 = Convert.ToDateTime(dateStr2);
            int compNum = DateTime.Compare(t1, t2);
            if (compNum > 0)
            {
                //继续创建第二天（当天的）的文件夹，并且往里面加上图片
                string saveRealPath = parentPath + "\\I12\\" + timefolder2 + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\I12\\" + timefolder2;
                if (this.txtChildI12.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildI12.Text.Trim();
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\I12\\" + timefolder2 + "\\" + this.txtChildI12.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxI12.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    myImage.Save(saveRealPath);
                    this.txtBoxI12.Text = "";
                }
            }
            if (compNum == 0)
            {
            }
            if (compNum < 0)
            {

                //创建第二天的文件夹，并且往里面加上图片
                string tommorm = DateTime.Now.AddDays(+1).ToString("MMdd");
                string saveRealPath = parentPath + "\\I12\\" + tommorm + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\I12\\" + tommorm;
                if (this.txtChildI12.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildI12.Text.Trim();
                    Console.WriteLine(filepaht);
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\I12\\" + tommorm + "\\" + this.txtChildI12.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxI12.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }

                    myImage.Save(saveRealPath);
                    this.txtBoxI12.Text = "";
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.txtBoxPath.Text.Trim().Length == 0)
            {
                MessageBox.Show("parent Path is not null");
                return;
            }
            if (this.txtBoxI22.Text.Trim().Length == 0)
            {
                MessageBox.Show("SN is not null");
                return;
            }




            //获得当前屏幕的分辨率            
            Screen scr = Screen.PrimaryScreen;
            Rectangle rc = scr.Bounds;
            int iWidth = rc.Width;
            int iHeight = rc.Height;
            //创建一个和屏幕一样大的Bitmap            
            Image myImage = new Bitmap(iWidth, iHeight);
            //从一个继承自Image类的对象中创建Graphics对象            
            Graphics g = Graphics.FromImage(myImage);
            //抓屏并拷贝到myimage里            
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(iWidth, iHeight));
            //保存为文件         
            string parentPath = this.txtBoxPath.Text.Trim();
            string timefolder = DateTime.Now.ToString("mmddss");
            string timefolder2 = DateTime.Now.ToString("MMdd");
            string snnumber = this.txtBoxI22.Text.Trim();



            DateTime dt = DateTime.Now;
            string dateStr1 = "20:00:00";
            string dateStr2 = dt.ToString("HH:mm:ss");
            DateTime t1 = Convert.ToDateTime(dateStr1);
            DateTime t2 = Convert.ToDateTime(dateStr2);
            int compNum = DateTime.Compare(t1, t2);
            if (compNum > 0)
            {
                //继续创建第二天（当天的）的文件夹，并且往里面加上图片
                string saveRealPath = parentPath + "\\I22\\" + timefolder2 + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\I22\\" + timefolder2;
                if (this.txtChildI22.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildI22.Text.Trim();
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\I22\\" + timefolder2 + "\\" + this.txtChildI22.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxI22.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    myImage.Save(saveRealPath);
                    this.txtBoxI22.Text = "";
                }
            }
            if (compNum == 0)
            {
            }
            if (compNum < 0)
            {

                //创建第二天的文件夹，并且往里面加上图片
                string tommorm = DateTime.Now.AddDays(+1).ToString("MMdd");
                string saveRealPath = parentPath + "\\I22\\" + tommorm + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\I22\\" + tommorm;
                if (this.txtChildI22.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildI22.Text.Trim();
                    Console.WriteLine(filepaht);
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\I22\\" + tommorm + "\\" + this.txtChildI22.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxI22.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }

                    myImage.Save(saveRealPath);
                    this.txtBoxI22.Text = "";
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.txtBoxPath.Text.Trim().Length == 0)
            {
                MessageBox.Show("parent Path is not null");
                return;
            }
            if (this.txtBoxH12.Text.Trim().Length == 0)
            {
                MessageBox.Show("SN is not null");
                return;
            }




            //获得当前屏幕的分辨率            
            Screen scr = Screen.PrimaryScreen;
            Rectangle rc = scr.Bounds;
            int iWidth = rc.Width;
            int iHeight = rc.Height;
            //创建一个和屏幕一样大的Bitmap            
            Image myImage = new Bitmap(iWidth, iHeight);
            //从一个继承自Image类的对象中创建Graphics对象            
            Graphics g = Graphics.FromImage(myImage);
            //抓屏并拷贝到myimage里            
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(iWidth, iHeight));
            //保存为文件         
            string parentPath = this.txtBoxPath.Text.Trim();
            string timefolder = DateTime.Now.ToString("mmddss");
            string timefolder2 = DateTime.Now.ToString("MMdd");
            string snnumber = this.txtBoxH12.Text.Trim();



            DateTime dt = DateTime.Now;
            string dateStr1 = "20:00:00";
            string dateStr2 = dt.ToString("HH:mm:ss");
            DateTime t1 = Convert.ToDateTime(dateStr1);
            DateTime t2 = Convert.ToDateTime(dateStr2);
            int compNum = DateTime.Compare(t1, t2);
            if (compNum > 0)
            {
                //继续创建第二天（当天的）的文件夹，并且往里面加上图片
                string saveRealPath = parentPath + "\\H12\\" + timefolder2 + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\H12\\" + timefolder2;
                if (this.txtChildH12.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildH12.Text.Trim();
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\H12\\" + timefolder2 + "\\" + this.txtChildH12.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxH12.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    myImage.Save(saveRealPath);
                    this.txtBoxH12.Text = "";
                }
            }
            if (compNum == 0)
            {
            }
            if (compNum < 0)
            {

                //创建第二天的文件夹，并且往里面加上图片
                string tommorm = DateTime.Now.AddDays(+1).ToString("MMdd");
                string saveRealPath = parentPath + "\\H12\\" + tommorm + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\H12\\" + tommorm;
                if (this.txtChildH12.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildH12.Text.Trim();
                    Console.WriteLine(filepaht);
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\H12\\" + tommorm + "\\" + this.txtChildH12.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxH12.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }

                    myImage.Save(saveRealPath);
                    this.txtBoxH12.Text = "";
                }

            }
        }

        private void txtBoxM12_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtBoxM12.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                button1_Click(null, null);
            }
        }

        private void txtBoxL12_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtBoxL12.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                button2_Click(null, null);
            }
        }

        private void txtBoxL22_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtBoxL22.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                button3_Click(null, null);
            }
        }

        private void txtBoxK12_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtBoxK12.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                button4_Click(null, null);
            }
        }

        private void txtBoxK22_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtBoxK22.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                button5_Click(null, null);
            }
        }

        private void txtBoxI12_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtBoxI12.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                button6_Click(null, null);
            }
        }

        private void txtBoxI22_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtBoxI22.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                button7_Click(null, null);
            }
        }

        private void txtBoxH12_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtBoxH12.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                button8_Click(null, null);
            }
        }
    }
}
