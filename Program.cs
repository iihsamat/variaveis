//Stefeson
Console.Clear();

﻿string nome, nome2, nome3;

Console.Write("Primeiro nome: ");
nome = Console.ReadLine()!;

Console.Write("Sobrenome: ");
nome2 = Console.ReadLine()!;

nome3 = nome;
nome = nome2;
nome2 = nome3;

Console.Clear();

Console.WriteLine("Trocando os nomes");
Console.WriteLine($"Nome = {nome}");
Console.WriteLine($"Sobrenome = {nome2}");