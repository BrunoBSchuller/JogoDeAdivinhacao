namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        // V1 : ESTRUTURA BASICA E ENTRADA DO USUARIO
        static void Main(string[] args)
        
        
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Jogo da Adivinhação");
            Console.WriteLine("----------------------------------------------");


            //Lógica do jogo
            Random geradorDeNumeros = new Random();
             
            int numeroSecreto = geradorDeNumeros.Next(1, 21);

            Console.Write("Digite um número (de 1 á 20) para chutar: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Você digitou o número: " + numeroDigitado); 

            if (numeroDigitado == numeroSecreto)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Parabéns, você acertou!");
                Console.WriteLine("----------------------------------------------");
            }                
            else if (numeroDigitado > numeroSecreto)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("O número digitado foi maior que o número secreto!");
                Console.WriteLine("----------------------------------------------");
            }
            else
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("O número digitado foi menor que o número secreto!");
                Console.WriteLine("----------------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
