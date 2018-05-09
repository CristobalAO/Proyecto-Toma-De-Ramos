using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest
{
    [Serializable]
    class Ramo
    {
        string nombre;
        string hora;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        public Ramo(string nombre, string hora)
        {
            this.Nombre = nombre;
            this.Hora = hora;
        }
    }
}
