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
        public string[] userWork = new string[4];

        string userAnswer = null;
        int[] userAnswers = new int[5];
        string correctness;
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
                    Console.WriteLine($"{i+1}) {exercises[i]} = ");
                    try
                    {
                        userAnswer = Console.ReadLine();
                        double handledAnswer = Convert.ToDouble(userAnswer);
                        userAnswers[i] = (int)handledAnswer;
                        if (userAnswers[i] == rightAnswers[i])
                        {
                            userRightAnswersAmount++;
                            correctness = "Correct";
                        }
                        else
                        {
                            correctness = $"Wrong. Right answer is {rightAnswers[i]}";
                        }
                        userWork[i] = $"{i+1}) {exercises[i]} = {userAnswers[i]}. {correctness}";
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
            AskFromUser();
            AskAgain();
        }

        public void ShowWork()
        {
            foreach (string el in userWork)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine($"Amount of right answers {userRightAnswersAmount}");
            Console.WriteLine($"Amount of wrong answers {exercises.Length - userRightAnswersAmount}");

        }

        public void AskFromUser()
        {
            string[] positiveOptions = {};
            while (true)
            {
                Console.WriteLine("Do you want to show your work?");
                string userDecision = Console.ReadLine();
                if (userDecision == "y")
                {
                    ShowWork();
                    break;
                }
                else if (userDecision == "n")
                {
                    break;
                }
            }
        }

        public void AskAgain()
        {
            Console.WriteLine("Do you want to try again?");
            string userDecision = Console.ReadLine();
            while (true)
            {

                if (userDecision == "y")
                {
                    SolveExercises();
                    break;

                }
                else if (userDecision == "n")
                {
                    Console.WriteLine("Buy!");
                    break;
                }
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
