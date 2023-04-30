using CalculationAppCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CalculationReportApp
{
    public partial class ResultsForm : Form
    {
        private List<Executor> executors;
        Form1 form1=new Form1();
           
              
        public ResultsForm(List<Executor> executors)
        {
            InitializeComponent();
            this.executors = executors;
        }
       

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm(executors);
            WriteDataGriedView(executors);
          
        }
   
        private void SortByNameButton_Click(object sender, EventArgs e)
        {
            form1.sign = "name";
            WriteDataGriedView(executors.OrderByDescending(x => x.Name).ToList());
            
        }

       
        private void SortByRKKButton_Click(object sender, EventArgs e)
        {
            form1.sign = "rkkCount";
            WriteDataGriedView(executors.OrderByDescending(x => x.RKK_Count).ThenByDescending(x=>x.AppealsCount).ToList());
        }

        private void SortByAppealsButton_Click(object sender, EventArgs e)
        {
            form1.sign = "appealsCount";
            WriteDataGriedView(executors.OrderByDescending(x => x.AppealsCount).ThenByDescending(x=>x.RKK_Count).ToList());
        }

        private void SortByTotalAmountButton_Click(object sender, EventArgs e)
        {
            form1.sign = "totalCount";
            WriteDataGriedView(executors.OrderByDescending(x => x.TotalCount).ThenByDescending(x => x.RKK_Count).ToList());
        }

        private void WriteDataGriedView(List<Executor> executors)
        {
            ResultsdataGridView.Rows.Clear();

            var results = executors;
            var cnt = 1;
            for (int i = 0; i < executors.Count; i++)
            {
                var userResult = results[i];
                ResultsdataGridView.Rows.Add(cnt, userResult.Name, userResult.RKK_Count, userResult.AppealsCount, userResult.TotalCount);
                cnt += 1;
            }

        }
       
    }
}
