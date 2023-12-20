using System;

public class BaseConverter
{
    public static void Main()
    {
        string binaryNumber = "1010";
        int decimalNumber = Convert.ToInt32(binaryNumber, 2);

        Console.WriteLine($"Ikkilik son: {binaryNumber} o`nlikka o`tkazilganda: {decimalNumber}");

        decimalNumber = 12;
        binaryNumber = Convert.ToString(decimalNumber, 2);

        Console.WriteLine($"O`nlikdagi son: {decimalNumber} ikkilikka o`tkazilganda: {binaryNumber}\n");
    }
}
