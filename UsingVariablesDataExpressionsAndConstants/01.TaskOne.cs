using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Size
{
    private double width;
    private double height;

	public Size()
    {

    }
    public Size(double initialWidth, double initialHeight)
    {
        this.Width = initialWidth;
        this.Height = initialHeight;
    }

	public double Width
    {
        get
        {
            return this.width;
        }
        set
        {
            if (value < 0 || value == null)
            {
                throw new ArgumentNullException("The width cannot be null negative");
            }
			this.width = value;
        }
    }

	public double Height
    {
        get
        {
            return this.height;
        }
        set
        {
            if (value < 0 || value == null)
            {
                throw new ArgumentNullException("The height cannot be null negative");
            }
			this.height = value;
        }
    }


    public static Size GetRotatedSize(Size sizeOfTheFigure, double angleOfTheFigure)
    {
		double sinOfTheAngle = Math.Abs(Math.Sin(angleOfTheFigure));
		double cosOfTheAngle = Math.Abs(Math.Cos(angleOfTheFigure));
		double newWidth = cosOfTheAngle * sizeOfTheFigure.width + sinOfTheAngle * sizeOfTheFigure.height;
		double newHeight = sinOfTheAngle * sizeOfTheFigure.width + cosOfTheAngle * sizeOfTheFigure.height;
        return new Size(newWidth, newHeight);
          
    }
}



