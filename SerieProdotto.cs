using System;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (span < 0 || span > digits.Length)
        {
            throw new ArgumentException("Non e valido");
        }
        if (span == 0)
        {
            return 1;
        }
        long largestProduct = 0;
        for (int i = 0; i <= digits.Length - span; i++)
        {
            long product = 1;
            for (int j = 0; j < span; j++)
            {
                char c = digits[i + j];
                if (!char.IsDigit(c))
                {
                    throw new ArgumentException("Span con caratteri invalido");
                }
                product *= (long)(c - '0');
            }
            if (product > largestProduct)
            {
                largestProduct = product;
            }
        }
        return largestProduct;
    }
}