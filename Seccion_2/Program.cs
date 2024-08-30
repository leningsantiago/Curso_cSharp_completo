using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Realizar un programa de computadora que haga el calculo Del area y perimetro de un rectangulo

            // Declarar Variables
            double altura, ancho, area, perimetro;

            // Pedimos la altura y la convertimos al tipo de dato especifico
            Console.Write("Ingresa la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            // Pedimos el ancho y la convertimos al tipo de dato especifico
            Console.Write("Ingresa el ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            // Calculamos el Area
            area = altura * ancho;

            // Calculamos el perimetro
            perimetro = 2 * (altura + ancho);

            // Mostrar el resultado
            Console.WriteLine("El area es: {0}", area);
            Console.WriteLine("El perimetro es: {0}", perimetro);


            //// Hacer un programa que transforme de grados Centígrados a grados Fahrenheit

            //// Variables
            //float gradosC, gradosF;

            //// Pedimos los °C
            //Console.Write("Dame los °C: ");
            //gradosC = Convert.ToSingle(Console.ReadLine());

            ////Convertimos los °C a °F
            //gradosF = (gradosC * 1.8f) + 32;

            //// Mostramos el resultado
            //Console.WriteLine("{0} °C = {1} °F", gradosC, gradosF);

            //// Hacer un programa que calcule el perímetro de cualquier polígono regular

            //// Variables
            //int numeroLados;
            //double tamañoLado, perimetro;

            //// Pedimos el número de lados
            //Console.Write("Dame el número de lados: ");
            //numeroLados = Convert.ToInt32(Console.ReadLine());

            //// Pedimos la medida de uno de los lados
            //Console.Write("Dame el tamaño de uno de los lados: ");
            //tamañoLado = Convert.ToDouble(Console.ReadLine());

            //// Calculamos el perímetro
            //perimetro = numeroLados * tamañoLado;

            //// Mostramos el resultado
            //Console.WriteLine("El perímetro es: {0}", perimetro);



        }
    }
}
