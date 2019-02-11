using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelManipulater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_SortFile.Enabled = false;
        }
        
        Excel.Application xlApp;
        Excel.Range xlRange;
        Excel.Workbook xlWorkbook;
        Excel._Worksheet xlWorksheet;
        OpenFileDialog FileDialog;

        private void btn_ImportFile_Click(object sender, EventArgs e)
        {
            FileDialog = new OpenFileDialog();
            FileDialog.ShowDialog();

            xlApp = new Excel.Application();
            xlWorkbook = xlApp.Workbooks.Open(FileDialog.FileName);
            xlWorksheet = xlWorkbook.Sheets[1];
            xlRange = xlWorksheet.UsedRange;

            fillComboBoxes(xlRange);

            btn_SortFile.Enabled = true;
        }

        private void fillComboBoxes(Excel.Range xlRange)
        {
            int row = 1;
            while (!string.IsNullOrEmpty(xlRange.Cells[1, row].Value2?.ToString()))
            {
                cmb_SortBy.Items.Add(xlRange.Cells[1, row].Value2.ToString());
                row++;
            }

            cmb_SortStyles.Items.Add("Ascending");
            cmb_SortStyles.Items.Add("Descending");
        }


        private void btn_SortFile_Click(object sender, EventArgs e)
        {
            Excel.Range fullDataRange = xlWorksheet.UsedRange;

            if (cmb_SortBy.SelectedIndex == -1)
            {
                cmb_SortBy.SelectedIndex++;
            }

            if (cmb_SortStyles.SelectedIndex == -1)
            {
                cmb_SortStyles.SelectedIndex++;
            }

            switch (cmb_SortStyles.Text)
            {
                case "Ascending":
                    fullDataRange.Sort(fullDataRange.Columns[cmb_SortBy.SelectedIndex + 1, Type.Missing], Excel.XlSortOrder.xlAscending, 
                        Type.Missing, Type.Missing, Excel.XlSortOrder.xlAscending, Type.Missing, Excel.XlSortOrder.xlAscending, 
                        Excel.XlYesNoGuess.xlGuess, Type.Missing, Type.Missing, Excel.XlSortOrientation.xlSortColumns, Excel.XlSortMethod.xlPinYin, 
                        Excel.XlSortDataOption.xlSortNormal, Excel.XlSortDataOption.xlSortNormal, Excel.XlSortDataOption.xlSortNormal);
                    break;

                case "Descending":
                    fullDataRange.Sort(fullDataRange.Columns[cmb_SortBy.SelectedIndex + 1, Type.Missing], Excel.XlSortOrder.xlDescending, 
                        Type.Missing, Type.Missing, Excel.XlSortOrder.xlDescending, Type.Missing, Excel.XlSortOrder.xlDescending,
                        Excel.XlYesNoGuess.xlGuess, Type.Missing, Type.Missing, Excel.XlSortOrientation.xlSortColumns, Excel.XlSortMethod.xlPinYin,
                        Excel.XlSortDataOption.xlSortNormal, Excel.XlSortDataOption.xlSortNormal, Excel.XlSortDataOption.xlSortNormal);
                    break;
            }

            if (xlWorkbook.ReadOnly)
            {
                MessageBox.Show("The changes couldnt be saved because the File is most likely still open, please close it and try again");
            }
            else
            {
                xlWorkbook.Save();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            xlWorkbook.Close();
        }
    }
}
