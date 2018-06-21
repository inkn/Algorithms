public class Solution {
    public int LengthOfLastWord(string s) {
            /*
            s=s.Trim();
            int a =s.LastIndexOf(' ') ;
            int l=s.Length;
            if ( a== -1&&l==0)
            {
                return 0;
            }
            else
            {
                return l-a-1;
            }*/
        int count=0;
        bool isOk=false;
        for(int i=s.Length-1;i>=0;i--){
            if(s[i].Equals(' ')&&!isOk)
                 continue;
            isOk=true;
            if(s[i].Equals(' ')) break;
            count++;   
        }
        return count;
        
        
    }
}