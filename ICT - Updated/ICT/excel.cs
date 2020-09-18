using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ICT
{
    class excel
    {
        string newPath = "";
        _Application excel32 = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public excel(string newPath, int Sheet)
        {
            this.newPath = newPath;
            wb = excel32.Workbooks.Open(newPath);
            ws = wb.Worksheets[Sheet];
        }

        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
                return ws.Cells[i, j].Value2;
            else
                return "";
        }

        public void WriteToCell(int i, int j, string s)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = s;
        }

        public void Save()
        {
            wb.Save();
        }

        public void SaveAs(string path)
        {
            wb.SaveAs(newPath);
        }

        public void Close()
        {
            wb.Close();
        }



    }
}
