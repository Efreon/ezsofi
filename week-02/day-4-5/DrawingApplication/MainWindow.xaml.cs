using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;
using System;


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

            FunctionToCenter(foxDraw);
        }

        private static Color RandomColor()
        {
            // pick random colors in loops
            var list = new List<Color> {Colors.Tomato, Colors.Yellow, Colors.Black, Colors.BurlyWood, Colors.Chocolate};
            // használhatunk dictionary-t is, ha meg akarjuk adni, hogy melyik színt használjuk
            var colorNumber = new Random().Next(0, list.Count);
            var color = list[colorNumber];
            return color;
        }

        private static Point middlePoint()
        {
            int canvasHeight = 800;
            int canvasWidth = 800;
            int middleX = canvasWidth / 2;
            int middleY = canvasHeight / 2;
            Point middlePoint = new Point(middleX, middleY);
            return middlePoint;
        }
 

        private void DrawLines(FoxDraw foxDraw)
        {
                foxDraw.SetBackgroundColor(Colors.Linen);
                // draw a red horizontal line to the canvas' middle.
                var startingPointHorizontal = new Point(0, 400);
                var endingPointHorizontal = new Point(800, 400);
                foxDraw.SetStrokeColor(Colors.Red);
                foxDraw.DrawLine(startingPointHorizontal, endingPointHorizontal);
                // draw a green vertical line to the canvas' middle.
                var startingPointVertical = new Point(400, 0);
                var endingPointVertical = new Point(400, 800);
                foxDraw.SetStrokeColor(Colors.ForestGreen);
                foxDraw.DrawLine(startingPointVertical, endingPointVertical);
        }

        private void  ColoredBox(FoxDraw foxDraw)
        {
            foxDraw.SetBackgroundColor(Colors.Azure);
            // Draw a box that has different colored lines on each edge.
            var pointA= new Point(200, 200);
            var pointB= new Point(600, 200);
            var pointC = new Point(600, 600);
            var pointD = new Point(200, 600);

            foxDraw.SetStrokeColor(RandomColor());
            foxDraw.DrawLine(pointA, pointB);

            foxDraw.SetStrokeColor(RandomColor());
            foxDraw.DrawLine(pointC, pointD);

            foxDraw.SetStrokeColor(RandomColor());
            foxDraw.DrawLine(pointA, pointD);

            foxDraw.SetStrokeColor(RandomColor());
            foxDraw.DrawLine(pointC, pointB);
        }

        private void Diagonals(FoxDraw foxDraw)
        {
            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.
            foxDraw.SetStrokeColor(Colors.Green);
            var startingPointDiagonalUL = new Point(0, 0);
            var endingPointDiagonalUL = new Point(800, 800);
            foxDraw.DrawLine(startingPointDiagonalUL, endingPointDiagonalUL);
            foxDraw.SetStrokeColor(Colors.Red);
            var startingPointDiagonalRL = new Point(800, 0);
            var endingPointDiagonalRL = new Point(0, 800);
            foxDraw.DrawLine(startingPointDiagonalRL, endingPointDiagonalRL);
        }

        private void GoToCenter(FoxDraw foxDraw,  int startingX, int startingY )
        {
            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Draw at least 3 lines with that function using a loop.
            for (int i= 1; i<= 3; i++)
            {
                foxDraw.SetStrokeColor(RandomColor());
                foxDraw.DrawLine(i*startingX, startingY, 400, 400);
            }
        }

        private void HorizontalLines(FoxDraw foxDraw, int startingX, int startingY)
        {
            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the foxDraw
            // and draws a 50 long horizontal line from that point.
            // Draw at least 3 lines with that function using a loop.
            int lineLength = 50;
            for (int i=1; i<= 3; i++)
            {
                foxDraw.SetStrokeColor(RandomColor());
                foxDraw.DrawLine(i*startingX, i*startingY, i*startingX + lineLength, i*startingY);
            }
        }

        private void CenteredSquare(FoxDraw foxDraw)
        {
            // Draw a green 10x10 square to the canvas' center.
            int canvasHeight = 800;
            int canvasWidth = 800;
            int middleX = canvasWidth / 2;
            int middleY = canvasHeight / 2;
            int sideSize = 10;
            int sideSizeHalf = sideSize / 2;
            int startingX = middleX- sideSizeHalf;
            int startingY = middleY - sideSizeHalf;

            foxDraw.SetStrokeColor(Colors.DarkOliveGreen);
            foxDraw.DrawRectangle(startingX, startingY, sideSize, sideSize);
        }

        private void FourRectangles(FoxDraw foxDraw)
        {
            // draw four different size and color rectangles.
            // avoid code duplication.
            int startingX = 50;
            int startingY = 50;
            int sideSize = 100;
            for (int i = 1; i <= 4; i++)
            {
                foxDraw.SetFillColor(RandomColor());
                foxDraw.DrawRectangle(i*startingX, i*startingY, i*sideSize, i*sideSize);
            }
        }

        private void PositionSquare(FoxDraw foxDraw, int startingX, int startingY)
        {
            // create a function that draws one square and takes 3 parameters:
            // the x and y coordinates of the square's top left corner
            // and the foxDraw and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.
            int sideSize = 50;
            for (int i=1; i<= 3; i++)
            {
                foxDraw.DrawRectangle(i*startingX, i*startingY, sideSize, sideSize);
            }
        }

        private void CenterBoxFunction(FoxDraw foxDraw, int sideSize)
        {
            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.
            
            for (int i=10; i>= 1; i--)
            {
                foxDraw.SetFillColor(RandomColor());
                int startingX = 400 - i*sideSize / 2;
                int startingY = 400 -i*sideSize / 2;
                foxDraw.DrawRectangle(startingX, startingY,  i*sideSize, i*sideSize);
            }
        }

        private void RainbowBoxFunction(FoxDraw foxDraw, int sideSize)
        {
            // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares (red, orange, yellow, green, blue, indigo, violet).
            // var colorNumber = new System.Random().Next(0, list.Count);
            // var colorRainbow = list[colorNumber];

            var list = new List<Color> { Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet };

            int middlePoint = 400;
            int halfSideSize = sideSize / 2;
            for (int i = list.Count-1; i>= 1; i--)
            {
                var colorNumber = i;
                var color = list[colorNumber];
                foxDraw.SetFillColor(color);
                foxDraw.DrawRectangle(middlePoint- i*halfSideSize, middlePoint-i*halfSideSize, i*sideSize, i*sideSize );
            }
        }

        private void PurpleSteps(FoxDraw foxDraw)
        {
            int startingX = 10;
            int startingY = 10;
            int sideSize = 10;
            for (int i = 1; i <= 18; i++)
            {
                foxDraw.SetFillColor(Colors.Purple);
                foxDraw.DrawRectangle(i * startingX, i * startingY, sideSize, sideSize);
            }
        }

        private void PurpleSteps3d(FoxDraw foxDraw)
        {
            int startingPoints = 10;
            int sideSize = 10;
            for (int i = 0; i <= 10; i++)
            {
                foxDraw.SetFillColor(Colors.Purple);
                foxDraw.DrawRectangle(startingPoints, startingPoints, i*sideSize, i*sideSize);
                startingPoints = startingPoints +i * sideSize;
            }
        }

        private void StarryNight(FoxDraw foxDraw)
        {
            // Draw the night sky:
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)

            foxDraw.SetBackgroundColor(Colors.Black);
            int sideSize = 5;
            int maxRandomNumber = 800 - sideSize;

            for (int i=0; i<=20; i++)
            {
                int randomStartingX = new Random().Next(0, maxRandomNumber);
                int randomStartingY = new Random().Next(0, maxRandomNumber);

                foxDraw.SetFillColor(Colors.LightGray);
                foxDraw.DrawRectangle(randomStartingX, randomStartingY, sideSize, sideSize);
            }
        }
        private void FunctionToCenter (FoxDraw foxDraw)
        {
            // Create a function that draws a single line and takes 3 parameters:
            // the x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Fill the canvas with lines from the edges, every 20 px, to the center.

            for (int x = 0; x <= 800; x+=20)
            {   
                if(x==0)
                {
                    for (int y = 0; y <= 800; y+=20)
                    {
                        foxDraw.DrawLine(x, y, 400, 400);
                    }
                }
                if (x>0 && x<800)
                {
                    foxDraw.DrawLine(x, 0, 400, 400);
                    foxDraw.DrawLine(x, 800, 400, 400);
                }
                if (x==800)
                {
                    for (int y = 800; y >= 0; y-=20)
                    {
                        foxDraw.DrawLine(x, y, 400, 400);
                    }
                }
            }
        }
        private void InitializeComponent()
        {
                AvaloniaXamlLoader.Load(this);
        }
    } 
}