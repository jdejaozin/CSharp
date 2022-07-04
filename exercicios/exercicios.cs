using System;
using System.Globalization;

namespace exercicios
{
    class exercicios
    {
        static void Main(string[] args)
        {
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("Insira o valor do exercício que deseja realizar");
                Console.WriteLine("1 - Área de 2 triângulos");
                Console.WriteLine("2 - Área de 2 triângulos utilizando POO");
                Console.WriteLine("3 - Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            double xA, xB, xC, yA, yB, yC;

                            Console.WriteLine("Entre com as medidas do triângulo X:");
                            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.WriteLine("Entre com as medidas do triângulo Y:");
                            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            double p = (xA + xB + xC) / 2.0;
                            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
                            Console.WriteLine($"Área de X = " + areaX.ToString("F2", CultureInfo.InvariantCulture));
                            p = (yA + yB + yC) / 2.0;
                            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
                            Console.WriteLine($"Área de Y = " + areaY.ToString("F2", CultureInfo.InvariantCulture));

                            if (areaX > areaY)
                            {
                                Console.WriteLine("O triângulo X tem a área maior");
                            }
                            else if (areaX == areaY)
                            {
                                Console.WriteLine("A área dos triângulos são iguais");
                            }
                            else
                            {
                                Console.WriteLine("O triângulo Y tem a área maior");
                            }
                            Console.WriteLine("Aperte qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Triangulo x, y;

                            x = new Triangulo();
                            y = new Triangulo();

                            Console.WriteLine("Entre com as medidas do triângulo X:");
                            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.WriteLine("Entre com as medidas do triângulo Y:");
                            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                            double areaX = x.AreaTriangulo();
                            Console.WriteLine($"Área de X = " + areaX.ToString("F2", CultureInfo.InvariantCulture));
                            double areaY = y.AreaTriangulo();
                            Console.WriteLine($"Área de Y = " + areaY.ToString("F2", CultureInfo.InvariantCulture));

                            if (areaX > areaY)
                            {
                                Console.WriteLine("O triângulo X tem a área maior");
                            }
                            else if (areaX == areaY)
                            {
                                Console.WriteLine("A área dos triângulos são iguais");
                            }
                            else
                            {
                                Console.WriteLine("O triângulo Y tem a área maior");
                            }
                            Console.WriteLine("Aperte qualquer tecla para continuar");
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                }

            } while (op != 3);
        }
    }
}
