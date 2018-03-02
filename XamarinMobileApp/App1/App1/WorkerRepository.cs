using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace App1
{
    public class WorkerRepository
    {
        SQLiteConnection database;
        public WorkerRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Worker>();
        }
        public IEnumerable<Worker> GetItems()
        {
            return (from i in database.Table<Worker>() select i).ToList();
        }
        public Worker GetItem(int id)
        {
            return database.Get<Worker>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Worker>(id);
        }
        public int SaveItem(Worker item)
        {

            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }




    }
}