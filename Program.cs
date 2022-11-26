using SnakeProject;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.CursorVisible = false;

Snake snake = new Snake();

Food.GiveNewFood();

while (!ControllsApp.GameIsOver)
{
    VectorController.CheckForKey();
    Food.Show();
    snake.MoveSnake(VectorController.movement);

    Thread.Sleep((int)Math.Floor(ControllsApp.Speed));
}

Console.WriteLine($"\n\nGame Over! Your length is: {snake.Length}");