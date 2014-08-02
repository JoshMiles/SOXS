using System;

namespace Sangria
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if(args.Length == 0)
			{
				burnWitches(); // Burn them. All of them.	
			}
			
			// I should probably design some kind of syntax
			Stage1 stage1 = new Stage1(AppDomain.CurrentDomain.BaseDirectory + args[0]);
			stage1.start ();
		}
		
		public static void burnWitches()
		{
			Console.WriteLine ("Usage: sangria [input_file] [output.c]");
			Environment.Exit (0);
		}
	}
}
