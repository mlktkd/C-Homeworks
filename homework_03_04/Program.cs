using System;

namespace homework_03_04
{
  public class homework_03_04
  {
    private static Prob_1 problem_01 = new Prob_1();
    private static Prob_2 problem_02 = new Prob_2();
    private static Prob_3 problem_03 = new Prob_3();
    private static Prob_4 problem_04 = new Prob_4();
    public static void Main(string[] argc)
    {
      problem_01.StartProb_01();
      problem_02.StartProb_02();
      problem_03.StartProb_03();
      problem_04.StartProb_04();
    }
  }
}