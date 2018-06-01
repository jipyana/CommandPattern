using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using CommandPattern;


namespace CommandPattern.Models
{
    //Receiver
    public class ShapeClassCommand : ICommand
    {

        public Rectangle Rect { get; set; }
        int maxLeft;
        int maxTop;

        public ShapeClassCommand(Rectangle rectangle, Grid Grid1)
        {
            this.Rect = rectangle;
            maxLeft =  Convert.ToInt32(Grid1.ActualWidth - rectangle.Width);
            maxTop = Convert.ToInt32(Grid1.ActualHeight - rectangle.Height);

        }

        public void Execute()
        {
            Random rand = new Random();
            Rect.Margin = new Thickness(rand.Next(maxLeft), rand.Next(maxTop), 0, 0);
        }

        public void Undo()
        {
            //Previous x or y position
            maxLeft =

        }





    }
}
