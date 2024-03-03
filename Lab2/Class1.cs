using System;
using System.Collections.Generic;

public class Class1
{
    // Методи для арифметичних операцій
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Ділення на 0 неможливе");
        }
        return a / b;
    }

    // Метод для піднесення числа до ступеня та виведення результату в Р-ічній і десятковій системах числення
    public (string decimalResult, string radixResult) Power(double baseNumber, double exponent, int radix)
    {
        int resultDecimal = (int)Math.Pow(baseNumber, exponent);
        string decimalResult = resultDecimal.ToString(); // Результат у десятковій системі числення
        string radixResult = ConvertFromDecimal(resultDecimal, radix); // Результат у Р-ічній системі числення
        string formattedRadixResult = $"{resultDecimal:X}"; // Додати дужки і шістнадцяткове значення
        return (decimalResult, formattedRadixResult);
    }
    // Метод для переведення з десяткової системи числення в Р-ічну
    public string ConvertFromDecimal(int number, int radix)
    {
        if (number == 0)
            return "0";

        string result = "";
        while (number > 0)
        {
            result = digitToChar[number % radix] + result;
            number /= radix;
        }
        return result;
    }

    // Метод для переведення з Р-ічної системи числення в десяткову
    public int ConvertToDecimalFromRadix(string number, int radix)
    {
        int result = 0;
        int power = 1;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            result += charToDigit[number[i]] * power;
            power *= radix;
        }
        return result;
    }

    // Метод для переведення з Р-ічної системи числення в десяткову
    public int ConvertToDecimal(string number, int radix)
    {
        int result = 0;
        int power = 1;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            result += charToDigit[number[i]] * power;
            power *= radix;
        }
        return result;
    }

    // Приватні поля для конвертації чисел між системами числення
    private Dictionary<char, int> charToDigit = new Dictionary<char, int>()
    {
        {'0', 0}, {'1', 1}, {'2', 2}, {'3', 3}, {'4', 4},
        {'5', 5}, {'6', 6}, {'7', 7}, {'8', 8}, {'9', 9},
        {'A', 10}, {'B', 11}, {'C', 12}, {'D', 13}, {'E', 14}, {'F', 15}
        
    };

    private Dictionary<int, char> digitToChar = new Dictionary<int, char>()
    {
        {0, '0'}, {1, '1'}, {2, '2'}, {3, '3'}, {4, '4'},
        {5, '5'}, {6, '6'}, {7, '7'}, {8, '8'}, {9, '9'},
        {10, 'A'}, {11, 'B'}, {12, 'C'}, {13, 'D'}, {14, 'E'}, {15, 'F'}
        
    };
}
