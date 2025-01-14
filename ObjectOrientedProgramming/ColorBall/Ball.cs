namespace OOP3;

public class Ball
{
    private int size;
    private Color bColor;
    private int throwCount;
    
    public Ball(int size, Color color)
    {
        this.size = size;
        this.bColor = color;
        throwCount = 0;
    }

    public void PopBall()
    {
       size = 0;
    }
    
    public void Throw()
    {
        if (size > 0)
        {
            throwCount++;
        }
    }

    public int GetThrowCount()
    {
        return throwCount;
    }
    


}