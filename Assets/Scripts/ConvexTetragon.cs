using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvexTetragon : Tetragon
{
    public ConvexTetragon(float a, float b, float angle) : base(a, b, angle) { }

    public override string GetInfo()
    {
        return $"Выпуклый четырехугольник: стороны {a} и {b}, угол {angle}°, периметр: {CountPerimeter()}, площадь: {CountArea()}";
    }
}