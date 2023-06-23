CW(" === Alcool-Ou-Gasolina ==== \n");

Console.Write("Digite o preço do etanol (R$).....: ");
double preçoEtanol = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o preço da gasolina (R$)...: ");
double preçoGasolina = Convert.ToDouble(Console.ReadLine()!);


double razaoPrecos = Calcular(preçoEtanol, preçoGasolina);
double razaoPrecosPorcentagem = razaoPrecos * 100;
CW($"diferencia  entre os preços: {razaoPrecosPorcentagem:N1}%");

Console.ForegroundColor = ConsoleColor.DarkGreen;
bool abastecerComGasolina = Recomendacao(razaoPrecos);
CW($"Recomendação: Abastecer com {((abastecerComGasolina) ? "Gasolina" : "Etanol")}");
Console.ResetColor();
static double Calcular(double valorEtanol, double valorGasolina) {
return valorEtanol / valorGasolina;
}

static bool Recomendacao(double razaoPrecos) {
double percentualIdeal = 0.73;
return razaoPrecos > percentualIdeal;
}



//Criação de uma sub rotina onde CW = Console.Writeline 
void CW (string CW) 
{
    Console.WriteLine(CW);

};
