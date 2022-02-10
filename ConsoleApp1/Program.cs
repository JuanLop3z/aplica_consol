using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program {
        static void Main(string[] args)
        {
            int opcion;
            String claveReal = "arroz";
            string ClaveIngresada = Console.ReadLine();
            {
                do
                {//menu de opciones
                    if (claveReal == ClaveIngresada) {
                        Console.WriteLine("-------------");
                        Console.WriteLine(" Venta de carros");
                        Console.WriteLine("1. Marcas de carros");
                        Console.WriteLine("2. Carros ultimo modelo");
                        Console.WriteLine("3. Carros vendidos");
                        Console.WriteLine("4. Salir");

                        //leer opcion del usuario
                        int.TryParse(Console.ReadLine(), out opcion);

                        switch (opcion)
                        {

                            case 1:
                                Console.WriteLine("Toyota");
                                Console.WriteLine("BMW");
                                Console.WriteLine("Hyundai");
                                Console.WriteLine("Chevrolet");
                                break;
                            case 2:
                                Console.WriteLine("Hylux");
                                Console.WriteLine("Onix");
                                Console.WriteLine("Sedan");
                                Console.WriteLine("Captiva");
                                break;
                            case 3:
                                Console.WriteLine("Sedan");
                                Console.WriteLine("Onix");
                                Console.WriteLine("Captiva");
                                break;
                            default:
                                break;
                        }
                        }
                    } while (opcion != 4) ;
                }

        }

        } 
    }