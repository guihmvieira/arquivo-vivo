namespace OlaArquivoVivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Projeto Arquivo Vivo ===");
            Console.WriteLine("Contratante: Prefeitura de Vale Verde");
            Console.WriteLine("Contrato nº 087/2026");
            Console.WriteLine();

            Console.Write("Qual é o seu nome? ");
            string? nome = Console.ReadLine();

            Console.WriteLine($"Bem-vindo à DocsPrime, {nome}!");
            Console.WriteLine($"Hoje é {DateTime.Now:dd/MM/yyyy}. Bom trabalho!");
        }
    }
}