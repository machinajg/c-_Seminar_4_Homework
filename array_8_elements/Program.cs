//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//      1). По материалам лекции (один в один)

// void FillArray(int[] digits)
// {
//     int length = digits.Length;
//     int index = 0;
//     while (index < length)
//     {
//         digits[index] = new Random().Next(1,20);
//         index ++;
//     }
// }
// void PrintArray(int[] digs)
// {
//     int length = digs.Length;
//     int index = 0;
//     while (index < length)
//     {
//         Console.WriteLine(digs[index]);
//         index ++;
//     }
// }
// int[]array = new int [8];
// FillArray (array);
// PrintArray (array);



int [] arr = {4,26,7,890,3,104,78,9};
void PrintArray (int[]array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}
PrintArray (arr);