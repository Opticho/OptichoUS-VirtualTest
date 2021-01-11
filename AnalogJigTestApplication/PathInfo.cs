using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace AnalogJigTestApplication
{
    public class PathInfo
    {
        public static string excelPath = Path.GetFullPath(@"..\..\..\settingFile\AnalogJigAddressMap.xlsx");
        private byte loadCount = 0;

        public PathInfo()
        {
            excelPath = Find_Path(excelPath);
            loadCount++;
        }

        public string Find_Path(string file_path)
        {
            
            FileInfo file = new FileInfo(file_path);

            if (file.Exists == false)
            {
                if (MessageBox.Show("Can't find AnalogJigAddressMap.xlsx, Please find excel file first.\n Current path: " + excelPath, "Can't Find File Error", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    file_path = Search_Path();
                }
                else
                {
                    ExitProgram();
                }
            }
            return file_path;
        }

        public string Search_Path()
        {

            firstStep:

            string file_path = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            openFileDialog.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
            openFileDialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog.FileName;

                DialogResult messageResult = MessageBox.Show("File content at path: " + file_path + "\nIs the right Excel file path?", "Yes No Cancel", MessageBoxButtons.YesNoCancel);

                if (messageResult == DialogResult.Yes)
                {
                    return file_path;
                }
                else if (messageResult == DialogResult.No)
                {
                    goto firstStep;
                }
                else if (messageResult == DialogResult.Cancel)
                {
                    if (loadCount > 0)
                    {
                        file_path = PathInfo.excelPath;
                    }
                    else
                    {
                        ExitProgram();
                    }
                }
            }
            return file_path;
        }

        public void ExitProgram()
        {
            MessageBox.Show("프로그램을 종료합니다", "NO XLSX EXIST", MessageBoxButtons.OK);
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}
