namespace ChallengeE_Csharp_ByteQtd
{
    public class ConversorBytes
    {

        // Sem SOLID

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

        //public int getQuantidade(string[] valores) => help(valores).Item1;
        //public int getQuantidadeForaDaFaixa(string[] valores) => help(valores).Item3;
        //public int getQuantidadeForaDaFaixa(string[] valores) => help(valores).Item2;

        //Com SOLID
        public int getQuantidade(string[] valores)
        {
            int qtd = 0;
            foreach (var item in valores)
            {
                try
                {
                    Convert.ToByte(item);
                    qtd++;
                }
                catch (Exception)
                { 

                }
            }
            return qtd;
        }

        public int getQuantidadeFormato(string[] valores)
        {
            int qtd = 0;
            foreach (var item in valores)
            {
                try
                {
                    Convert.ToByte(item);
                }
                catch (FormatException)
                {
                    qtd++;
                }
                catch (OverflowException)
                {
                    
                }
            }
            return qtd;
        }

        public int getQuantidadeForaDaFaixa(string[] valores)
        {
            int qtd = 0;
            foreach (var item in valores)
            {
                try
                {
                    Convert.ToByte(item);
                }
                catch (FormatException)
                {
                   
                }
                catch (OverflowException)
                {
                    qtd++;
                }
            }
            return qtd;
        }
    }
}
