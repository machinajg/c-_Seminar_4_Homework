// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// 1). Цикл for (без метода)

// Console.Write("Введите число А:  ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B:  ");
// int B = Convert.ToInt32(Console.ReadLine());
// int res = 1;
// for (int i = 0; i < B; i ++ )
// {
//     res = res * A;
// }
// Console.WriteLine(res);


// 2). Метод с циклом for

int GetPow (int A, int B)
{
    int res =1 ;
    for (int i = 0; i < B; i ++)
    {
        res = res * A;
    }
    return res;
}
int result = GetPow (3,5);
Console.WriteLine($" A в степени B равно {result}");
