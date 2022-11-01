using ChallengeE_Csharp_ByteQtd;

var aa = new ConversorBytes();

string[] a1 = new string[] { "10", "300", "bbb", "20", "30", "--", "/", "50", "1000" };
string[] a2 = new string[] { "10", "/50", "11", "20", "1000", "13", "[]" };
string[] a3 = new string[] { "254", "200", "1" };
string[] a4 = new string[] { "///", "$%", "#@#" };
string[] a5 = new string[] { "255" };

Console.WriteLine(aa.getQuantidade(a1));
Console.WriteLine(aa.getQuantidade(a2));
Console.WriteLine(aa.getQuantidade(a3));
Console.WriteLine(aa.getQuantidade(a4));
Console.WriteLine(aa.getQuantidade(a5));

Console.WriteLine("-----------------------------------------------------------------------------------------");

Console.WriteLine(aa.getQuantidadeFormato(a1));
Console.WriteLine(aa.getQuantidadeFormato(a2));
Console.WriteLine(aa.getQuantidadeFormato(a3));
Console.WriteLine(aa.getQuantidadeFormato(a4));
Console.WriteLine(aa.getQuantidadeFormato(a5));

Console.WriteLine("-----------------------------------------------------------------------------------------");

Console.WriteLine(aa.getQuantidadeForaDaFaixa(a1));
Console.WriteLine(aa.getQuantidadeForaDaFaixa(a2));
Console.WriteLine(aa.getQuantidadeForaDaFaixa(a3));
Console.WriteLine(aa.getQuantidadeForaDaFaixa(a4));
Console.WriteLine(aa.getQuantidadeForaDaFaixa(a5));
