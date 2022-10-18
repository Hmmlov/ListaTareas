using ListaTareas.Modelo;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListaTareas.Datos
{
    public class SQLiteHelper
    {
        private readonly SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Mtareas>();
        }
        public Task<int> CrearTarea(Mtareas mtareas)
        {
            return db.InsertAsync(mtareas);
        }

        public Task<List<Mtareas>> ListarTareas()
        {
            return db.Table<Mtareas>().ToListAsync();
        }
        public Task<int> ActualizarTarea(Mtareas mtareas)
        {
            return db.UpdateAsync(mtareas);
        }
        public Task<int> EliminarTarea(Mtareas mtareas)
        {
            return db.DeleteAsync(mtareas);
        }
    }
}
