namespace Desafio
{
    public static class ExtensorNumerico
    {
        private static readonly string[] unidades = {"", "UM", "DOIS", "TRÊS", "QUATRO", "CINCO", "SEIS", "SETE", "OITO", "NOVE", "DEZ",
        "ONZE", "DOZE", "TREZE", "QUATORZE", "QUINZE", "DEZESSEIS", "DEZESSETE", "DEZOITO", "DEZENOVE"};
        private static readonly string[] dezenas = { "", "DEZ", "VINTE", "TRINTA", "QUARENTA", "CINQUENTA", "SESSENTA", "SETENTA", "OITENTA", "NOVENTA" };
        private static readonly string[] centenas = { "", "CENTO", "DUZENTOS", "TREZENTOS", "QUATROCENTOS", "QUINHENTOS", "SEISCENTOS", "SETECENTOS", "OITOCENTOS", "NOVECENTOS" };

        public static string ConverterParaExtenso(double valor)
        {
            int reais = (int)Math.Floor(valor);
            int centavos = (int)Math.Round((valor - reais) * 100);
            string extensoReais = string.Empty, extensoCentavos = string.Empty;

            if (reais == 0)
            {
                extensoReais = "ZERO";
            }
            else if (reais < 0 || reais > 999999999)
            {
                extensoReais = "VALOR INVÁLIDO";
            }
            else if (reais == 1)
            {
                extensoReais = "UM REAL";
            }
            else if (reais == 100)
            {
                extensoReais = "CEM REAIS";
            }
            else
            {
                extensoReais = ConverterValor(reais) + " REAIS";
            }

            if (centavos == 0)
            {
                extensoCentavos = " E ZERO CENTAVOS";
            }
            else if (centavos == 1)
            {
                extensoCentavos = "E UM CENTAVO";
            }
            else
            {
                extensoCentavos = " E " + ConverterValor(centavos) + " CENTAVOS";
            }

            return extensoReais + extensoCentavos;
        }

        private static string ConverterValor(int valor)
        {
            if (valor < 20)
            {
                return unidades[valor];
            }
            else if (valor < 100)
            {
                return dezenas[valor / 10] + ((valor % 10 != 0) ? " E " + unidades[valor % 10] : "");
            }
            else if (valor < 1000)
            {
                return centenas[valor / 100] + ((valor % 100 != 0) ? " E " + ConverterValor(valor % 100) : "");
            }
            else if (valor < 1000000)
            {
                return ConverterValor(valor / 1000) + " MIL " + ((valor % 1000 != 0) ? ConverterValor(valor % 1000) : "");
            }
            else if (valor < 1000000000)
            {
                return ConverterValor(valor / 1000000) + " MILHÕES " + ((valor % 1000000 != 0) ? ConverterValor(valor % 1000000) : "");
            }
            else
            {
                return "VALOR FORA DA FAIXA";
            }
        }
    }
}