using System.Globalization;

namespace FichaDeRequerimento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

            //Dados
            string numeroProtocolo = "2026/000123";
            DateTime dataProtocolo = new DateTime(2026, 10, 5);
            string requerente = "João da Silva";
            string cpf = "12345678909";
            string assunto = "Solicitação de certidão de tempo de serviço";
            string setorDestino = "Setor Administrativo";
            int quantidadePaginas = 3;
            bool urgente = true;

            Console.WriteLine("=== FICHA DE REQUERIMENTO===");
            Console.WriteLine($"Protocolo: {numeroProtocolo}");
            Console.WriteLine($"Data: {dataProtocolo:dd/MM/yyyy}");
            Console.WriteLine($"Requerente: {requerente}");
            Console.WriteLine($"CPF: {cpf}");
            Console.WriteLine($"Assunto: {assunto}");
            Console.WriteLine($"Setor de Destino: {setorDestino}");
            Console.WriteLine($"Quantidade de Páginas: {quantidadePaginas}");
            Console.WriteLine($"Urgente? {(urgente ? "Sim" : "Não")}");
            

            
        }
    }
}
