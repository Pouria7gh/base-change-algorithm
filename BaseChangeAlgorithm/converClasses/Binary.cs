using System;

namespace BaseChangeAlgorithm.converClasses;

public static class Binary
{
    public static int ConvertToBinary(int num)
    {
        int qoutient = num;
        int[] remainders = new int[100];
        string binaryNumber = string.Empty;
        int i = 0;

        while(qoutient != 0)
        {
            remainders[i] = qoutient % 2;
            qoutient /= 2;
            i++;
        }
        while(i >= 0)
        {
            binaryNumber += remainders[i];
            i--;
        }
        return int.Parse(binaryNumber);
    }
}
