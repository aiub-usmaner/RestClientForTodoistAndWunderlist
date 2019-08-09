using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Client3
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            String titel = textBoxTaskTitel.Text + dateTimePicker1.Text.ToString();
            Int64 todoist_project_id = 2215010764;
            Int64 wunderlist_project_id = 401500612;
            if (checkBoxWunderlist.Checked)
            {
                String resultWunderlistRequest = Wunderlist.CreateTask(wunderlist_project_id, titel, dateTimePicker1.Text.ToString());

            }
            if (checkBoxTodoist.Checked)
            {
                String resultTodoistRequest = Todoist.CreateTask(todoist_project_id, titel, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Int64 todoist_project_id = 2215010764;
            Int64 wunderlist_project_id = 401500612;

            Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook xlWorkbook = app.Workbooks.Open(@"C:\freigabe\aufgabenliste.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            for (int i = 2; i <= 4; i++)
            {

                String titel = xlRange.Cells[i, 1].Value2.ToString()+" | "+ DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss");
                double datum = double.Parse(xlRange.Cells[i, 2].Value2.ToString());
                var dateTimeWunderlist = DateTime.FromOADate(datum).ToString("yyyy-MM-dd:hh:mm:ss");
                var dateTimeTodoist = DateTime.FromOADate(datum).ToString("yyyy-MM-dd");
                // MessageBox.Show(titel + " " + dateTime);

                if (checkBoxWunderlist.Checked)
                {
                    String resultWunderlistRequest = Wunderlist.CreateTask(wunderlist_project_id, titel,dateTimeWunderlist);

                }
                if (checkBoxTodoist.Checked)
                {
                    String resultTodoistRequest = Todoist.CreateTask(todoist_project_id, titel, dateTimeTodoist);
                }

            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            app.Quit();
            Marshal.ReleaseComObject(app);
        }
    }
}



