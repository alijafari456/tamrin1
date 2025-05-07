using System;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal class Program
{
	private static void _003CMain_003E_0024(string[] args)
	{
		Console.Write("tedad dars ra vared konid ");
		float td = float.Parse(Console.ReadLine());
		float s = 0f;
		float j = 0f;
		for (int i = 1; (float)i <= td; i++)
		{
			Console.Write("tedad vahed dars {0}:", i);
			float vd = float.Parse(Console.ReadLine());
			Console.Write("nomre dars ra vared konid {0}:", i);
			float nd = float.Parse(Console.ReadLine());
			s += nd * vd;
			j += vd;
		}
		Console.Write(s / j);
	}
}
