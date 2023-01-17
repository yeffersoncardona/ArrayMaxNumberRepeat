using System;

namespace MayorNumArray
{
    class Program
    {
		static int[] myArray = { 1, 2, 2, 4, 5, 6, 7, 8, 8, 8 };
		public static void Main(string[] args)
        {
			
				int maxSec = 1;
				int maxSecAux = 1;
				int numMaxSec = 0;
				int numAux = 0;
				for (int i = 0; i < myArray.Length; i++)
				{
					if (myArray[i] == numAux)
					{
						maxSecAux += 1;
					}
					else
					{
						maxSecAux = 0;
					}

					if (maxSecAux > maxSec)
					{
						maxSec = maxSecAux;
						numMaxSec = myArray[i];
					}
					numAux = myArray[i];
			    }
				Console.WriteLine("Longest: " + (maxSec + 1));
				Console.WriteLine("Number: " + numMaxSec);

			
		}
    }
}
