
#region Task 1 - Cycles
//Console.WriteLine("Define number:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Define power:");
//int b = Convert.ToInt32(Console.ReadLine());


//static void Power(int a, int b)
//{
//    for (int i = 1; i < b; i++)
//    {
//        a += a;
//    }
//    Console.WriteLine(a);
//}
//Power(a, b);
#endregion
#region Task 2 - Cycles
//Console.WriteLine("Define a:");
//int a = Convert.ToInt32(Console.ReadLine());
//static void Remainder(int a)
//{
//    int sum = 0;
//    for (int i = 0; i <= 1000 ; i++)
//    {
//        int rem = i % a;
//        if (rem == 0)
//        {
//            sum++;
//        }
//    }
//    Console.WriteLine("Amount of numbers that have no remainder when divided: " + sum);
//}
//Remainder(a);
#endregion
#region Task 3 - Cycles
//Console.WriteLine("Define a: ");
//int a = Convert.ToInt32(Console.ReadLine());
//static void Sqr(int a)
//{
//	for (int i = 1; i * i < a; i++)
//	{
//		Console.WriteLine(i);
//	}
//}
//Sqr(a);	
#endregion
#region Task 4 - Cycles
//Console.WriteLine("Define a: ");
//int a = Convert.ToInt32(Console.ReadLine());
//static void Divisor(int a)
//{
//      int maxDivisor = 0;
//    for (int i = 2; i < a; i++)
//    {
//        if (a % i == 0)
//        {
//            maxDivisor = a / i;
//            break;

//        }

//    }
//    Console.WriteLine(maxDivisor);
//}
//Divisor(a);
#endregion
#region Task 5 - Cycles
//Console.WriteLine("Define a: ");
//int from = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Define b: ");
//int to = Convert.ToInt32(Console.ReadLine());
//static void sumOf(int a, int b)
//{
//	int sum = 0;
//	int from = a;
//	int to	= b;
//	if (b<a)
//	{
//		to = a;
//		from = b;
//	}
//	for (int i = from; i < to; i++)
//	{
//		int remainder = i % 7;
//		if (remainder == 0)
//		{
//			sum += i;
//		}
//	}
//	Console.WriteLine(sum);
//}
//sumOf(from, to);
#endregion
#region Task 6 - Cycles
//Console.WriteLine("Define a; ");
//int a = Convert.ToInt32(Console.ReadLine());
//static void fibonacci(int a)
//{
//    int answ = 0;
//    int current = 1;
//    int temp;
//    for (int i = 1; i <= a; i++)
//    {
//        temp = current;
//        Console.WriteLine(current);
//        current = answ + temp;
//        answ = temp;
//    }

//}
//fibonacci(a);
#endregion
#region Task 7 - Cycles
//Cycles 7
//Console.WriteLine("Define a:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Define b:");
//int b = Convert.ToInt32(Console.ReadLine());
//static void Euclid(int a, int b)
//{
//    int number1 = a;
//    int number2 = b;

//    while (a != 0 && b != 0)
//    {
//        if (a > b)
//        {
//            a %= b;
//        }
//        else
//        {
//            b %= a;

//        }
//    }
//    if (a == 0)
//    {
//        Console.WriteLine("Answer is: " + b);
//    }
//    else
//    {
//        Console.WriteLine("Answer is: " + a);
//    }

//}
//Euclid(a, b);
#endregion
#region Task 8 - Cycles
Console.WriteLine("Define a: ");
double a = double.Parse(Console.ReadLine());
int b = Convert.ToInt32(a / 2);
static void pow(double a, double b)
{
    int res = 0;
    while (Math.Pow(b, 3) > a)
    {

        double temp = b / 2;
        b = temp; ;
    }
    Console.WriteLine(b);

}
pow(a, b);









#endregion
#region Task 9 - Cycles
//Console.WriteLine("Define a:");
//int a = Convert.ToInt32(Console.ReadLine());

//static void Odds(int a)
//{
//	int odd;
//	while (a>0)
//	{
//		int last = a % 10;
//		odd = last % 2;
//		if (odd == 1)
//		{
//			Console.WriteLine(last);
//		}
//	}
//}
//Odds(a);
#endregion
#region Task 10 - Cycles
//Console.WriteLine("Define a:");
//int a = Convert.ToInt32(Console.ReadLine());
//static void mirror(int a)
//{
//    int mirrored = 0;
//    while (a > 0)
//    {
//        int last = a % 10;
//        mirrored = last + mirrored * 10;
//        a = a / 10;
//    }
//    Console.WriteLine(mirrored);
//}
#endregion
#region Task 11 - Cycles
//Cycles 11
//using System.Collections.Generic;

