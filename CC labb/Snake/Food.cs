﻿namespace CC_labb;

public class Food
{
    public Position foodPosition = new Position();
    Random random = new Random();

    public Food()
    {
        foodPosition.x = random.Next(1, 75);
        foodPosition.y = random.Next(1, 25);
    }
    public void DrawFood()
    {
        Console.SetCursorPosition(foodPosition.x, foodPosition.y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("*");
        Console.ResetColor();
    }
    public Position FoodLocation()
    {
        return foodPosition;
    }
    public void FoodLocationNew()
    {
        foodPosition.x = random.Next(1, 75);
        foodPosition.y = random.Next(1, 25);
    }
}
