using System;
using CalculationAppCommon;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

namespace CalculationReportApp
{

    public partial class Form1 : Form
    {
        public static Form1 form1 = new Form1();
        private bool timeFlag = true;
        private string filename1;
        private string filename2;
        private string filetext1;
        private string filetext2;
        public string sign;
        private string path;
    
        public Form1()
        {
            InitializeComponent();

        }

        private void appealsButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename1 = openFileDialog1.FileName;
                var tmpname = filename1.Split('\\');
                appealsLabel.Text = $"Выбран файл {filename1.Split('\\')[tmpname.Length - 1]}";
                form1.filetext1 = File.ReadAllText(filename1);
            }
        }

        private void rkkButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                filename2 = openFileDialog2.FileName;
                var tmpname = filename2.Split('\\');
                rkkLabel.Text = $" Выбран файл {filename2.Split('\\')[tmpname.Length - 1]}";
                form1.filetext2 = File.ReadAllText(filename2);
            }
        }


        private void ShowResultsButton_Click(object sender, EventArgs e)
        {
           
            if (ProtectAgainstFool())
            {
                var userResultsForm = new ResultsForm(ResultForSortDGV(filetext1, filetext2));
                userResultsForm.Show();
            }
            else
            {
                MessageBox.Show("Загрузите два файла");
            }
            
        }

        private void CloseAPPButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void SortByNameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var signSort = "name";
            if (ProtectAgainstFool())
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    form1.path = saveFileDialog1.FileName;
                }
                ResultForSort(form1.filetext1, form1.filetext2, signSort);
            }
            else
                MessageBox.Show("Загрузите два файла");
        }

        private void SortByRKKToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var signSort = "rkkCount";
            if (ProtectAgainstFool())
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    form1.path = saveFileDialog1.FileName;
                }
                ResultForSort(form1.filetext1, form1.filetext2, signSort);
            }
            else
                MessageBox.Show("Загрузите два файла");
        }

        private void SortByAppleasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var signSort = "appealsCount";
            if (ProtectAgainstFool())
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    form1.path = saveFileDialog1.FileName;
                }
                ResultForSort(form1.filetext1, form1.filetext2, signSort);
            }

            else
                MessageBox.Show("Загрузите два файла");

        }

        private void SortByTotalAmountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var signSort = "totalCount";
            if (ProtectAgainstFool())
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    form1.path = saveFileDialog1.FileName;
                }
                ResultForSort(form1.filetext1, form1.filetext2, signSort);
            }

            else
                MessageBox.Show("Загрузите два файла");

        }

        private bool ProtectAgainstFool()
        {
            return appealsLabel.Text.Length > 0 & rkkLabel.Text.Length > 0;
        }

        private static List<Executor> ResultForSort(string path1, string path2, string signSort)
        {
            var res = new List<Executor>();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var strmas1 = form1.filetext1.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            var strmas2 = form1.filetext2.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            var dct1 = Calculate.ExecutorsAndTheirTasksAmount(strmas1);
            var dct2 = Calculate.ExecutorsAndTheirTasksAmount(strmas2);
            switch (signSort)
            {
                case "name":
                    res = Calculate.CreateResultExecutorsList(dct1, dct2).OrderByDescending(x => x.Name).ToList();
                    break;
                case "rkkCount":
                    res = Calculate.CreateResultExecutorsList(dct1, dct2).OrderByDescending(x => x.RKK_Count).ThenByDescending(x => x.TotalCount).ToList();
                    break;
                case "appealsCount":
                    res = Calculate.CreateResultExecutorsList(dct1, dct2).OrderByDescending(x => x.AppealsCount).ThenByDescending(x => x.RKK_Count).ToList();
                    break;
                case "totalCount":
                    res = Calculate.CreateResultExecutorsList(dct1, dct2).OrderByDescending(x => x.TotalCount).ThenByDescending(x => x.RKK_Count).ToList();
                    break;
            }

            var time = watch.ElapsedMilliseconds.ToString();
            FileProvider.Write(form1.path, res, form1.timeFlag, time, signSort);
            watch.Stop();
            form1.timeFlag = false;
            return res;
        }
        private static List<Executor> ResultForSortDGV(string path1, string path2)
        {
            var strmas1 = form1.filetext1.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            var strmas2 = form1.filetext2.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            var dct1 = Calculate.ExecutorsAndTheirTasksAmount(strmas1);
            var dct2 = Calculate.ExecutorsAndTheirTasksAmount(strmas2);
            return Calculate.CreateResultExecutorsList(dct1, dct2).ToList();
        }
        
    }
}
