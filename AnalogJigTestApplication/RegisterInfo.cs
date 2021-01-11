using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace AnalogJigTestApplication
{
    class RegisterInfo
    {
        public List<string> registerName = new List<string>();
        public List<uint> registerAddr = new List<uint>();
        public List<uint> registerSize = new List<uint>();
        public List<uint> registerDepth = new List<uint>();
        public List<uint> registerValue = new List<uint>();
        //20200401 update for datagridview
        public List<string> registerDefault = new List<string>();
        public List<string> registerFunction = new List<string>();

        private object lockObj = new object();

        //public RegisterInfo()
        //{
        //    ExcelPath = Path.GetFullPath(Path.Combine(PathInfo.DEFAULT, @"AnalogJigAddressMap.xlsx"));
        //}

        public void RegisterUpdate(string ExcelSheetName, Excel.Workbook xlWorkBook)
        {
            Excel._Worksheet xlWorkSheet = xlWorkBook.Sheets[ExcelSheetName];
            Excel.Range xlRange = xlWorkSheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            //Console.WriteLine(rowCount);
            //int colCount = 5;

            Parallel.For(3, rowCount, i =>
            {
                bool _en = false;
                string rName = string.Empty;
                uint rAddr = 0;
                uint rSize = 0;
                uint rDepth = 0;

                if (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null )
                {
                    rAddr = Convert.ToUInt32(xlRange.Cells[i, 1].Value2.ToString(), 16);
                    rName = xlRange.Cells[i, 2].Value2.ToString();
                    rSize = Convert.ToUInt32(xlRange.Cells[i, 3].Value2.ToString(), 10);
                    rDepth = Convert.ToUInt32(xlRange.Cells[i, 4].Value2.ToString(), 10);
                    _en = true;
                }
                
                if (_en == true)
                {
                    lock (lockObj)
                    {
                        registerName.Add(rName);
                        registerAddr.Add(rAddr);
                        registerSize.Add(rSize);
                        registerDepth.Add(rDepth);
                    }

                }
            });


            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorkSheet);
        }

        public void RegisterUpdate(string ExcelSheetName, int AFE5809Select, Excel.Workbook xlWorkBook)
        {
            Excel._Worksheet xlWorkSheet = xlWorkBook.Sheets[ExcelSheetName];
            Excel.Range xlRange = xlWorkSheet.UsedRange;

            int rowCount = xlRange.Rows.Count;

            //int colCount = 12;

            Parallel.For(3, rowCount, i =>
            {
                bool _en = false;
                string rName = string.Empty;
                uint rAddr = 0;
                uint rSize = 0;
                uint rDepth = 0;
                uint rValue = 0;
                string rDefault = string.Empty;
                string rFunction = string.Empty;

                if (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null)
                {
                    rAddr = Convert.ToUInt32(xlRange.Cells[i,1].Value2.ToString(), 16);
                    rName = xlRange.Cells[i,2].Value2.ToString();
                    rSize = Convert.ToUInt32(xlRange.Cells[i,3].Value2.ToString(), 10);
                    rDepth = Convert.ToUInt32(xlRange.Cells[i,4].Value2.ToString(), 10);
                    rFunction = xlRange.Cells[i, 7].Value2.ToString();

                    if (AFE5809Select == 0)
                    {
                        rValue = Convert.ToUInt32(xlRange.Cells[i, 9].Value2.ToString(), 16); //Pattern Test value
                    }
                    else
                    {
                        rValue = Convert.ToUInt32(xlRange.Cells[i, 10].Value2.ToString(), 16); //Function value
                    }

                    rDefault = xlRange.Cells[i, 11].Value2.ToString();
                    _en = true;
                }
                else
                {
                    _en = false;
                }

                if (_en == true)
                {
                    lock (lockObj)
                    {
                        registerName.Add(rName);
                        registerAddr.Add(rAddr);
                        registerSize.Add(rSize);
                        registerDepth.Add(rDepth);
                        registerValue.Add(rValue);
                        registerDefault.Add(rDefault);
                        registerFunction.Add(rFunction);
                    }
                }
            });

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorkSheet);

        }

        public int RegisterSearch(string Name)
        {
            int result = 10000;

            for (int i = 0; i < registerName.Count(); i++)
            {
                if (Name == registerName[i].Trim())
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public void RegisterClear()
        {
            registerName.Clear();
            registerAddr.Clear();
            registerSize.Clear();
            registerDepth.Clear();
            registerValue.Clear();
            registerDefault.Clear();
            registerFunction.Clear();
        }
    }
}
