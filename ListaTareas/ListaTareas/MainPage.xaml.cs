using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using ListaTareas.Modelo;
using System.Net.Http;
using System.Net;
using ListaTareas.Vistas;

namespace ListaTareas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Login log = new Login
            {
                email = txtEmail.Text,
                password = txtPassword.Text,
            };
            Uri RequestUri = new Uri("https://reqres.in/api/login"); //aqui deben colocar su url
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(log);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(RequestUri, contentJson);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                await Navigation.PushAsync(new Listas());
            }
            else
            {
                await DisplayAlert("Mensaje", "Datos invalidos", "OK");
            }
        }
    }
}
