using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Bingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //定义2个数组，存放 中奖与不中奖号码
        List<int> listOrg = new List<int>();
        List<string> listLuck = new List<string>();

        bool isStart = false;
        bool isMax = false;
        int row = 1;
        int column = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            ////#region//初始化控件参数

            //////窗口参数
            //////this.FormBorderStyle = FormBorderStyle.None;     //设置窗体为无边框样式
            //////this.WindowState = FormWindowState.Maximized;    //最大化窗体 

            //////最小化按钮参数
            ////labFormMin.Left = (int)(0.95 * this.Width);
            ////labFormMin.Top = (int)(0.016 * this.Height);
            ////#endregion
            Control.CheckForIllegalCrossThreadCalls = false;

            //背景
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //SetStyle(ControlStyles.UserPaint, true); 
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            //SetStyle(ControlStyles.DoubleBuffer, true); //双缓冲

            //plane初始化
            panelEnhanced1.Top = 0;
            panelEnhanced1.Left = 0;
            panelEnhanced1.Width = this.Width;
            panelEnhanced1.Height = this.Height;

            //窗口热键
            this.KeyPreview = true;

            //初始化org数组，写入1-75
            int n = 75;
            for (int i = 1; i <= n; i++)
                listOrg.Add(i);

            #region//删除
            ////初始化luck表格 添加10行空行
            //for (int i = 0; i < 10; i++)
            //{
            //    dataGridViewLuck.Rows.Add();
            //    //int index = dataGridViewLuck.Rows.Add();
            //    //dataGridViewLuck.Rows[index].Cells[0].Value = "1";
            //    //dataGridViewLuck.Rows[index].Cells[1].Value = "2";
            //    //dataGridViewLuck.Rows[index].Cells[2].Value = "3";
            //    //dataGridViewLuck.Rows[index].Cells[3].Value = "4";
            //    //dataGridViewLuck.Rows[index].Cells[4].Value = "5";
            //}
            #endregion
        }

        #region//初始化控件参数
        private void lab()
        {
            //最小化按钮参数
            labFormMin.Left = this.Width-63;
            labFormMin.Top = 10;

            //设置窗体为无边框样式
            this.FormBorderStyle = FormBorderStyle.None;

            //滚动数字参数
            int labNum_Width = (int)(this.Width * 0.3); //30%
            int labNum_Height = (int)(this.Height * 0.6); //60%
            int labNum_Top = (int)(this.Height * 0.2); //(100-60/2) =20%
            int labNum_Left = (int)(this.Width * 0.1); //10%
            labNum.Top = labNum_Top;
            labNum.Left = labNum_Left;
            labNum.Width = labNum_Width;
            labNum.Height = labNum_Height;
            labNum.Font = new Font("微软雅黑", 130, FontStyle.Bold);//设置成参数读取

            #region//删除
            ////luck表格参数
            //int Luck_Width = (int)(this.Width * 0.4); //40%
            //int Luck_Height = labNum_Height; //60%
            //int Luck_Top = labNum_Top; //(100-60/2) =20%
            //int Luck_Left = labNum_Left + labNum_Width + (int)(this.Width * 0.1); //10%
            //dataGridViewLuck.Width = Luck_Width;
            //dataGridViewLuck.Height = Luck_Height;
            //dataGridViewLuck.Top = Luck_Top;
            //dataGridViewLuck.Left = Luck_Left;


            ////luck表格列数
            //int Luck_Column_Num = 5;
            ////luck表格行数
            //int Luck_Row_Num = 10;

            ////luck表格列宽
            //int Luck_ColumnWidth = (int)(Luck_Width / Luck_Column_Num);
            ////luck表格行高
            //int Luck_RowHeight = (int)(Luck_Height / Luck_Row_Num);

            //for (int i = 0; i < Luck_Column_Num; i++)
            //{
            //    //luck表格列宽
            //    dataGridViewLuck.Columns[i].Width = Luck_ColumnWidth;
            //    dataGridViewLuck.Columns[i].DefaultCellStyle.Font = new Font("微软雅黑", (int)(Luck_RowHeight * 2 / 3), FontStyle.Bold);
            //}

            ////luck表格行高
            //for (int i = 0; i < Luck_Row_Num-1; i++)
            //{
            //    dataGridViewLuck.Rows[i].Height = Luck_RowHeight;
            //    dataGridViewLuck.Rows[i].DefaultCellStyle.BackColor = Color.Transparent;
            //}
            //dataGridViewLuck.Rows[Luck_Row_Num - 1].Height = Luck_Height - 9*Luck_RowHeight;
            //dataGridViewLuck.Rows[Luck_Row_Num - 1].DefaultCellStyle.BackColor = Color.Transparent;
            #endregion

            //luck参数
            int Luck_Width = (int)(this.Width * 0.4 / 5) ; //40%
            int Luck_Height = labNum_Height; //60%
            int Luck_Top = labNum_Top; //(100-60/2) =20%
            int Luck_Left = labNum_Left + labNum_Width + (int)(this.Width * 0.1); //10%
            int Luck_RowHeight = (int)(Luck_Height / 10);

            labLuck1.Width = Luck_Width;
            labLuck1.Height = Luck_Height;
            labLuck1.Top = Luck_Top;
            labLuck1.Left = Luck_Left;
            labLuck1.Font = new Font("微软雅黑", (int)(Luck_RowHeight * 2 / 3), FontStyle.Bold);


            labLuck2.Width = Luck_Width;
            labLuck2.Height = Luck_Height;
            labLuck2.Top = Luck_Top;
            labLuck2.Left = Luck_Left + Luck_Width;
            labLuck2.Font = new Font("微软雅黑", (int)(Luck_RowHeight * 2 / 3), FontStyle.Bold);

            labLuck3.Width = Luck_Width;
            labLuck3.Height = Luck_Height;
            labLuck3.Top = Luck_Top;
            labLuck3.Left = Luck_Left + 2 * Luck_Width;
            labLuck3.Font = new Font("微软雅黑", (int)(Luck_RowHeight * 2 / 3), FontStyle.Bold);

            labLuck4.Width = Luck_Width;
            labLuck4.Height = Luck_Height;
            labLuck4.Top = Luck_Top;
            labLuck4.Left = Luck_Left + 3 * Luck_Width;
            labLuck4.Font = new Font("微软雅黑", (int)(Luck_RowHeight * 2 / 3), FontStyle.Bold);

            labLuck5.Width = Luck_Width;
            labLuck5.Height = Luck_Height;
            labLuck5.Top = Luck_Top;
            labLuck5.Left = Luck_Left + 4 * Luck_Width;
            labLuck5.Font = new Font("微软雅黑", (int)(Luck_RowHeight * 2 / 3), FontStyle.Bold);

            panelEnhanced1.Width = this.Width;
            panelEnhanced1.Height = this.Height;
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;    //最小化窗体 
        }

        protected override void OnResize(EventArgs e)
        {    
            if (WindowState == FormWindowState.Maximized && !isMax)
            {
                ////最大化时所需的操作 
                //MessageBox.Show("max");
                isMax = true;
                lab();
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                ////最小化时所需的操作
                //MessageBox.Show("min");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int min = 1;
            //int max = listOrg.Count;
            ////MessageBox.Show(max.ToString());
            //if (min > max)
            //    return;

            //int k = new Random(Guid.NewGuid().GetHashCode()).Next(min, max + 1);

            //labNum.Text = listOrg[k - 1].ToString();


            //labLuck.Text += "   " + listOrg[k - 1].ToString();
            //listLuck.Add(listOrg[k - 1]);
            //listOrg.RemoveAt(k - 1);

            Thread t = new Thread(start);
            t.Start();
            //start();

            //string t = "";
            //for (int i = 0; i < 10; i++)
            //    t += new Random(Guid.NewGuid().GetHashCode()).Next(1, 10).ToString() + "|";
            ////int k = new Random(Guid.NewGuid().GetHashCode()).Next(1, 75);
            //MessageBox.Show(t);
        }

        private void start()
        {
            int min = 1;
            int max = listOrg.Count;
            //MessageBox.Show(max.ToString());
            if (min > max)
                return;

            while (isStart)
            {
                Thread.Sleep(50);
                int k = new Random(Guid.NewGuid().GetHashCode()).Next(min, max);
                int temp = listOrg[k - 1];
                labNum.Text = temp.ToString();

                listOrg.RemoveAt(k - 1);
                listOrg.Add(temp);
            }

            #region//删除
            ////添加到luck 表格
            //bool isAdd = false;
            //for (int i = 0; i < 10; i++)
            //{
            //    if (isAdd)
            //        break;
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (isAdd)
            //            break;
            //        if(dataGridViewLuck.Rows[i].Cells[j].Value == null)
            //        {
            //            dataGridViewLuck.Rows[i].Cells[j].Value = labNum.Text;
            //            isAdd = true;
            //        }
            //    }
            //}
            #endregion

            //添加到luck
            Label lab = new Label();
            switch(column)
            {
                case 1:
                    lab = labLuck1;
                    break;
                case 2:
                    lab = labLuck2;
                    break;
                case 3:
                    lab = labLuck3;
                    break;
                case 4:
                    lab = labLuck4;
                    break;
                case 5:
                    lab = labLuck5;
                    break;
            }

            lab.Text += labNum.Text + "\r\n";
            column += 1;
            if (column > 5)
            {
                column = 1;
                row += 1;
            }
            //bool isAdd = false;
            //for (int i = 0; i < 10; i++)
            //{
            //    if (isAdd)
            //        break;
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (isAdd)
            //            break;
            //        if
            //    }
            //}

            //重置list 
            listLuck.Add(labNum.Text);
            listOrg.RemoveAt(max - 1);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space))
            {
                if(isStart)
                {
                    //结束
                    isStart = false;
                    //MessageBox.Show("结束");
                }
                else
                {
                    //开始
                    isStart = true;
                    Thread t = new Thread(start);
                    t.Start();                    // Run WriteY on the new thread
                    //MessageBox.Show("开始");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("点击ok退出", "标题", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {//确定按钮的方法
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
