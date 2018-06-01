using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using CommandPattern;


namespace CommandPattern.Models
{
    //Receiver
    public class ShapeClassCommand : ICommand
    {

        public Rectangle Rect { get; set; }
        public Grid NewPosition { get; set; }
        public Grid OldPosition { get; set; }
        int maxLeft;
        int maxTop;

        public ShapeClassCommand(Rectangle rectangle, Grid oldPosition)
        {
            Rect = rectangle;
            OldPosition = oldPosition;
            //NewPosition = ((Canvas.GetLeft(rectangle), Canvas.GetTop(rectangle)));
        }

        public void Execute()
        {
            maxLeft = Convert.ToInt32(OldPosition.ActualWidth + Rect.Width);
            maxTop = Convert.ToInt32(OldPosition.ActualHeight + Rect.Height);
            Random rand = new Random();
            Rect.Margin = new Thickness(rand.Next(maxLeft), rand.Next(maxTop), 1, 1);
            Rect.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        public void Undo()
        {
            maxLeft = Convert.ToInt32(NewPosition.ActualWidth - Rect.Width);
            maxTop = Convert.ToInt32(NewPosition.ActualHeight - Rect.Height);
            Random rand = new Random();
            Rect.Margin = new Thickness(rand.Next(maxLeft ), rand.Next(maxTop), 0, 0);
            /*
             * Keep track of Color 
             * Keep track of OldPosition and New Position
             */

        }





    }
}
