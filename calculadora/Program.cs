#region Requisitos da calculadora
//Requisito 1
//Nossa calculadora deve ter a possibilidade de somar dois números. 
//Requisito 02 
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma
//Requisito 03 
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração
//Requisito 04 
//Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática
//Requisito 05 
//Nossa calculadora deve validar a opções do menu 
//Requisito 06
//Nossa calculadora deve realizar as operações com "0"
//Requisito 07
//Nossa calculadora deve realizar as operações com números com duas casas decimais
//Requisito 08
//Nossa calculadora deve permitir visualizar as operações já realizadas
// *  Critérios:
// *      1 - A descrição da operação realizada deve aparecer assim, exemplo:
// *  2 + 2 = 4
// *  10 - 5 = 5
#endregion
namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int contas = 10;
            string[] historico = new string[contas];
            decimal numberFinal = 0;

            string contaEfetuada = "";
            bool ehParaContinuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Calculadora 2023");
                Console.WriteLine("Digite 1 para Soma");
                Console.WriteLine("Digite 2 para Subtração");
                Console.WriteLine("Digite 3 para Multiplicação");
                Console.WriteLine("Digite 4 para Divisão");
                Console.WriteLine("Digite 5 para Gerar Tabuada");
                Console.WriteLine("Digite S para Sair");

                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "S" && operacao != "s" && operacao != "5")
                {
                    Console.WriteLine("Opção inválida! Tente novamente!");
                    Console.ReadLine();
                    continue;
                }

                if (operacao == "5")
                {

                    Console.WriteLine("Digite o número para gerar a tabuada: ");
                    int tabuada = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= 10; i++)//i = i + 1
                    {
                        int resultadoMulti = tabuada * i;
                        Console.WriteLine(tabuada + " x " + i + " = " + resultadoMulti);
                    }
                    #region Montando a tabuada com while
                    //while (numero <=10)
                    //{
                    //    int resultadoMulti = tabuada* numero;
                    //    numero = numero +1;
                    //    Console.WriteLine(tabuada + " x " + numero + " = " + resultadoMulti);
                    //}
                    #endregion
                    Console.ReadLine();
                    continue;
                }
                Console.Write("Digite o primeiro número: ");
                decimal number1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                decimal number2 = Convert.ToDecimal(Console.ReadLine());
                switch (operacao)
                {
                    case "1":
                        numberFinal = number1 + number2;
                        contaEfetuada = $"{number1} + {number2} = {numberFinal}"; break;
                    case "2":
                        numberFinal = number1 - number2;
                        contaEfetuada = $"{number1} - {number2} = {numberFinal}"; break;
                    case "3":
                        numberFinal = number1 * number2;
                        contaEfetuada = $"{number1} * {number2} = {numberFinal}"; break;
                    case "4":
                        {
                            while (number2 == 0)
                            {
                                Console.WriteLine("Segundo número NÃO PODE SER ZERO! Tente novamente.");
                                Console.ReadLine();
                                Console.WriteLine("Digite o segundo número: ");
                                number2 = Convert.ToDecimal(Console.ReadLine());
                            }


                            numberFinal = number1 / number2;
                            contaEfetuada = $"{number1} / {number2} = {numberFinal}"; break;
                        }
                }
                #region Caso utilizado com IF
                ////if (operacao == "1")
                //{
                //    numberFinal = number1 + number2;
                //    contaEfetuada = $"{number1} + {number2} = {numberFinal}";
                //}
                //else if (operacao == "2")
                //{
                //    numberFinal = number1 - number2;
                //    contaEfetuada = $"{number1} - {number2} = {numberFinal}";
                //}
                //else if (operacao == "3")
                //{
                //    numberFinal = number1 * number2;
                //    contaEfetuada = $"{number1} * {number2} = {numberFinal}";
                //}
                //else if (operacao == "4")
                //{

                //    while (number2 == 0)
                //    {
                //        Console.WriteLine("Segundo número NÃO PODE SER ZERO! Tente novamente.");
                //        Console.ReadLine();
                //        Console.WriteLine("Digite o segundo número: ");
                //        number2 = Convert.ToDecimal(Console.ReadLine());
                //    }


                //    numberFinal = number1 / number2;
                //    contaEfetuada = $"{number1} / {number2} = {numberFinal}";
                //}
                #endregion
                decimal resultadoFormatado = Math.Round(numberFinal, 2);

                Console.WriteLine("O resultado é: " + resultadoFormatado);
                Console.ReadLine();

                historico[contador] = contaEfetuada;
                contador++;

                foreach (var item in historico)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();

            } while (ehParaContinuar);

        }
    }
}

