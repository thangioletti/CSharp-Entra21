Console.Write("Digite o primeiro número: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int maior = num1;

if (num2 > maior)
{
    maior = num2;
}

if (num3 > maior)
{
    maior = num3;
}

Console.WriteLine("O maior número é: " + maior);