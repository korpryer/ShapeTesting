using System;
using System.Windows.Forms;

namespace Shapes
{
    class main
    {

        private static int handleShape()
        {
            string shapeColor = string.Empty;
            shape tempShape = null;

            Console.WriteLine("Enter the color of the shape");

            shapeColor = Console.ReadLine();
            tempShape = new shape(shapeColor);

            Console.WriteLine("Set Shape Color to {0}", tempShape.getColor());

            return 0;
        }

        private static int handleSquare()
        {
            int squareSize = new int();
            string squareColor = string.Empty;
            square tempSquare = new square();

            Console.WriteLine("Enter the size of the square");
            
            if(int.TryParse(Console.ReadLine(), out squareSize))
            { 
                tempSquare.setSquareSize(squareSize);
            }

            Console.WriteLine("Enter the color of the square");
            squareColor = Console.ReadLine();

            tempSquare.setSquareColor(squareColor);

            Console.WriteLine("Square size is {0} and square color is {1}", tempSquare.getColor(), tempSquare.getSquareSize());
            
            return 0;
        }

        private static int handleQuadrilateral()
        {
            string quadColor = string.Empty;
            quadrilateral tempQuad = new quadrilateral();

            Console.WriteLine("What color is the quadrilateral?");
            quadColor = Console.ReadLine();

            tempQuad.setColor(quadColor);

            Console.WriteLine("Quad Info: Size 1 {0}, Size 2 {1}, Size 3 {2}, Size 4 {3}, Color {4}", tempQuad.getSide1Len(), tempQuad.getSide2Len(), tempQuad.getSide2Len(), tempQuad.getSide4Len(), tempQuad.getColor());

            return 0;
        }

        static int Main()
        {
            string shape = string.Empty;
            bool endOfProgram = false;

            while (!endOfProgram)
            {
                Console.WriteLine("Welcome to the Shapes Class");
                Console.WriteLine("Please enter a shape to create: Shape, Quadrilateral, Square or Type end to exit");
                shape = Console.ReadLine();

                switch (shape)
                {
                    case "Shape":
                        handleShape();
                        break;
                    case "Square":
                        handleSquare();
                        break;
                    case "Quadrilateral":
                        handleQuadrilateral();
                        break;
                    case "end":
                        endOfProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
            }

            return 0;
        }
    }

    class shape
    {
        private string color;

        public shape()
        {
            this.color = "Blue";
            return;
        }

       public shape(string color)
        {
            if (color != string.Empty)
            {
                this.color = color;
            }

            return;
        }

        public int setColor(string color)
        {
            if (color != string.Empty)
            {
                this.color = color;
            }

            return 0;
        }

        public string getColor()
        {
            return this.color;
        }
    }


    class quadrilateral : shape
    { 
        private int side1Len = 4;
        private int side2Len = 4;
        private int side3Len = 4;
        private int side4Len = 4;

        public quadrilateral()
        {
            this.setColor("Blue");
            return;
        }

        public quadrilateral(string color)
        {
            if (!color.Equals(string.Empty))
            {
                this.setColor(color);
            }

            return;
        }

        public int getSide1Len()
        {
            return this.side1Len;
        }

        public int getSide2Len()
        {
            return this.side2Len;
        }

        public int getSide3Len()
        {
            return this.side3Len;
        }

        public int getSide4Len()
        {
            return this.side4Len;
        }

        protected int setSide1Len(int length)
        {
            if (length > 0)
            {
                this.side1Len = length;
            }

            return 0;
        }

        protected int setSide2Len(int length)
        {
            if (length > 0)
            {
                this.side2Len = length;
            }

            return 0;
        }

        protected int setSide3Len(int length)
        {
            if (length > 0)
            {
                this.side3Len = length;
            }

            return 0;
        }

        protected int setSide4Len(int length)
        {
            if (length > 0)
            {
                this.side4Len = length;
            }

            return 0;
        }
    }

    class square :quadrilateral
    {
       public square()
       {
            this.setColor("Blue");
            this.setSide1Len(1);
            this.setSide2Len(1);
            this.setSide3Len(1);
            this.setSide4Len(1);
       }

        public square(string color)
        {
            if (!color.Equals(string.Empty))
            {
                this.setColor(color);
            }

            this.setSide1Len(1);
            this.setSide2Len(1);
            this.setSide3Len(1);
            this.setSide4Len(1);
        }

        public square(int length)
        {
            this.setColor("Blue");

            if (length > 0)
            {
                this.setSide1Len(length);
                this.setSide2Len(length);
                this.setSide3Len(length);
                this.setSide4Len(length);
            }
        }

        public square(string color, int length)
        {
            if (!color.Equals(string.Empty))
            {
                this.setColor(color);
            }

            if (length > 0)
            {
                this.setSide1Len(length);
                this.setSide2Len(length);
                this.setSide3Len(length);
                this.setSide4Len(length);
            }
        }

        public int setSquareSize(int length)
        {
            if (length > 0)
            {
                this.setSide1Len(length);
                this.setSide2Len(length);
                this.setSide3Len(length);
                this.setSide4Len(length);
            }

            return 0;
        }

        public int setSquareColor(string color)
        {
            if (!color.Equals(string.Empty))
            {
                this.setColor(color);
            }
            return 0;
        }

        public int getSquareSize()
        {
            return this.getSide1Len();
        }
    }

}
