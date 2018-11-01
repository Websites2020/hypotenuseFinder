using System;

public class Calculate
{
	public static void Main()
	{
		string strSide1, strSide2;
		int side1, side2;
		double answer;

		Console.Out.Write("This program finds the hypotenuse of a triangle.\n");
		Console.Out.Write("Enter the length of the first side: ");
		strSide1 = Console.ReadLine();
		side1 = Convert.ToInt32(strSide1);

		Console.Out.Write("Enter the length of the second side: ");
		strSide2 = Console.ReadLine();
		side2 = Convert.ToInt32(strSide2);

		answer = hypotenuse(side1, side2);

		Console.Out.Write("The hypotenuse of {0} and {1} is {2}.", side1, side2, answer);
	}

	public static double hypotenuse(int sideOne, int sideTwo)
	{
		double result;
		result = Math.Truncate(Math.Sqrt(Math.Pow(sideOne, 2) + Math.Pow(sideTwo, 2))*100) / 100;

		return result;
	}
}