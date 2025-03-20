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
            Console.Write("Digite um número para chutar: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Você digitou o número: " + numeroDigitado); 


            Console.ReadLine();
        }
    }
}
