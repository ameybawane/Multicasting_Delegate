using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastingDelegates
{
    // Step 1: define a delegate
    public delegate void RectDelegate(double Width, double Height);
    internal class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of Rectangle: " + Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter of Rectangle: " + 2 * (Width * Height));
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            // Step 2: instantiating the delegate
            // creating instance of delegate
            // RectDelegate rd = new RectDelegate(rect.GetArea); // explicitly calling constructor
            RectDelegate rd = rect.GetArea;
            // calling second method
            rd += rect.GetPerimeter;
            // Step 3: now call the delegate by passing required parameter values,
            // so that intarnally the method which is bound with the delegate get executed.
            // rd(12.34, 56.78);
            rd.Invoke(12.34, 56.78);
            Console.WriteLine();
            rd.Invoke(47.34, 34.78);

            Console.ReadKey();
        }
    }
}
