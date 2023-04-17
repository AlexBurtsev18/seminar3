// void ShowRange(int quad)
// {
//     if(quad == 1) Console.WriteLine ("x > 0 and y > 0");
//     else if(quad == 2) Console.WriteLine ("x < 0 and y > 0");
//     else if(quad ==3) Console.WriteLine ("x < 0 and y < 0");
//     else if(quad == 4) Console.WriteLine ("x > 0 and y < 0");
//     else Console.WriteLine("Wrong number of quadrant!");
// }

// Console.Write("Input a number pf quadrant: ");
// int quadrant = Convert.ToInt32(Console.ReadLine());

// ShowRange(quadrant);

// // Task 1++
// int ReturnCoor(double x, double y)
// {
//     int coord;
//     if(x>0 && y>0)
//     {
//         return coord = 1;
//     }
//     else if(x<0 && y>0)
//     {
//         return coord = 2;
//     }
//     else if(x<0 && y<0)
//     {
//         return coord = 3;
//     }
//     else
//     {
//         return coord = 4;
//     }
// }
// Console.WriteLine("Введите координаты x");
// double coordX = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты y");
// double coordY = Convert.ToDouble(Console.ReadLine());
// double returnResult = ReturnCoor(coordX, coordY);
// Console.WriteLine($"Ваша координатная плоскость {returnResult}");

// Task 2++. 

// void TablKvad(int N)
// {
//     int count = 1;
//     while(count<=N)
//     {
//         Console.WriteLine($"Квадрат {count} составляет { count*count} ");
//         count++;
//     }   
// }

// Console.Write("Input your number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// TablKvad(number);

// Task 3++.

// double Gipotenuza(double x1, double y1, double x2, double y2)
// {
//     double distX = x2 - x1;
//     double distY = y2 - y1;
//     double result = Math.Sqrt(distX*distX + distY*distY);
//     return result;
// }
// Console.Write("Введите значение x1 ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение y1 ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение x2 ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение y2 ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double res = Math.Round(Gipotenuza(x1, y1, x2, y2),3);

// Console.WriteLine($"Расстояние между точками 1 и 2 составляет - {res}");

// Homework. 
// Task 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReverseNumber(int num)
{
    int revNum = 0;
    while (num > 0)
    {
        revNum = revNum * 10 + num % 10;
        num = num / 10;
    }
    return revNum;
}
Console.WriteLine("Введите число: ");
int result = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReverseNumber(result));