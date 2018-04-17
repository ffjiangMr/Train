using System;
using System.Text.RegularExpressions;
using System.Threading;

public class Form1
{


    public static void Main()
    {
        String time = "2019/11/11 23:59";
        DateTime test;
        DateTime.TryParse(time, out test);
        Console.WriteLine(test.ToString("yyyy/M/d HH:mm"));


        String patterm1 = @"                                                       
    .---- -. -. .  .   .                               
   ( .',----- - - ' '                                  
    \_/      ;--:-\         __--------------------__   
   __U__n_^_''__[. |ooo___  | |_!_||_!_||_!_||_!_| |   
 c(_ ..(_ ..(_ ..( /,,,,,,] | |___||___||___||___| |   
   \___________'_|,L______],|______________________|   
   (@)(@)__(@)(@)  (@)__(@)      (@)^(@)__(@)^(@)       ";
        String patterm2 = @"                                                       
    .---- -. -. .  .   .                               
   ( .',----- - - ' '                                  
    \_/      ;--:-\         __--------------------__   
   __U__n_^_''__[. |ooo___  | |_!_||_!_||_!_||_!_| |   
 c(_ ..(_ ..(_ ..( /,,,,,,] | |___||___||___||___| |   
   \___________'_|,L______],|______________________|   
   (@)(@)--(@)(@)  (@)--(@)      (@)^(@)--(@)^(@)       ";
        String patterm3 = @"                                                       
    .---- -. -. .  .   .                               
   ( .',----- - - ' '                                  
    \_/      ;--:-\         __--------------------__   
   __U__n_^_''__[. |ooo___  | |_!_||_!_||_!_||_!_| |   
 c(_ ..(_ ..(_ ..( /,,,,,,] | |___||___||___||___| |   
   \___________'_|,L______],|______________________|   
   (@)(@)~~(@)(@)  (@)~~(@)      (@)^(@)~~(@)^(@)       ";
        String patterm4 = @"                                                       
    .---- -. -. .  .   .                               
   ( .',----- - - ' '                                  
    \_/      ;--:-\         __--------------------__   
   __U__n_^_''__[. |ooo___  | |_!_||_!_||_!_||_!_| |   
 c(_ ..(_ ..(_ ..( /,,,,,,] | |___||___||___||___| |   
   \___________'_|,L______],|______________________|   
   (@)(@)--(@)(@)  (@)--(@)      (@)^(@)--(@)^(@)       ";
        String temp = "                                                                                                                                                                                       ";
        String[] array = new String[] { patterm1, patterm2, patterm3, patterm4 };
        Int32 valueIndex = 0;
        Int32 dely = 200;
        while (true)
        {
            for (Int32 flag = 0; flag < temp.Length; flag++)
            {
                var values = array[valueIndex++].Split(new String[] { "\r\n" }, StringSplitOptions.None);
                foreach (var item in values)
                {
                    if (!String.IsNullOrEmpty(item))
                    {
                        Console.WriteLine(temp.Substring(flag) + item);
                    }
                }
                Thread.Sleep(100);
                Console.Clear();
                //if (dely < 80)
                //{
                //    dely = 80;
                //}
                if (valueIndex > 3)
                {
                    valueIndex = 0;
                }
            }
            for (Int32 flag = 0; flag < 54; flag++)
            {
                var values = array[valueIndex++].Split(new String[] { "\r\n" }, StringSplitOptions.None);
                foreach (var item in values)
                {
                    if (!String.IsNullOrEmpty(item))
                    {
                        var subStr1 = item.Substring(0, flag + 1);
                        var subStr2 = item.Substring(flag + 1);
                        Console.WriteLine(subStr2 + temp + subStr1);
                    }
                }
                Thread.Sleep(100);
                Console.Clear();
                //if (dely < 80)
                //{
                //    dely = 80;
                //}
                if (valueIndex > 3)
                {
                    valueIndex = 0;
                }
            }
        }
        Console.WriteLine(patterm1);
        var result = Regex.IsMatch("", patterm1);
        Console.Read();
    }


    public struct aa
    {
        public int a;
        public String b;
        public aa(Int32 s, String d)
        {
            a = s;
            b = d;
        }
    }
}