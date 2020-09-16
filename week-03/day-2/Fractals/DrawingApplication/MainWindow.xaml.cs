using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;
using System;
using System.Data.Common;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            /*
            int sideSize = 600;
            var height = Math.Sqrt(3)  * (sideSize*0.5);
            Point leftPoint = new Point(100, 100);
            Point rightPoint = new Point(700, 100);
            Point bottomPoint = new Point(400, 100 + height);
            TriangleFractals(foxDraw, 5, leftPoint, rightPoint, bottomPoint);
            */

            Point upperLeftCorner = new Point(100, 100);
            Point upperRightCorner = new Point(700, 100);
            Point lowerRightCorner = new Point(700, 700);
            Point lowerLeftCorner = new Point(100, 700);

            SquaresRecursion(foxDraw, 5, upperLeftCorner, upperRightCorner, lowerRightCorner, lowerLeftCorner);
        }
        private static Color RandomColor()
        {
            // pick random colors in loops
            var list = new List<Color> { Color.Parse("#8ecae6"), Color.Parse("#219ebc"), Color.Parse("#023047"), Color.Parse("#ffb703"), Color.Parse("#fb8500") };
            var colorNumber = new Random().Next(0, list.Count);
            var color = list[colorNumber];
            return color;
        }

        private void TriangleFractals(FoxDraw foxDraw, int level, Point leftPoint, Point rightPoint, Point bottomPoint)
        {
            if (level == 0)
            {
                foxDraw.DrawPolygon(new List<Point> { leftPoint, rightPoint, bottomPoint });
                foxDraw.SetFillColor(RandomColor());
            }
            else
            {
                Point leftMid = new Point((bottomPoint.X + leftPoint.X) / 2,(bottomPoint.Y + leftPoint.Y) / 2);
                Point rightMid = new Point((bottomPoint.X + rightPoint.X) / 2,(bottomPoint.Y + rightPoint.Y) / 2);
                Point topMid = new Point((leftPoint.X + rightPoint.X) / 2,(leftPoint.Y + rightPoint.Y) / 2);

                TriangleFractals(foxDraw, level - 1,rightMid, bottomPoint, leftMid);
                TriangleFractals(foxDraw, level - 1,leftMid, leftPoint, topMid);
                TriangleFractals(foxDraw, level - 1,rightMid, topMid, rightPoint);
            }
        }

        // Not finished yet //
        private void SquaresRecursion(FoxDraw foxDraw, int level, Point upperLeftCorner, Point upperRightCorner, Point lowerRightCorner, Point lowerLeftCorner)
         {
            if (level == 0)
            {
                foxDraw.DrawLine(upperLeftCorner, upperRightCorner);
                foxDraw.DrawLine( upperRightCorner,  lowerRightCorner);
                foxDraw.DrawLine( lowerLeftCorner,  lowerRightCorner);
                foxDraw.DrawLine( upperLeftCorner,  lowerLeftCorner);
                // foxDraw.SetFillColor(RandomColor());
            }
            else
            {
                Point upperLeftOneThird = new Point((upperRightCorner.X - upperLeftCorner.X)/2, upperLeftCorner.Y);
                Point upperLeft = new Point((upperRightCorner.X - upperLeftCorner.X) / 2, upperLeftCorner.Y);
                Point upperRightCorner = new Point(upperRightCorner.X, (lowerRightCorner.X - upperRightCorner.Y) / 2);
                Point bottomThird = new Point((lowerRightCorner.X - lowerLeftCorner.X)/2, lowerLeftCorner.Y);
                Point leftThird = new Point(upperLeftCorner.X, (lowerLeftCorner.Y - upperLeftCorner.Y)/2);

                SquaresRecursion(foxDraw, level - 1, upperLeftOneThird, bottomPoint, leftMid);
                SquaresRecursion(foxDraw, level - 1, leftMid, leftPoint, topMid);
                SquaresRecursion(foxDraw, level - 1, rightMid, topMid, rightPoint);
            }
         }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}