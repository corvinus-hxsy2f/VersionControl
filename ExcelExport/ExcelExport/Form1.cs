using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System;

namespace ExcelExport
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities();
        List<Flat> lakasok;
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.DataSource = lakasok;
            CreateExcel();
            CreateTable();
          
        }

        public void LoadData() 
        {
            lakasok = context.Flats.ToList();
        }

        public void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;


                //...

                xlApp.Visible = true;
                xlApp.UserControl = true;

            }
            catch (Exception ex)
            {
                string hiba = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(hiba, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
            
        }

        private void CreateTable()
        {

        }
    }
}
