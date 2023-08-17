
Console.Write("Digite o valor total da compra: ");
double valorTotal = Convert.ToInt32(Console.ReadLine());

if (valorTotal >= 100)
{
    Console.WriteLine($"Valor com desconto: R${valorTotal * 0.9}");
}
else
{
    Console.WriteLine($"Valor sem desconto: R${valorTotal}");
}