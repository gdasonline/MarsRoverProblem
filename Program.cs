using System;
using System.Linq;

namespace MarsRover
{
    public class Program
    {
        static void Main(string[] args)
        {
			//Get the  first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are assumed to be 0,0.
			var maxPoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

			//Get the rover's position
			var startPositions = Console.ReadLine().Trim().Split(' ');
            Position position = new Position();

            if (startPositions.Count() == 3)
            {
                position.X = Convert.ToInt32(startPositions[0]);
                position.Y = Convert.ToInt32(startPositions[1]);
                position.Direction = (Directions)Enum.Parse(typeof(Directions), startPositions[2]);
            }

			//Get the series of instructions telling the rover how to explore the plateau.
			var moves = Console.ReadLine().ToUpper();

			//Process output for each rover should be its final co - ordinates and heading.

			try
            {
                position.StartMoving(maxPoints, moves);
                Console.WriteLine($"{position.X} {position.Y} {position.Direction.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
