//  
//  CraftServ.cs
//  
//  Author:
//       Caleb Gibbs <cmacgibbs@gmail.com>
// 
//  Copyright (c) 2011 Caleb Gibbs
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Threading;

namespace CraftServ
{
	public class CraftServ
	{
		public static void Main(string[] args)
		{
			new CraftServ();
		}
		public static bool isRunning = true;
		
		csConsole console;
		
		public CraftServ ()
		{
			csLogger.Init();
			console = new csConsole();
			for(int i=0; i<20; i++)
			{
				csLogger.Write("Testing " + i);
				Thread.Sleep(2000);
			}
		}
	}
}

