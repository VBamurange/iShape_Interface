using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    
    void Start()
    {
        Trapezium x = new Trapezium(5, 7, 6.5);
        Circle y = new Circle(4);
        Nonagon z = new Nonagon(9, 3);

        UnityEngine.Debug.Log("Area of Trapezium: " + x.CalculateArea());
        UnityEngine.Debug.Log("Perimeter of Trapezium: " + x.CalculatePerimeter());

        UnityEngine.Debug.Log("Area of Circle: " + y.CalculateArea());
        UnityEngine.Debug.Log("Perimeter of Circle: " + y.CalculatePerimeter());

        UnityEngine.Debug.Log("Area of Nonagon: " + z.CalculateArea());
        UnityEngine.Debug.Log("Perimeter of Nonagon: " + z.CalculatePerimeter());
    }
}

public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

public class Trapezium : IShape
{
    private double base_a;
    private double base_b;
    private double height;

    public Trapezium(double base_a, double base_b, double height)
    {
        this.base_a = base_a;
        this.base_b = base_b;
        this.height = height;
    }

    public double CalculateArea()
    {
        return ((base_a + base_b) / 2) * height;
    }

    public double CalculatePerimeter()
    {
        
        return base_a + base_b + 2 * height;
    }
}

public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

public class Nonagon : IShape
{
    private int numberOfSides;
    private double length;

    public Nonagon(int numberOfSides, double length)
    {
        this.numberOfSides = numberOfSides;
        this.length = length;
    }

    public double CalculateArea()
    {
        double apothem = length / (2 * Math.Tan(Math.PI / numberOfSides));
        return (length * numberOfSides * apothem) / 2;
    }

    public double CalculatePerimeter()
    {
        return numberOfSides * length;
    }
}
