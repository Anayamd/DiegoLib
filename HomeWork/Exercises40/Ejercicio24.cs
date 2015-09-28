using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio24
{
	static void Main(string[] args)
	{
		int[] nums = Basics.getArray (3);

		for (int i = 1; i < nums.Length; i++) {
			int key = nums [i];
			int j = i - 1;
			while (j >= 0 && nums[j]>key) {
				nums [j + 1] = nums [j];
				j--;
			}
			nums [j + 1] = key;
		}

		Console.WriteLine ();
		foreach (int item in nums) {
			Console.Write ("{0} ", item);
		}
		Console.WriteLine ();

		Console.Read ();
	}
}
