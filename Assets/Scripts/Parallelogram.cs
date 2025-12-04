using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallelogram : ConvexTetragon //наследуемся по цепочке
{
    public Parallelogram(float a, float b, float angle) : base(a, b, angle) { }

    // У параллелограмма прот. стороны равны - периметр считается так же. Соответственно используем базовый метод
    
    // Площадь также - используем базовый

    public override string GetInfo()
    {
        return $"Параллелограмм: стороны {a} и {b}, угол {angle}°, периметр: {CountPerimeter()}, площадь: {CountArea()}";
    }
}