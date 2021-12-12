using FinalExam.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Services
{
    public static class Constants
    {
        public const string DatabaseFilename = "FinalExamSetASQLite.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
    }
    public class ProductDatabase
    {
        readonly SQLiteAsyncConnection database;

        public ProductDatabase()
        {
            database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            database.CreateTableAsync<Product>().Wait();
        }

        public Task<List<Product>> GetProductsAsync()
        {
            return database.Table<Product>().ToListAsync();
        }


        public Task<int> SaveProductAsync(Product product)
        {
            if (product.Id != 0)
            {
                return database.UpdateAsync(product);
            }
            else
            {
                return database.InsertAsync(product);
            }
        }

        public Task<int> DeleteProductAsync(Product product)
        {
            return database.DeleteAsync(product);
        }
    }
}
