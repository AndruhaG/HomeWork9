//Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N, кратные трём.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

void Zadacha64()
{
    Console.WriteLine("Введите начальное число ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите конечное число ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    
    if ( m < n)
    {
        Console.WriteLine($"Натуральные числа кратные 3: от {m} до {n}");
        for (int count = m; count <= n; count++) 
        {
           if (count % 3 == 0) 
           {
           Console.Write(count + "\t"); 
           }
        }
    }
    
    else if (m > n)
    {
        Console.WriteLine($"Натуральные числа кратные 3: от {m} до {n}");
        for (int count = m; n <= count; count--) 
        {
           if (count % 3 == 0)
           {
                Console.Write(count + "\t"); 
           } 
        }
    }
}


// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Zadacha66()
{
    Console.WriteLine("Введите начальное число ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите конечное число ");
    int n = Convert.ToInt32(Console.ReadLine());

    SumNumbers(m, n, 0);

    void SumNumbers (int m, int n, int sum)
    {
        sum = 0;
        for (sum = 0; m <= n; m++) 
        {
            sum = sum + m;
        }    
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
    }   
}


// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

void Zadacha68()
{
    Console.WriteLine("Введите начальное число ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите конечное число ");
    int n = Convert.ToInt32(Console.ReadLine());

    int FunctionAkkerman = Akk(m, n);

    int Akk(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return Akk(m - 1, 1);
        return Akk(m - 1, Akk(m, n - 1));
    }
    Console.Write($"Функция Аккермана = {FunctionAkkerman} ");
}



//Zadacha64();
//Zadacha66();
Zadacha68();
