using System.Collections;

Int32 a = 400000400;

Object o  = a;
Console.WriteLine(o.GetType());
Console.WriteLine(o);

//Int16 s = (Int16)o; // Invalid cast

//Console.WriteLine(s.GetType());
//Console.WriteLine(s);

ArrayList arrayList = new ArrayList();
Point p;

for(int i = 0; i < 3; i++)
{
    p.a = p.b = i;
    arrayList.Add(p);
}


for (int i = 0; i < 3; i++)
{
    Console.WriteLine(arrayList[i]);
}

public struct Point
{
    public int a, b;

    public override string ToString()
    {
        return $"a = {a}\nb = {b}";
    }
}