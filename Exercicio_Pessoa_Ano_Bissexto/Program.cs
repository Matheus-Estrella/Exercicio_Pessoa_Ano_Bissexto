namespace Exercicio_Pessoa_Ano_Bissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Pessoa pessoa = new Pessoa();
            TimeSpan dif = now - pessoa.Get_Nascimento();
            float anos_bissextos = (float)((dif.Days/365.25)/4);
            Console.WriteLine($"\nA pessoa {pessoa.Get_Nome()} tem {anos_bissextos:0.0} anos bissextos de vida");
        }
    }
}
