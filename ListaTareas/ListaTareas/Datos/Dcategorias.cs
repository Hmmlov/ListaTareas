using ListaTareas.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListaTareas.Datos
{
    public class Dcategorias
    {

        public ObservableCollection<Mcategorias> ListarCategorias()
        {
            return new ObservableCollection<Mcategorias>(){
                
                new Mcategorias()
                {
                    icono = "https://i.ibb.co/zJNtyJV/trophy.png",
                    categoria = "Sport",
                    color = "#6C9EFD"
                },
                new Mcategorias()
                {
                    icono = "https://i.ibb.co/LZbgHNP/musical-note.png",
                    categoria = "Music",
                    color = "white"
                },
                new Mcategorias()
                {
                    icono = "https://i.ibb.co/xzSNqzR/gorro-de-graduacion.png",
                    categoria = "Study",
                    color = "white"
                },
                new Mcategorias()
                {
                    icono = "https://i.ibb.co/42gvRz0/grid.png",
                    categoria = "All",
                    color = "white"
                }
             };
        }

    }
}

