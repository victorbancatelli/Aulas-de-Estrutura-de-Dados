//Double Dobrar(Double x)
//{
//    Double result = 2 * x; 
//    return result;
//}

//Double mediaFecap(Double N1, Double PO, Double PI)
//{
//    Double result = N1 * 0.20 + PI * 0.30 * PO * 0.50;
//    return result;
//}

//Double media = mediaFecap(6.0, 7.0, 9.0);
//Console.WriteLine(media);

using System.Security.Cryptography;

// Maneira feita por mim  //
//int diaMes (int mes)
//{
//    int result = 0;

//    switch (mes)
//    {
//        case 1:
//            Console.WriteLine("Esse mês tem 31 dias");
//            break;
//        case 2:
//            Console.WriteLine("Esse mês tem 28 dias");
//            break;
//        case 3:
//            Console.WriteLine("Esse mês tem 31 dias");
//            break;
//        case 4:
//            Console.WriteLine("Esse mês tem 30 dias");
//            break;
//        case 5:
//            Console.WriteLine("Esse mês tem 31 dias");
//            break;
//        case 6:
//            Console.WriteLine("Esse mês tem 30 dias");
//            break;
//        case 7:
//            Console.WriteLine("Esse mês tem 31 dias");
//            break;
//        case 8:
//            Console.WriteLine("Esse mês tem 30 dias");
//            break;
//        case 9:
//            Console.WriteLine("Esse mês tem 31 dias");
//            break;
//        case 10:
//            Console.WriteLine("Esse mês tem 30 dias");
//            break;
//        case 11:
//            Console.WriteLine("Esse mês tem 31 dias");
//            break;
//        case 12:
//            Console.WriteLine("Esse mês tem 30 dias");
//            break;


//    }
//      return result;
//}
//Maneira feita pelo Professor//
int diaMes(int mes)
{
    int result = 0;

    switch (mes)
    {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12: result = 31; break;
        case 2: result = 28; break;
        case 4:
        case 6:
        case 9:
        case 11: result = 30; break;
    }
    return result;
}
int FimMes(int dia, int mes)
{
    int diasMes = diaMes(mes);
    int fim = diasMes - dia;
    return fim;
}
int dia, mes;
Console.WriteLine("Entre com o mês 1-12");
mes = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o dia do mês");
dia = int.Parse(Console.ReadLine());
int fim = FimMes(dia, mes);
Console.WriteLine("Faltam " + fim + " dpara terminar o mês " + mes);