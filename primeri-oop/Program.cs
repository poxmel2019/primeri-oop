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
        public int Scores
        {
            get
            {
                Console.WriteLine("User scores: ");
                return _scores;
            }
            set
            {
                _scores = value;
            }

        }
       

        public int userRightAnswersAmount = 0;

        int userAnswer = 0;
        int[] userAnswers = new int[5];
        public User()
        {
            Scores = 0;
            
            
        }

        public void SolveExercises()
        {
            for (int i = 0; i < exercises.Length; i++)
            {
                Console.WriteLine(exercises[i]);
                userAnswer = Convert.ToInt32(Console.ReadLine());
                userAnswers[i] = userAnswer;
                if (userAnswers[i] == rightAnswers[i])
                {
                    userRightAnswersAmount++;    
                }
            }
            if (userRightAnswersAmount == exercises.Length)
            {
                Scores++;
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
            Console.WriteLine(me.Scores);


            Console.Read();
        }
    }
}
