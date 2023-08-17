Console.Write("Digite o peso (kg): ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a altura (m): ");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);

if (imc < 18.5)
{
    Console.WriteLine("Abaixo do peso");
}
else if (imc < 25)
{
    Console.WriteLine("Peso normal");
}
else if (imc < 30)
{
    Console.WriteLine("Sobrepeso");
}
else
{
    Console.WriteLine("Obeso");
}
