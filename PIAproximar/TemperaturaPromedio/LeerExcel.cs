using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace TemperaturaPromedio
{
    class LeerExcel
    {
        string RutaExcel = "";
        _Application Excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public LeerExcel (string RutaExcel, int HojaLeer)
        {
            this.RutaExcel = RutaExcel;
            wb = Excel.Workbooks.Open(RutaExcel);
            ws = wb.Worksheets[HojaLeer];
        }

        public string ExcelLeer(int i, int j)
        {
            i++;//Porque excel no empieza en cero 
            j++;
            if (ws.Cells[i,j].Value2 != null)
            {
                return ws.Cells[i, j].Value2;
            }
            else
            {
                return "";
            }
            
        }
    }
}
