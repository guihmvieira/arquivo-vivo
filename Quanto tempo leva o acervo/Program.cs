using System.Globalization;

namespace M01.Logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

            // Dados do mês
            int totalPaginas = 400000;
            int paginasPorMes = 42000;

            // Cálculos
            int mesesCompletos = totalPaginas / paginasPorMes;
            int paginasQueSobram = totalPaginas % paginasPorMes;

            // Relatório
            Console.WriteLine($"Total de Páginas: {totalPaginas:N0}");
            Console.WriteLine($"Produção Mensal: {paginasPorMes:N0}");
            Console.WriteLine($"Meses Completos: {mesesCompletos}");
            Console.WriteLine($"Páginas que sobram para o mês seguinte: {paginasQueSobram}");

            long cpfComoNumero = 00001234567890;
            Console.WriteLine(cpfComoNumero);
        }
    }
}