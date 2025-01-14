namespace OOP3;

class Program
{
    static void Main(string[] args)
    {
        Color redColor = new Color(255, 0, 0);
        Color greenColor = new Color(0, 255, 0);
        Color blueColor = new Color(0, 0, 255);

        // Create Ball instances
        Ball redBall = new Ball(10, redColor);
        Ball greenBall = new Ball(15, greenColor);
        Ball blueBall = new Ball(20, blueColor);

        // Throw the balls
        redBall.Throw();
        redBall.Throw();
        greenBall.Throw();
        blueBall.Throw();
        blueBall.Throw();
        blueBall.Throw();

        // Pop the red ball and try throwing it again
        redBall.PopBall();
        redBall.Throw();

        // Print the throw counts
        Console.WriteLine($"Red ball throw count: {redBall.GetThrowCount()}");
        Console.WriteLine($"Green ball throw count: {greenBall.GetThrowCount()}");
        Console.WriteLine($"Blue ball throw count: {blueBall.GetThrowCount()}");

        // Print the grayscale value of the blue ball's color
        Console.WriteLine($"Blue ball color grayscale value: {blueColor.GetGrayscale()}");
    }
}