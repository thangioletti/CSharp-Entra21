Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade <= 12)
{
    Console.WriteLine("Bem-vindo, " + nome + "!");
}
else if (idade <= 19)
{
    Console.WriteLine("Olá, " + nome + "!");
}
else
{
    Console.WriteLine("Olá, Sr./Sra. " + nome + "!");
}