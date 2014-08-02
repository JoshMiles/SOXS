using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
namespace Sangria
{
	public class Stage1
	{
		string FILENAME = "";
		string[] FILECONTENTS;
		List<string> lexemes = new List<string>();
	
		public void loadLexemes()
		{
			lexemes.Add ("class");
			lexemes.Add ("end");
			lexemes.Add("print");
		}
		
		public Stage1 (string FILE_PATH)
		{
			this.FILENAME = FILE_PATH;
		}
		public void start()
		{
			loadLexemes();
			FILECONTENTS = File.ReadAllLines (FILENAME);
			for(int lines = 0; lines < FILECONTENTS.Length; lines++)
			{
				string lexeme = "";
				if(lexeme.Contains(lexeme))
				{
					Console.WriteLine ("Lexeme found %1", lexeme);	
				}
				for(int characters = 0; characters < FILECONTENTS.Length; characters++)
				{	
					// the stream of characters
					lexeme = lexeme + FILECONTENTS[lines][characters];
				}
			}
		}
	}
}

