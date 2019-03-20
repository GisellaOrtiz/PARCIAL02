using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METODOS
{
    public class ejercicios01al04
    {
        public int opc;
        public void ejercicio01y02()
        {
            Console.WriteLine(" INGRESE OPCION 1 u OPCION 2");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1: Console.WriteLine("MULTIPLICACION");
                    Console.WriteLine("INGRESE UN NUMERO ENTERO");
                    int valor1 = int.Parse(Console.ReadLine());
                    if (valor1 < 0 || valor1 > 0)
                    {
                        Console.WriteLine("INGRESE EL SIGUIENTE NUMERO ENTERO");
                        int valor2 = int.Parse(Console.ReadLine());
                        int multi = valor1 * valor2;
                        Console.WriteLine("RESULTADO  :" + multi);
                    }
                    else Console.WriteLine("RESULTADO DE LA MULTIPLICACION ES CERO");
                    break;
                case 2: Console.WriteLine("DIVISION");
                    Console.WriteLine("INGRESE A CONTINUACION DOS NUMEROS ENTEROS");
                    Console.WriteLine("PRIMER ENTERO");
                    int valor3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("SEGUNDO ENTERO");
                    int valor4 = int.Parse(Console.ReadLine());
                    if (valor4 < 0 || valor4 > 0)
                    {
                        double div = valor3 / valor4;
                        Console.WriteLine("RESULTADO  :" + div);
                    }
                    else Console.WriteLine("ERROR: NO SE PUEDE DIVIDIR");
                    break;
                case 3: Console.WriteLine("CAPTURAR 5 NOMBRES DE ALUMNOS");
                    int n = 5;
                    for (n = 1; n <= 5;n++ )
                    {
                        Console.WriteLine("INGRESE NOMBRE DEL ALUMNO");
                        string nombre = Console.ReadLine();
                        Console.WriteLine(" NOMBRE : " + nombre);
                    }   
                    break;
                case 4: Console.WriteLine("CAPTURAR 5 EDADES DE ALUMNOS");
                    int m=0;

                    do
                    {
                            Console.WriteLine("INGRESE NOMBRE DEL ALUMNO");
                            int edad = int.Parse(Console.ReadLine());
                            m = m + 1;
                            Console.WriteLine(" EDAD : " + edad);
                    }
                    while (m < 5);

                    break;
            }
        }



    }

   
}
