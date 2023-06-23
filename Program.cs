
Console.WriteLine(" === Alcool-Ou-Gasolina ==== \n");

Console.Write("Digite o preço do etanol (R$).....: ");
double valorEtanol = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o preço da gasolina (R$)...: ");
double valorGasolina = Convert.ToDouble(Console.ReadLine()!);


double razaoPrecos = CalcularRazaoPrecos(valorEtanol, valorGasolina);
double razaoPrecosPorcentagem = razaoPrecos * 100;
    Console.WriteLine($"diferencia  entre os preços: {razaoPrecosPorcentagem:N1}%");

 Console.ForegroundColor = ConsoleColor.DarkGreen;
bool abastecerComGasolina = VerificarRecomendacao(razaoPrecos);
    Console.WriteLine($"Recomendação: Abastecer com {((abastecerComGasolina) ? "Gasolina" : "Etanol")}");
Console.ResetColor();
static double CalcularRazaoPrecos(double valorEtanol, double valorGasolina) {
return valorEtanol / valorGasolina;
}

static bool VerificarRecomendacao(double razaoPrecos) {
double percentualIdeal = 0.73;
return razaoPrecos > percentualIdeal;
}


