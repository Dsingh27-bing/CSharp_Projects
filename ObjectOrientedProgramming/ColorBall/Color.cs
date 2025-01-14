namespace OOP3;

public class Color
{
    private int red;
    private int green;
    private int blue;
    private int alpha;
    
    public Color(int red, int green, int blue, int alpha)
    {
        this.red = ValidateColorValue(red);
        this.green = ValidateColorValue(green);
        this.blue = ValidateColorValue(blue);
        this.alpha = ValidateColorValue(alpha);
    }

    // Constructor with red, green, blue (alpha defaults to 255)
    public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

    // Get and set methods for red, green, blue, and alpha
    public int GetRed() => red;
    public void SetRed(int red) => this.red = ValidateColorValue(red);

    public int GetGreen() => green;
    public void SetGreen(int green) => this.green = ValidateColorValue(green);

    public int GetBlue() => blue;
    public void SetBlue(int blue) => this.blue = ValidateColorValue(blue);

    public int GetAlpha() => alpha;
    public void SetAlpha(int alpha) => this.alpha = ValidateColorValue(alpha);

    // Method to calculate grayscale value (average of red, green, and blue)
    public int GetGrayscale()
    {
        return (red + green + blue) / 3;
    }

    // Helper method to validate color values (0-255)
    private int ValidateColorValue(int value)
    {
        if (value < 0 || value > 255)
        {
            throw new ArgumentException("Color values must be between 0 and 255.");
        }
        return value;
    }
}