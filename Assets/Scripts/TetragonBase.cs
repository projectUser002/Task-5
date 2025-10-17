using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetragon
{
    protected float a;
    protected float b;
    protected float angle;

    public Tetragon(float a, float b, float angle)
    {
        this.a = a;
        this.b = b;
        this.angle = angle;
    }

    public virtual float CountPerimeter()
    {
        return 2f * (a + b);
    }

    public virtual float CountArea()
    {
        return a * b * Mathf.Sin(angle * Mathf.Deg2Rad);
    }

    public virtual string GetInfo()
    {
        return $"Четырехугольник: стороны {a} и {b}, угол {angle}°, периметр: {CountPerimeter()}, площадь: {CountArea()}";
    }
}