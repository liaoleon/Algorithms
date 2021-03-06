﻿namespace Algorithms.SortAlgorithms
{
    public class InsertionSort : SortBase
    {
        public override void Sort<T>(T[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                for (int j = i - 1; j >= 0 && input[j + 1].CompareTo(input[j]) < 0; j--)
                {
                    Swap(ref input[j], ref input[j + 1]);
                }
            }
        }
        private void OldSort(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                //int temp = input[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (input[j + 1] < input[j])
                    {
                        //j+1 is always temp index
                        Swap(ref input[j], ref input[j + 1]);
                        //input[j + 1] = input[j];
                        //input[j] = temp;
                    }
                    else
                        break;
                }
            }
        }
    }
}
