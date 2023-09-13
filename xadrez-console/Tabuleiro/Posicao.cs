
namespace tabuleiro
{
    internal class Posicao
    {

        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int colunas)
        {
            this.linha = linha;
            this.coluna = colunas;
        }

        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha + ", " + coluna;
        }
    }
}
