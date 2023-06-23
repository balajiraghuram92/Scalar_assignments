using System;
using System.Collections.Generic;



class SumOfEvenNumbers {
   public List<int> A = new List<int>{16,3,3,6,7,8,17,13,7};
   public List<List<int>> B = new List<List<int>>{new List<int>{2,6}, new List<int>{4,7}, new List<int>{6,7}};
    public List<int> solve(List<int> A, List<List<int>> B) {            
        List<int> result = new List<int>();
        List<int> prefixEvenSum = new List<int>();
        
        int evenSum = 0;
        for(int i = 0; i < A.Count; i++)
        {
            if(i % 2 != 0)
            {                
                prefixEvenSum.Add(evenSum);
            }
            else
            {
                
                evenSum += A[i]; 
                prefixEvenSum.Add(evenSum);
            }
        }

        int sum = 0;
        for(int i = 0; i < B.Count; i++)
        { 
            int end = B[i][1];
            int start = B[i][0];
            if(start != 0)
                sum = prefixEvenSum[end] - prefixEvenSum[start - 1];
            else
                sum = prefixEvenSum[end];

            result.Add(sum);            
        }
        return result;
    }
}