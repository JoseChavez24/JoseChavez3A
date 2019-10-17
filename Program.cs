using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber
{
    class Program
    {
        static void Main(string[] args)
        {
            int control = 0;
            while (control==0)
            {
                Console.WriteLine();
                Console.WriteLine("\t*********************************************************");
                Console.WriteLine("\t*------------PROGRAMACION ORIENTADA A OBJETOS-----------*");
                Console.WriteLine("\t*                     MENU DE PROGRAMAS                 *");
                Console.WriteLine("\t*********************************************************");
                Console.WriteLine("\t*  1)PROGRAMA #1\t2)PROGRAMA #2\t  3)PROGRAMA #3 *");
                Console.WriteLine("\t*                                                       *");
                Console.WriteLine("\t*  4)PROGRAMA #4\t5)PROGRAMA #5\t  6)PROGRAMA #6 *");
                Console.WriteLine("\t*                                                       *");
                Console.WriteLine("\t*  7)PROGRAMA #7\t8)PROGRAMA #8\t  9)PROGRAMA #9 *");
                Console.WriteLine("\t*                                                       *");
                Console.WriteLine("\t* 10)PROGRAMA #10\t11)SALIR\t                *");                
                Console.WriteLine("\t*********************************************************");
                Console.WriteLine("");
                Console.Write("Ingrese la opcion respectiva a ejecutar (1-11): ");
                string opcionSel = Console.ReadLine();

                if (opcionSel == "1")
                {
                    Console.Clear();
                    Console.WriteLine("PROGRAMA 1: NUMERO MAYOR DE UNA SERIE.");
                    Console.WriteLine("");
                    int cantidad = 0, numero = 0, nmayor = 0;
                    string cantidadAux = "", numeroAux = "";
                    Console.Write("Ingrese cantidad de numeros: ");
                    cantidadAux = Console.ReadLine();
                    cantidad = Convert.ToInt32(cantidadAux);
                    Console.WriteLine("");
                    for (int i = 1; i <= cantidad; i++)
                    {
                        Console.Write("Ingrese numero: ");
                        numeroAux = Console.ReadLine();
                        numero = Convert.ToInt32(numeroAux);
                        Console.WriteLine("");
                        if (numero >= nmayor)
                        {
                            nmayor = numero;
                        }
                    }
                    Console.WriteLine("El numero mayor es: " + nmayor);
                    Console.WriteLine();
                    Console.WriteLine("Finalizado, presione Enter para volver al Menu Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (opcionSel == "2")
                {
                    Console.Clear();
                    Console.WriteLine("PROGRAMA 2: CUADRADO DE ASTERISCOS.");
                    Console.WriteLine("");
                    int numero = 0;
                    string dimension = "";
                    Console.Write("Ingrese la dimension del cuadrado: ");
                    dimension = Console.ReadLine();
                    Console.WriteLine("");
                    numero = Convert.ToInt32(dimension);
                    for (int i = 0; i < numero; i++)
                    {
                        for (int i2 = 0; i2 < numero; i2++)
                        {
                            if ((i > 0) && (i < numero - 1) && (i2 > 0) && (i2 < numero - 1))
                            {
                                Console.Write("   ");
                            }
                            else
                            {
                                Console.Write(" * ");
                            }
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Finalizado, presione Enter para volver al Menu Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (opcionSel=="3")
                {
                    Console.Clear();
                    Console.WriteLine("PROGRAMA 3: FACTURA DE PRODUCTOS.");
                    Console.WriteLine("*****************************");
                    Console.WriteLine("---------- FACTURA ----------");
                    Console.WriteLine("*****************************");
                    Console.WriteLine();
                    int cantidad = 0, soporte = 0;
                    double precio = 0, subtotal = 0, total = 0;
                    string cantidadAux, precioAux;

                    while (soporte == 0)
                    {
                        Console.Write("Ingrese cantidad: ");
                        cantidadAux = Console.ReadLine();
                        cantidad = Convert.ToInt32(cantidadAux);
                        Console.WriteLine();
                        if (cantidad == 0)
                        {
                            Console.WriteLine("El total es: " + total);
                            Console.WriteLine("*****************************");
                            soporte = 1;
                        }
                        else
                        {
                            Console.Write("Ingrese precio: ");
                            precioAux = Console.ReadLine();
                            precio = Convert.ToDouble(precioAux);
                            Console.WriteLine();
                            subtotal = cantidad * precio;
                            total = subtotal + total;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Finalizado, presione Enter para volver al Menu Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (opcionSel=="4")
                {
                    Console.Clear();
                    Console.WriteLine("PROGRAMA 4: CALCULO DE SALARIOS SEMANALES.");
                    int horas = 0, salario = 0, soporte = 0, soporte2 = 0;
                    string horasAux = "", respuesta = "";
                    while (soporte == 0)
                    {
                        Console.WriteLine("");
                        Console.Write("Ingresar horas totales: ");
                        horasAux = Console.ReadLine();
                        horas = Convert.ToInt32(horasAux);
                        Console.WriteLine("");
                        if (horas > 35)
                        {
                            salario = (horas - 35) * 22 + (35 * 15);
                            Console.WriteLine("El salario semanal es: " + salario);
                            Console.WriteLine("");
                        }
                        else
                        {
                            salario = (horas * 15);
                            Console.WriteLine("El salario semanal es: " + salario);
                            Console.WriteLine("");
                        }
                        do
                        {
                            Console.Write("¿Desea calcular otro salario? (si/no): ");
                            respuesta = Console.ReadLine();
                            if (respuesta == "si")
                            {
                                Console.Clear();
                                Console.WriteLine("Espere...");
                                Console.WriteLine("");
                                soporte2 = 1;
                            }
                            else if (respuesta == "no")
                            {                                
                                soporte = 1;
                                soporte2 = 1;
                            }
                            else if (respuesta == "")
                            {
                                Console.Clear();
                                Console.WriteLine("Error. Por favor ingrese una respuesta valida.");
                                Console.WriteLine("Presione Enter para continuar.");
                                Console.ReadKey();
                                Console.Clear();
                                soporte2 = 0;
                            }
                            else if ((respuesta != "si") && (respuesta != "no"))
                            {
                                soporte2 = 0;
                                Console.Clear();
                                Console.WriteLine("Error. Por favor ingrese una respuesta valida.");
                                Console.WriteLine("Presione Enter para continuar.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        } while (soporte2 == 0);

                    }
                    Console.WriteLine();
                    Console.WriteLine("Finalizado, presione Enter para volver al Menu Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (opcionSel=="5")
                {
                    Console.Clear();
                    Console.WriteLine("PROGRAMA 5 (asteriscos4): PIRAMIDE DE ASTERISCOS");
                    Console.WriteLine("");
                    int numero, soporte;
                    string numeroAux;
                    Console.Write("Ingrese dimension de la piramide: ");
                    numeroAux = Console.ReadLine();
                    numero = Convert.ToInt32(numeroAux);
                    Console.WriteLine("");
                    soporte = numero - 1;

                    for (int i = 1; i <= numero; i++)
                    {
                        for (int i2 = 1; i2 <= soporte; i2++)

                            Console.Write(" ");
                        soporte--;

                        for (int i2 = 1; i2 <= 2 * i - 1; i2++)

                            Console.Write("*");
                        Console.WriteLine("");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Finalizado, presione Enter para volver al Menu Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcionSel=="6")
                {
                    Console.Clear();
                    Console.WriteLine("PROGRAMA 6: ROMBO DE ASTERICOS.");
                    Console.WriteLine("");
                    int numero, soporte;
                    string numeroAux;
                    Console.Write("Ingrese dimension del rombo: ");
                    numeroAux = Console.ReadLine();
                    numero = Convert.ToInt32(numeroAux);
                    Console.WriteLine("");
                    soporte = numero - 1;

                    for (int i = 1; i <= numero; i++)
                    {
                        for (int i2 = 1; i2 <= soporte; i2++)
                            Console.Write(" ");
                        soporte--;

                        for (int i2 = 1; i2 <= 2 * i - 1; i2++)
                            Console.Write("*");
                        Console.WriteLine("");
                    }
                    soporte = 1;
                    for (int i = 1; i <= numero - 1; i++)
                    {
                        for (int i2 = 1; i2 <= soporte; i2++)
                            Console.Write(" ");
                        soporte++;

                        for (int i2 = 1; i2 <= 2 * (numero - i) - 1; i2++)
                            Console.Write("*");
                        Console.WriteLine("");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Finalizado, presione Enter para volver al Menu Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (opcionSel=="7")
                {
                    Console.Clear();
                    Console.WriteLine("PROGRAMA 7: COLUMNAS DE NUMEROS DEL 1 AL 100 Y VICEVERSA.");
                    Console.WriteLine("");
                    int c2=100;
                    Console.WriteLine("\t\t  -------------------------------------------");
                    Console.WriteLine("\t\t  -     Columna 1      |      Columna 2     -");
                    Console.WriteLine("\t\t  -------------------------------------------");
                    for (int i = 1; i <= 100; i++)
                    {                       
                        if ((i >= 1) && (i <= 9))
                        {
                            Console.WriteLine("\t\t\t   {0}                     {1}", i, c2 + "  ");
                        }
                        else
                        {
                            if ((i >= 10) && (i <= 90))
                            {
                                Console.WriteLine("\t\t\t   {0}                    {1}", i, c2 + "  ");
                            }
                            else if ((i >= 90) && (i <= 100) && (c2 > 0))
                            {
                                Console.WriteLine("\t\t\t   {0}                    {1}", i, c2 + "  ");
                            }
                        }
                        c2--;
                    }
                    Console.WriteLine("\t\t  -------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Finalizado, presione Enter para volver al Menu Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (opcionSel=="8")
                {
                    Console.Clear();
                    Console.WriteLine("PROGRAMA 8: COLUMNAS CON SERIE DE NUMEROS DE 1 EN 1, 2 EN 2 Y 3 EN 3.");
                    Console.WriteLine("");
                    int numero, columna1, columna2 = 2, columna3 = 3;
                    string numeroAux;
                    Console.Write("Ingrese un numero entero positivo: ");
                    numeroAux = Console.ReadLine();
                    numero = Convert.ToInt32(numeroAux);
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("-Columna 1        Columna 2        Columna 3-");
                    Console.WriteLine("---------------------------------------------");
                    for (columna1 = 1; columna1 <= numero; columna1++)
                    {
                        Console.WriteLine("    {0,2}               {1,2}                {2} ", columna1, columna2, columna3);
                        columna2 = columna2 + 2;
                        columna3 = columna3 + 3;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Finalizado, presione Enter para volver al Menu Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (opcionSel=="9")
                {
                    Console.Clear();
                    Console.SetWindowSize(80, 60);
                    Console.WriteLine("\t         --------------------------------------------------");
                    Console.WriteLine("\t         - PROGRAMA 9: TABLAS DE MULTIPLICAR DEL 1 AL 15  -");
                    Console.WriteLine("\t         --------------------------------------------------");
                    for (int i = 1; i <= 15; i++)
                    {
                        for (int i2 = 1; i2 <= 12; i2++)
                        {
                            Console.WriteLine("\t\t\t\t   {0,2} x {1,2} = {2}", i, i2, i * i2);
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Finalizado, presione Enter para volver al Menu Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcionSel=="10")
                {
                    Console.Clear();
                    Console.WriteLine("PROGRAMA 10: OPERACIONES CON UN NUMERO.");
                    Console.WriteLine("");
                    int soporte = 0;
                    while (soporte == 0)
                    {
                        int numero, sumatoria = 0, factorial = 1;
                        string opcion, numeroAux;
                        Console.WriteLine("");
                        Console.WriteLine("     **************************");
                        Console.WriteLine("     *    Menu de Opciones    *");
                        Console.WriteLine("     *        1) Salir        *");
                        Console.WriteLine("     *       2)Sumatoria      *");
                        Console.WriteLine("     *       3)Factorial      *");
                        Console.WriteLine("     **************************");
                        Console.WriteLine("");
                        Console.Write("Digite el numero de la opcion a ejecutar (1/2/3): ");
                        opcion = Console.ReadLine();
                        if (opcion == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Finalizado.");
                            soporte = 1;
                        }
                        else if (opcion == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("         |-----SUMATORIA DE UN NUMERO.-----|");
                            Console.WriteLine("");
                            Console.Write("Ingrese un numero para realizar la operacion: ");
                            numeroAux = Console.ReadLine();
                            numero = Convert.ToInt32(numeroAux);
                            for (int i = 1; i <= numero; i++)
                            {
                                sumatoria = sumatoria + i;
                            }
                            Console.WriteLine("");
                            Console.WriteLine("La sumatoria total de " + numero + " es: " + sumatoria);
                            sumatoria = 0;
                            Console.WriteLine("");
                            Console.WriteLine("Presione Enter para continuar");
                            Console.ReadKey();
                        }
                        else if (opcion == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("         |-----FACTORIAL DE UN NUMERO.-----|");
                            Console.WriteLine("");
                            Console.Write("Ingrese un numero para realizar la operacion: ");
                            numeroAux = Console.ReadLine();
                            numero = Convert.ToInt32(numeroAux);
                            for (int i = 1; i <= numero; i++)
                            {
                                factorial = factorial * i;
                            }
                            Console.WriteLine("");
                            Console.WriteLine("El factorial de " + numero + " es: " + factorial);
                            factorial = 0;
                            Console.WriteLine("");
                            Console.WriteLine("Presione Enter para continuar");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Error. Por favor ingrese una opcion valida.");
                            Console.WriteLine("Presione Enter para continuar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        Console.Clear();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Finalizado, presione Enter para volver al Menu Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (opcionSel=="11")
                {
                    control = 1;
                    Console.WriteLine("Programa Finalizado.");
                    Console.WriteLine("Presione Enter para salir.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Error. Por favor digite una opcion valida para la ejecucion.");
                    Console.WriteLine("Presione Enter para volver al Menu Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
            Console.ReadKey();
        }
    }
}
