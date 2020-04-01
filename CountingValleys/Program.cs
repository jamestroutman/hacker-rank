using System;

namespace CountingValleys
{
    class Program
    {
        static int countingValleys(int n, string s) {
            int rise = 0;
            int valleys = 0;
            var belowSeaLevel = false;

            //Console.WriteLine(s);

            for (int i = 0; i < n; i++)
            {
                if(s[i] == 'U'){
                    rise++;
                }else
                {
                    rise--;

                    if(rise < 0){
                        belowSeaLevel = true;
                    }
                }
                //Console.WriteLine("rise: " + rise);

                if(rise == 0 && belowSeaLevel == true){
                    belowSeaLevel = false;
                    valleys++;
                }
            }

            return valleys;
        }
        static void Main(string[] args)
        {

        int n = 8;

        string s = "UDDDUDUU";

        int result = countingValleys(n, s);

        Console.WriteLine(result);
      }
    }
}
