using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightMe.Model;

namespace WeightMe.Data
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<WeightEntry>().Wait();
        }

        public Task<List<WeightEntry>> GetWeightEntriesAsync()
        {
            return _database.Table<WeightEntry>().ToListAsync();
        }

        public Task<int> SaveWeightEntryAsync(WeightEntry entry)
        {
            if (entry.Id != 0)
            {
                return _database.UpdateAsync(entry);
            }
            else
            {
                return _database.InsertAsync(entry);
            }
        }

        public Task<int> DeleteWeightEntryAsync(WeightEntry entry)
        {
            return _database.DeleteAsync(entry);
        }
    }
}
