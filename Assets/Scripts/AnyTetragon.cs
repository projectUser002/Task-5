using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyTetragon : Tetragon
{
    public float c;
    public float d;
    public AnyTetragon(float a, float b, float _c, float _d, float angle) : base(a, b, angle)
    {
        c = _c;
        d = _d;
    }

    public override float CountPerimeter()
    {
        return a + b + c + d;
    }

    public override float CountArea()
    {
        float diagonal = Mathf.Sqrt(a * a + b * b - 2 * a * b * Mathf.Cos(angle * Mathf.Deg2Rad));
        
        float semi1 = (a + b + diagonal) / 2f;
        float area1 = Mathf.Sqrt(semi1 * (semi1 - a) * (semi1 - b) * (semi1 - diagonal));
        
        float semi2 = (c + d + diagonal) / 2f;
        float area2 = Mathf.Sqrt(semi2 * (semi2 - c) * (semi2 - d) * (semi2 - diagonal));
        
        return area1 + area2;
    }

    public override string GetInfo()
    {
        return $"Случайный сетырехугольник: сторона {a}, периметр: {CountPerimeter()}, площадь: {CountArea()}";
    }
}
