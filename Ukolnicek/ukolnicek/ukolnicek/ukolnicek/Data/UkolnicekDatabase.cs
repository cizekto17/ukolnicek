using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using ukolnicek.Models;

namespace ukolnicek.Data
{
    public class UkolnicekDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public UkolnicekDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Ukol>().Wait();
        }

        public Task<List<Ukol>> GetNotesAsync()
        {
            return _database.Table<Ukol>().ToListAsync();
        }

        public Task<Ukol> GetNoteAsync(int id)
        {
            return _database.Table<Ukol>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Ukol note)
        {
            if (note.ID != 0)
            {
                return _database.UpdateAsync(note);
            }
            else
            {
                return _database.InsertAsync(note);
            }
        }

        public Task<int> DeleteNoteAsync(Ukol note)
        {
            return _database.DeleteAsync(note);
        }
    }
}