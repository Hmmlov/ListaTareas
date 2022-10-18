using ListaTareas.Datos;
using ListaTareas.Vistas;
using System;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;

namespace ListaTareas
{
    public partial class App : Application
    {
        private static SQLiteHelper db;
        public static SQLiteHelper MyDatabase
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "ListaTareas.db3"));
                }
                return db;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new PaginaPrincipal();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
