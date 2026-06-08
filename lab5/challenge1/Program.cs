using System;

namespace challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLine line = null;
            int choice = 0;

            while ((choice = LineUI.Menu()) != 10)
            {
                if (choice == 1)
                {
                    MyPoint p1 = LineUI.TakePointInput("begin");
                    MyPoint p2 = LineUI.TakePointInput("end");
                    line = new MyLine(p1, p2);
                    LineUI.DisplayMessage("Line created!");
                }
                else if (line != null)
                {
                    if (choice == 2)
                    {
                        line.setBegin(LineUI.TakePointInput("new begin"));
                        LineUI.DisplayMessage("Begin point updated.");
                    }
                    else if (choice == 3)
                    {
                        line.setEnd(LineUI.TakePointInput("new end"));
                        LineUI.DisplayMessage("End point updated.");
                    }
                    else if (choice == 4)
                    {
                        LineUI.DisplayPoint("Begin", line.getBegin());
                    }
                    else if (choice == 5)
                    {
                        LineUI.DisplayPoint("End", line.getEnd());
                    }
                    else if (choice == 6)
                    {
                        LineUI.DisplayResult("Length of line", line.getLength());
                    }
                    else if (choice == 7)
                    {
                        LineUI.DisplayResult("Gradient of line", line.getGradient());
                    }
                    else if (choice == 8)
                    {
                        LineUI.DisplayResult("Distance of begin from origin", line.getBegin().distanceFromZero());
                    }
                    else if (choice == 9)
                    {
                        LineUI.DisplayResult("Distance of end from origin", line.getEnd().distanceFromZero());
                    }
                }
                else
                {
                    LineUI.DisplayMessage("Error: Please create a line first (Option 1).");
                }
            }
        }
    }
}