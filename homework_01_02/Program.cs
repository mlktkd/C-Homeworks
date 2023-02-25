using System;
using System.Collections.Specialized;

namespace Problems
{
  public class Program
  {
    private static Prob_01 problem_01 = new Prob_01();
    private static Prob_02 problem_02 = new Prob_02();
    private static Prob_03 problem_03 = new Prob_03();
    private static Prob_04 problem_04 = new Prob_04();
    private static Prob_05 problem_05 = new Prob_05();
    private static Prob_06 problem_06 = new Prob_06();
    public static void Main(string[] args)
    {
      problem_01.StartProblem_01();
      problem_02.StartProblem_02();
      problem_03.StartProblem_03();
      problem_04.StartProblem_04();
      problem_05.StartProblem_05();
      problem_06.StartProblem_06();
    }
  }
}