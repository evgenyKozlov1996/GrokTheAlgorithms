using System;
namespace DynamicProgramming
{
    public static class StringComparisonSolver
    {
        public static int CalculateIsSame(string str1, string str2)
        {
            var comparisonMatrix = new int[str1.Length, str2.Length];
            int maxVal = 0;
            for (var i = 0; i < str1.Length; i++)
            {
                for (var j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        if (i - 1 < 0 || j - 1 < 0)
                        {
                            comparisonMatrix[i, j] = 1;
                        }
                        else
                        {
                            comparisonMatrix[i, j] = comparisonMatrix[i - 1, j - 1] + 1;
                        }
                    }
                    else
                    {
                        if (i - 1 < 0 || j - 1 < 0)
                        {
                            comparisonMatrix[i, j] = 0;
                        }
                        else
                        {
                            comparisonMatrix[i, j] = Math.Max(comparisonMatrix[i - 1, j], comparisonMatrix[i, j - 1]);
                        }
                    }

                    if (comparisonMatrix[i, j] > maxVal)
                    {
                        maxVal = comparisonMatrix[i, j];
                    }
                }
            }

            return maxVal;
        }
    }
}

