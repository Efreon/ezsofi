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

            LinePlay(foxDraw);
        }

        private static Color RandomColor()
        {
            // pick random colors in loops
            var list = new List<Color> { Colors.Tomato, Colors.Yellow, Colors.Black, Colors.BurlyWood, Colors.Chocolate };
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

        private void ColoredBox(FoxDraw foxDraw)
        {
            foxDraw.SetBackgroundColor(Colors.Azure);
            // Draw a box that has different colored lines on each edge.
            var pointA = new Point(200, 200);
            var pointB = new Point(600, 200);
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

        private void GoToCenter(FoxDraw foxDraw, int startingX, int startingY)
        {
            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Draw at least 3 lines with that function using a loop.
            for (int i = 1; i <= 3; i++)
            {
                foxDraw.SetStrokeColor(RandomColor());
                foxDraw.DrawLine(i * startingX, startingY, 400, 400);
            }
        }

        private void HorizontalLines(FoxDraw foxDraw, int startingX, int startingY)
        {
            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the foxDraw
            // and draws a 50 long horizontal line from that point.
            // Draw at least 3 lines with that function using a loop.
            int lineLength = 50;
            for (int i = 1; i <= 3; i++)
            {
                foxDraw.SetStrokeColor(RandomColor());
                foxDraw.DrawLine(i * startingX, i * startingY, i * startingX + lineLength, i * startingY);
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
            int startingX = middleX - sideSizeHalf;
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
                foxDraw.DrawRectangle(i * startingX, i * startingY, i * sideSize, i * sideSize);
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
            for (int i = 1; i <= 3; i++)
            {
                foxDraw.DrawRectangle(i * startingX, i * startingY, sideSize, sideSize);
            }
        }

        private void CenterBoxFunction(FoxDraw foxDraw, int sideSize)
        {
            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            for (int i = 10; i >= 1; i--)
            {
                foxDraw.SetFillColor(RandomColor());
                int startingX = 400 - i * sideSize / 2;
                int startingY = 400 - i * sideSize / 2;
                foxDraw.DrawRectangle(startingX, startingY, i * sideSize, i * sideSize);
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
            for (int i = list.Count - 1; i >= 1; i--)
            {
                var colorNumber = i;
                var color = list[colorNumber];
                foxDraw.SetFillColor(color);
                foxDraw.DrawRectangle(middlePoint - i * halfSideSize, middlePoint - i * halfSideSize, i * sideSize, i * sideSize);
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
                foxDraw.DrawRectangle(startingPoints, startingPoints, i * sideSize, i * sideSize);
                startingPoints = startingPoints + i * sideSize;
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

                for (int i = 0; i <= 20; i++)
                {
                    int randomStartingX = new Random().Next(0, maxRandomNumber);
                    int randomStartingY = new Random().Next(0, maxRandomNumber);

                    foxDraw.SetFillColor(Colors.LightGray);
                    foxDraw.DrawRectangle(randomStartingX, randomStartingY, sideSize, sideSize);
                }
            }
            private void FunctionToCenter(FoxDraw foxDraw)
            {
                // Create a function that draws a single line and takes 3 parameters:
                // the x and y coordinates of the line's starting point and the
                // foxDraw and draws a line from that point to the center of the
                // canvas.
                // Fill the canvas with lines from the edges, every 20 px, to the center.

                for (int x = 0; x <= 800; x += 20)
                {
                    if (x == 0)
                    {
                        for (int y = 0; y <= 800; y += 20)
                        {
                            foxDraw.DrawLine(x, y, 400, 400);
                        }
                    }
                    if (x > 0 && x < 800)
                    {
                        foxDraw.DrawLine(x, 0, 400, 400);
                        foxDraw.DrawLine(x, 800, 400, 400);
                    }
                    if (x == 800)
                    {
                        for (int y = 800; y >= 0; y -= 20)
                        {
                            foxDraw.DrawLine(x, y, 400, 400);
                        }
                    }
                }
            }
            private void drawBoxes(FoxDraw foxDraw, int columnCount, int rowsCount, int boxSize)
            {
                var yOffset = -0.5 * boxSize;

                for (int row = 0; row < rowsCount; row++)
                {
                    for (int i = 0; i < columnCount; i++)
                    {
                        if (row % 2 == 0)
                        {
                            drawBox(foxDraw, boxSize, new Point(i * (boxSize * Math.Sqrt(3)), yOffset + row * 1.5 * boxSize));
                        }
                        else
                        {
                            drawBox(foxDraw, boxSize, new Point(i * (boxSize * Math.Sqrt(3)) + boxSize * Math.Sqrt(3) / 2, yOffset + row * 1.5 * boxSize));
                        }

                    }
                }
            }

            private void drawBox(FoxDraw foxDraw, double boxSize, Point startingPoint)
            {
                var xAdjustment = Math.Sqrt(3) / 2 * boxSize;
                Point a = new Point(+startingPoint.X, +startingPoint.Y);
                Point b = new Point(xAdjustment + startingPoint.X, 0.5 * boxSize + startingPoint.Y);
                Point c = new Point(xAdjustment + startingPoint.X, 1.5 * boxSize + startingPoint.Y);
                Point d = new Point(+startingPoint.X, 2 * boxSize + startingPoint.Y);
                Point e = new Point(-xAdjustment + startingPoint.X, 1.5 * boxSize + startingPoint.Y);
                Point f = new Point(-xAdjustment + startingPoint.X, 0.5 * boxSize + startingPoint.Y);

                Point center = new Point(0, boxSize);

                List<Point> vertices = new List<Point> { a, b, c, d, e, f, center };
                for (int i = 0; i < vertices.Count; i++)
                {
                    vertices[i] = new Point(vertices[i].X + startingPoint.X, vertices[i].Y + startingPoint.Y);
                }

                foxDraw.SetFillColor(Color.Parse("FFA400"));
                foxDraw.DrawPolygon(new List<Point> { a, b, center, f, a });

                foxDraw.SetFillColor(Color.Parse("#078388"));
                foxDraw.DrawPolygon(new List<Point> { b, c, d, center, b });

                foxDraw.SetFillColor(Color.Parse("#078397"));
                foxDraw.DrawPolygon(new List<Point> { center, d, e, a, center });
            }

            private void EnvelopeStar(FoxDraw foxDraw)
            {

                for (int i = 0; i <= 800; i += 20)
                {
                    foxDraw.SetStrokeColor(Color.Parse("#232528"));
                    foxDraw.DrawLine(400, 0, i, 400);
                    foxDraw.SetStrokeColor(Color.Parse("#232528"));
                    foxDraw.DrawLine(400, 800, i, 400);
                    if (i != 400)
                    {
                        foxDraw.SetStrokeColor(Color.Parse("#232528"));
                        foxDraw.DrawLine(0, 400, 400, i);
                        foxDraw.SetStrokeColor(Color.Parse("#232528"));
                        foxDraw.DrawLine(800, 400, 400, i);
                    }

                    foxDraw.SetStrokeColor(Color.Parse("#232528"));
                    foxDraw.SetFillColor(Colors.White);
                    foxDraw.DrawEllipse(-400, -400, 800, 800);

                    foxDraw.SetStrokeColor(Color.Parse("#232528"));
                    foxDraw.SetFillColor(Colors.White);
                    foxDraw.DrawEllipse(400, -400, 800, 800);


                    foxDraw.SetStrokeColor(Color.Parse("#232528"));
                    foxDraw.SetFillColor(Colors.White);
                    foxDraw.DrawEllipse(-400, 400, 800, 800);

                    foxDraw.SetStrokeColor(Color.Parse("#232528"));
                    foxDraw.SetFillColor(Colors.White);
                    foxDraw.DrawEllipse(400, 400, 800, 800);
                }

            }

            private void EnvelopeStar2(FoxDraw foxDraw)
            {

            int lineTchickness = 2;
                for (int i = 0; i <= 800; i += 20)
                {
                foxDraw.SetStrokeThicknes(lineTchickness);
                    foxDraw.SetStrokeColor(Color.Parse("#232528"));
                    foxDraw.DrawLine(400, 0, i, 400);
                    foxDraw.SetStrokeColor(Color.Parse("#232528"));
                    foxDraw.DrawLine(400, 800, i, 400);
                    if (i != 400)
                    {
                    foxDraw.SetStrokeThicknes(lineTchickness);
                    foxDraw.SetStrokeColor(Color.Parse("#232528"));
                        foxDraw.DrawLine(0, 400, 400, i);
                        foxDraw.SetStrokeColor(Color.Parse("#232528"));
                        foxDraw.DrawLine(800, 400, 400, i);
                    }

                foxDraw.SetStrokeThicknes(lineTchickness);
                int circleSize = 800;
                    int circleMiddlePoint = 400;
                    foxDraw.SetStrokeColor(Color.Parse("#232528"));
                    foxDraw.SetFillColor(Colors.White);
                    foxDraw.DrawEllipse(-circleMiddlePoint, -circleMiddlePoint, circleSize, circleSize);

                foxDraw.SetStrokeThicknes(lineTchickness);
                foxDraw.SetStrokeColor(Color.Parse("#232528"));
                    foxDraw.SetFillColor(Colors.White);
                    foxDraw.DrawEllipse(circleMiddlePoint, -circleMiddlePoint, circleSize, circleSize);


                    foxDraw.SetStrokeColor(Color.Parse("#232528"));
                    foxDraw.SetFillColor(Colors.White);
                    foxDraw.DrawEllipse(-circleMiddlePoint, circleMiddlePoint, circleSize, circleSize);

                    foxDraw.SetStrokeColor(Color.Parse("#232528"));
                    foxDraw.SetFillColor(Colors.White);
                    foxDraw.DrawEllipse(circleMiddlePoint, circleMiddlePoint, circleSize, circleSize);
                }

            }
            
            private void LinePlay(FoxDraw foxDraw)
            {
            int lineThickness = 2;
            foxDraw.SetStrokeThicknes(lineThickness);
            foxDraw.SetStrokeColor(Color.Parse("#02111B"));
            // top-left to bottom right
                for (int i = 0; i <= 800; i += 30)
                {
                    foxDraw.DrawLine(0, 0, 800, i);
                }
                // bottom right to top-left
                for (int i = 0; i <= 800; i += 30)
                {
                    foxDraw.DrawLine(800, 800, i, 0);
                }

            foxDraw.SetStrokeThicknes(lineThickness);
            foxDraw.SetStrokeColor(Color.Parse("#5D737E"));
            // left top to bottom right
            for (int i = 0; i <= 800; i += 30)
                {
                    foxDraw.DrawLine(0, 0, i, 800);
                }
            
                // left top to bottom right
                for (int i = 0; i <= 800; i += 30)
                {
                    foxDraw.DrawLine(800, 800, 0, i);
                }
            
                // middle Ellipse

                // Draw ellipse to screen.
                //foxDraw.DrawEllipse( 0, 0, 100, 100);


            }
            

            private void InitializeComponent()
            {
                AvaloniaXamlLoader.Load(this);
            }
        }
    } 