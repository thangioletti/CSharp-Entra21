Console.Write("Digite o saldo da conta: ");
double saldoConta = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor que deseja sacar: ");
double valorSaque = Convert.ToDouble(Console.ReadLine());

if (valorSaque <= saldoConta)
{
    Console.WriteLine("Saque autorizado.");
}
else
{
    Console.WriteLine("Saldo insuficiente.");
}