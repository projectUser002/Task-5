using UnityEngine;

public class TetragonTester : MonoBehaviour
{
    void Start()
    {
        Debug.Log("ТЕСТИРОВАНИЕ КЛАССОВ ЧЕТЫРЕХУГОЛЬНИКОВ");

        Tetragon tetragon = new Tetragon(5f, 6f, 60f);
        Debug.Log(tetragon.GetInfo());

        ConvexTetragon convex = new ConvexTetragon(5f, 6f, 60f);
        Debug.Log(convex.GetInfo());

        Parallelogram parallelogram = new Parallelogram(5f, 6f, 60f);
        Debug.Log(parallelogram.GetInfo());

        Rhombus rhombus = new Rhombus(5f, 60f);
        Debug.Log(rhombus.GetInfo());

        Rectangle rectangle = new Rectangle(5f, 6f);
        Debug.Log(rectangle.GetInfo());

        Square square = new Square(5f);
        Debug.Log(square.GetInfo());

        Debug.Log("=== СРАВНЕНИЕ РАЗЛИЧНЫХ ФИГУР ===");
        float side = 4f;
        
        Square testSquare = new Square(side);
        Rectangle testRectangle = new Rectangle(side, side);
        Rhombus testRhombus = new Rhombus(side, 90f);
        
        Debug.Log($"Квадрат со стороной {side}: P={testSquare.CountPerimeter()}, S={testSquare.CountArea()}");
        Debug.Log($"Прямоугольник {side}x{side}: P={testRectangle.CountPerimeter()}, S={testRectangle.CountArea()}");
        Debug.Log($"Ромб со стороной {side} и углом 90°: P={testRhombus.CountPerimeter()}, S={testRhombus.CountArea()}");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TestRandomFigures();
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TestAreaCalculation();
        }
    }

    void TestRandomFigures()
    {
        Debug.Log("СЛУЧАЙНЫЕ ФИГУРЫ");
        
        float randomA = Random.Range(1f, 10f);
        float randomB = Random.Range(1f, 10f);
        float randomAngle = Random.Range(30f, 150f);
        
        Tetragon randomTetragon = new Tetragon(randomA, randomB, randomAngle);
        Parallelogram randomParallelogram = new Parallelogram(randomA, randomB, randomAngle);
        Rhombus randomRhombus = new Rhombus(randomA, randomAngle);
        
        Debug.Log(randomTetragon.GetInfo());
        Debug.Log(randomParallelogram.GetInfo());
        Debug.Log(randomRhombus.GetInfo());
    }

    void TestAreaCalculation()
    {
        Debug.Log("ПРОВЕРКА ФОРМУЛ ПЛОЩАДИ");
        
        Rectangle rect = new Rectangle(3f, 4f);
        float expectedRectArea = 3f * 4f;
        float actualRectArea = rect.CountArea();
        Debug.Log($"Прямоугольник 3x4: ожидаемая площадь={expectedRectArea}, фактическая={actualRectArea}, совпадение={Mathf.Approximately(expectedRectArea, actualRectArea)}");

        Square sq = new Square(5f);
        float expectedSquareArea = 5f * 5f;
        float actualSquareArea = sq.CountArea();
        Debug.Log($"Квадрат 5x5: ожидаемая площадь={expectedSquareArea}, фактическая={actualSquareArea}, совпадение={Mathf.Approximately(expectedSquareArea, actualSquareArea)}");

        Rhombus rhomb = new Rhombus(6f, 30f);
        float expectedRhombArea = 6f * 6f * Mathf.Sin(30f * Mathf.Deg2Rad);
        float actualRhombArea = rhomb.CountArea();
        Debug.Log($"Ромб сторона=6, угол=30°: ожидаемая площадь={expectedRhombArea}, фактическая={actualRhombArea}, совпадение={Mathf.Approximately(expectedRhombArea, actualRhombArea)}");
    }
}