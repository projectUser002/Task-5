using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhombus : Parallelogram
{
    public Rhombus(float a, float angle) : base(a, a, angle) 
    {
        //b = a
    }

    public override float CountPerimeter()
    {
        return 4f * a; // P = 4a
    }

    // S = a^2 * sin(angle)
    public override float CountArea()
    {
        return a * a * Mathf.Sin(angle * Mathf.Deg2Rad);
    }

    public override string GetInfo()
    {
        return $"Ромб: сторона {a}, угол {angle}°, периметр: {CountPerimeter()}, площадь: {CountArea()}";
    }
}