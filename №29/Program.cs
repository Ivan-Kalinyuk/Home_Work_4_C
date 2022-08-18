Console.WriteLine ("Введите количество элементов Вашего массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] ar = new int [N];
Console.WriteLine("Введите элементы массива (каждый раз с новой строки): ");
for (int i = 0; i < N; i++)
{
    ar[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Вот элементы Вашего массива в строчку: ");
for (int i = 0; i < N; i++)
{
   Console.Write(ar[i] + " "); 
}

