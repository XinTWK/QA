using System;


namespace QA
{
    class Program
    {
        static void Main(string[] args)
        {

            // 召喚池類型
            string summonpoolType;
            // 精選5星機率
            double specialFiveStar;
            // 非精選5星機率
            double commonFiveStar;
            // 精選5星召喚石顏色的數量
            double[] specialFiveStarColorNum = new double[4];
            // 精選5星召喚石顏色
            int specialFiveStarColor;
            // 精選5星中獎機率
            double probabliity;

            double result;

            Console.WriteLine("請輸入召喚池類型");
            summonpoolType = Console.ReadLine();

            Console.WriteLine("請輸入精選5星的機率");
            specialFiveStar = double.Parse(Console.ReadLine());

            Console.WriteLine("請輸入非精選5星的機率");
            commonFiveStar = double.Parse(Console.ReadLine());

            Console.WriteLine("請輸入精選5星召喚石顏色的數量");
            Console.WriteLine("紅色數量為: ");
            string inputRed = Console.ReadLine();
            Console.WriteLine("綠色數量為: ");
            string inputGreen = Console.ReadLine();
            Console.WriteLine("藍色數量為: ");
            string inputBlue = Console.ReadLine();
            Console.WriteLine("灰色數量為: ");
            string inputGray = Console.ReadLine();

            specialFiveStarColorNum[0] = double.Parse(inputRed);
            specialFiveStarColorNum[1] = double.Parse(inputGreen);
            specialFiveStarColorNum[2] = double.Parse(inputBlue);
            specialFiveStarColorNum[3] = double.Parse(inputGray);

            Console.WriteLine("請輸入目標精選5星召喚石的顏色");
            Console.WriteLine("1:紅色  2:綠色  3:藍色  4:灰色");

            specialFiveStarColor = int.Parse(Console.ReadLine());

            switch (specialFiveStarColor)
            {
                case 1:
                    probabliity = specialFiveStar * (specialFiveStarColorNum[0] / specialFiveStarColorNum.Length);
                    result = (1 - Math.Pow((1 - probabliity), 5)) / 20;
                    Console.WriteLine("期望值為 " + result);
                    break;
                case 2:
                    probabliity = specialFiveStar * (specialFiveStarColorNum[1] / specialFiveStarColorNum.Length);
                    result = (1 - Math.Pow((1 - probabliity), 5)) / 20;
                    Console.WriteLine("期望值為 " + result);
                    break;
                case 3:
                    probabliity = specialFiveStar * (specialFiveStarColorNum[2] / specialFiveStarColorNum.Length);
                    result = (1 - Math.Pow((1 - probabliity), 5)) /20;
                    Console.WriteLine("期望值為 " + result);
                    break;
                case 4:
                    probabliity = specialFiveStar * (specialFiveStarColorNum[3] / specialFiveStarColorNum.Length);
                    result = (1 - Math.Pow((1 - probabliity), 5)) /20;
                    Console.WriteLine("期望值為 " + result);
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }

    }
}
