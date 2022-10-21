using ListaTareas.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaTareas.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listas : ContentPage
    {
        public Listas()
        {
            InitializeComponent();
            BindingContext = new VMpaginaprincipal(Navigation);
        }
    }
}