using System;

Double NI, PI, PO, NF;

//inicio_algoritmo
Console.WriteLine("Insira a sua nota da NI: ");
NI = float.Parse(Console.ReadLine());
Console.WriteLine("Insira a sua nota da PI: ");
PI = float.Parse(Console.ReadLine());
Console.WriteLine("Insira a sua nota da PO: ");
PO = float.Parse(Console.ReadLine());

NF = NI * 0.2 + PI * 0.3 + PO * 0.5;

//fim_algoritmo
Console.WriteLine("A sua média esse semestre foi igual a " + NF);