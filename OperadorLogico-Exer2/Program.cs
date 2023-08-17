Console.Write("Deseja um café? (sim/não): ");
string respostaCafe = Console.ReadLine().ToLower();

if (respostaCafe.Equals("sim"))
{
    Console.Write("Deseja açúcar? (sim/não): ");
    string respostaAcucar = Console.ReadLine().ToLower();

    if (respostaAcucar.Equals("sim"))
    {
        Console.WriteLine("Aqui está o seu café com açúcar.");
    }
    else
    {
        Console.WriteLine("Aqui está o seu café preto.");
    }
}
else
{
    Console.WriteLine("Ok, sem problema. Até a próxima!");
}