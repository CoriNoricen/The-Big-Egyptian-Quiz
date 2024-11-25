using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Big_Egyptian_Quiz;

namespace The_Big_Egyptian_Quiz
{
    internal class Question
    {
        static Random rnd = new Random();
        public static int count = 0;

        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswerPosition { get; set; }
        public string CorrectAnswerText { get; set; }

        //Question Constructor
        public Question(string questionText, string[] answers, int correctAnswerPosition, string correctAnswerText)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerPosition = correctAnswerPosition;
            CorrectAnswerText = correctAnswerText;
        }

        public string GetQuestionText()
        {
            return QuestionText;
        }
        public string[] GetPossibleAnswers()
        {
            return Answers;
        }
        public int GetAnswerPosition()
        {
            return CorrectAnswerPosition;
        }
        public string GetAnswerText()
        {
            return CorrectAnswerText;
        }

        public static bool Topic1;
        public static int Topic1Count = 0;
        public static bool Topic1C;

        public static bool Topic2;
        public static int Topic2Count = 0;
        public static bool Topic2C;

        public static bool Topic3;
        public static int Topic3Count = 0;
        public static bool Topic3C;

        public static bool Topic4;
        public static int Topic4Count = 0;
        public static bool Topic4C;

        public static int Randomiser(int j)
        {
            
            int i = 0;
            
            while (true)
            {
                switch (j)
                {
                    case 1:
                        i = rnd.Next(0, 4);
                        break;
                    case 2:
                        i = rnd.Next(4, 7);
                        break;
                    case 3:
                        i = rnd.Next(7, 10);
                        break;
                    case 4:
                        i = rnd.Next(10, 13);
                        break;
                }

                if (TopicScreen.player.TopicScreens.Count == 0)
                {
                    i = 1234;
                    break;
                }
                else if (Topic1Count == 4 && Topic1C == false)
                {
                    Topic1C = true;
                    i = 4321;
                    break;
                }
                else if (Topic2Count == 3 && Topic2C == false)
                {
                    Topic2C = true;
                    i = 4321;
                    break;
                }
                else if (Topic3Count == 3 && Topic3C == false)
                {
                    Topic3C = true;
                    i = 4321;
                    break;
                }
                else if (Topic4Count == 3 && Topic4C == false)
                {
                    Topic4C = true;
                    i = 4321;
                    break;
                }
                else if (TopicScreen.player.TopicScreens.Contains(i))
                {
                    switch(j)
                    {
                        case 1: Topic1Count++; break;
                        case 2: Topic2Count++; break; 
                        case 3: Topic3Count++; break;
                        case 4: Topic4Count++; break;
                    }
                    // Mark the question as used
                    TopicScreen.player.TopicScreens.Remove(i);
                    break;
                }
            }

            return i;           
        }
    }
}
