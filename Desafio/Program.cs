using Desafio;

Console.Write("Valor final da compra: R$");
double valorFinal = double.Parse(Console.ReadLine());

Console.WriteLine(ExtensorNumerico.ConverterParaExtenso(valorFinal));