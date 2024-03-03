

namespace XadrezTabuleiro
{
    class Tabuleiro
    {
        public int Colunas { get; set; }
        public int Linhas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int colunas, int linhas)
        {
            Colunas = colunas;
            Linhas = linhas;
            Pecas = new Peca[colunas, linhas];
        }

        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
    }
}
