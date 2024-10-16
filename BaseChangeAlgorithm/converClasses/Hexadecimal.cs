using System;
using System.Dynamic;

namespace BaseChangeAlgorithm.converClasses;

public static class Hexadecimal
{
    public static string ConvertToHexadecimal(int num){
        int qoutient = num;
        int[] remainders = new int[100];
        string hexadecimal = string.Empty;
        int i = 0;

        while(qoutient != 0)
        {
            remainders[i] = qoutient % 16;
            qoutient /= 16;
            i++;
        }
        i--;
        while(i >= 0)
        {
            if(remainders[i] <= 9)
            {
                hexadecimal += remainders[i];
            }
            else
            {
                switch(remainders[i])
                {
                    case 10 :
                        hexadecimal += "A";
                    break;
                    case 11 :
                        hexadecimal += "B";
                    break;
                    case 12 :
                        hexadecimal += "C";
                    break;
                    case 13 :
                        hexadecimal += "D";
                    break;
                    case 14 :
                        hexadecimal += "E";
                    break;
                    case 15 :
                        hexadecimal += "F";
                    break;
                }
            }
            i--;
        }
        return hexadecimal;
    }
}
