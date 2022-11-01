namespace ChallengeE_Csharp_ByteQtd
{
    public class ConversorBytes
    {
        public (int, int, int) help(string[] valores, int qtdDentroFaixa = 0, int qtdForaFaixa = 0, int qtdIncompativeis = 0)
        {
            foreach (var item in valores)
            {
                try
                {
                    int itemInt = Convert.ToInt32(item);
                    if (itemInt >= 0 && itemInt <= 255) { qtdDentroFaixa++; } else { qtdForaFaixa++; }
                }
                catch (Exception) { qtdIncompativeis++; }
            }
            return (qtdDentroFaixa, qtdForaFaixa, qtdIncompativeis);
        }
        public int getQuantidade(string[] valores) => help(valores).Item1;

        public int getQuantidadeFormato(string[] valores) => help(valores).Item3;

        public int getQuantidadeForaDaFaixa(string[] valores) => help(valores).Item2;
    }
}
