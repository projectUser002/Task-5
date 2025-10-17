using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : Parallelogram
{
    public Rectangle(float a, float b) : base(a, b, 90f) 
    {
        //все углы 90 градусов
    }

    // Периметр остается P = 2(a + b)

    public override float CountArea()
    {
        return a * b;
    }

    public override string GetInfo()
    {
        return $"Прямоугольник: стороны {a} и {b}, периметр: {CountPerimeter()}, площадь: {CountArea()}";
    }
}
