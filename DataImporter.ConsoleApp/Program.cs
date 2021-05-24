using System;
using System.Collections.Generic;
using System.IO;
using DataImporter.Core;
using DataImporter.Repository;
using DataImporter.Repository.Contexts;
using DataImporter.Repository.Services;
using Microsoft.EntityFrameworkCore;


namespace DataImporter.ConsoleApp
{
  
    class Program
    {
        static void Main(string[] args)
        {
            string filesPath = Environment.CurrentDirectory;
            filesPath = filesPath + "\\TestData";
            //var csvService = new CSVService();
            //csvService.LoadFiles(filesPath);
            var optionBuilder = new DbContextOptionsBuilder<DataImporterDbContext>();
            optionBuilder.UseSqlServer("Server=localhost;...");//put the connection str from the config file
            var context = new DataImporterDbContext(optionBuilder.Options);

            var dataImportSvr = new DataImporterService(new ProductRepository(context));
            dataImportSvr.ImportDataFromPath(filesPath);

        }
    }
}
