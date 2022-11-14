{
    double n = 38.8;
    double p = 81.3;
    Console.WriteLine("Число p={0}",p);
    Console.WriteLine("Массив:");
    Random nums = new Random();
    double[] array = new double[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = nums.NextDouble() * 16.1;
        Console.WriteLine(array[i].ToString("F1"));
    }
        double x = Enumerable.Sum(array)+n;
        Console.WriteLine("Сумма чисел в массиве={0}", x.ToString("F1"));
    if (p <x)
    {
        Console.WriteLine("В данном случае утверждрение верно");
    }
    else
    {
        Console.WriteLine("В данном случае утверждение не верно");
    }
    Console.WriteLine(x.ToString("F1"));
}
