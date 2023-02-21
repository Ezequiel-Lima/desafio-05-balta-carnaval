using Desafio;
using System.Runtime.CompilerServices;

Console.WriteLine("Valor final da compra: R$");
double valorFinal = double.Parse(Console.ReadLine());

Console.WriteLine(ExtensorNumerico.ConverterParaExtenso(valorFinal));