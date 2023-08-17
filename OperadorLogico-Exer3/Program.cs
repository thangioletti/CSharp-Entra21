Console.Write("Digite o primeiro número: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 || num1 == num3 || num2 == num3)
{
    Console.WriteLine("Pelo menos dois números são iguais.");
}
else
{
    Console.WriteLine("Nenhum dos números é igual aos outros.");
}