namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                decimal resultado;

                Console.WriteLine("Selecione a operação");
                Console.WriteLine();
                Console.WriteLine("Digite 1 para SOMA");
                Console.WriteLine("Digite 2 para SUBTRAÇÃO");
                Console.WriteLine("Digite 3 para MULTIPLICAÇÃO");
                Console.WriteLine("Digite 4 para DIVISÃO");
                int operacao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o primeiro número: ");
                decimal numero1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                decimal numero2 = Convert.ToDecimal(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        {
                            resultado = numero1 + numero2;
                            Console.WriteLine("O resultado é: " + resultado);
                            break;
                        }
                    case 2:
                        {
                            resultado = numero1 - numero2;
                            Console.WriteLine("O resultado é: " + resultado);
                            break;
                        }
                    case 3:
                        {
                            resultado = numero1 * numero2;
                            Console.WriteLine("O resultado é: " + resultado);
                            break;
                        }
                    case 4:
                        while (numero2 == 0)
                        {
                            Console.WriteLine("Digite um número diferente de zero");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                        }
                        {
                            
                            resultado = numero1 / numero2;
                            decimal resultadoFormatado = Math.Round(resultado, 2);
                            Console.WriteLine("O resultado é: " + resultadoFormatado);
                            break;
                        }
                    default:
                        Console.WriteLine("Operação inválida");
                        break;
                }
                Console.WriteLine("Gostaria de continuar? S = Sim, N = Não:");
            } while (Console.ReadLine().ToUpper() == "S");
            Console.WriteLine("Finalizando...");
        }

    }
}











