using System;
class BoxTesting
{
    public static void Main()
    {
        int i = 15, j, k;
        bool b = false, c, d;
        object obj1 = i,obj2 = b;
        j = (int)obj1; // unboxing obj1 
        c = (bool)obj2; // unboxing obj2
        k = i + (int)obj1;
        d = b && (bool)obj2;

        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",
        i, obj1, b, obj2, j, c, k, d);
        //

    }
}
