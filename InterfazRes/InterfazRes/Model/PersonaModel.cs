using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace InterfazRes.Model
{
    public class PersonaModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
        private bool isBusy = false;

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }



        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }
        private int celular;

        public int Celular
        {
            get { return celular; }
            set
            {
                celular = value;
                OnPropertyChanged();
            }
        }

        private string correo;

        public string Correo
        {
            get { return correo; }
            set
            {
                correo = value;
                OnPropertyChanged();
                
            }
        }

        private string contrasena;

        public string Contrasena
        {
            get { return contrasena; }
            set
            {
                contrasena = value;
                OnPropertyChanged();

            }
        }


        private string nombreCompleto;

        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apellido}";
            }
            set
            {
                nombreCompleto = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Mensaje));
            }
        }
        private string mensaje;



        public string Mensaje
        {
            get
            {
                return $"Tu nombre es: {NombreCompleto}";
            }
        }

    }
}
