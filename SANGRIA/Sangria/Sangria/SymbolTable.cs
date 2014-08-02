using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Sangria
{
	public class SymbolTable
	{
		Dictionary<string, string> symbols = new Dictionary<string, string>();
		public void Add(string key, string _value)
		{
			symbols.Add (key, _value);	
		}
		public string Lookup(string name)
		{
			for(int i = 0; i < symbols.Count; i++)
			{
				
				{
				//	return symbols[i][name];
				}
			}
			return null;
		}
		public void ClearTable()
		{
			symbols.Clear ();
		}
	}
}

