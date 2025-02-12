using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Calculadora
{
    public static class Program
    {
        private static string valid_char; // Declara variaveis constantes para validação de caracteres e numeros
        private static string valid_number;

        public static void Main()
        {
            Console.Clear();

            Console.WriteLine("CALCULADORA:\n" +
                "1 - SOMA\n" +
                "2 - DIVISÃO\n" +
                "3 - SUBTRAÇÃO\n" +
                "4 - POTÊNCIA\n" +
                "5 - SAIR\n");

            string value_calc = Console.ReadLine();

            // valida primeiro se o valor for caracter ou nulo. Caso verdadeiro, vai retornar para o menu 
            if (string.IsNullOrEmpty(value_calc) || Regex.IsMatch(value_calc, "[a-zA-Z]", RegexOptions.NonBacktracking))
            {
                Program.Main();
            }

            int opcao_calc = Convert.ToInt32(value_calc);


            valid_char = "[a-zA-Z]";
            valid_number = "[1-99999999999999999]";          

            // se o valor é maior que 5 ou menor que 1, vai voltar para o menu 
            if (opcao_calc < 1 || opcao_calc > 5)
            {
                Program.Main();
            }
            else
            {
                // caso o valor esteja dentro dos requisitos mencionados no menu vai solicitar as operações.
                Console.Clear();               

                Console.WriteLine("Insere o primeiro valor");
                string valor1 = Console.ReadLine();
                int confirm_valor1 = Convert.ToInt32(valor1);

                Console.WriteLine("Insere o segundo valor");
                string valor2 = Console.ReadLine();
                int confirm_valor2 = Convert.ToInt32(valor2);

                if (opcao_calc == 1)  /* SOMA */
                {
                    Console.Clear();
                    Program.Soma(confirm_valor1, confirm_valor2);

                }

                if (opcao_calc == 2) /* DIVISÂO */
                {
                    Console.Clear();
                    Program.Divisao(confirm_valor1, confirm_valor2);

                }

                if (opcao_calc == 3) /* SUBTRACAO */
                {
                    Console.Clear();
                    Program.Subtracao(confirm_valor1, confirm_valor2);

                }

                if (opcao_calc == 4) /* POTENCIA */
                {
                    Console.Clear();
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

        static void Soma(int a, int b)  /* efetua os calculos de soma */
        {
            int result;
            result = a + b;
            Console.WriteLine("A soma dos dois números é: " + result );
            string volta_menu = Console.ReadLine();

            /* Faz validação se é introduzido valor caracter ou numerico ou se o campo é nulo ou vazio e se foi introduzido um campo valor.
             * Valida também se for introduzido um "enter" ou "escape" */
            if (Regex.IsMatch(volta_menu, valid_char, RegexOptions.NonBacktracking) && Regex.IsMatch(volta_menu, valid_number, RegexOptions.NonBacktracking) || string.IsNullOrEmpty(volta_menu))
            {
                Main();

            }

        }
        static void Divisao(int a, int b)  /* efetua os calculos de divisão */
        {
            int result;
            result = a / b;
            Console.WriteLine("A divisao dos dois números é: " + result );
            string volta_menu = Console.ReadLine();

            /* Faz validação se é introduzido valor caracter ou numerico ou se o campo é nulo ou vazio e se foi introduzido um campo valor.
             * Valida também se for introduzido um "enter" ou "escape" */
            if (Regex.IsMatch(volta_menu, valid_char, RegexOptions.NonBacktracking) && Regex.IsMatch(volta_menu, valid_number, RegexOptions.NonBacktracking) || string.IsNullOrEmpty(volta_menu))
            {
                Main();

            }


        }
        static void Subtracao(int a, int b) /* efetua os calculos de substração */
        {
            int result;
            result = a - b;
            Console.WriteLine("A subtracao dos dois números é:" + result );
            string volta_menu = Console.ReadLine();

            /* Faz validação se é introduzido valor caracter ou numerico ou se o campo é nulo ou vazio e se foi introduzido um campo valor.
             * Valida também se for introduzido um "enter" ou "escape" */
            if (Regex.IsMatch(volta_menu, valid_char, RegexOptions.NonBacktracking) && Regex.IsMatch(volta_menu, valid_number, RegexOptions.NonBacktracking) || string.IsNullOrEmpty(volta_menu))
            {
                Main();

            }


        }
        static void Potencia(int a, int b) /* efetua os calculos de potência */
        {
            double result;
            result = Math.Pow(a, b);
            Console.WriteLine("A potencia dos dois números é:" + result );
            string volta_menu = Console.ReadLine();

            /* Faz validação se é introduzido valor caracter ou numerico ou se o campo é nulo ou vazio e se foi introduzido um campo valor.
             * Valida também se for introduzido um "enter" ou "escape" */
            if (Regex.IsMatch(volta_menu, valid_char, RegexOptions.NonBacktracking) && Regex.IsMatch(volta_menu, valid_number, RegexOptions.NonBacktracking) || string.IsNullOrEmpty(volta_menu))
            {
                Main();

            }

        }
    }

}
