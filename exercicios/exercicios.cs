using System;
using System.Globalization;
using System.Collections.Generic;

namespace exercicios
{
    class exercicios
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("Insira o valor do exercício que deseja realizar");
                Console.WriteLine("1 - Área de 2 triângulos");
                Console.WriteLine("2 - Área de 2 triângulos utilizando POO");
                Console.WriteLine("3 - Sistema de estoque");
                Console.WriteLine("4 - Área/Perímetro/Diagonal de um retângulo");
                Console.WriteLine("5 - Cadastro de funcionário");
                Console.WriteLine("6 - Notas do Aluno");
                Console.WriteLine("7 - Valor de Pi/Circunferencia/Volume utilizando métodos estáticos");
                Console.WriteLine("8 - Valor de Pi/Circunferencia/Volume utilizando métodos estáticos que estão em outro arquivo");
                Console.WriteLine("9 - Conversor de dólar");
                Console.WriteLine("10 - Sistema de estoque com construtor");
                Console.WriteLine("11 - Conta Bancaria");
                Console.WriteLine("12 - Sistema de estoque com vetor");
                Console.WriteLine("13 - Quartos para alugar");
                Console.WriteLine("14 - Lista de empregados");
                Console.WriteLine("15 - Sair");
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
                        {
                            Produto p = new Produto();

                            Console.WriteLine("Entre os dados do produto:");
                            Console.Write("Nome: ");
                            p.Nome = Console.ReadLine();
                            Console.Write("Preço: ");
                            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Quantidade no estoque: ");
                            p.Quantidade = int.Parse(Console.ReadLine());

                            Console.WriteLine("Dados do produto: " + p);

                            Console.WriteLine("");
                            Console.WriteLine("Digite o número de produtos a ser adicionado: ");
                            int qte = int.Parse(Console.ReadLine());
                            p.AdicionarProdutos(qte);
                            Console.WriteLine("Dados do produto: " + p);

                            Console.WriteLine("");
                            Console.WriteLine("Digite o número de produtos a ser removido: ");
                            qte = int.Parse(Console.ReadLine());
                            p.RemoverProdutos(qte);
                            Console.WriteLine("Dados do produto: " + p);

                            Console.WriteLine("Aperte qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Retangulo x = new Retangulo();
                            Console.WriteLine("Entre a largura e a altura do retângulo: ");
                            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.WriteLine("Perímetro do retângulo: " + x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
                            Console.WriteLine("Área do retângulo: " + x.Area().ToString("F2", CultureInfo.InvariantCulture));
                            Console.WriteLine("Diagonal do retângulo: " + x.Diagonal().ToString("F2"));

                            Console.WriteLine("Aperte qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Funcionario funcionario1 = new Funcionario();

                            Console.WriteLine("Insira o nome do funcionário:");
                            funcionario1.Nome = Console.ReadLine();
                            Console.WriteLine("Insira o salário do funcionário:");
                            funcionario1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.WriteLine("Insira o valor do imposto:");
                            funcionario1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.WriteLine("Funcionário: " + funcionario1);

                            Console.WriteLine("Digite a porcenta que deseja aumentar o salário:");
                            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            funcionario1.AumentarSalario(porcentagem);

                            Console.WriteLine("Funcionário: " + funcionario1);

                            Console.WriteLine("Aperte qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            Aluno aluno = new Aluno();

                            Console.WriteLine("Insira o nome do aluno:");
                            aluno.Nome = Console.ReadLine();
                            Console.WriteLine("Digite as três notas do aluno");
                            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            aluno.Aprovado();

                            Console.WriteLine("Aperte qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Digite o valor do raio:");
                            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            double circ = Circunferencia(raio);
                            double volume = Volume(raio);
                            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
                            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
                            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

                            Console.WriteLine("Aperte qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Digite o valor do raio:");
                            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            double circ = Calculadora.Circunferencia(raio);
                            double volume = Calculadora.Volume(raio);
                            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
                            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
                            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

                            Console.WriteLine("Aperte qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Qual a cotação do dólar? ");
                            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.WriteLine("Quantos dólares deseja comprar? ");
                            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            double reais = ConversorDeMoeda.Conversao(cotacao, dolar);
                            Console.WriteLine("Valor a ser pago em reais: " + reais.ToString("F2", CultureInfo.InvariantCulture));
                            
                            Console.WriteLine("Aperte qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("Entre os dados do produto:");
                            Console.Write("Nome: ");
                            string nome = Console.ReadLine();
                            Console.Write("Preço: ");
                            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Quantidade no estoque: ");
                            int quantidade = int.Parse(Console.ReadLine());

                            ProdutoConstrutor p = new ProdutoConstrutor(nome, preco, quantidade);

                            Console.WriteLine();
                            Console.WriteLine("Dados do produto: " + p);
                            Console.WriteLine();
                            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
                            int qte = int.Parse(Console.ReadLine());
                            p.AdicionarProdutos(qte);
                            Console.WriteLine();
                            Console.WriteLine("Dados atualizados: " + p);
                            Console.WriteLine();
                            Console.Write("Digite o número de produtos a ser removido do estoque: ");
                            qte = int.Parse(Console.ReadLine());
                            p.RemoverProdutos(qte);
                            Console.WriteLine();
                            Console.WriteLine("Dados atualizados: " + p);

                            Console.WriteLine("Aperte qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case 11:
                        {
                            double deposito;
                            ContaBancaria conta;

                            Console.Write("Entre o número da conta: ");
                            int numConta = int.Parse(Console.ReadLine());
                            Console.Write("Entre o titular da conta: ");
                            string titular = Console.ReadLine();
                            Console.WriteLine("Haverá depósito inicial? [s/n]");
                            string opDeposito = Console.ReadLine();

                            if(opDeposito.ToUpper() == "S")
                            {
                                Console.Write("Insira o valor do depósito: ");
                                deposito = double.Parse(Console.ReadLine());
                                conta = new ContaBancaria(numConta, titular, deposito);
                            }
                            else
                            {
                                conta = new ContaBancaria(numConta, titular);
                            }

                            Console.WriteLine("\n"+conta);

                            Console.Write("\nEntre um valor para depósito: ");
                            deposito = double.Parse(Console.ReadLine());
                            conta.Deposito(deposito);
                            Console.WriteLine(conta);

                            Console.Write("\nEntre um valor para saque: ");
                            deposito = double.Parse(Console.ReadLine());
                            conta.Saque(deposito);
                            Console.WriteLine(conta);


                            Console.WriteLine("Aperte qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case 12:
                        {
                            Console.Write("Deseja guardar informações de quantos produtos? ");
                            int indiceVetor = int.Parse(Console.ReadLine());

                            Produto[] vetorProdutos = new Produto[indiceVetor];

                            for(int i = 0; i < vetorProdutos.Length; i++)
                            {
                                Console.Write("Insira o nome do produto: ");
                                string nome = Console.ReadLine();
                                Console.Write("Insira o valor do produto: ");
                                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                Console.Write("Insira a quatidade do produto em estoque: ");
                                int quantidade = int.Parse(Console.ReadLine());

                                Produto p = new Produto { Nome = nome, Preco = preco, Quantidade = quantidade };

                                vetorProdutos[i] = p;
                            }

                            Console.WriteLine("\nLista de produtos:");
                            for(int i = 0; i < vetorProdutos.Length; i++)
                            {
                                Console.WriteLine(vetorProdutos[i]);
                            }

                            Console.WriteLine("\nAperte qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case 13:
                        {
                            string cont;
                            Pessoas[] quartos = new Pessoas[10];
                            do
                            {
                                int vagos = 0;
                                for (int i = 0; i < quartos.Length; i++)
                                {
                                    if (quartos[i] == null)
                                    {
                                        Console.WriteLine($"Quarto {i + 1}: vago");
                                        vagos++;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Quarto {i + 1}: {quartos[i]}");
                                    }
                                }
                                Console.WriteLine($"O Hotel possui {vagos} quartos vagos");
                                Console.Write("\nDeseja alugar qual quarto? ");
                                int numAlugar = int.Parse(Console.ReadLine());
                                numAlugar--;
                                if (quartos[numAlugar] == null)
                                {
                                    Console.Write("Insira o nome de quem está alugando: ");
                                    string nome = Console.ReadLine();
                                    Console.Write("Insira agora o e-mail: ");
                                    string email = Console.ReadLine();
                                    quartos[numAlugar] = new Pessoas(nome, email);
                                }
                                else
                                {
                                    Console.WriteLine("Quarto ocupado. Escolha outro quarto!");
                                }
                                Console.Write("Deseja alugar mais algum quarto?[s/n] ");
                                cont = Console.ReadLine();

                            } while (cont.ToUpper() != "N");
                            

                            Console.WriteLine("Aperte qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case 14:
                        {
                            List<Employee> employeeList = new List<Employee>();
                            int op2;
                            do
                            {
                                Console.WriteLine("1 - Adicionar empregado");
                                Console.WriteLine("2 - Aumentar salário do empregado");
                                Console.WriteLine("3 - Diminuir salário do empregado");
                                Console.WriteLine("4 - Ver lista de empregados");
                                Console.WriteLine("5 - Sair");
                                op2 = int.Parse(Console.ReadLine());

                                switch (op2)
                                {
                                    case 1:
                                        {
                                            Console.Write("ID: ");
                                            int id = int.Parse(Console.ReadLine());
                                            Console.Write("Nome: ");
                                            string nome = Console.ReadLine();
                                            Console.Write("Salário: ");
                                            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                                            Employee empregado = new Employee(id, nome, salario);

                                            employeeList.Add(empregado);

                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Write("Qual o ID do empregado que terá o aumento? ");
                                            int id = int.Parse(Console.ReadLine());
                                            Console.Write("Insira a porcentagem de aumento: ");
                                            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                                            int teste = employeeList.FindIndex(x => x.Id == id);

                                            employeeList[teste].Increase(porcentagem);

                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Write("Qual o ID do empregado que terá o decrescimo? ");
                                            int id = int.Parse(Console.ReadLine());
                                            Console.Write("Insira a porcentagem de decrescimo: ");
                                            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                                            int teste = employeeList.FindIndex(x => x.Id == id);

                                            employeeList[teste].Decrease(porcentagem);
                                            break;
                                        }
                                    case 4:
                                        {
                                            foreach(Employee item in employeeList)
                                            {
                                                Console.WriteLine(item);
                                            }
                                            Console.WriteLine("Aperte qualquer tecla para continuar");
                                            Console.ReadKey();
                                            break;
                                        }
                                }

                            } while (op2 != 5);

                            Console.WriteLine("Aperte qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case 15:
                        Console.WriteLine("Saindo...");
                        break;
                }

            } while (op != 15);
        }

        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }
        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * raio * raio * raio;
        }
    }
}
