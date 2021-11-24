namespace Tabuleiro
{
    internal class Posicao
    {
        public int linha { get; set; }
        public int coluna {  get; set; }    

        public Posicao(int linha, int Coluna)
        {
            this.linha = linha;
            this.coluna = Coluna;   
        }

        public override string ToString()
        {
            return linha
            + ", "
            + coluna;
        }
    }
}
