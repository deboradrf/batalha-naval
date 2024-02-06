using System.Text;

namespace BatalhaNaval
{
    internal class Program
    {
        static char[,] CriarTabuleiroJogadorComputador(int linhas, int colunas)
        {
            char[,] tabuleiroJogadorComputador = new char[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    tabuleiroJogadorComputador[i, j] = 'A';
                }
            }

            return tabuleiroJogadorComputador;
        }
        static char[,] CriarTabuleiroOcultoJogadorComputador(int linhas, int colunas)
        {
            char[,] tabuleiroOcultoJogadorComputador = new char[linhas, colunas];

            for (int i = 0; i < tabuleiroOcultoJogadorComputador.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiroOcultoJogadorComputador.GetLength(1); j++)
                {
                    tabuleiroOcultoJogadorComputador[i, j] = 'A';
                }
            }

            return tabuleiroOcultoJogadorComputador;
        }

        static void MostrarTabuleiroOcultoJogadorComputador(char[,] tabuleiroOcultoJogadorComputador)
        {
            for (int i = 0; i < tabuleiroOcultoJogadorComputador.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiroOcultoJogadorComputador.GetLength(1); j++)
                {
                    Console.Write(tabuleiroOcultoJogadorComputador[i, j] + " " + " ");
                }
                Console.WriteLine(" " + " ");
            }
        }

        static void PosicionarEmbarcacoesJogadorComputador(char[,] tabuleiroJogadorComputador)
        {
            string linhaArquivo;
            string[] dados;

            try
            {
                StreamReader frotaComputador = new StreamReader("C:\\Users\\Débora\\Desktop\\Batalha Naval\\Batalha Naval\\frotaComputador.txt", Encoding.UTF8);
                linhaArquivo = frotaComputador.ReadLine();

                while (linhaArquivo != null)
                {
                    dados = linhaArquivo.Split(';');

                    if (dados[0] == "Submarino")
                    {
                        int linhaSubmarino = int.Parse(dados[2]);
                        int colunaSubmarino = int.Parse(dados[3]);

                        for (int linha = 0; linha < tabuleiroJogadorComputador.GetLength(0); linha++)
                        {
                            for (int coluna = 0; coluna < tabuleiroJogadorComputador.GetLength(1); coluna++)
                            {
                                tabuleiroJogadorComputador[linhaSubmarino, colunaSubmarino] = 'S';
                            }
                        }
                    }

                    if (dados[0] == "Hidroavião")
                    {
                        char posicaoHidroaviao = char.Parse(dados[1]);
                        int linhaHidroaviao = int.Parse(dados[2]);
                        int colunaHidroaviao = int.Parse(dados[3]);

                        for (int linha = 0; linha < tabuleiroJogadorComputador.GetLength(0); linha++)
                        {
                            for (int coluna = 0; coluna < tabuleiroJogadorComputador.GetLength(1); coluna++)
                            {
                                if (posicaoHidroaviao == 'v')
                                {
                                    tabuleiroJogadorComputador[linhaHidroaviao, colunaHidroaviao] = 'H';
                                    tabuleiroJogadorComputador[linhaHidroaviao + 1, colunaHidroaviao] = 'H';
                                }
                                if (posicaoHidroaviao == 'h')
                                {
                                    tabuleiroJogadorComputador[linhaHidroaviao, colunaHidroaviao] = 'H';
                                    tabuleiroJogadorComputador[linhaHidroaviao, colunaHidroaviao + 1] = 'H';
                                }
                            }
                        }
                    }

                    if (dados[0] == "Cruzador")
                    {
                        char posicaoCruzador = char.Parse(dados[1]);
                        int linhaCruzador = int.Parse(dados[2]);
                        int colunaCruzador = int.Parse(dados[3]);

                        for (int linha = 0; linha < tabuleiroJogadorComputador.GetLength(0); linha++)
                        {
                            for (int coluna = 0; coluna < tabuleiroJogadorComputador.GetLength(1); coluna++)
                            {
                                if (posicaoCruzador == 'v')
                                {
                                    tabuleiroJogadorComputador[linhaCruzador, colunaCruzador] = 'C';
                                    tabuleiroJogadorComputador[linhaCruzador + 1, colunaCruzador] = 'C';
                                    tabuleiroJogadorComputador[linhaCruzador + 2, colunaCruzador] = 'C';
                                }
                                if (posicaoCruzador == 'h')
                                {
                                    tabuleiroJogadorComputador[linhaCruzador, colunaCruzador] = 'C';
                                    tabuleiroJogadorComputador[linhaCruzador, colunaCruzador + 1] = 'C';
                                    tabuleiroJogadorComputador[linhaCruzador, colunaCruzador + 2] = 'C';
                                }
                            }
                        }
                    }

                    if (dados[0] == "Encouraçado")
                    {
                        char posicaoEncouracado = char.Parse(dados[1]);
                        int linhaEncouracado = int.Parse(dados[2]);
                        int colunaEncouracado = int.Parse(dados[3]);

                        for (int linha = 0; linha < tabuleiroJogadorComputador.GetLength(0); linha++)
                        {
                            for (int coluna = 0; coluna < tabuleiroJogadorComputador.GetLength(1); coluna++)
                            {
                                if (posicaoEncouracado == 'v')
                                {
                                    tabuleiroJogadorComputador[linhaEncouracado, colunaEncouracado] = 'E';
                                    tabuleiroJogadorComputador[linhaEncouracado + 1, colunaEncouracado] = 'E';
                                    tabuleiroJogadorComputador[linhaEncouracado + 2, colunaEncouracado] = 'E';
                                    tabuleiroJogadorComputador[linhaEncouracado + 3, colunaEncouracado] = 'E';
                                }
                                if (posicaoEncouracado == 'h')
                                {
                                    tabuleiroJogadorComputador[linhaEncouracado, colunaEncouracado] = 'E';
                                    tabuleiroJogadorComputador[linhaEncouracado, colunaEncouracado + 1] = 'E';
                                    tabuleiroJogadorComputador[linhaEncouracado, colunaEncouracado + 2] = 'E';
                                    tabuleiroJogadorComputador[linhaEncouracado, colunaEncouracado + 3] = 'E';
                                }
                            }
                        }
                    }

                    if (dados[0] == "Porta-aviões")
                    {
                        char posicaoPortaaviao = char.Parse(dados[1]);
                        int linhaPortaaviao = int.Parse(dados[2]);
                        int colunaPortaaviao = int.Parse(dados[3]);

                        for (int linha = 0; linha < tabuleiroJogadorComputador.GetLength(0); linha++)
                        {
                            for (int coluna = 0; coluna < tabuleiroJogadorComputador.GetLength(1); coluna++)
                            {
                                if (posicaoPortaaviao == 'v')
                                {
                                    tabuleiroJogadorComputador[linhaPortaaviao, colunaPortaaviao] = 'P';
                                    tabuleiroJogadorComputador[linhaPortaaviao + 1, colunaPortaaviao] = 'P';
                                    tabuleiroJogadorComputador[linhaPortaaviao + 2, colunaPortaaviao] = 'P';
                                    tabuleiroJogadorComputador[linhaPortaaviao + 3, colunaPortaaviao] = 'P';
                                    tabuleiroJogadorComputador[linhaPortaaviao + 4, colunaPortaaviao] = 'P';
                                }
                                if (posicaoPortaaviao == 'h')
                                {
                                    tabuleiroJogadorComputador[linhaPortaaviao, colunaPortaaviao] = 'P';
                                    tabuleiroJogadorComputador[linhaPortaaviao, colunaPortaaviao + 1] = 'P';
                                    tabuleiroJogadorComputador[linhaPortaaviao, colunaPortaaviao + 2] = 'P';
                                    tabuleiroJogadorComputador[linhaPortaaviao, colunaPortaaviao + 3] = 'P';
                                    tabuleiroJogadorComputador[linhaPortaaviao, colunaPortaaviao + 4] = 'P';
                                }
                            }
                        }
                    }
                    linhaArquivo = frotaComputador.ReadLine();
                }
                frotaComputador.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        static string CriarNickname(string nomeCompleto)
        {
            string[] partesNome = nomeCompleto.Split(' ');
            string iniciais = "";

            for (int i = 1; i < partesNome.Length; i++)
            {
                iniciais += partesNome[i][0];
            }

            string nickname = partesNome[0] + iniciais;

            return nickname;
        }

        static char[,] CriarTabuleiroJogadorHumano(int linhas, int colunas)
        {
            char[,] tabuleiroJogadorHumano = new char[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    tabuleiroJogadorHumano[i, j] = 'A';
                }
            }

            return tabuleiroJogadorHumano;
        }

        static char[,] CriarTabuleiroOcultoJogadorHumano(int linhas, int colunas)
        {
            char[,] tabuleiroOcultoJogadorHumano = new char[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    tabuleiroOcultoJogadorHumano[i, j] = 'A';
                }
            }

            return tabuleiroOcultoJogadorHumano;
        }

        static void MostrarTabuleiroOcultoJogadorHumano(char[,] tabuleiroOcultoJogadorHumano)
        {
            for (int i = 0; i < tabuleiroOcultoJogadorHumano.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiroOcultoJogadorHumano.GetLength(1); j++)
                {
                    Console.Write(tabuleiroOcultoJogadorHumano[i, j] + " " + " ");
                }
                Console.WriteLine(" " + " ");
            }
        }

        static void PosicionarEmbarcacoesJogadorHumano(char[,] tabuleiroJogadorHumano)
        {
            int quantSubmarino = 0;
            while (quantSubmarino < 4)
            {
                Console.WriteLine("Informe a posição para o " + (quantSubmarino + 1) + " submarino!");
                Console.WriteLine("Linha: ");
                int linhaSubmarino = int.Parse(Console.ReadLine());
                Console.WriteLine("Coluna: ");
                int colunaSubmarino = int.Parse(Console.ReadLine());

                if (linhaSubmarino >= 0 && linhaSubmarino <= 9 && colunaSubmarino >= 0 && colunaSubmarino <= 9)
                {
                    if (tabuleiroJogadorHumano[linhaSubmarino, colunaSubmarino] == 'A')
                    {
                        tabuleiroJogadorHumano[linhaSubmarino, colunaSubmarino] = 'S';

                        quantSubmarino++;
                    }
                    else
                    {
                        Console.WriteLine("ERRO: Posição ocupada! Informe uma posição vazia");
                    }
                }
                else
                {
                    Console.WriteLine("ERRO: Posição inválida! Informe uma posição dentro do tabuleiro");
                }
                Console.WriteLine();
            }

            int quantHidroaviao = 0;
            while (quantHidroaviao < 3)
            {
                Console.WriteLine("Informe a posição para o " + (quantHidroaviao + 1) + " hidroavião!");
                Console.WriteLine("Linha: ");
                int linhaHidroaviao = int.Parse(Console.ReadLine());
                Console.WriteLine("Coluna: ");
                int colunaHidroaviao = int.Parse(Console.ReadLine());

                Console.WriteLine("(v) Vertical ou (h) Horizontal ?");
                char posicaoHidroaviao = char.Parse(Console.ReadLine());

                if (linhaHidroaviao >= 0 && linhaHidroaviao <= 9 && colunaHidroaviao >= 0 && colunaHidroaviao <= 9)
                {
                    switch (posicaoHidroaviao)
                    {
                        case 'v':
                            if (linhaHidroaviao >= 0 && linhaHidroaviao + 1 <= 9 && colunaHidroaviao >= 0 && colunaHidroaviao <= 9)
                            {

                                if (tabuleiroJogadorHumano[linhaHidroaviao, colunaHidroaviao] == 'A' && tabuleiroJogadorHumano[linhaHidroaviao + 1, colunaHidroaviao] == 'A')
                                {
                                    tabuleiroJogadorHumano[linhaHidroaviao, colunaHidroaviao] = 'H';
                                    tabuleiroJogadorHumano[linhaHidroaviao + 1, colunaHidroaviao] = 'H';

                                    quantHidroaviao++;
                                }
                                else
                                {
                                    Console.WriteLine("ERRO: Posição ocupada! Informe uma posição vazia");
                                }
                            }
                            else
                            {
                                Console.WriteLine("ERRO: Embarcação não cabe no tabuleiro! Informe outra posição");
                            }
                            break;

                        case 'h':
                            if (linhaHidroaviao >= 0 && linhaHidroaviao <= 9 && colunaHidroaviao >= 0 && colunaHidroaviao + 1 <= 9)
                            {
                                if (tabuleiroJogadorHumano[linhaHidroaviao, colunaHidroaviao] == 'A' && tabuleiroJogadorHumano[linhaHidroaviao, colunaHidroaviao + 1] == 'A')
                                {
                                    tabuleiroJogadorHumano[linhaHidroaviao, colunaHidroaviao] = 'H';
                                    tabuleiroJogadorHumano[linhaHidroaviao, colunaHidroaviao + 1] = 'H';

                                    quantHidroaviao++;
                                }
                                else
                                {
                                    Console.WriteLine("ERRO: Posição ocupada! Informe uma posição vazia");
                                }
                            }
                            else
                            {
                                Console.WriteLine("ERRO: Embarcação não cabe no tabuleiro! Informe outra posição");
                            }
                            break;

                        default:
                            Console.WriteLine("ERRO: Posição inválida! Informe (v) Vertical ou (h) Horizontal");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ERRO: Posição inválida! Informe uma posição dentro do tabuleiro");
                }
                Console.WriteLine();
            }

            int quantCruzador = 0;
            while (quantCruzador < 2)
            {
                Console.WriteLine("Informe a posição para o " + (quantCruzador + 1) + " cruzador!");
                Console.WriteLine("Linha: ");
                int linhaCruzador = int.Parse(Console.ReadLine());
                Console.WriteLine("Coluna: ");
                int colunaCruzador = int.Parse(Console.ReadLine());

                Console.WriteLine("(v) Vertical ou (h) Horizontal ?");
                char posicaoCruzador = char.Parse(Console.ReadLine());

                if (linhaCruzador >= 0 && linhaCruzador <= 9 && colunaCruzador >= 0 && colunaCruzador <= 9)
                {
                    switch (posicaoCruzador)
                    {
                        case 'v':
                            if (linhaCruzador >= 0 && linhaCruzador + 2 <= 9 && colunaCruzador >= 0 && colunaCruzador <= 9)
                            {
                                if (tabuleiroJogadorHumano[linhaCruzador, colunaCruzador] == 'A' && tabuleiroJogadorHumano[linhaCruzador + 1, colunaCruzador] == 'A' && tabuleiroJogadorHumano[linhaCruzador + 2, colunaCruzador] == 'A')
                                {
                                    tabuleiroJogadorHumano[linhaCruzador, colunaCruzador] = 'C';
                                    tabuleiroJogadorHumano[linhaCruzador + 1, colunaCruzador] = 'C';
                                    tabuleiroJogadorHumano[linhaCruzador + 2, colunaCruzador] = 'C';

                                    quantCruzador++;
                                }
                                else
                                {
                                    Console.WriteLine("ERRO: Posição ocupada! Informe uma posição vazia");
                                }
                            }
                            else
                            {
                                Console.WriteLine("ERRO: Embarcação não cabe no tabuleiro! Informe outra posição");
                            }
                            break;

                        case 'h':
                            if (linhaCruzador >= 0 && linhaCruzador <= 9 && colunaCruzador >= 0 && colunaCruzador + 2 <= 9)
                            {

                                if (tabuleiroJogadorHumano[linhaCruzador, colunaCruzador] == 'A' && tabuleiroJogadorHumano[linhaCruzador, colunaCruzador + 1] == 'A' && tabuleiroJogadorHumano[linhaCruzador, colunaCruzador + 2] == 'A')
                                {
                                    tabuleiroJogadorHumano[linhaCruzador, colunaCruzador] = 'C';
                                    tabuleiroJogadorHumano[linhaCruzador, colunaCruzador + 1] = 'C';
                                    tabuleiroJogadorHumano[linhaCruzador, colunaCruzador + 2] = 'C';

                                    quantCruzador++;
                                }
                                else
                                {
                                    Console.WriteLine("ERRO: Posição ocupada! Informe uma posição vazia");
                                }
                            }
                            else
                            {
                                Console.WriteLine("ERRO: Embarcação não cabe no tabuleiro! Informe outra posição");
                            }
                            break;

                        default:
                            Console.WriteLine("ERRO: Posição inválida! Informe (v) Vertical ou (h) Horizontal");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ERRO: Posição inválida! Informe uma posição dentro do tabuleiro");
                }
                Console.WriteLine();
            }

            int quantEncouracado = 0;
            while (quantEncouracado < 1)
            {
                Console.WriteLine("Informe a posição para o encouraçado!");
                Console.WriteLine("Linha: ");
                int linhaEncouracado = int.Parse(Console.ReadLine());
                Console.WriteLine("Coluna: ");
                int colunaEncouracado = int.Parse(Console.ReadLine());

                Console.WriteLine("Vertical (v) ou Horizontal (h) ?");
                char posicaoEncouracado = char.Parse(Console.ReadLine());

                if (linhaEncouracado >= 0 && linhaEncouracado <= 9 && colunaEncouracado >= 0 && colunaEncouracado <= 9)
                {
                    switch (posicaoEncouracado)
                    {
                        case 'v':
                            if (linhaEncouracado >= 0 && linhaEncouracado + 3 <= 9 && colunaEncouracado >= 0 && colunaEncouracado <= 9)
                            {
                                if (tabuleiroJogadorHumano[linhaEncouracado, colunaEncouracado] == 'A' && tabuleiroJogadorHumano[linhaEncouracado + 1, colunaEncouracado] == 'A' && tabuleiroJogadorHumano[linhaEncouracado + 2, colunaEncouracado] == 'A' && tabuleiroJogadorHumano[linhaEncouracado + 3, colunaEncouracado] == 'A')
                                {
                                    tabuleiroJogadorHumano[linhaEncouracado, colunaEncouracado] = 'E';
                                    tabuleiroJogadorHumano[linhaEncouracado + 1, colunaEncouracado] = 'E';
                                    tabuleiroJogadorHumano[linhaEncouracado + 2, colunaEncouracado] = 'E';
                                    tabuleiroJogadorHumano[linhaEncouracado + 3, colunaEncouracado] = 'E';

                                    quantEncouracado++;
                                }
                                else
                                {
                                    Console.WriteLine("ERRO: Posição ocupada! Informe uma posição vazia");
                                }
                            }
                            else
                            {
                                Console.WriteLine("ERRO: Embarcação não cabe no tabuleiro! Informe outra posição");
                            }
                            break;

                        case 'h':
                            if (linhaEncouracado >= 0 && linhaEncouracado <= 9 && colunaEncouracado >= 0 && colunaEncouracado + 3 <= 9)
                            {
                                if (tabuleiroJogadorHumano[linhaEncouracado, colunaEncouracado] == 'A' && tabuleiroJogadorHumano[linhaEncouracado, colunaEncouracado + 1] == 'A' && tabuleiroJogadorHumano[linhaEncouracado, colunaEncouracado + 2] == 'A' && tabuleiroJogadorHumano[linhaEncouracado, colunaEncouracado + 3] == 'A')
                                {
                                    tabuleiroJogadorHumano[linhaEncouracado, colunaEncouracado] = 'E';
                                    tabuleiroJogadorHumano[linhaEncouracado, colunaEncouracado + 1] = 'E';
                                    tabuleiroJogadorHumano[linhaEncouracado, colunaEncouracado + 2] = 'E';
                                    tabuleiroJogadorHumano[linhaEncouracado, colunaEncouracado + 3] = 'E';

                                    quantEncouracado++;
                                }
                                else
                                {
                                    Console.WriteLine("ERRO: Posição ocupada! Informe uma posição vazia");
                                }
                            }
                            else
                            {
                                Console.WriteLine("ERRO: Embarcação não cabe no tabuleiro! Informe outra posição");
                            }
                            break;

                        default:
                            Console.WriteLine("ERRO: Posição inválida! Informe (v) Vertical ou (h) Horizontal");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ERRO: Posição inválida! Informe uma posição dentro do tabuleiro");
                }
                Console.WriteLine();
            }

            int quantPortaaviao = 0;
            while (quantPortaaviao < 1)
            {
                Console.WriteLine("Informe a posição para o porta-aviões!");
                Console.WriteLine("Linha: ");
                int linhaPortaaviao = int.Parse(Console.ReadLine());
                Console.WriteLine("Coluna: ");
                int colunaPortaaviao = int.Parse(Console.ReadLine());

                Console.WriteLine("Vertical (v) ou Horizontal (h) ?");
                char posicaoPortaaviao = char.Parse(Console.ReadLine());

                if (linhaPortaaviao >= 0 && linhaPortaaviao <= 9 && colunaPortaaviao >= 0 && colunaPortaaviao <= 9)
                {
                    switch (posicaoPortaaviao)
                    {
                        case 'v':
                            if (linhaPortaaviao >= 0 && linhaPortaaviao + 4 <= 9 && colunaPortaaviao >= 0 && colunaPortaaviao <= 9)
                            {
                                if (tabuleiroJogadorHumano[linhaPortaaviao, colunaPortaaviao] == 'A' && tabuleiroJogadorHumano[linhaPortaaviao + 1, colunaPortaaviao] == 'A' && tabuleiroJogadorHumano[linhaPortaaviao + 2, colunaPortaaviao] == 'A' && tabuleiroJogadorHumano[linhaPortaaviao + 3, colunaPortaaviao] == 'A' && tabuleiroJogadorHumano[linhaPortaaviao + 4, colunaPortaaviao] == 'A')
                                {
                                    tabuleiroJogadorHumano[linhaPortaaviao, colunaPortaaviao] = 'P';
                                    tabuleiroJogadorHumano[linhaPortaaviao + 1, colunaPortaaviao] = 'P';
                                    tabuleiroJogadorHumano[linhaPortaaviao + 2, colunaPortaaviao] = 'P';
                                    tabuleiroJogadorHumano[linhaPortaaviao + 3, colunaPortaaviao] = 'P';
                                    tabuleiroJogadorHumano[linhaPortaaviao + 4, colunaPortaaviao] = 'P';

                                    quantPortaaviao++;
                                }
                                else
                                {
                                    Console.WriteLine("ERRO: Posição ocupada! Informe uma posição vazia");
                                }
                            }
                            else
                            {
                                Console.WriteLine("ERRO: Embarcação não cabe no tabuleiro! Informe outra posição");
                            }
                            break;

                        case 'h':
                            if (linhaPortaaviao >= 0 && linhaPortaaviao <= 9 && colunaPortaaviao >= 0 && colunaPortaaviao + 4 <= 9)
                            {
                                if (tabuleiroJogadorHumano[linhaPortaaviao, colunaPortaaviao] == 'A' && tabuleiroJogadorHumano[linhaPortaaviao, colunaPortaaviao + 1] == 'A' && tabuleiroJogadorHumano[linhaPortaaviao, colunaPortaaviao + 2] == 'A' && tabuleiroJogadorHumano[linhaPortaaviao, colunaPortaaviao + 3] == 'A' && tabuleiroJogadorHumano[linhaPortaaviao, colunaPortaaviao + 4] == 'A')
                                {
                                    tabuleiroJogadorHumano[linhaPortaaviao, colunaPortaaviao] = 'P';
                                    tabuleiroJogadorHumano[linhaPortaaviao, colunaPortaaviao + 1] = 'P';
                                    tabuleiroJogadorHumano[linhaPortaaviao, colunaPortaaviao + 2] = 'P';
                                    tabuleiroJogadorHumano[linhaPortaaviao, colunaPortaaviao + 3] = 'P';
                                    tabuleiroJogadorHumano[linhaPortaaviao, colunaPortaaviao + 4] = 'P';

                                    quantPortaaviao++;
                                }
                                else
                                {
                                    Console.WriteLine("ERRO: Posição ocupada! Informe uma posição vazia");
                                }

                            }
                            else
                            {
                                Console.WriteLine("ERRO: Embarcação não cabe no tabuleiro! Informe outra posição");
                            }
                            break;

                        default:
                            Console.WriteLine("ERRO: Posição inválida! Informe (v) Vertical ou (h) Horizontal");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ERRO: Posição inválida! Informe uma posição dentro do tabuleiro");
                }
                Console.WriteLine();
            }
        }

        static void JogadaJogadorHumano(string nickname, char[,] tabuleiroJogadorComputador, char[,] tabuleiroOcultoJogadorComputador, ref int pontuacaoJogadorHumano)
        {
            bool continuarJogada = true;

            do
            {
                if (pontuacaoJogadorHumano == 25)
                {
                    continuarJogada = false;
                }
                else
                {
                    Console.WriteLine(nickname + ", " + "escolha uma posição para atirar!");
                    Console.WriteLine("Linha: ");
                    int linhaJogadaJogadorHumano = int.Parse(Console.ReadLine());
                    Console.WriteLine("Coluna: ");
                    int colunaJogadaJogadorHumano = int.Parse(Console.ReadLine());

                    if (linhaJogadaJogadorHumano >= 0 && linhaJogadaJogadorHumano <= 9 && colunaJogadaJogadorHumano >= 0 && colunaJogadaJogadorHumano <= 9)
                    {
                        if (tabuleiroOcultoJogadorComputador[linhaJogadaJogadorHumano, colunaJogadaJogadorHumano] != 'T')
                        {
                            if (tabuleiroJogadorComputador[linhaJogadaJogadorHumano, colunaJogadaJogadorHumano] != 'A')
                            {
                                tabuleiroOcultoJogadorComputador[linhaJogadaJogadorHumano, colunaJogadaJogadorHumano] = 'T';

                                Console.WriteLine();
                                Console.WriteLine("Acertou!");
                                Console.WriteLine();

                                pontuacaoJogadorHumano++;
                                continuarJogada = true;
                            }
                            else
                            {
                                tabuleiroOcultoJogadorComputador[linhaJogadaJogadorHumano, colunaJogadaJogadorHumano] = 'X';

                                Console.WriteLine();
                                Console.WriteLine("Errou!");
                                Console.WriteLine();

                                continuarJogada = false;
                            }
                            MostrarTabuleiroOcultoJogadorComputador(tabuleiroOcultoJogadorComputador);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("ERRO: Você já atirou nessa posição! Informe outra posição.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERRO: Posição inválida! Informe uma posição dentro do tabuleiro");
                    }
                }
            }
            while (continuarJogada == true);

            Console.WriteLine("Pontuação: " + pontuacaoJogadorHumano);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
        }

        static void EscreverJogadaJogadorHumano(char[,] tabuleiroOcultoJogadorComputador)
        {
            try
            {
                StreamWriter arqJogadas = new StreamWriter("C:\\Users\\Débora\\Desktop\\Batalha Naval\\Batalha Naval\\jogadas.txt", false, Encoding.UTF8);
                for (int i = 0; i < tabuleiroOcultoJogadorComputador.GetLength(0); i++)
                {
                    for (int j = 0; j < tabuleiroOcultoJogadorComputador.GetLength(1); j++)
                    {
                        if (tabuleiroOcultoJogadorComputador[i, j] == 'T')
                        {
                            arqJogadas.WriteLine($"Tiro: ({i},{j})");
                        }
                    }
                }
                arqJogadas.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        static void JogadaJogadorComputador(char[,] tabuleiroJogadorHumano, char[,] tabuleiroOcultoJogadorHumano, ref int pontuacaoJogadorComputador)
        {
            bool continuarJogada = true;
            Random r = new Random();

            do
            {
                if (pontuacaoJogadorComputador == 25)
                {
                    continuarJogada = false;
                }
                else
                {
                    Console.WriteLine("Computador, escolha uma posição para atirar!");
                    int linhaJogadaJogadorComputador = r.Next(10);
                    int colunaJogadaJogadorComputador = r.Next(10);

                    if (linhaJogadaJogadorComputador >= 0 && linhaJogadaJogadorComputador <= 9 && colunaJogadaJogadorComputador >= 0 && colunaJogadaJogadorComputador <= 9)
                    {
                        if (tabuleiroJogadorHumano[linhaJogadaJogadorComputador, colunaJogadaJogadorComputador] != 'T')
                        {
                            if (tabuleiroJogadorHumano[linhaJogadaJogadorComputador, colunaJogadaJogadorComputador] != 'A')
                            {
                                tabuleiroOcultoJogadorHumano[linhaJogadaJogadorComputador, colunaJogadaJogadorComputador] = 'T';

                                Console.WriteLine();
                                Console.WriteLine("Acertou!");
                                Console.WriteLine();

                                pontuacaoJogadorComputador++;
                                continuarJogada = true;
                            }
                            else
                            {
                                tabuleiroOcultoJogadorHumano[linhaJogadaJogadorComputador, colunaJogadaJogadorComputador] = 'X';

                                Console.WriteLine();
                                Console.WriteLine("Errou!");
                                Console.WriteLine();

                                continuarJogada = false;
                            }
                        }
                        MostrarTabuleiroOcultoJogadorHumano(tabuleiroOcultoJogadorHumano);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("ERRO: Posição inválida! Informe uma posição dentro do tabuleiro");
                    }
                }
            }
            while (continuarJogada == true);

            Console.WriteLine("Pontuação: " + pontuacaoJogadorComputador);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
        }

        static void EscreverJogadaJogadorComputador(char[,] tabuleiroOcultoJogadorHumano)
        {
            try
            {
                StreamWriter arqJogadas = new StreamWriter("C:\\Users\\Débora\\Desktop\\Batalha Naval\\Batalha Naval\\jogadas.txt", false, Encoding.UTF8);
                for (int i = 0; i < tabuleiroOcultoJogadorHumano.GetLength(0); i++)
                {
                    for (int j = 0; j < tabuleiroOcultoJogadorHumano.GetLength(1); j++)
                    {
                        if (tabuleiroOcultoJogadorHumano[i, j] == 'T')
                        {
                            arqJogadas.WriteLine($"Tiro: ({i},{j})");
                        }
                    }
                }
                arqJogadas.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        static void Main(string[] args)
        {
            char[,] tabuleiroJogadorComputador = CriarTabuleiroJogadorComputador(10, 10);
            char[,] tabuleiroOcultoJogadorComputador = CriarTabuleiroOcultoJogadorComputador(10, 10);

            char[,] tabuleiroJogadorHumano = CriarTabuleiroJogadorHumano(10, 10);
            char[,] tabuleiroOcultoJogadorHumano = CriarTabuleiroOcultoJogadorHumano(10, 10);

            PosicionarEmbarcacoesJogadorComputador(tabuleiroJogadorComputador);

            Console.WriteLine("Informe seu nome completo: ");
            string nomeCompleto = Console.ReadLine();
            nomeCompleto = nomeCompleto.ToLower();

            string nickname = CriarNickname(nomeCompleto);

            Console.WriteLine();
            Console.WriteLine("Embarcações que devem ser colocadas no tabuleiro: ");
            Console.WriteLine("4 submarinos ocupando 1 casa");
            Console.WriteLine("3 hidroavião ocupando 2 casas");
            Console.WriteLine("2 cruzador ocupando 3 casas");
            Console.WriteLine("1 encouraçado ocupando 4 casas");
            Console.WriteLine("1 porta-aviões ocupando 5 casas");
            Console.WriteLine();

            PosicionarEmbarcacoesJogadorHumano(tabuleiroJogadorHumano);

            Console.WriteLine("Vamos começar o jogo...");
            Console.WriteLine();

            int pontuacaoJogadorHumano = 0;
            int pontuacaoJogadorComputador = 0;
            bool jogoEmAndamento = true;

            while (jogoEmAndamento == true)
            {
                Console.WriteLine("Tabuleiro do Jogador Computador: ");
                MostrarTabuleiroOcultoJogadorComputador(tabuleiroOcultoJogadorComputador);
                Console.WriteLine();

                JogadaJogadorHumano(nickname, tabuleiroJogadorComputador, tabuleiroOcultoJogadorComputador, ref pontuacaoJogadorHumano);
                if (pontuacaoJogadorHumano == 25)
                {
                    Console.WriteLine(nickname + " VENCEU!");
                    EscreverJogadaJogadorHumano(tabuleiroOcultoJogadorComputador);
                    jogoEmAndamento = false;
                }

                if (jogoEmAndamento == true)
                {
                    Console.WriteLine("Tabuleiro de " + nickname + ": ");
                    MostrarTabuleiroOcultoJogadorHumano(tabuleiroOcultoJogadorHumano);
                    Console.WriteLine();

                    JogadaJogadorComputador(tabuleiroJogadorHumano, tabuleiroOcultoJogadorHumano, ref pontuacaoJogadorComputador);
                    if (pontuacaoJogadorComputador == 25)
                    {
                        Console.WriteLine("JogadorComputador VENCEU!");
                        EscreverJogadaJogadorComputador(tabuleiroOcultoJogadorHumano);
                        jogoEmAndamento = false;
                    }
                }
            }
        }
    }
}

