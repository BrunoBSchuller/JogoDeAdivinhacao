using System.Security.Claims;

namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        // V4 : Criar mútiplas tentativas
        static void Main(string[] args)
        {
           
            {
                while (true)
                {
                    String[] historicoNumeros = new string[21];

                    int contadorHistorico = 0;

                    int pontuacao = 1000;

                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Jogo da Adivinhação");
                    Console.WriteLine("----------------------------------------------");

                    //escolha de dificuldade

                    Console.WriteLine("Escolha um nível de dificuldade;");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("1 - Fácil (10 tentativas)");
                    Console.WriteLine("2 - Fácil (5 tentativas)");
                    Console.WriteLine("3 - Fácil (3 tentativas)");
                    Console.WriteLine("----------------------------------------------");

                    Console.Write("Digite sua escolha: ");
                    string escolhaDeDificuldade = Console.ReadLine();

                    int totalDeTentativas = 0;

                    if (escolhaDeDificuldade == "1")
                        totalDeTentativas = 10;

                    else if (escolhaDeDificuldade == "2")
                        totalDeTentativas = 5;

                    else
                        totalDeTentativas = 3;


                    // escolha de número aleatório

                    Random geradorDeNumeros = new Random();

                    int numeroSecreto = geradorDeNumeros.Next(1, 21);

                    
                    


                        //Lógica do jogo
                        for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)

                        {   
                            Console.Clear();

                            Console.Write("Digite um número (de 1 á 20) para chutar: ");
                            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                           

                            // Pontuação

                            int resultado = (Math.Abs(numeroDigitado - numeroSecreto) / 2);
                            pontuacao -= resultado;

                            Console.WriteLine("PONTUAÇÃO:" + pontuacao);

                            // Histórico
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("Você digitou o número: " + numeroDigitado);

                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("Números ja Digitados:");



                            for (int contador = 0; contador < contadorHistorico; contador++)
                            {
                                Console.WriteLine(historicoNumeros[contador]);
                                Console.WriteLine();
                            }




                            if (numeroDigitado == numeroSecreto)
                            {

                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("Parabéns, você acertou!");
                                Console.WriteLine("----------------------------------------------");
                                break;

                            }

                            else if (numeroDigitado > numeroSecreto)
                            {
                                historicoNumeros[contadorHistorico] = $"{numeroDigitado}";

                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("O número digitado foi maior que o número secreto!");
                                Console.WriteLine("----------------------------------------------");

                            }

                            else if (numeroDigitado < numeroSecreto)
                            {
                                historicoNumeros[contadorHistorico] = $"{numeroDigitado}";

                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("O número digitado foi menor que o número secreto!");
                                Console.WriteLine("----------------------------------------------");

                            }



                            contadorHistorico++;



                            Console.WriteLine("Precione Enter para continuar!");
                            Console.ReadLine();


                        }
                           Console.WriteLine("Deseja continuar (S/N)");
                             string continuar = Console.ReadLine();
    
                    if (continuar == "S")
                        continue;

                    else if (continuar == "s")
                        continue;

                    else
                        break;




                }
                
            }
            

        }

    }
}
