int F1 (int A, int B)
{
    int i = 1;
    int Answer = 1;
    while (i <= B)
    {
        Answer = Answer * A;
        i ++;
    }
    return Answer;
}
Console.Write("Введите любое натуральное число A = ");
int A1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое натуральное число B = ");
int B1 = Convert.ToInt32(Console.ReadLine());
int Answer1 = F1 (A1, B1);
Console.Write("Число А, возведенное в степень числа В = ");
Console.WriteLine(Answer1);