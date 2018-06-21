using System;
using System.Text;

public class Accumul 
{
	public static String Accum(string s) 
  {
     char t;
     var sb=new StringBuilder();
     for(int i=0;i<s.Length;i++){
     
       sb.Append(char.ToUpper(s[i]));
       t=char.ToLower(s[i]);
       
       for(int j=0;j<i;j++){
       sb.Append(t);
       }
       
       sb.Append('-');
       
     }
     sb.Remove(sb.Length-1,1);
     return sb.ToString();
  }
}