using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calculadora
{
    public class Program
    {

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

            // se o valor for caracter ou nulo ou maior que 5, vai voltar para o menu 
            if (string.IsNullOrEmpty(value_calc) && Regex.IsMatch(value_calc, "[a-zA-Z]", RegexOptions.NonBacktracking) || value_calc.Length> 1)  
            {

                Console.WriteLine("Please, press the options main menu!!");
                Main();


            }
            else
            {
                // se o valor for numerico, converte para Int32 e faz os calculos corretos, consoante
                //cada um das opções dos menu que tem para efetuar 

                int opcao_calc = Convert.ToInt32(value_calc);

                if (opcao_calc >= 1 && opcao_calc <= 5)
                {
                    if (opcao_calc == 1)  /* SOMA */
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

                    if (opcao_calc == 2) /* DIVISÂO */
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

                    if (opcao_calc == 3) /* SUBTRACAO */
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

                    if (opcao_calc == 4) /* POTENCIA */
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

                    if (opcao_calc == 5) /* SAIR */
                    {
                        Console.Clear();
                        Console.WriteLine("Press to close....");
                        Console.ReadKey();
                        System.Environment.Exit('0');

                    }
                }
            }
        
        }


        static void Soma(int a, int b)  /* efetua os calculos de soma */
        {
            int result;
            result = a + b;
            Console.WriteLine("A soma dos dois números é: " + result + "\n Press any key to back to main painel");
            string volta_menu = Console.ReadLine();

            /* Faz validação se é introduzido valor caracter ou numerico ou se o campo é nulo ou vazio e se foi introduzido um campo valor.
             * Valida também se for introduzido um "emter" ou "escape" */
            if (Regex.IsMatch(volta_menu, "[a-zA-Z]", RegexOptions.NonBacktracking) && Regex.IsMatch(volta_menu, "[1-99999999999999999]", RegexOptions.NonBacktracking) || string.IsNullOrEmpty(volta_menu))
            {
                Main();

            }

        }
        static void Divisao(int a, int b)  /* efetua os calculos de divisão */
        {
            int result;
            result = a / b;
            Console.WriteLine("A divisao dos dois números é: " + result + "\n Press '0' to back to painel main");
            string volta_menu = Console.ReadLine();

            /* Faz validação se é introduzido valor caracter ou numerico ou se o campo é nulo ou vazio e se foi introduzido um campo valor.
             * Valida também se for introduzido um "emter" ou "escape" */
            if (Regex.IsMatch(volta_menu, "[a-zA-Z]", RegexOptions.NonBacktracking) && Regex.IsMatch(volta_menu, "[1-99999999999999999]", RegexOptions.NonBacktracking) || string.IsNullOrEmpty(volta_menu))
            {
                Main();

            }


        }
        static void Subtracao(int a, int b) /* efetua os calculos de substração */
        {
            int result;
            result = a - b;
            Console.WriteLine("A subtracao dos dois números é:" + result + "\n Press '0' to back to painel main");
            string volta_menu = Console.ReadLine();

            /* Faz validação se é introduzido valor caracter ou numerico ou se o campo é nulo ou vazio e se foi introduzido um campo valor.
             * Valida também se for introduzido um "emter" ou "escape" */
            if (Regex.IsMatch(volta_menu, "[a-zA-Z]", RegexOptions.NonBacktracking) && Regex.IsMatch(volta_menu, "[1-99999999999999999]", RegexOptions.NonBacktracking) || string.IsNullOrEmpty(volta_menu))
            {
                Main();

            }


        }
        static void Potencia(int a, int b) /* efetua os calculos de potência */
        {
            double result;
            result = Math.Pow(a, b);
            Console.WriteLine("A potencia dos dois números é:" + result + "\nPress '0' to back to painel main");
            string volta_menu = Console.ReadLine();

            /* Faz validação se é introduzido valor caracter ou numerico ou se o campo é nulo ou vazio e se foi introduzido um campo valor.
             * Valida também se for introduzido um "emter" ou "escape" */
            if (Regex.IsMatch(volta_menu, "[a-zA-Z]", RegexOptions.NonBacktracking) && Regex.IsMatch(volta_menu, "[1-99999999999999999]", RegexOptions.NonBacktracking) || string.IsNullOrEmpty(volta_menu))
            {
                Main();

            }

        }
    }

}
