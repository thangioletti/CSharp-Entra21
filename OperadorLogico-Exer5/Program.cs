Console.Write("Digite sua identificação: ");
string identificacao = Console.ReadLine();

Console.Write("Digite a hora de entrada (formato HH:mm): ");
int horaEntrada = Convert.ToInt32(Console.ReadLine());

if (identificacao == "12345" && horaEntrada >= 9 && horaEntrada <= 18)
{
    Console.WriteLine("Acesso autorizado.");
}
else
{
    Console.WriteLine("Acesso negado.");
}
        