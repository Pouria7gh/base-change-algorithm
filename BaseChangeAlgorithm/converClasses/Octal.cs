using System;

namespace BaseChangeAlgorithm.converClasses;

public class Octal
{
    public static int ConvertToOctal(int num){
        int qoutient = num;
        int[] remainders = new int[100];
        string octal = string.Empty;
        int i = 0;

        while(qoutient != 0)
        {
            remainders[i] = qoutient % 8;
            qoutient /= 8;
            i++;
        }
        i--;
        while(i >= 0)
        {
            octal += remainders[i];
            i--;
        }
        return int.Parse(octal);
    }
}
