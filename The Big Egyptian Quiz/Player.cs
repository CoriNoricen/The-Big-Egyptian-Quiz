using System;
using System.Collections.Generic;

namespace The_Big_Egyptian_Quiz
{
    [Serializable]
    public class Player
    {
        public string Username;
        public int Score;
        public string Avatar;

        //scores and total scores for each topic
        public int Topic1Score;
        public int Topic1TotalScore = 19;
        public int Topic2Score;
        public int Topic2TotalScore = 14;
        public int Topic3Score;
        public int Topic3TotalScore = 18;
        public int Topic4Score;
        public int Topic4TotalScore = 15;

        //prevents resetting player early
        public bool FirstTime = true;

        public int TotalTotalScore = 66;

        public List<int> TopicScreens = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        public Player(string name, int score)
        {
            Username = name;
            Score = score;
            Avatar = "111";
        }

        public void ResetPlayer()
        {
            Username = "";
            Score = 0;
            Avatar = "";

            Topic1Score = 0;
            Topic2Score = 0;
            Topic3Score = 0;
            Topic4Score = 0;

            FirstTime = true;

            Question.Topic1 = false;
            Question.Topic1Count = 0;
            Question.Topic1C = false;
            Question.Topic2 = false;
            Question.Topic2Count = 0;
            Question.Topic2C = false;
            Question.Topic3 = false;
            Question.Topic3Count = 0;
            Question.Topic3C = false;
            Question.Topic4 = false;
            Question.Topic4Count = 0;
            Question.Topic4C = false;

            PasswordScreen.LeaderAccessible = true;
            PasswordScreen.PasswordCompleted = false;

            for (int i = 0; i <= 12; i++) 
            {
                TopicScreens.Add(i);
            }
           
    }

        public int IncreaseScore(int qScore)
        {
            //if for topics through to adding to spec topic then add total
            if (Question.Topic1 == true)
            {
                Topic1Score += qScore;
            }
            else if (Question.Topic2 == true)
            {
                Topic2Score += qScore;
            }
            else if (Question.Topic3 == true)
            {
                Topic3Score += qScore;
            }
            else if (Question.Topic4 == true)
            {
                Topic4Score += qScore;
            }
            Score += qScore;
            return Score;
        }
    }
}
