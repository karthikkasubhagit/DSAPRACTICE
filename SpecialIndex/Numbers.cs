// namespace SpecialIndex;

public class Numbers
{
    public static int[] PrefixEven(int[] Array)
    {
        int[] PrefixEven = new int[Array.Length];
        PrefixEven[0] = Array[0];

        for (int i = 1; i < Array.Length; i++)
        {
            if (i % 2 == 0)
            {
                PrefixEven[i] = PrefixEven[i - 1] + Array[i];
            }
            else
            {
                PrefixEven[i] = PrefixEven[i - 1];
            }
        }

        return PrefixEven;
    }

    public static int[] PrefixOdd(int[] Array)
    {
        int[] PrefixOdd = new int[Array.Length];
        PrefixOdd[0] = 0;

        for (int i = 1; i < Array.Length; i++)
        {
            if (i % 2 == 0)
            {
                PrefixOdd[i] = PrefixOdd[i - 1];
            }
            else
            {
                PrefixOdd[i] = PrefixOdd[i - 1] + Array[i];
            }
        }

        return PrefixOdd;
    }

    public int SpecialIndex(int[] A)
    {
        int[] pfe = PrefixEven(A);
        int[] pfo = PrefixOdd(A);
        int count = 0;

        int Length = A.Length;

        for (int i = 0; i < Length; i++)
        {
            int soo;
            int soe;
            if (i == 0)
            {
                soe = pfo[Length - 1];
                soo = pfe[Length - 1];
            }
            else
            {
                soe = pfe[i - 1] + pfo[Length - 1] - pfo[i];
                soo = pfo[i - 1] + pfe[Length - 1] - pfe[i];
            }

            if (soe == soo)
            {
                System.Console.WriteLine($"Special Index: {i}");
                count++;
            }
        }

        return count;

    }
}