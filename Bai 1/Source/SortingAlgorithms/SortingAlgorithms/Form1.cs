using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public partial class FrmChart : Form
    {
        public FrmChart()
        {
            InitializeComponent();
        }
        int n;//chay duoc voi so luong n < 47000000
        double time;
        private void button1_Click(object sender, EventArgs e)
        {
            int dem = 0;
            Stopwatch begin = new Stopwatch();
            begin.Start();
            chart1.Series["Insert"].Points.Clear(); chart1.Series["Insert"].Enabled = true;
            chart1.Series["Select"].Points.Clear(); chart1.Series["Select"].Enabled = true;
            chart1.Series["Bubble"].Points.Clear(); chart1.Series["Bubble"].Enabled = true;
            chart1.Series["Merge"].Points.Clear(); chart1.Series["Merge"].Enabled = true;
            chart1.Series["QuickFirst"].Points.Clear(); chart1.Series["QuickFirst"].Enabled = true;
            chart1.Series["QuickMiddle"].Points.Clear(); chart1.Series["QuickMiddle"].Enabled = true;
            chart1.Series["QuickRandom"].Points.Clear(); chart1.Series["QuickRandom"].Enabled = true;
            AlgorithmSort al = new AlgorithmSort();
            Random rd = new Random();
            Stopwatch stInsertion = new Stopwatch();
            Stopwatch stSelection = new Stopwatch();
            Stopwatch stBubbleSort = new Stopwatch();
            Stopwatch stMergeSort = new Stopwatch();
            Stopwatch stQuickSort = new Stopwatch();
            if (txtN.Text == "") MessageBox.Show("Hãy nhập vào n!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                n = int.Parse(txtN.Text);
                long[] a = new long[n];

                for (long i = 0; i < n; i++)
                {
                    a[i] = rd.Next(0,n);
                }
                if (radioButton1.Checked)
                {
                    al.QuickSortFirst(a, 0, n - 1);
                }
                else if (radioButton2.Checked)
                {
                    al.QuickSortFirst(a, 0, n - 1);
                    long[] c = new long[n];
                    for (int i = 0; i < n; i++)
                        c[n - i - 1] = a[i];
                    a = c;
                }
                //Thoi gian tinh cua giai thuat Insertion Sort
                long[] b = new long[n];
                if (cbInsert.Checked)
                {
                    for (long i = 0; i < n; i++)
                    {
                        b[i] = a[i];
                    }
                    stInsertion.Start();
                    al.InsertionSort(b);
                    stInsertion.Stop();
                    time = double.Parse(stInsertion.Elapsed.TotalMilliseconds.ToString()) * 1000;
                    chart1.Series["Insert"].Points.AddXY(Convert.ToString(n), Convert.ToInt32(time)); dem++;
                }
                else
                {
                    chart1.Series["Insert"].Enabled = false;
                }
                //Thoi gian tinh cua giai thuat Selection Sort
                

                if (cbSelect.Checked)
                {
                    for (long i = 0; i < n; i++)
                    {
                        b[i] = a[i];
                    }
                    stSelection.Start();
                    al.SelectionSort(b);
                    stSelection.Stop();
                    time = double.Parse(stSelection.Elapsed.TotalMilliseconds.ToString()) * 1000;
                    chart1.Series["Select"].Points.AddXY(Convert.ToString(n), Convert.ToInt32(time)); dem++;
                }
                else
                {
                    chart1.Series["Select"].Enabled = false;
                }
                //Thoi gian tinh cua giai thuat Bubble Sort

                if (cbBubble.Checked)
                {
                    for (long i = 0; i < n; i++)
                    {
                        b[i] = a[i];
                    }
                    stBubbleSort.Start();
                    al.bubbleSort(b);
                    stBubbleSort.Stop();
                    time = double.Parse(stBubbleSort.Elapsed.TotalMilliseconds.ToString()) * 1000;
                    chart1.Series["Bubble"].Points.AddXY(Convert.ToString(n), Convert.ToInt32(time)); dem++;
                }
                else
                {
                    chart1.Series["Bubble"].Enabled = false;
                }


                //Thoi gian tinh cua giai thuat Merge Sort 

                if (cbMerge.Checked)
                {
                    for (int i = 0; i < n; i++)
                    {
                        b[i] = a[i];
                    }
                    stMergeSort.Start();
                    al.MergeSort(b, n - 1);
                    stMergeSort.Stop();
                    time = double.Parse(stMergeSort.Elapsed.TotalMilliseconds.ToString()) * 1000;
                    chart1.Series["Merge"].Points.AddXY(Convert.ToString(n), Convert.ToInt32(time)); dem++;
                }
                else
                {
                    chart1.Series["Merge"].Enabled = false;
                }

                
               //Thoi gian tinh cua giai thuat Quick sort first


                if (cbQuickFirst.Checked)
                {
                    for (int i = 0; i < n; i++)
                        b[i] = a[i];
                    stQuickSort.Start();
                    al.QuickSortFirst(b, 0, n - 1);
                    stQuickSort.Stop();
                    time = double.Parse(stQuickSort.Elapsed.TotalMilliseconds.ToString()) * 1000;
                    chart1.Series["QuickFirst"].Points.AddXY(Convert.ToString(n), Convert.ToInt32(time)); dem++;
                }
                else
                    chart1.Series["QuickFirst"].Enabled = false;



                //Thoi gian tinh cua giai thuat Quick Sort middle



                if (cbQuickMiddle.Checked)
                {
                    for (int i = 0; i < n; i++)
                        b[i] = a[i];
                    stQuickSort.Start();
                    al.QuickSortMiddle(b, 0, n - 1);
                    stQuickSort.Stop();
                    time = double.Parse(stQuickSort.Elapsed.TotalMilliseconds.ToString()) * 1000;
                    chart1.Series["QuickMiddle"].Points.AddXY(Convert.ToString(n), Convert.ToInt32(time)); dem++;
                }
                else
                    chart1.Series["QuickMiddle"].Enabled = false;


                //Thoi gian tinh cua giai thuat Quick sort random


                if (cbQuickRandom.Checked)
                {
                    for (int i = 0; i < n; i++)
                        b[i] = a[i];
                    stQuickSort.Start();
                    al.QuickSortRandom(b, 0, n - 1);
                    stQuickSort.Stop();
                    time = double.Parse(stQuickSort.Elapsed.TotalMilliseconds.ToString()) * 1000;
                    
                    chart1.Series["QuickRandom"].Points.AddXY(Convert.ToString(n), Convert.ToInt32(time)); dem++;
                }
                else
                    chart1.Series["QuickRandom"].Enabled = false;

               
                begin.Stop();
                if(dem <= 3)
                    chart1.Series["Insert"].CustomProperties = chart1.Series["Bubble"].CustomProperties = 
                        chart1.Series["Select"].CustomProperties = 
                        chart1.Series["QuickMiddle"].CustomProperties = chart1.Series["QuickFirst"].CustomProperties
                        = chart1.Series["Merge"].CustomProperties = chart1.Series["QuickRandom"].CustomProperties =
                        "PointWidth=0.8";
                else if (dem == 4 || dem == 5 ||dem ==6)
                    chart1.Series["Insert"].CustomProperties = chart1.Series["Bubble"].CustomProperties =
                        chart1.Series["QuickFirst"].CustomProperties =
                        chart1.Series["Select"].CustomProperties = 
                        chart1.Series["QuickMiddle"].CustomProperties = chart1.Series["Merge"].CustomProperties 
                        = chart1.Series["QuickRandom"].CustomProperties =
                        "PointWidth= 1.0";
                else if (dem == 7 || dem == 8||dem == 9)
                    chart1.Series["Insert"].CustomProperties = chart1.Series["Bubble"].CustomProperties =
                        chart1.Series["QuickFirst"].CustomProperties = 
                        chart1.Series["Select"].CustomProperties = 
                        chart1.Series["QuickMiddle"].CustomProperties = chart1.Series["Merge"].CustomProperties =
                         chart1.Series["QuickRandom"].CustomProperties =
                        "PointWidth= 1.7";
                
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
