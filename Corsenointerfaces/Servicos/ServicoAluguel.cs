using System;
using Corsenointerfaces.Entities;

namespace Corsenointerfaces.Servicos
{
    class ServicoAluguel
    {
        public double PrecoPorHora{ get; private set; }
        public double PrecoPorDia { get; private set; }

        private BrasilTaxaServico _brasilTaxaServico = new BrasilTaxaServico();
        public ServicoAluguel(double precoPorHora, double precoPorDia)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
        }
        public void ProcessandoFatura(AluguelCarro aluguelCarro)
        {
            TimeSpan duracao = aluguelCarro.Devolucao.Subtract(aluguelCarro.Entrada);

            double basePagamento = 0.0; //Calculo do pagamento Basico
            if(duracao.TotalHours <= 12.0)
            {
                basePagamento = PrecoPorHora * Math.Ceiling(duracao.TotalHours); //Math.Celling arredonta pra cima 
            }
            else
            {
                basePagamento = PrecoPorDia * Math.Ceiling(duracao.TotalDays); 
            }
            double taxa = _brasilTaxaServico.Taxa(basePagamento);

            aluguelCarro.Fatura = new Fatura(basePagamento, taxa);
        }
    }
}
