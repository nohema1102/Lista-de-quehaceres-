using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Lista_de_quehaceres_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            CultureInfo cultura = new CultureInfo("es-MX");
            string fechaStr = fecha.ToString("d/M/yyyy");

            List<string> quehacerPendiente = new List<string>();
            List<string> quehacerCompletado = new List<string>();


            string opcion = "";
            string pendiente = "";


            Console.WriteLine("¡Bienvenido/a a tu lista de quehaceres!ヾ(＾-＾)ノ");
            //Menú de opciones
            while (opcion != "1" && opcion != "2" && opcion != "3"
             && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "0")
            {
                while (opcion != "0")
                {
                    Console.WriteLine("1) Agregar pendiente");
                    Console.WriteLine("2) Mostrar Pendientes");
                    Console.WriteLine("3) Mostrar Completados");
                    Console.WriteLine("4) Borrar pendiente");
                    Console.WriteLine("5) Completar Pendiente");
                    Console.WriteLine("6) Exportar");
                    Console.WriteLine("0) SALIR");

                    Console.WriteLine("Por favor selecciona una opción");

                    opcion = Console.ReadLine();
                    //Si la opcion es invalida
                    if (opcion != "1" && opcion != "2" && opcion != "3"
                     && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "0")
                    {
                        Console.WriteLine("¡Oops! La opción que seleccionaste no es válida ~( ´•︵•` )~");
                    }
                    //Manejo de opciones
                    if (opcion == "1")
                    {
                        Console.WriteLine("Nuevo pendiente:");
                        pendiente = Console.ReadLine();
                        quehacerPendiente.Add(pendiente);
                    }
                    else if (opcion == "2")
                    {
                        Console.WriteLine("Tus pendientes son: ");
                        for (int i = 0; i < quehacerPendiente.Count; i++)
                        {
                            Console.WriteLine(quehacerPendiente[i] + " " + fechaStr + " [ ]");
                        }
                        if (quehacerPendiente.Count == 0)
                        {
                            Console.WriteLine("No tienes pendientes, ¡Yupiii! (⌐■_■)");
                        }
                    }
                    else if (opcion == "3")
                    {
                        Console.WriteLine("Esto es lo que haz completado:");
                        for (int i = 0; i < quehacerCompletado.Count; i++)
                        {
                            Console.WriteLine(quehacerCompletado[i] + " [x]");
                        }
                        if (quehacerCompletado.Count == 0)
                        {
                            Console.WriteLine("¡No haz completado ningún pendiente! (◞‸◟；)");
                        }

                    }
                    else if (opcion == "4")
                    {
                        Console.WriteLine("Estos son tus pendientes: ");
                        for (int i = 0; i < quehacerPendiente.Count; i++)
                        {
                            Console.WriteLine(quehacerPendiente[i]);
                        }

                        Console.WriteLine("Ingresa el pendiente a borrar: ");
                        pendiente = Console.ReadLine();
                        quehacerPendiente.Remove(pendiente);
                        Console.WriteLine("Pendiente eliminado: " + pendiente);


                    }
                    else if (opcion == "5")
                    {
                        Console.WriteLine("Estos son tus pendientes: ");
                        for (int i = 0; i < quehacerPendiente.Count; i++)
                        {
                            Console.WriteLine(quehacerPendiente[i]);
                        }
                        Console.WriteLine("¿Que pendiente haz completado?");
                        pendiente = Console.ReadLine();
                        quehacerPendiente.Remove(pendiente);
                        quehacerCompletado.Add(pendiente);
                    }
                    else if (opcion == "6")
                    {
                        Console.WriteLine("Tu lista de pendientes y completados ha sido exportada a un archivo de texto");
                        using (StreamWriter quehaceresTxt = new StreamWriter("Lista de quehaceres (•‿•)"))
                        {
                            quehaceresTxt.WriteLine("(´･＿･‘) Lo que tienes pendiente:");
                            for (int i = 0; i < quehacerPendiente.Count; i++)
                            {
                                quehaceresTxt.WriteLine(quehacerPendiente[i] + " " + fechaStr + " [ ]");
                            }
                            quehaceresTxt.WriteLine("〈( ^.^)ノ Lo que has completado: ");

                            for (int i = 0; i < quehacerCompletado.Count; i++)
                        {
                            quehaceresTxt.WriteLine(quehacerCompletado[i] + " [x]");
                        }
                            

                        }
                    }
                    else if (opcion == "0")
                    {
                        Console.WriteLine("¡Hasta luego! ヽ(^◇^*)/");
                    }
                }

            }



        }
    }
}
