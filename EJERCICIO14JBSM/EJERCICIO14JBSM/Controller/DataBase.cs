using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using EJERCICIO14JBSM.Models;

namespace EJERCICIO14JBSM.Controller
{
    public class DataBase
    {
        readonly SQLiteAsyncConnection dbase;

        public DataBase(string dbpath)
        {
            dbase = new SQLiteAsyncConnection(dbpath);
            dbase.CreateTableAsync<Photos>();
        }

        public Task<int> SavePhotosAsync(Photos photo)
        {
            if (photo.id != 0)
            {
                return dbase.UpdateAsync(photo);
            }
            else
            {
                return dbase.InsertAsync(photo);
            }
        }

        public Task<List<Photos>> GetPhotosAsync()
        {
            return dbase.Table<Photos>().ToListAsync();
        }

        public Task<Photos> GetPhotosByIdAsync(int idPhoto)
        {
            return dbase.Table<Photos>().Where(a => a.id == idPhoto).FirstOrDefaultAsync();
        }
    }
}
