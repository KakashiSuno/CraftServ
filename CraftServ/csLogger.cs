//  
//  csLogger.cs
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
using System.Collections.Generic;

namespace CraftServ
{
	public static class csLogger
	{
		static string[] log = new string[20];
		public static bool newMsg = false;
		
		public static string[] Log {get{return log;}}
		
		public static void Init()
		{
			for(int i=0; i<log.Length; i++)
				log[i] = "";
		}
		
		public static void Write(string msg)
		{
			string tmp = DateTime.Now.ToString("[HH:MM:ss] ") + msg;
			
			for(int i=0; i<log.Length; i++)
			{
				if(log[i].Length != 0)
				{
					if(i == log.Length-1)
					{
						cycle_log();
						log[i] = tmp;
					}
				}
				else
				{
					log[i] = tmp;
					break;
				}
			}
			newMsg = true;
		}
		
		static void cycle_log()
		{
			string tmp = "";
			
			for(int i=0; i<log.Length; i++)
			{
				tmp = log[i];
				log[i] = "";
				if(i != 0)
					log[i-1] = tmp;
			}
		}
	}
}

