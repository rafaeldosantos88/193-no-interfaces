using System;
using System.Globalization;
using Corsenointerfaces.Entities;
using Corsenointerfaces.Servicos;

namespace Corsenointerfaces
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre com os Dados do Aluguel");
            Console.Write("Modelo Carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Entre com data de Entrada do Carro: (dd/MM/yyyy HH:mm): ");
            DateTime entrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data de devolução Carro (dd/MM/yyyy HH:mm): ");
            DateTime devolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o preço por Hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o preço por Dia: ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AluguelCarro aluguelCarro = new AluguelCarro(entrada, devolucao, new Veiculo(modelo));

            ServicoAluguel servicoAluguel = new ServicoAluguel(hora, dia);

            servicoAluguel.ProcessandoFatura(aluguelCarro);

            Console.WriteLine("Fatura");
            Console.WriteLine(aluguelCarro.Fatura);
        }
    }
}
