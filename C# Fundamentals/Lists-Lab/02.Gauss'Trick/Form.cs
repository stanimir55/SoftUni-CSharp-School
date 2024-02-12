using System;

namespace BallGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(40, 20);

            int paddleWidth = 6;
            int paddleHeight = 1;
            int paddleX = Console.WindowWidth / 2 - paddleWidth / 2;
            int paddleY = Console.WindowHeight - 2;
            int ballX = Console.WindowWidth / 2;
            int ballY = Console.WindowHeight / 2;
            int ballSpeedX = 1;
            int ballSpeedY = -1;
            int score = 0;

            while (true)
            {
                Console.Clear();
                DrawPaddle(paddleX, paddleY, paddleWidth, paddleHeight);
                DrawBall(ballX, ballY);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.LeftArrow && paddleX > 0)
                    {
                        paddleX--;
                    }
                    else if (key.Key == ConsoleKey.RightArrow && paddleX < Console.WindowWidth - paddleWidth)
                    {
                        paddleX++;
                    }
                }

                ballX += ballSpeedX;
                ballY += ballSpeedY;

                if (ballX == 0 || ballX == Console.WindowWidth - 1)
                {
                    ballSpeedX = -ballSpeedX;
                }

                if (ballY == 0)
                {
                    ballSpeedY = -ballSpeedY;
                }
                else if (ballY == Console.WindowHeight - 2 && ballX >= paddleX && ballX < paddleX + paddleWidth)
                {
                    ballSpeedY = -ballSpeedY;
                    score++;
                }
                else if (ballY == Console.WindowHeight - 1)
                {
                    break; // Game over
                }

                System.Threading.Thread.Sleep(50);
            }

            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
            Console.WriteLine("Game over!");
            Console.WriteLine($"Your score: {score}");
        }

        static void DrawPaddle(int x, int y, int width, int height)
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
        }

        static void DrawBall(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }
    }
}
