using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer2();
            Console.ReadKey();
        }
        static void ejer1()


        {
            double aumento = 0, descuento = 0, precio_producto, precio_final = 0;
            int codigo_descuento;

            Console.Write("INGRESE EL PRECIO PRODUCTO: ");
            precio_producto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n[1].ESTUDIANTE\n[2].EMPLEADO\n[3].CLIENTE FRECUENTE");
            Console.Write("\nINGRESA TU CÓDIGO DE DESCUENTO: ");
            codigo_descuento = Convert.ToInt32(Console.ReadLine());

            if (precio_producto > 0 && (codigo_descuento == 1 || codigo_descuento == 2 || codigo_descuento == 3))
            {
                switch (codigo_descuento)
                {
                    case 1:
                        descuento = precio_producto * 0.10;
                        break;
                    case 2:
                        descuento = precio_producto * 0.15;
                        break;
                    case 3:
                        descuento = precio_producto * 0.20;
                        break;
                    default:
                        Console.WriteLine("\nCÓDIGO DE DESCUENTO INCORRECTO");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nEL PRECIO DEL PRODUCTO DEBE SER MAYOR A 0 Y EL CÓDIGO DE DESCUENTO VÁLIDO");
                Environment.Exit(0);
            }

            if (precio_producto > 500)
            {
                aumento = precio_producto * 0.05;
            }


            precio_final = (precio_producto - descuento) + aumento;
            precio_final = Math.Round(precio_final, 2);

            Console.WriteLine($"\nEL DESCUENTO ES: {descuento:F2} soles");
            Console.WriteLine($"EL INCREMENTO ES: {aumento:F2} soles");
            Console.WriteLine($"EL PRECIO FINAL ES: {precio_final:F2} soles");

        }
        static void ejer2()
        {
            //Ejercicio 2

            int nota = 0;
            double potencia,raiz;

            Console.Write("INGRESE SU NOTA [0-20]: ");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 0 && nota <= 20)

            {
                Console.WriteLine("TU NOTA ESTA DENTRO DEL RANGO");
            }

            else if (nota < 0 || nota > 20)
            {
                Console.WriteLine("TU NOTA ESTA FUERA DEL RANGO");
                Environment.Exit(0);
            }


            switch (nota)
            {
                case int n when (nota >= 0 && nota <= 10):
                    Console.WriteLine("DESAPROBADO");
                    break;
                case int n when (nota >= 11 && nota <= 13):
                    Console.WriteLine("REGULAR");
                    break;
                case int n when (nota >= 14 && nota <= 17):
                    Console.WriteLine("BUENO");
                    break;

               case int n when (nota >= 18 && nota <=20):
                    Console.WriteLine("EXCELENTE");
                    break;
                
               default:
                    Console.WriteLine("NOTA INVALIDA");
                    break;
            }
             if (nota >= 14 && nota % 2 == 0)
            {
                                Console.WriteLine("Buen desempeño con nota par");
            }
             if (nota < 11 || nota %2 != 0)
            {
                                 Console.WriteLine("Necesita reforzar");
            }

             raiz = Math.Round(Math.Sqrt(nota),1);
            potencia = Math.Pow(nota, 3);

            Console.WriteLine($"Raíz cuadrada: {raiz}");
            Console.WriteLine($"Potencia: {potencia}");

        }
    }
}
