namespace JogoDosDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Cabeçalho
                Console.WriteLine("================================");
                Console.WriteLine("         Jogo dos dados         ");
                Console.WriteLine("================================");

                Console.Write("Pressione ENTER para jogar os dados...");
                Console.ReadLine();
                
                int somadoUs = 0;
                int somadoPc = 0;

                //Gerar números
                Random numeroAleatorio = new Random();

                int numeroAleatorioPc = numeroAleatorio.Next(1, 7);
                int numeroAleatorioUs = numeroAleatorio.Next(1, 7);

                Console.WriteLine($"{numeroAleatorioPc}");

                string mensagemFinal = "";

                while (numeroAleatorioPc <= 25 && numeroAleatorioUs <= 25)
                {
                    Console.Clear();
                    Console.WriteLine($"o Número que a MÁQUINA tirou: {numeroAleatorioPc}");
                    Console.WriteLine($"o Número que o USUÁRIO tirou: {numeroAleatorioUs}");

                    somadoUs += numeroAleatorio.Next(1, 7);
                    somadoPc += numeroAleatorio.Next(1, 7);

                    Console.WriteLine($"A soma da MÁQUINA está em: {somadoPc}");
                    Console.WriteLine($"A soma do USUÁRIO está em: {somadoUs}");

                    Console.ReadLine();

                    if (numeroAleatorioPc >= 25)
                    {
                        mensagemFinal = "Você perdeu mais sorte na próxima.";
                        break;
                    }
                    else if (numeroAleatorioUs >= 25)
                    {   
                        mensagemFinal = "PARABÉNS VOCÊ GANHOU CARA";
                        break;
                    }
                   
                }
                Console.WriteLine($"{mensagemFinal}");
                Console.Write("Deseja tentar novamente ? (S/N): ");

                string opcaoContinuar = Console.ReadLine().ToUpper().Trim();

                if (opcaoContinuar != "S")
                {
                    break;
                }

            }


        }
    }
}
