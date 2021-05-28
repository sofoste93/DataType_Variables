		using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType_Variables
{
	class Program
	{
		static void Main(string[] args)
		{
			byte aByte = 32;
			Console.WriteLine("A Byte: "+ aByte);

			sbyte aSByte = -16;
			Console.WriteLine("A smallByte: "+ aSByte);

			int aInt = -1987654320;
			Console.WriteLine("An integer: " + aInt);

			uint aUInt = 1987654320;
			Console.WriteLine("An uInteger: "+ aUInt);

			short aShort = -29876;
			Console.WriteLine("A short: " + aShort);

			ushort aUShort = 59999;
			Console.WriteLine("An uShort: " + aUShort);

			float aFloat = -66.56743f;
			Console.WriteLine("A float: " + aFloat);

			double aDouble = -1345.67643533424;
			Console.WriteLine("A double: " + aDouble);

			bool aBoolean = true;
			Console.WriteLine("A boolean: " + aBoolean);

			char aChar = 'S';
			Console.WriteLine("A character: " + aChar);

			string aString = "How big is God?";
			Console.WriteLine("A string: " + aString);

			string anotherString = "1234";
			Console.WriteLine("Another string: " + anotherString);

			int stringIntoInteger = int.Parse(anotherString);
			Console.WriteLine("Converted string: " + stringIntoInteger + 2);

			Console.ReadLine();
			Console.ReadKey();
		}
	}
}
