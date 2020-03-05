using System;
 using System.Collections;
 
 namespace Lab2Dll
 {
     public class String
     {
         public char[] Str;
         public String(char[] line)
         {
             if(Char.IsLower(line[0])) line[0] = Char.ToUpper(line[0]);
             Str = line;
         }
         
     }
 }