//Console.WriteLine("Define a:");
//int a = Convert.ToInt32(Console.ReadLine());

//static void evenOdd(int a)
//{
//    for (int i = 1; i < a; i++)
//    {


//        int sumeven = 0;
//        int sumOdd = 0;
//        int temp = i;

//        while (temp != 0)
//        {
//            int last = temp % 10;
//            if (last % 2 == 0)
//            {
//                sumeven += last;
//            }
//            else
//            {
//                sumOdd += last;
//            }
//            temp /= 10;
//        }
//        if (sumeven > sumOdd)
//        {
//            Console.WriteLine(i);
//        }
//        {

//        }
//    }
//}
//evenOdd(a);
#endregion
#region Task 12 - Cycles 
//Cycles 12
//Console.WriteLine("Define a:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Define b:");
//int b = Convert.ToInt32(Console.ReadLine());
//static void sum(int a, int b)
//{
//    int consB = b;
//    int r = 0;
//    int count = 0;
//    while (a > 0)
//    {
//        r = a % 10;

//        while (b > 0)
//        {
//            int t = b % 10;
//            if (t == r)
//            {
//                count++;
//            }
//            b /= 10;
//        }

//        a /= 10;
//        b = consB;
//    }
//    Console.WriteLine("Count of similar numbers are: " + count);

//}
//sum(a, b);
#endregion
#region Task 13 - Cycles
//Cycles 13
//Console.WriteLine("Define n: ");
//int n = Convert.ToInt32(Console.ReadLine());
//static void toN(int n)
//{
//    double sum = 0;
//    for (double i = 1; i <= n; i++)
//    {

//        double step = 1 + (1 / Math.Pow(i, 2));
//        sum = sum + step;
//    }
//    Console.WriteLine(sum);
//}
//toN(n);
#endregion
#region Task 14 - Cycles
//Console.WriteLine("Input first number:");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input second number:");
//int n = Convert.ToInt32(Console.ReadLine());

//static void Formula(int x,int n)
//{
//    int denominator = 1;
//    double sum = 0;
//    for (int i = 0; i < n; i++)
//    {
//        denominator *= (x + i);
//        sum += 1.0 / denominator;
//    }
//    Console.WriteLine(sum);
//}
// Formula( x,n)
//static void formulaFactorial(int x,int n)
//{
//    int factorial = 1;
//    double sum = 0;
//    for (int i = 1; i <= n; i++)
//    {
//        double numerator = Math.Pow(x, i);
//        factorial *= i;
//        sum += numerator / factorial;
//    }
//    Console.WriteLine(sum);
//}
//formulaFactorial(x,n);
#endregion
#region Task 15 - Cycles
//int n = Convert.ToInt32(Console.ReadLine());

//static void Multiplation(int n)
//{
//    double multiplation = 1;
//    int factorial = 1;
//    for (int i = 1; i <= n; i++)
//    {
//        factorial *= i;
//        multiplation *= 2+(1.0/ factorial);
//    }
//    Console.WriteLine(multiplation);
//}
//Multiplation(n);

//static void Sum(int n)
//{
//    double sum = 0;
//    int factorial = 1;
//    for (int i = 1; i <= n; i++)
//    {
//        factorial *= i;
//        sum *= (i + 1.0) / factorial;
//    }
//    Console.WriteLine(sum);
//}
//Sum(n);
#endregion
#region Task 16 - Cycles
//Console.WriteLine("Input number d:");
//int d = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input number x:");
//int x = Convert.ToInt32(Console.ReadLine());

//static void checkInaccuracy(int n)
//{
//    double result = Math.Pow(Math.PI, 2) / 6;
//    double sum = 0;
//    for (int i = 1; i <= n; i++)
//    {
//        sum += 1.0 / (i * i);
//    }

//    Console.WriteLine($"Inaccuracy in this calculation is {result - sum}");
//}
//checkInaccuracy(n);

//static void checkInaccuracy(int n)
//{
//    double result = 3.0 / 4;
//    double sum = 0;
//    for (int i = 1; i <= n; i++)
//    {
//        sum += 1.0 / (i * (i+2));
//    }

//    Console.WriteLine($"Inaccuracy in this calculation is {result - sum}");
//}
//checkInaccuracy(n);

