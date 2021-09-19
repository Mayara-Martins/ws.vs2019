using System;
using System.Globalization;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0} tem o valor de {1} reais", produto1, preco1);
            Console.WriteLine("{0} tem o valor de {1:F2} reis  ", produto2, preco2);
            Console.WriteLine();
            Console.Write("Registro: " );
            Console.WriteLine("{0} anos de idade, codigo {1} e o genero: {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: {0}", medida);
            Console.WriteLine("Arredondado (Tres casa decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
