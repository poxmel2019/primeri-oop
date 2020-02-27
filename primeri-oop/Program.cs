using System;

namespace primeri_oop
{
    class Examples
    {
        protected string[] exercises = { "1 + 1", "1 - 1", "1 * 1", "1 / 1" };
        protected int[] rightAnswers = { 2, 0, 1, 1 };
        public Examples() { }
    }
    class User : Examples
    {
        private int _scores = 0;
        private int[] _userAnswers = new int[4];
        public int Scores
        {
            get
            {
                Console.WriteLine("User scores: ");
                return _scores;
            }
            /*
            set
            {
                _scores = value;
            }
            */
        }

        public int[] UserAnswers
        {
            get;
            set;
        }
       

        public int userRightAnswersAmount = 0;

        string userAnswer = null;
        int[] userAnswers = new int[5];
        public User()
        {
            _scores = 0;
          
        }

        public void SolveExercises()
        {
            //double handledAnswer = 0;
            for (int i = 0; i < exercises.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine(exercises[i]);
                    try
                    {
                        userAnswer = Console.ReadLine();
                        double handledAnswer = Convert.ToDouble(userAnswer);
                        userAnswers[i] = (int)handledAnswer;
                        if (userAnswers[i] == rightAnswers[i])
                        {
                            userRightAnswersAmount++;
                        }
                        break;
                    }
                    catch (FormatException)
                    {
                        if (string.IsNullOrEmpty(userAnswer) || string.IsNullOrWhiteSpace(userAnswer))
                        {
                            Console.WriteLine("You entered nothing!");
                        }
                        else
                        {
                            Console.WriteLine("Number please");
                        }
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Number is too big!");
                    }
                    
                }
                
            }
            if (userRightAnswersAmount == exercises.Length)
            {
                _scores++;
            }
            
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            User me = new User();
            //Console.WriteLine(me.Scores);
            me.SolveExercises();
            //me.Scores = 10;
            Console.WriteLine(me.Scores);


            Console.Read();
        }
    }
}