//static void checkInaccuracy(int d,int x)
//{
//    double result = Math.Pow(Math.E, x) ;
//    int factorial = 1;
//    double sum = 1;
//    for (int i = 1; i <= d; i++)
//    {
//        factorial *= i;
//        sum += Math.Pow(x,i) / factorial;
//    }   

//    Console.WriteLine($"Inaccuracy in this calculation is {result - sum}");
//}
//checkInaccuracy(d,x);
#endregion
#region Task 17 - Cycles
//for (int i = 10; i <= 99; i++)
//{
//    int count = 0;
//    int newCount = 0;
//    for (int j = 2; j <= 9; j++)
//    {
//        if (sumdig(i) == sumdig(i * j))
//        {
//            Console.WriteLine($"{j} : {i}");

//        }
//    }

//}

//static int sumdig(int n)
//{
//    int sum = 0;
//    while (n > 0)
//    {
//        sum = sum + n % 10;
//        n = n / 10;
//    }
//    return sum;
//}
#endregion
#region Task 18 - Cycles
//static int facto(int n)
//{
//    int result = 1;
//    for (int i = 1; i <= n; i++)
//    {
//        result = result * i;
//    }
//    return result;
//}
//for (int i = 100; i <= 999; i++) /// 154
//{
//    int a = i / 100;
//    int b = (i / 10) % 10;
//    int c = i % 10;
//    if (facto(a) + facto(b) + facto(c) == i)
//    {
//        Console.WriteLine(i);
//    }
//}

#endregion
#region Task 19 - Cycles
//static void twosumpow(int n)
//{
//    for (int i = 1; i <= n; i++)
//    {
//        for (int j = 0; j <= n; j++)
//        {
//            if (i * i + j * j == n)
//            {
//                Console.WriteLine($"{i}^2 + {j}^2 = {n}");
//                return;
//            }
//        }
//    }
//}
#endregion
#region Task 20 - Cycles
//Console.WriteLine("Input n:");
//int n = Convert.ToInt32(Console.ReadLine());

//if (n==sumOfDivisors(n))
//{
//	Console.WriteLine("It is perfect Number");
//}
//else
//{
//    Console.WriteLine("It is not a perfect Number");
//}
//static int sumOfDivisors(int n)
//{
//    int sum = 1;
//	for (int i = 2; i <= n/2; i++)
//	{
//		if (n%i==0)
//		{
//			sum += i;
//		}
//	}
//	return sum;
//}

#endregion
#region Task 21 - Cycles
//Console.WriteLine("Input k:");
//int k = Convert.ToInt32(Console.ReadLine());


//static void findDigit(int k)
//{
//    /*-------------------------There is for optimizing  loops iteration count -----------------*/
//    if (k % 2 == 1 && k > 9)
//    {
//        k--;
//    }
//    if (k > 10)
//    {
//        k = 10 + (Convert.ToInt32((k - Math.Pow(10, (numberCount(k) - 1))) / 2));
//    }
//    /*-------------------------There is for optimizing loops iteration count -----------------*/
//    long number = 1;
//    for (int i = 2; i <= k; i++)
//    {
//        number *= Convert.ToInt64(Math.Pow(10, (numberCount(i))));
//        number += i;

//    }
//    Console.WriteLine(number);
//    if (k % 2 == 0)
//    {
//        Console.WriteLine(number / 10 % 10);
//    }
//    else
//    {
//        Console.WriteLine(number % 10);
//    }
//}
//static int numberCount(int n)
//{
//    int count = 0;
//    while (n > 0)
//    {
//        count++;
//        n /= 10;
//    }
//    return count;
//}
//findDigit(k);
#endregion
#region Task 22 - Cycles
//Console.WriteLine("Input k:");
//int k = Convert.ToInt32(Console.ReadLine());

//static void findDigit(int k)
//{
//    long number = 1;
//    for (int i = 2; i <= k; i++)
//    {
//        number *= Convert.ToInt64(Math.Pow(10, (numberCount(i*i))));
//        number += (i*i);

//    }
//    Console.WriteLine(number);
//    if (k % 2 == 0)
//    {
//        Console.WriteLine(number / 10 % 10);
//    }
//    else
//    {
//        Console.WriteLine(number % 10);
//    }
//}
//static int numberCount(int n)
//{
//    int count = 0;
//    while (n > 0)
//    {
//        count++;
//        n /= 10;
//    }
//    return count;
//}
//findDigit(k);
#endregion