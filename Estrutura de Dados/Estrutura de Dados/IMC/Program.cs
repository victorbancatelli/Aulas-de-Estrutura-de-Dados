Double calcIMC(Double peso, Double altura)
{
    Double IMC = peso / (altura * altura);
    IMC=Math.Round(IMC, 4);
    return IMC;
}

string genero;
Double peso, altura;

Console.WriteLine("Entre com seu gênero (F/M):");
genero = Console.ReadLine();
Console.WriteLine("Entre com seu peso (Kg):");
peso=Double.Parse(Console.ReadLine()); 
Console.WriteLine("Entre com sua Altura (Metros):");
altura=Double.Parse(Console.ReadLine()); 

Double meuIMC=calcIMC(peso, altura);
Console.WriteLine("IMC=" + meuIMC);
Console.WriteLine(classificaIMC(genero, altura, peso));

string classificaIMC(String gen, Double peso, Double altura)
{
    string classifica = "";
    Double imc=calcIMC(peso, altura);
    if (imc > 39.9) classifica = "OBSIDADE MORBIDA!!";
    else classifica = "ABAIXO DO NORMAL";
    return classifica;
}
