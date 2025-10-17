using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Rectangle
{
    public Square(float a) : base(a, a) 
    {
        // Все стороны равны
    }

    public override float CountPerimeter()
    {
        return 4f * a; // P = 4a
    }

    public override float CountArea()
    {
        return a * a;
    }

    public override string GetInfo()
    {
        return $"Квадрат: сторона {a}, периметр: {CountPerimeter()}, площадь: {CountArea()}";
    }
}
