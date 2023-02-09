//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// 1). Цикл for

// Console.Write("Введите число А:  ");
// int A = Convert.ToInt32(Console.ReadLine());
// int res = 0;
// for (int i = 0; A > 0; i++)
// {
//     int B = A % 10;
//     A = A / 10;
//     res = res + B;
// }
// Console.WriteLine(res);


// 2).  Метод

int SumUp (int A)
{
    int res = 0;
    for (int i = 0; A > 0; i++)
    {
        int B = A % 10;
        A = A / 10;
        res = res + B;
    }
    return res;
}
int GetSum = SumUp(9012);
Console.WriteLine(GetSum);
