using System;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;


namespace TemperaturaPromedio
{
    class Program
    {
        
        static void Main(string[] args)
        {
           Console.WriteLine("Presiona Enter para abrir excel");
            Console.ReadLine();
            AbrirExcel();
        }
        public static void AbrirExcel()
        {
            string contenido = "";
            int indice = 0;
            LeerExcel excel = new LeerExcel(@"LeerDatosDesdeBlogAExcel.xlsx", 1);
            do
            {
                Console.WriteLine(excel.ExcelLeer(indice, 0)+ "\n");
                indice++;
            }
            while (contenido!="");
            Console.ReadLine();
        }
    }
    
}
