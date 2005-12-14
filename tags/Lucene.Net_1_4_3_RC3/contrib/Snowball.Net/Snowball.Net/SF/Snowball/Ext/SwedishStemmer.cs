/* 
 * Copyright 2004 The Apache Software Foundation
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

// This file was generated automatically by the Snowball to Java compiler
using System;
using Among = SF.Snowball.Among;
using SnowballProgram = SF.Snowball.SnowballProgram;
namespace SF.Snowball.Ext
{
	
	/// <summary> Generated class implementing code defined by a snowball script.</summary>
	public class SwedishStemmer : SnowballProgram
	{
		public SwedishStemmer()
		{
			InitBlock();
		}
		private void  InitBlock()
		{
			a_0 = new Among[]{new Among("a", - 1, 1, "", this), new Among("arna", 0, 1, "", this), new Among("erna", 0, 1, "", this), new Among("heterna", 2, 1, "", this), new Among("orna", 0, 1, "", this), new Among("ad", - 1, 1, "", this), new Among("e", - 1, 1, "", this), new Among("ade", 6, 1, "", this), new Among("ande", 6, 1, "", this), new Among("arne", 6, 1, "", this), new Among("are", 6, 1, "", this), new Among("aste", 6, 1, "", this), new Among("en", - 1, 1, "", this), new Among("anden", 12, 1, "", this), new Among("aren", 12, 1, "", this), new Among("heten", 12, 1, "", this), new Among("ern", - 1, 1, "", this), new Among("ar", - 1, 1, "", this), new Among("er", - 1, 1, "", this), new Among("heter", 18, 1, "", this), new Among("or", - 1, 1, "", this), new Among("s", - 1, 2, "", this), new Among("as", 21, 1, "", this), new Among("arnas", 22, 1, "", this), new Among("ernas", 22, 1, "", this), new Among("ornas", 22, 1, "", this), new Among("es", 21, 1, "", this), new Among("ades", 26, 1, "", this), new Among("andes", 26, 1, "", this), new Among("ens", 21, 1, "", this), new Among("arens", 29, 1, "", this), new Among("hetens", 29, 1, "", this), new Among("erns", 21, 1, "", this), new Among("at", - 1, 1, "", this), new Among("andet", - 1, 1, "", this), new Among("het", - 1, 1, "", this), new Among("ast", - 1, 1, "", this)};
			a_1 = new Among[]{new Among("dd", - 1, - 1, "", this), new Among("gd", - 1, - 1, "", this), new Among("nn", - 1, - 1, "", this), new Among("dt", - 1, - 1, "", this), new Among("gt", - 1, - 1, "", this), new Among("kt", - 1, - 1, "", this), new Among("tt", - 1, - 1, "", this)};
			a_2 = new Among[]{new Among("ig", - 1, 1, "", this), new Among("lig", 0, 1, "", this), new Among("els", - 1, 1, "", this), new Among("fullt", - 1, 3, "", this), new Among("l\u00F6st", - 1, 2, "", this)};
		}
		
		private Among[] a_0;
		private Among[] a_1;
		private Among[] a_2;
		private static readonly char[] g_v = new char[]{(char) (17), (char) (65), (char) (16), (char) (1), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (24), (char) (0), (char) (32)};
		private static readonly char[] g_s_ending = new char[]{(char) (119), (char) (127), (char) (149)};
		
		private int I_p1;
		
		protected internal virtual void  copy_from(SwedishStemmer other)
		{
			I_p1 = other.I_p1;
			base.copy_from(other);
		}
		
		private bool r_mark_regions()
		{
			int v_1;
			// (, line 26
			I_p1 = limit;
			// goto, line 30
			while (true)
			{
				v_1 = cursor;
				do 
				{
					if (!(in_grouping(g_v, 97, 246)))
					{
						goto lab1_brk;
					}
					cursor = v_1;
					goto golab0_brk;
				}
				while (false);

lab1_brk: ;
				
				cursor = v_1;
				if (cursor >= limit)
				{
					return false;
				}
				cursor++;
			}

golab0_brk: ;
			
			// gopast, line 30
			while (true)
			{
				do 
				{
					if (!(out_grouping(g_v, 97, 246)))
					{
						goto lab3_brk;
					}
					goto golab2_brk;
				}
				while (false);

lab3_brk: ;
				
				if (cursor >= limit)
				{
					return false;
				}
				cursor++;
			}

golab2_brk: ;
			
			// setmark p1, line 30
			I_p1 = cursor;
			// try, line 31
			do 
			{
				// (, line 31
				if (!(I_p1 < 3))
				{
					goto lab4_brk;
				}
				I_p1 = 3;
			}
			while (false);

lab4_brk: ;
			
			return true;
		}
		
		private bool r_main_suffix()
		{
			int among_var;
			int v_1;
			int v_2;
			// (, line 36
			// setlimit, line 37
			v_1 = limit - cursor;
			// tomark, line 37
			if (cursor < I_p1)
			{
				return false;
			}
			cursor = I_p1;
			v_2 = limit_backward;
			limit_backward = cursor;
			cursor = limit - v_1;
			// (, line 37
			// [, line 37
			ket = cursor;
			// substring, line 37
			among_var = find_among_b(a_0, 37);
			if (among_var == 0)
			{
				limit_backward = v_2;
				return false;
			}
			// ], line 37
			bra = cursor;
			limit_backward = v_2;
			switch (among_var)
			{
				
				case 0: 
					return false;
				
				case 1: 
					// (, line 44
					// delete, line 44
					slice_del();
					break;
				
				case 2: 
					// (, line 46
					if (!(in_grouping_b(g_s_ending, 98, 121)))
					{
						return false;
					}
					// delete, line 46
					slice_del();
					break;
				}
			return true;
		}
		
		private bool r_consonant_pair()
		{
			int v_1;
			int v_2;
			int v_3;
			// setlimit, line 50
			v_1 = limit - cursor;
			// tomark, line 50
			if (cursor < I_p1)
			{
				return false;
			}
			cursor = I_p1;
			v_2 = limit_backward;
			limit_backward = cursor;
			cursor = limit - v_1;
			// (, line 50
			// and, line 52
			v_3 = limit - cursor;
			// among, line 51
			if (find_among_b(a_1, 7) == 0)
			{
				limit_backward = v_2;
				return false;
			}
			cursor = limit - v_3;
			// (, line 52
			// [, line 52
			ket = cursor;
			// next, line 52
			if (cursor <= limit_backward)
			{
				limit_backward = v_2;
				return false;
			}
			cursor--;
			// ], line 52
			bra = cursor;
			// delete, line 52
			slice_del();
			limit_backward = v_2;
			return true;
		}
		
		private bool r_other_suffix()
		{
			int among_var;
			int v_1;
			int v_2;
			// setlimit, line 55
			v_1 = limit - cursor;
			// tomark, line 55
			if (cursor < I_p1)
			{
				return false;
			}
			cursor = I_p1;
			v_2 = limit_backward;
			limit_backward = cursor;
			cursor = limit - v_1;
			// (, line 55
			// [, line 56
			ket = cursor;
			// substring, line 56
			among_var = find_among_b(a_2, 5);
			if (among_var == 0)
			{
				limit_backward = v_2;
				return false;
			}
			// ], line 56
			bra = cursor;
			switch (among_var)
			{
				
				case 0: 
					limit_backward = v_2;
					return false;
				
				case 1: 
					// (, line 57
					// delete, line 57
					slice_del();
					break;
				
				case 2: 
					// (, line 58
					// <-, line 58
					slice_from("l\u00F6s");
					break;
				
				case 3: 
					// (, line 59
					// <-, line 59
					slice_from("full");
					break;
				}
			limit_backward = v_2;
			return true;
		}
		
		public virtual bool Stem()
		{
			int v_1;
			int v_2;
			int v_3;
			int v_4;
			// (, line 64
			// do, line 66
			v_1 = cursor;
			do 
			{
				// call mark_regions, line 66
				if (!r_mark_regions())
				{
					goto lab0_brk;
				}
			}
			while (false);

lab0_brk: ;
			
			cursor = v_1;
			// backwards, line 67
			limit_backward = cursor; cursor = limit;
			// (, line 67
			// do, line 68
			v_2 = limit - cursor;
			do 
			{
				// call main_suffix, line 68
				if (!r_main_suffix())
				{
					goto lab1_brk;
				}
			}
			while (false);

lab1_brk: ;
			
			cursor = limit - v_2;
			// do, line 69
			v_3 = limit - cursor;
			do 
			{
				// call consonant_pair, line 69
				if (!r_consonant_pair())
				{
					goto lab2_brk;
				}
			}
			while (false);

lab2_brk: ;
			
			cursor = limit - v_3;
			// do, line 70
			v_4 = limit - cursor;
			do 
			{
				// call other_suffix, line 70
				if (!r_other_suffix())
				{
					goto lab3_brk;
				}
			}
			while (false);

lab3_brk: ;
			
			cursor = limit - v_4;
			cursor = limit_backward; return true;
		}
	}
}
