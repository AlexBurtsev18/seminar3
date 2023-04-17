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

int ReturnCoor(double x, double y)
{
    int coord;
    if(x>0 && y>0)
    {
        return coord = 1;
    }
    else if(x<0 && y>0)
    {
        return coord = 2;
    }
    else if(x<0 && y<0)
    {
        return coord = 3;
    }
    else
    {
        return coord = 4;
    }
}
Console.WriteLine("Введите координаты x");
double coordX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты y");
double coordY = Convert.ToDouble(Console.ReadLine());
double returnResult = ReturnCoor(coordX, coordY);
Console.WriteLine($"Ваша координатная плоскость {returnResult}");
