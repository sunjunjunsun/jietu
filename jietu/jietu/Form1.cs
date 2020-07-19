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

namespace jietu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxP1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.txtBoxPath.Text.Trim().Length==0)
            {
                MessageBox.Show("parent Path is not null");
                return;
            }
            if (this.txtBoxP1.Text.Trim().Length == 0)
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
            string snnumber = this.txtBoxP1.Text.Trim();



            DateTime dt = DateTime.Now;
            string dateStr1 = "20:00:00";
            string dateStr2 = dt.ToString("HH:mm:ss");
            DateTime t1 = Convert.ToDateTime(dateStr1);
            DateTime t2 = Convert.ToDateTime(dateStr2);
            int compNum = DateTime.Compare(t1, t2);
            if (compNum > 0)
            {
                //继续创建第二天（当天的）的文件夹，并且往里面加上图片
                string saveRealPath = parentPath + "\\P12\\" + timefolder2 + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\P12\\" + timefolder2;
                if (this.txtChildP1.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildP1.Text.Trim();
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\P12\\" + timefolder2 + "\\" + this.txtChildP1.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxP1.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    myImage.Save(saveRealPath);
                    this.txtBoxP1.Text = "";
                }
            }
            if (compNum == 0)
            {
            }
            if (compNum < 0)
            {

                //创建第二天的文件夹，并且往里面加上图片
                string tommorm = DateTime.Now.AddDays(+1).ToString("MMdd");
                string saveRealPath = parentPath + "\\P12\\" + tommorm + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\P12\\" + tommorm;
                if (this.txtChildP1.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildP1.Text.Trim();
                    Console.WriteLine(filepaht);
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\P12\\" + tommorm + "\\" + this.txtChildP1.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxP1.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }

                    myImage.Save(saveRealPath);
                    this.txtBoxP1.Text = "";
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
            if (this.txtBoxQ1.Text.Trim().Length == 0)
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
            string snnumber = this.txtBoxQ1.Text.Trim();

            DateTime dt = DateTime.Now;
            string dateStr1 = "20:00:00";
            string dateStr2 = dt.ToString("HH:mm:ss");
            DateTime t1 = Convert.ToDateTime(dateStr1);
            DateTime t2 = Convert.ToDateTime(dateStr2);
            int compNum = DateTime.Compare(t1, t2);
            if (compNum > 0)
            {
                //继续创建第二天（当天的）的文件夹，并且往里面加上图片
                string saveRealPath = parentPath + "\\Q12\\" + timefolder2 + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\Q12\\" + timefolder2;
                if (this.txtChildQ1.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildQ1.Text.Trim();
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\Q12\\" + timefolder2 + "\\" + this.txtChildQ1.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxQ1.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    myImage.Save(saveRealPath);
                    this.txtBoxQ1.Text = "";
                }
            }
            if (compNum == 0)
            {
            }
            if (compNum < 0)
            {

                //创建第二天的文件夹，并且往里面加上图片
                string tommorm = DateTime.Now.AddDays(+1).ToString("MMdd");
                string saveRealPath = parentPath + "\\Q12\\" + tommorm + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\Q12\\" + tommorm;
                if (this.txtChildQ1.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildQ1.Text.Trim();
                    Console.WriteLine(filepaht);
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\Q12\\" + tommorm + "\\" + this.txtChildQ1.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxQ1.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }

                    myImage.Save(saveRealPath);
                    this.txtBoxQ1.Text = "";
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
            if (this.txtBoxR1.Text.Trim().Length == 0)
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
            string snnumber = this.txtBoxR1.Text.Trim();




            DateTime dt = DateTime.Now;
            string dateStr1 = "20:00:00";
            string dateStr2 = dt.ToString("HH:mm:ss");
            DateTime t1 = Convert.ToDateTime(dateStr1);
            DateTime t2 = Convert.ToDateTime(dateStr2);
            int compNum = DateTime.Compare(t1, t2);
            if (compNum > 0)
            {
                //继续创建第二天（当天的）的文件夹，并且往里面加上图片
                string saveRealPath = parentPath + "\\R12\\" + timefolder2 + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\R12\\" + timefolder2;
                if (this.txtChildR1.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildR1.Text.Trim();
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\R12\\" + timefolder2 + "\\" + this.txtChildR1.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxR1.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    myImage.Save(saveRealPath);
                    this.txtBoxR1.Text = "";
                }
            }
            if (compNum == 0)
            {
            }
            if (compNum < 0)
            {

                //创建第二天的文件夹，并且往里面加上图片
                string tommorm = DateTime.Now.AddDays(+1).ToString("MMdd");
                string saveRealPath = parentPath + "\\R12\\" + tommorm + "\\" + snnumber + "__" + timefolder + ".jpg";
                string filepaht = parentPath + "\\R12\\" + tommorm;
                if (this.txtChildR1.Text.Trim().Length != 0)
                {

                    filepaht = filepaht + "\\" + this.txtChildR1.Text.Trim();
                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }
                    saveRealPath = parentPath + "\\R12\\" + tommorm + "\\" + this.txtChildR1.Text.Trim() + "\\" + snnumber + "__" + timefolder + ".jpg";
                    myImage.Save(saveRealPath);
                    this.txtBoxR1.Text = "";
                }
                else
                {

                    if (!Directory.Exists(filepaht))
                    {
                        Directory.CreateDirectory(filepaht);
                    }

                    myImage.Save(saveRealPath);
                    this.txtBoxR1.Text = "";
                }

            }



        }

        private void txtBoxP1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtBoxP1.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                button1_Click(null, null);
            }
        }

        private void txtBoxQ1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtBoxQ1.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                button2_Click(null, null);
            }
        }

        private void txtBoxR1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtBoxR1.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                button3_Click(null, null);
            }
        }
    }
}
