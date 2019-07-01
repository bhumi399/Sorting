using System;

public class Class1
{
	public static void Main(String[] args)
	{
		int[] arr = new int[] {5,40,80,65,87,43,9 };

		Array.Sort(arr);

		//Array.Reverse(arr);

		foreach (var i in arr)
		{
			Console.Write(i + " ");

		}

        Console.ReadLine();
	}
	
}
