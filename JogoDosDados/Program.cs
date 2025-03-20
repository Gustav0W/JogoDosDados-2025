using System.Text.Json.Serialization;

namespace JogoDosDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaChegada = 30;

            while (true)
            {
                int posicaoJogador = 0;
                int posicaoMaquina = 0;

                bool jogoEmAndamento = true;

                while (jogoEmAndamento)
                { 
                    Console.Clear();
                    Console.WriteLine("================================");
                    Console.WriteLine("         Jogo dos dados         ");
                    Console.WriteLine("================================");
                    Console.WriteLine("        Rodada do Usuário       ");
                    Console.WriteLine("================================");
                    Console.Write("Pressione ENTER para jogar os dados...");
                    Console.ReadLine();

                    int resultadoJogador = SortearDado();

                    Console.WriteLine("================================");
                    Console.WriteLine($"O valor sorteado foi: {resultadoJogador}!");
                    Console.WriteLine("================================");

                    posicaoJogador += resultadoJogador;

                    Console.WriteLine($"Você está na posição: {posicaoJogador} de {limiteLinhaChegada}!");

                    if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15 || posicaoJogador == 25  )
                    {
                        Console.WriteLine("==================================");
                        Console.WriteLine("EVENTO ESPECIAL: Avanço de 3 casas extras");

                        posicaoJogador += 3;

                        Console.WriteLine($"Você avançou para a posição {posicaoJogador}");
                    }
                    else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");

                        posicaoJogador -= 2;

                        Console.WriteLine($"Você recuou para a posição: {posicaoJogador}!");
                        Console.WriteLine("----------------------------------");
                    }

                    if (posicaoJogador >= limiteLinhaChegada)
                    {
                        Console.WriteLine("Alcançaste a linha de chegada marujo parabéns!");

                        jogoEmAndamento = false;
                        continue;
                    }

                    Console.WriteLine("\n\n\n\n================================");
                    Console.WriteLine("        Rodada da Máquina       ");
                    Console.WriteLine("================================");
                    Console.Write("Pressione ENTER para ver a rodada dela...");
                    Console.ReadLine();

                    int resultadoComputador = SortearDado();

                    Console.WriteLine("====================================");
                    Console.WriteLine($"O valor sorteado foi: {resultadoComputador}");
                    Console.WriteLine("====================================");

                    posicaoMaquina += resultadoComputador;

                    Console.WriteLine($"O computador está na posição: {posicaoMaquina} de {limiteLinhaChegada}!");

                    if (posicaoMaquina == 5 || posicaoMaquina == 10 || posicaoMaquina == 15 || posicaoMaquina == 25)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");

                        posicaoMaquina += 3;

                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"O computador avançou para a posição: {posicaoMaquina}!");
                        Console.WriteLine("----------------------------------");

                    }
                    else if (posicaoMaquina == 7 || posicaoMaquina == 13 || posicaoMaquina == 20)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");

                        posicaoMaquina -= 2;

                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"O computador recuou para a posição: {posicaoMaquina}!");
                        Console.WriteLine("----------------------------------");
                    }

                    if (posicaoMaquina >= limiteLinhaChegada)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Que pena! O computador alcançou a linha de chegada, tente novamente!");
                        Console.WriteLine("----------------------------------");

                        jogoEmAndamento = false;
                        continue;
                    }

                    Console.ReadLine();

                }
                Console.Write("Deseja tentar novamente ? (S/N): ");

                string opcaoContinuar = Console.ReadLine().ToUpper().Trim();

                if (opcaoContinuar != "S")
                {
                    break;
                }

            }

            //Cabeçalho
            // Console.WriteLine($"{mensagemFinal}");
        }

        static int SortearDado()
        {
            Random numeroAleatorio = new Random();

            int resultado = numeroAleatorio.Next(1, 7); 

            return resultado;
        }

    }
}


                        // Console.Clear();
                        // Console.WriteLine($"o Número que a MÁQUINA tirou: {numeroAleatorioPc}");
                        // Console.WriteLine($"o Número que o USUÁRIO tirou: {numeroAleatorioUs}");
                        // 
                        // posicaoJogador += numeroAleatorio.Next(1, 7);
                        // posicaoMaquina += numeroAleatorio.Next(1, 7);
                        // 
                        // Console.WriteLine($"A soma da MÁQUINA está em: {posicaoMaquina}");
                        // Console.WriteLine($"A soma do USUÁRIO está em: {posicaoJogador}");
                        // 
                        // Console.ReadLine();