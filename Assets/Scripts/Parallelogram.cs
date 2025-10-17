using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallelogram : ConvexTetragon
{
    public Parallelogram(float a, float b, float angle) : base(a, b, angle) { }

    // У параллелограмма прот. стороны равны - периметр считается так же
    // Площадь также

    public override string GetInfo()
    {
        return $"Параллелограмм: стороны {a} и {b}, угол {angle}°, периметр: {CountPerimeter()}, площадь: {CountArea()}";
    }
}