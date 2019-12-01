using System.Globalization;


namespace Corsenointerfaces.Entities
{
    class Fatura
    {
        public double BasePagamento { get; set; }
        public double Taxa { get; set; }

        public Fatura(double basePagamento, double taxa)
        {
            BasePagamento = basePagamento;
            Taxa = taxa;
        }
        public double TotalPagamento                 //Propriedade de calculada
        {
            get { return BasePagamento + Taxa; }
        }

        public override string ToString()
        {
            return "Pagamento básico: "
                + BasePagamento.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal Pagamento: "
                + TotalPagamento.ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}
