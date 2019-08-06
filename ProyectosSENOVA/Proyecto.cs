using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectosSENOVA
{
    public class Proyecto
    {
        #region Atributos

        #endregion
        #region Propieades
        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area   { get; set; }
        public int Duracion  { get; set; }
        #endregion
        #region Contructores
        public Proyecto(string nombre, double codigo, string area, int duracion)
        {
            Nombre = nombre;
            Codigo = codigo;
            Area = area;
            Duracion = duracion;



        }
        public Proyecto(string area, int duracion)
        {
            Area = area;
            Duracion = duracion;
        }
        public Proyecto()
        {

        }
        #endregion
        #region Metodos

        public void IngresarPrpyecto()
        {
            Console.WriteLine("Ingrese el Nombre del Proyecto");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Codigo");
            Codigo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Area");
            Area = Console.ReadLine();
            Console.WriteLine("Ingrese el Duracion");
            Duracion = int.Parse(Console.ReadLine());

        }

        public void ImprimirProyecto()
        {
            Console.WriteLine($"El Nombre del proyecto es:{Nombre}");
            Console.WriteLine($"El Codigo del proyecto es:{Codigo}");
            Console.WriteLine($"El Area del proyecto es:{Area}");
            Console.WriteLine($"La durecion del proyecto es:{Duracion}");
        }
        #endregion


    }
}
