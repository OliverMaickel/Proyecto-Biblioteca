using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca
{
    internal class Ventas
    {
        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private string _libro;

        public string Libro
        {
            get => _libro;
            set => _libro = value;
        }

        //Precios
        public double AsignarPrecio()
        {
            switch (Libro)
            {
                case "Cien años de soledad": return 52.60;
                case "1984": return 45.00;
                case "El Principito": return 36.50;
                case "Matar a un ruiseñor": return 59.00;
                case "Orgullo y prejuicio": return 45.00;
                case "El Alquimista": return 49.00;
                case "Crimen y castigo": return 66.66;
                case "El Gran Gatsby": return 45.00;

            }
            return 0;


        }

        public double CalcularSubTotal()
        {
            return AsignarPrecio() * Cantidad;
        }

        public double CalcularDescuento()
        {
            double subTotal = CalcularSubTotal();
            if (subTotal <= 100) return 5.0 / 100 * subTotal;
            else if (subTotal >100 && subTotal <= 200) return 10.0/100 * subTotal;
            else return 12.5 / 100 * subTotal;
            
        }

        public double CalcularNeto()
        {
            return CalcularSubTotal() - CalcularDescuento();
        }






    }
}
