using System.Collections;
using System.Text;

class MorseCodeDecoder
{

  public static string DecodeLetters(string[] letters) {
       var sb = new StringBuilder();
       foreach (var s in letters)
       {
            sb.Append(MorseCode.Get(s));
       }
      return sb.ToString();
  }
  public static string DecodeWords(string[] words) {
    var sb = new StringBuilder();
    foreach(var s in words) {
      sb.Append(DecodeLetters(s.Split(' '))).Append(' ');
    }
    return sb.ToString().Substring(0, sb.Length - 1);
  }  

	public static string Decode(string morseCode)
	{
	  return DecodeWords(morseCode.Trim().Split(new string[] {"   "}, System.StringSplitOptions.None));
	}
}