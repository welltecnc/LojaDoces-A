
namespace LojaDoceA
{
    class Doce
    {
        //PROPRIEDADES(ATRIBUTOS)
        public string Confeiteiro { get; set; }
        public double CapacidadeKg { get; set; }
        public double PorcentagemPronta { get; set; }
        public double TaxaProducaoPorHora { get; set; }

        //MÉTODOS ( AÇÕES )

        public double CalcularkgFaltantes()
        {
            double porcentagemFaltante = (100.0 - PorcentagemPronta) / 100.0;
            return CapacidadeKg * porcentagemFaltante;
        }
        


        public double CalcularTempoRestanteHoras()
        {
            return CalcularkgFaltantes() / TaxaProducaoPorHora;
        }



        public double CalcularValorFaltante()
        {
            const double PRECO_POR_KG = 45.50;
            return CalcularkgFaltantes() * PRECO_POR_KG;
        }
    }
}
