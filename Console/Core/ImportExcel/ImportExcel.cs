using AppBussiness;
using Bussiness;
using Entity.Models;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OfficeOpenXml.ExcelErrorValue;

namespace Console.Core.ImportExcel
{
    public class ImportExcel
    {
        public static List<HyteraPerson> readExcel()
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                var HyteraPersonList = new List<HyteraPerson>();
                var fileName = file.FileName;
                using var package = new ExcelPackage(fileName);
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var currentSheet = package.Workbook.Worksheets;
                var workSheet = currentSheet.First();
                var noOfCol = workSheet.Dimension.End.Column;
                var noOfRow = workSheet.Dimension.End.Row;
                for (int rowIterator = 2; rowIterator <= noOfRow; rowIterator++)
                {
                    if (workSheet.Cells[rowIterator, 1].Value?.ToString() is null)
                    {
                        MessageBox.Show("Import successed");
                        break;
                    }
                    var hyteraPerson = new HyteraPerson
                    {
                        SeriNo = workSheet.Cells[rowIterator, 1].Value?.ToString(),
                        IsimVeSoyisim = workSheet.Cells[rowIterator, 2].Value.ToString(),
                    };
                    HyteraPersonList.Add(hyteraPerson);
                }
                return HyteraPersonList;
            }
            else
            {

            }
            return null;
        }
        public static List<Yazici> readExcelForYazici()
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                var YaziciPersonList = new List<Yazici>();

                var fileName = file.FileName;

                using var package = new ExcelPackage(fileName);
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var currentSheet = package.Workbook.Worksheets;
                var workSheet = currentSheet.First();
                var noOfCol = workSheet.Dimension.End.Column;
                var noOfRow = workSheet.Dimension.End.Row;

                for (int rowIterator = 2; rowIterator <= noOfRow; rowIterator++)
                {
                    if (workSheet.Cells[rowIterator, 1].Value?.ToString() is null)
                    {
                        MessageBox.Show("Import Başarılı");
                        break;

                    }
                    DateTime myDateTime = DateTime.Now;
                    string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    var yazici = new Yazici
                    {
                        Marka = workSheet.Cells[rowIterator, 2].Value?.ToString(),
                        Model = workSheet.Cells[rowIterator, 3].Value.ToString(),
                        TeslimTarih = Convert.ToDateTime(workSheet.Cells[rowIterator, 4].Value.ToString()),
                        SeriNumarasi= workSheet.Cells[rowIterator, 5].Value.ToString(),                       
                    };

                    YaziciPersonList.Add(yazici);
                }
                

                return YaziciPersonList;
            }
            else
            {

            }
            return null;
            
        }
        public static List<YaziciVeSeriNumaralari> readExcelForYaziciVeSeriNumaralari()
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                var YaziciVeSeriNumaralariList = new List<YaziciVeSeriNumaralari>();

                var fileName = file.FileName;

                using var package = new ExcelPackage(fileName);
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var currentSheet = package.Workbook.Worksheets;
                var workSheet = currentSheet.First();
                var noOfCol = workSheet.Dimension.End.Column;
                var noOfRow = workSheet.Dimension.End.Row;

                for (int rowIterator = 2; rowIterator <= noOfRow; rowIterator++)
                {
                    if (workSheet.Cells[rowIterator, 1].Value?.ToString() is null)
                    {
                        MessageBox.Show("Import successed");
                        break;

                    }
                    YaziciVeSeriNumaralari yaziciVeSeriNumaralari = new YaziciVeSeriNumaralari
                    {

                        Personel = workSheet.Cells[rowIterator, 1].Value?.ToString(),
                        Amir = workSheet.Cells[rowIterator, 2].Value.ToString(),
                        Yazici = workSheet.Cells[rowIterator, 3].Value.ToString(),
                        SeriNumarasi = workSheet.Cells[rowIterator, 4].Value.ToString(),
                        SicilNo= workSheet.Cells[rowIterator, 5].Value?.ToString(),

                    };

                    YaziciVeSeriNumaralariList.Add(yaziciVeSeriNumaralari);
                }
                return YaziciVeSeriNumaralariList;
            }
            else{}

            return null;
        }
        public static List<Otopark> readExcelForOtopark()
        {
            List<Otopark> otoparkList = new List<Otopark>();
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                
                var fileName = file.FileName;
                using var package = new ExcelPackage(fileName);
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var currentSheet = package.Workbook.Worksheets;
                var workSheet = currentSheet.First();
                var noOfCol = workSheet.Dimension.End.Column;
                var noOfRow = workSheet.Dimension.End.Row;
                for (int rowIterator = 2; rowIterator <= noOfRow; rowIterator++)
                {
                    if (workSheet.Cells[rowIterator, 1].Value?.ToString() is null)
                    {
                        MessageBox.Show("Import successed");
                        break;
                    }
                    Otopark otoparkPerson=new Otopark
                    {
                        //
                        SicilNo = workSheet.Cells[rowIterator, 1].Value.ToString(),
                        Ad = workSheet.Cells[rowIterator,2].Value.ToString(),
                        Soyad= workSheet.Cells[rowIterator, 3].Value.ToString(),
                        Servis= workSheet.Cells[rowIterator, 4].Value.CheckNull().ToString(),
                        BirimAdi= workSheet.Cells[rowIterator, 5].Value.CheckNull().ToString(),
                    };

                    otoparkList.Add(otoparkPerson);
                }

                return otoparkList;
            }
            else
            {

            }
            return null;
        }



        public static void AddDbForOtopark(List<Otopark> otoparkList)
        {
            OtoparkManager _manager = new(new());
            if (otoparkList is not null) { 
                foreach(var otopark in otoparkList)
                {
                _manager.Add(otopark);
                }
                MessageBox.Show("Veri Eklendi");
            }
        }
        public static void AddDB(List<HyteraPerson> hyteraPersons)
        {
            HyteraPersonManager manager = new(new());
            if (hyteraPersons is not null)
            {
                foreach (var item in hyteraPersons)
                {
                    manager.Add(item);
                }
            }           
        }
        public static void AddYaziciDB(List<Yazici> yazicies)
        {

            if (yazicies is not null)
            {
                YaziciManager manager = new(new());
                foreach (var item in yazicies)
                {
                    manager.Add(item);
                }
            }
               
          
        }
        public static void AddYaziciVeSeriNumaralariDb(List<YaziciVeSeriNumaralari> yaziciVeSeriNumaralari)
        {
            if (yaziciVeSeriNumaralari is not null)
            {
                YaziciVeSeriNumaralariManager manager = new(new());
                foreach (var item in yaziciVeSeriNumaralari)
                {
                    manager.Add(item);
                }
            }              
        }
    }
}
