
/*
Console.WriteLine("Введите число: ");                      //Задача 27
int x = Convert.ToInt32(Console.ReadLine());

double Sum(int x)
{
    double sum = 0;
    String ch = Convert.ToString(x);
    int count = ch.Length;
    for (int i = 0; i<count; i++)
        {
            double s =  char.GetNumericValue(ch[i]);
            sum = s + sum;
        }
    return sum;
}
Console.WriteLine("Cумма равна: " + Sum(x));
*/





void masiv()                     //Задача 29
{
    int[] array = new int[8];
    int count = array.Length;
    for (int i = 0; i<count; i++)
        {
            int x = new Random().Next(1,10);
            array[i] = x;
            Console.Write($"{array[i]} ");
        }
}
masiv();


