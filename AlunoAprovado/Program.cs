﻿Console.Write("Digite a nota do aluno: ");
double nota = Convert.ToDouble(Console.ReadLine());

if (nota >= 60)
{
    Console.WriteLine("Aluno aprovado!");
}

if (nota < 60)
{
    Console.WriteLine("Aluno reprovado.");
}
