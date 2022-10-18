using ListaTareas.Datos;
using ListaTareas.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ListaTareas.Vistas;

namespace ListaTareas.VistaModelo
{
    public class VMpaginaprincipal:BaseViewModel
    {
        #region VARIABLES
        List<Mtareas> _ListaTareas;
        Modelo.Mtareas _mtareas;
        public string _Titulo;
        public string _Descripcion;
        public string _Estado;
        ObservableCollection<Mcategorias> _ListaCategorias;
        #endregion
        #region CONSTRUCTOR
        public VMpaginaprincipal(INavigation navigation)
        {
            Navigation = navigation;
            ListarTareasAll();
            ListarCategoriasAll();
            //Actualizar();
        }
        #endregion
        #region OBJETOS
        public List<Mtareas> ListaTareas
        {
            get { return _ListaTareas; }
            set { SetValue(ref _ListaTareas, value); }
        }
        public ObservableCollection<Mcategorias> ListaCategorias
        {
            get { return _ListaCategorias; }
            set { SetValue(ref _ListaCategorias, value); }
        }
        public string Titulo
        {
            get { return _Titulo; }
            set { SetValue(ref _Titulo, value); }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { SetValue(ref _Descripcion, value); }
        }
        public string Estado
        {
            get { return _Estado; }
            set { SetValue(ref _Estado, value); }
        }
        #endregion
        #region PROCESOS
        public async void ListarTareasAll()
        {
            //var funcion = new Dtareas();
            //ListaTareas = funcion.ListarTareaas();
            ListaTareas = await App.MyDatabase.ListarTareas();
        }
        //Funcion muestra
        public async void Actualizar()
        {
            _mtareas.Descripcion = "Prueba";
            _mtareas.Titulo = "Prueba";
            _mtareas.Estado = "Completo";

            await App.MyDatabase.ActualizarTarea(_mtareas);
        }
        public async void AgregarTarea()
        {
            await App.MyDatabase.CrearTarea(new Modelo.Mtareas
            {
                Titulo = Titulo,
                Descripcion = Descripcion,
                Fecha = new DateTime(),
                Estado = Estado
            });
            ListarTareasAll();
            await Navigation.PushModalAsync(new PaginaPrincipal());
        }
        public async Task VistaAgregar()
        {
            await Navigation.PushModalAsync(new Agregar());
            
        }
        public void ListarCategoriasAll()
        {
            var funcion = new Dcategorias();
            ListaCategorias = funcion.ListarCategorias();
        }
        #endregion
        #region COMANDOS
        public ICommand agregarCommand => new Command(AgregarTarea);
        public ICommand VistaCommand => new Command(async () => await VistaAgregar());
        #endregion
    }
}
