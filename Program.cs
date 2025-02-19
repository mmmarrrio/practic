//  задача 1 описание автомобиля
using System.Threading.Channels;
using System;

public class Car
{
    public string Brand { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    public Car(string Brand, string Name, int Year)
    {
        Brand = Brand;
        Name = Name;
        Year = Year;
    }
    public void ShowInfo()
    {
        Console.WriteLine(Brand + Name + Year);
    }
}
class Programm
{
    static void Main(string[] args)
    {
        Car car = new Car("zov"+"goyda"+123);
        Console.WriteLine(car.Brand+car.Name+car.Year);
    }
}