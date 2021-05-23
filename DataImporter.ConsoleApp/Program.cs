using System;
using System.Collections.Generic;
using System.IO;
using DataImporter.Core;
using DataImporter.Core.Services;
using DataImporter.Repository;


namespace DataImporter.ConsoleApp
{
  
    class Program
    {
        static void Main(string[] args)
        {
            string filesPath = Environment.CurrentDirectory;
            filesPath = filesPath + "\\TestData";
            var csvService = new CSVService();
            Console.Write(filesPath);
            Console.ReadLine();
            //csvService.LoadFiles(filesPath);
            //var dataImportSvr = new DataImporterService();
            //dataImportSvr.ImportData(List<Product> prod);

        }
    }
}
