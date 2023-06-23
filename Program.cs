using System;
using System.Collections.Generic;
using System.Linq;

 
  class Program
  { 
    
    static void Main(string[] args)
      {
         SumOfEvenNumbers problem = new SumOfEvenNumbers();
         List<int> result = problem.solve(problem.A,problem.B);
         Console.WriteLine("Result :");
         PrintArray(result);
      }   


      static void PrintArray(List<int> result)
      {
        for(int i = 0; i < result.Count; i++)
        {          
          Console.WriteLine(result[i]);
        }
      }

      /*static void PrintMat(List<int> A, List<List<int>> B)
      {
        for(int i = 0; i < A.Count; i++)
        {
          
          Console.Write("[");
          for(int j = 0; j < A[i].Count; j++)
          {
            Console.Write(A[i][j] + ", ");
          }
           Console.Write("]");
           Console.WriteLine(",");
        }
      }*/
  }