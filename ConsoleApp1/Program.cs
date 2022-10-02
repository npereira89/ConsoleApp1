﻿using System;
using System.Linq;

namespace Calculadora
{
    class Program
    {

        static void Soma(int a, int b)
        {
            int result;
            result = a + b;
            Console.WriteLine($"A soma dos dois números é: {result}\nPress '0' to back to painel main");
            string volta_menu = Console.ReadLine();
            int confirm_volta_menu = Convert.ToInt32(volta_menu);

            if (confirm_volta_menu == 0)
            {
                Main();
            }
            else
            {
                do
                {
                    Console.WriteLine("Warning!! You should Press '0' to back to painel main.");
                    string tenta_volta_menu = Console.ReadLine();
                    int confirm_tenta_volta_menu = Convert.ToInt32(tenta_volta_menu);

                    if (confirm_tenta_volta_menu == 0)
                    {
                        Main();

                    }
                } while (confirm_volta_menu != 0);
            }

        }

        static void Divisao(int a, int b)
        {
            int result;
            result = a / b;
            Console.WriteLine($"A soma dos dois números é: {result}\nPress '0' to back to painel main");
            string volta_menu = Console.ReadLine();
            int confirm_volta_menu = Convert.ToInt32(volta_menu);

            if (confirm_volta_menu == 0)
            {
                Main();
            }
            else
            {
                do
                {
                    Console.WriteLine("Warning!! You should Press '0' to back to painel main.");
                    string tenta_volta_menu = Console.ReadLine();
                    int confirm_tenta_volta_menu = Convert.ToInt32(tenta_volta_menu);

                    if (confirm_tenta_volta_menu == 0)
                    {
                        Main();

                    }
                } while (confirm_volta_menu != 0);
            }

        }
        static void Subtracao(int a, int b)
        {
            int result;
            result = a - b;
            Console.WriteLine($"A soma dos dois números é: {result}\nPress '0' to back to painel main");
            string volta_menu = Console.ReadLine();
            int confirm_volta_menu = Convert.ToInt32(volta_menu);

            if (confirm_volta_menu == 0)
            {
                Main();
            }
            else
            {
                do
                {
                    Console.WriteLine("Warning!! You should Press '0' to back to painel main.");
                    string tenta_volta_menu = Console.ReadLine();
                    int confirm_tenta_volta_menu = Convert.ToInt32(tenta_volta_menu);

                    if (confirm_tenta_volta_menu == 0)
                    {
                        Main();

                    }
                } while (confirm_volta_menu != 0);
            }

        }
        static void Potencia(int a, int b)
        {
            double result;
            result = Math.Pow(a,b);
            Console.WriteLine($"A soma dos dois números é: {result}\nPress '0' to back to painel main");
            string volta_menu = Console.ReadLine();
            int confirm_volta_menu = Convert.ToInt32(volta_menu);

            if (confirm_volta_menu == 0)
            {
                Main();
            }
            else
            {
                do
                {
                    Console.WriteLine("Warning!! You should Press '0' to back to painel main.");
                    string tenta_volta_menu = Console.ReadLine();
                    int confirm_tenta_volta_menu = Convert.ToInt32(tenta_volta_menu);

                    if (confirm_tenta_volta_menu == 0)
                    {
                        Main();

                    }
                } while (confirm_volta_menu != 0);
            }

        }
        static void Main()
        {
            Console.Clear();

            Console.WriteLine("CALCULADORA:\n" +
                "1 - SOMA\n" +
                "2 - DIVISÃO\n" +
                "3 - SUBTRAÇÃO\n" +
                "4 - POTÊNCIA\n" +
                "5 - SAIR\n");

            string value_calc = Console.ReadLine();
            Console.WriteLine("O valor introduzido " + value_calc);

            // se o valor for caracter ou nulo, vai voltar para o menu. 
            if (string.IsNullOrEmpty(value_calc) || value_calc.Contains("A"))   
            {

                Console.WriteLine("Please, press the options main menu!!");
                Main();


            }
            else
            {
                // se o valor for numerico, converte para Int32 e faz os calculos corretos, consoante
                //cada um dos casos de testes que tem para efetuar 

                int opcao_calc = Convert.ToInt32(value_calc);

                if (opcao_calc >= 1 && opcao_calc <= 5)
                {
                    if (opcao_calc == 1)
                    {
                        Console.Clear();

                        Console.WriteLine("Insere o primeiro valor");
                        string valor1 = Console.ReadLine();
                        int confirm_valor1 = Convert.ToInt32(valor1);

                        Console.WriteLine("Insere o segundo valor");
                        string valor2 = Console.ReadLine();
                        int confirm_valor2 = Convert.ToInt32(valor2);

                        Program.Soma(confirm_valor1, confirm_valor2);

                    }

                    if (opcao_calc == 2)
                    {
                        Console.Clear();

                        Console.WriteLine("Insere o primeiro valor");
                        string valor1 = Console.ReadLine();
                        int confirm_valor1 = Convert.ToInt32(valor1);

                        Console.WriteLine("Insere o segundo valor");
                        string valor2 = Console.ReadLine();
                        int confirm_valor2 = Convert.ToInt32(valor2);

                        Program.Divisao(confirm_valor1, confirm_valor2);

                    }

                    if (opcao_calc == 3)
                    {
                        Console.Clear();

                        Console.WriteLine("Insere o primeiro valor");
                        string valor1 = Console.ReadLine();
                        int confirm_valor1 = Convert.ToInt32(valor1);

                        Console.WriteLine("Insere o segundo valor");
                        string valor2 = Console.ReadLine();
                        int confirm_valor2 = Convert.ToInt32(valor2);

                        Program.Subtracao(confirm_valor1, confirm_valor2);

                    }

                    if (opcao_calc == 4)
                    {
                        Console.Clear();

                        Console.WriteLine("Insere o primeiro valor");
                        string valor1 = Console.ReadLine();
                        int confirm_valor1 = Convert.ToInt32(valor1);

                        Console.WriteLine("Insere o segundo valor");
                        string valor2 = Console.ReadLine();
                        int confirm_valor2 = Convert.ToInt32(valor2);

                        Program.Potencia(confirm_valor1, confirm_valor2);

                    }

                    if (opcao_calc == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Press to close....");
                        Console.ReadKey();
                        System.Environment.Exit(0);

                    }

                    if (opcao_calc > 5)
                    {
                        Console.WriteLine("Please, press the options main menu!!");
                        Main();
                    }
                }
            }
        
        }
    }

}



