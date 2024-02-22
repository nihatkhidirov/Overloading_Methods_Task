namespace Overloading_Methods_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region __Methods__
            SumOfSequence(500, 20, 30);
            GAP("");
            SumOfSequence(20, 40, 50, 20);
            FindTheSeason(10);
            FindTheSeason("winter");
            Multiplication(231);
            FindingPromoted_Price(100, 120, 300);
            #endregion
        }
        #region Space
        static void GAP(string input)
        {
            Console.WriteLine("##################################################");
        }
        #endregion
        #region Task_1
        static void SumOfSequence(int a, int b, int c)
        {
            int sum = 0;
            if (a > 10 && a < 100)
            {
                sum = sum + a;
                Console.WriteLine("Edediniz 10-100 Araliginda yerlesir "+(a));
            }
            else
            {
                Console.WriteLine("Edediniz 10-100 araliginda yerlesmir: " + (a));
            }
            if (b > 10 && b < 100)
            {
                sum = sum + b;
                Console.WriteLine("Edediniz 10-100 Araliginda yerlesir " + (b));

            }
            else
            {
                Console.WriteLine("Edediniz 10-100 araliginda yerlesmir: " + (b));
            }

            if (c > 10 && c < 100)
            {
                sum = sum + c;
                Console.WriteLine("Edediniz 10-100 Araliginda yerlesir " + (c));

            }
            else
            {
                Console.WriteLine("Edediniz 10-100 araliginda yerlesmir: " + (c));
            }
            Console.WriteLine("10-100 Araliginda Yerlesen Ededlerin Cemi: "+(sum));
        }
        static void SumOfSequence(int a, int b, int c,int d)
        {
            int sum = 0;
            if (a > 10 && a < 100)
            {
                sum = sum + a;
                Console.WriteLine("Edediniz 10-100 Araliginda yerlesir " + (a));
            }
            else
            {
                Console.WriteLine("Edediniz 10-100 araliginda yerlesmir: " + (a));
            }
            if (b > 10 && b < 100)
            {
                sum = sum + b;
                Console.WriteLine("Edediniz 10-100 Araliginda yerlesir " + (b));

            }
            else
            {
                Console.WriteLine("Edediniz 10-100 araliginda yerlesmir: " + (b));
            }

            if (c > 10 && c < 100)
            {
                sum = sum + c;
                Console.WriteLine("Edediniz 10-100 Araliginda yerlesir " + (c));

            }
            else
            {
                Console.WriteLine("Edediniz 10-100 araliginda yerlesmir: " + (c));
            }
            if (d > 10 && d < 100)
            {
                sum = sum + d;
                Console.WriteLine("Edediniz 10-100 Araliginda yerlesir " + (d));

            }
            else
            {
                Console.WriteLine("Edediniz 10-100 araliginda yerlesmir: " + (d));
            }
            Console.WriteLine("10-100 Araliginda Yerlesen Ededlerin Cemi: " + (sum));
        }
        #endregion
        #region Task_2
        static void FindTheSeason(int EDED)
        {
            if (EDED == 12 || EDED == 1 || EDED == 2)
            {
                Console.WriteLine("Fesil:Qis");
            }
            else if (EDED == 3 || EDED == 4 || EDED == 5)
            {
                Console.WriteLine("Fesil:Yaz");
            }
            else if (EDED == 6 || EDED == 7 || EDED == 8)
            {
                Console.WriteLine("Fesil:Yay");
            }
            else if (EDED == 9 || EDED == 10 || EDED == 11)
            {
                Console.WriteLine("Fesil:Payiz");
            }
            else
            {
                Console.WriteLine("Duzgun Eded Daxil edilmemisdir");
            }
        }
        static void FindTheSeason(string seasonName)
        {
            switch (seasonName.ToLower())
            {
                case "winter":
                    Console.WriteLine("Fesil:Qis");
                    break;
                case "spring":
                    Console.WriteLine("Fesil:Yaz");
                    break;
                case "summer":
                    Console.WriteLine("Fesil:Yay");
                    break;
                case "autumn":
                    Console.WriteLine("Fesil:Payiz");
                    break;
                default:
                    Console.WriteLine("Duzgun Fesil adi daxil edilmemisdir");
                    break;
            }
        }
        #endregion
        #region Task_3
        static void Multiplication(int num)
        {
            int num1 = num % 10; //1
            int num2 = num % 100 / 10; //3
            int num3 = num / 100;//2
            int multiplication=num1 * num2 * num3;
            Console.WriteLine(multiplication);
        }
        static void Multiplication(int num1, int num2, int num3)
        {
            int multiplication = num1 * num2 * num3;
            Console.WriteLine(multiplication);
        }
        #endregion
        #region Task_4
        static void FindingPromoted_Price(int product_price1, int product_price2, int product_price3)
        {
           
            if (product_price1 > product_price2)
            {
                if (product_price1 > product_price3)
                {
                    if (product_price2 > product_price3)
                    {
                        Console.WriteLine("Cem:" + (product_price1 + product_price2));
                    }
                    else
                    {
                        Console.WriteLine("Cem:" + (product_price1 + product_price3));
                    }
                }
            }
            if (product_price2 > product_price3)
            {
                if (product_price2 > product_price1)
                {
                    if (product_price3 > product_price1)
                    {
                        Console.WriteLine("Cem:" + (product_price2 + product_price3));
                    }
                    else
                    {
                        Console.WriteLine("Cem:" + (product_price1 + product_price2));
                    }
                }
            }
            if (product_price3 > product_price2)
            {
                if (product_price3 > product_price1)
                {
                    if (product_price2 > product_price1)
                    {
                        Console.WriteLine("Cem:" + (product_price3 + product_price2));
                    }
                    else
                    {
                        Console.WriteLine("Cem:" + (product_price3 + product_price1));
                    }
                }
            }
        }
        static void FindingPromoted_Price(int[] productPrices)
        {
            Array.Sort(productPrices); //qiymetleri artan sekilde yazmaq ucun istifade olunur...
            Console.WriteLine("Cem:" + (productPrices[1] + productPrices[2]));
        }

        #endregion

    }
}