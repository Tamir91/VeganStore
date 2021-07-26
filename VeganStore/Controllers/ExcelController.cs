using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VeganStore.Models;

namespace VeganStore.Controllers
{
    class ExcelController
    {

        public static void CreateExcelReport<T>(string fileName)
        {
            DataSet set = DBSQL.Instance.GetDataForExcel<T>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" ;

            ExcelLibrary.DataSetHelper.CreateWorkbook(path + fileName, set);
        }

        public static void CreateExcelProductReport()
        {
            DataSet set = DBSQL.Instance.GetDataForExcel<Product>();
            string fileName = "products.xls";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\";
            ExcelLibrary.DataSetHelper.CreateWorkbook(path + fileName, set);
        }
    }
}
