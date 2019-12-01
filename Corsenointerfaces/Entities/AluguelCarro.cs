using System;

namespace Corsenointerfaces.Entities
{
    class AluguelCarro
    {
        public DateTime Entrada  { get; set; } //Data de devolução do Carro
        public DateTime Devolucao { get; set; }
        public Veiculo Veiculo { get; set; }  //AQUI FIZ ASSOCIAÇÃO
        public Fatura Fatura { get; set; }   //OUTRA ASSOCIAÇÃO

        public AluguelCarro(DateTime entrada, DateTime devolucao, Veiculo veiculo)
        {
            Entrada = entrada;
            Devolucao = devolucao;
            Veiculo = veiculo;
            Fatura = null;
        }
    }

}
