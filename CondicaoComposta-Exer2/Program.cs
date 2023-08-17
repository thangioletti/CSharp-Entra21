Console.Write("Digite um ano: ");
int ano = Convert.ToInt32(Console.ReadLine());

if (ano % 4 == 0)
{
    if (ano % 100 != 0)
    {
        Console.WriteLine("O ano é bissexto.");
    }
    else if (ano % 400 == 0)
    {
        Console.WriteLine("O ano é bissexto.");
    }
    else
    {
        Console.WriteLine("O ano não é bissexto.");
    }
}
else
{
    Console.WriteLine("O ano não é bissexto.");
}