
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using Georgita_Frunza_Proiect.Models;


namespace Georgita_Frunza_Proiect.Data
{
    public class SSListDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public SSListDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<SSList>().Wait();
        }
        public Task<List<SSList>> GetSSListsAsync()
        {
            return _database.Table<SSList>().ToListAsync();
        }
        public Task<SSList> GetSSListAsync(int id)
        {
            return _database.Table<SSList>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveSSListAsync(SSList sportslist)
        {
            if (sportslist.ID != 0)
            {
                return _database.UpdateAsync(sportslist);
            }
            else
            {
                return _database.InsertAsync(sportslist);
            }
        }
        public Task<int> DeleteSSListAsync(SSList sportslist)
        {
            return _database.DeleteAsync(sportslist);
        }
    }
}

