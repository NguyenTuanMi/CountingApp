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
using System.Runtime.InteropServices;

using Excel = Microsoft.Office.Interop.Excel;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Office.Interop.Excel;
using WinFormsApp;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private static string filePath = Path.GetFullPath("Data.xlsm");
        public static bool isAllow = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox2.Text != "")
            {
                int matchid = Int32.Parse(this.textBox2.Text);
                if (1 <= matchid && matchid <= 46)
                {
                   int id = matchid + 2;
                    string text = "";

                    Cursor.Current = Cursors.WaitCursor;

                    Excel.Application xlApp = new Excel.Application();
                        Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
                        Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                        Excel._Worksheet ws = xlWorkbook.Sheets[2];
                        Excel.Range xlRange = xlWorksheet.UsedRange;

                        xlWorksheet.Cells[id, 5] = this.textBox1.Text;
                        xlWorksheet.Cells[id, 6] = this.textBox4.Text;
                        xlWorksheet.Cells[id, 7] = this.textBox5.Text;
                        xlWorksheet.Cells[id, 8] = this.textBox6.Text;
                        xlWorksheet.Cells[id, 13] = this.textBox7.Text;
                        xlWorksheet.Cells[id, 14] = this.textBox8.Text;
                        xlWorksheet.Cells[id, 15] = this.textBox9.Text;
                        xlWorksheet.Cells[id, 12] = this.textBox12.Text;
                        xlApp.Visible = false;

                        string runMacro = "Data.xlsm!MatchPoint";

                        xlApp.GetType().InvokeMember("Run", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod, null, xlApp, new Object[] { runMacro });
                        // xlApp.UserControl = false;
                        xlWorkbook.Save();

                        //cleanup
                        GC.Collect();
                        GC.WaitForPendingFinalizers();

                        //release com objects to fully kill excel process from running in the background
                        Marshal.ReleaseComObject(xlRange);
                        Marshal.ReleaseComObject(xlWorksheet);

                        //close and release
                        xlWorkbook.Close();
                        Marshal.ReleaseComObject(xlWorkbook);

                        //quit and release
                        xlApp.Quit();
                        Marshal.ReleaseComObject(xlApp);

                        // Set cursor as default arrow
                        Cursor.Current = Cursors.Default;
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text != "")
            {
                int matchid = Int32.Parse(this.textBox2.Text) ;

                if (matchid >= 1 && matchid <= 46)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    int id = matchid + 2;

                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;



                    if (xlRange != null && xlRange.Value2 != null)
                    {
                        this.label2.Text = xlRange.Cells[id, 2].Value.ToString();
                        this.label3.Text = xlRange.Cells[id, 3].Value.ToString();
                        this.label4.Text = xlRange.Cells[id, 4].Value.ToString();
                        this.label5.Text = xlRange.Cells[id, 9].Value.ToString();
                        this.label6.Text = xlRange.Cells[id, 10].Value.ToString();
                        this.label7.Text = xlRange.Cells[id, 11].Value.ToString();

                        this.textBox1.Text = xlRange.Cells[id, 5].Value.ToString();
                        this.textBox4.Text = xlRange.Cells[id, 6].Value.ToString();
                        this.textBox5.Text = xlRange.Cells[id, 7].Value.ToString();
                        this.textBox6.Text = xlRange.Cells[id, 8].Value.ToString();
                        this.textBox7.Text = xlRange.Cells[id, 13].Value.ToString();
                        this.textBox8.Text = xlRange.Cells[id, 14].Value.ToString();
                        this.textBox9.Text = xlRange.Cells[id, 15].Value.ToString();
                        this.textBox12.Text = xlRange.Cells[id, 12].Value.ToString();

                    }

                    //cleanup
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    //release com objects to fully kill excel process from running in the background
                    Marshal.ReleaseComObject(xlRange);
                    Marshal.ReleaseComObject(xlWorksheet);

                    //close and release
                    xlWorkbook.Close();
                    Marshal.ReleaseComObject(xlWorkbook);

                    //quit and release
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);

                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;

                    
                }
            }
        }
    }
}
