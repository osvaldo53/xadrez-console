

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

        public void ColocarPeca(Peca p, Posicao pos)
        {
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
    }
}
