{
    double n = 38.8;
    double p = 81.3;
    Random nums = new Random();
    double[] array = new double[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = nums.NextDouble() * 16.1;
        Console.WriteLine(array[i].ToString("F1"));
    }
        double x = Enumerable.Sum(array);
        Console.WriteLine("Сумма чисел в массиве={0}", x.ToString("F1"));
    if (p <x)
    {
        Console.WriteLine("Утверждрение верно");
    }
    else
    {
        Console.WriteLine("Утверждение не верно");
    }
    Console.WriteLine(x.ToString("F1"));
}
