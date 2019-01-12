using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science_Quiz__attempt_3
{
    public class Globalvariables
    {
        /*
        Array key
       [0] = Question 1
       [1] = Question 2
       [2] = Question 3
       [3] = Question 4
       [4] = Question 5
       [5] = Question 6
       [6] = Question 7
       */

        // this variable will be used to decide which character image appears
        public static int Character = 0;
        // these variables will be used to log the user in
        public static string username = "admin";
        public static string password = "admin";
        public static int points = 0;

        // These are used to determine how many answers the user has selected.
        public static int question4i = 0; // question 4 (Intermediate) answers
        public static int question6b = 0; // Question 6 (Beginner) answers

        // Total number of forms
        // As stated I want the quiz to end after the user has answered 5 questions. This will be used keep track of that.
        public static int form = 0;

        // This will create a bool array which can be used to remember which questions have been completed.
        // Intermediate
        public static bool[] CompletedQuestionsI = new bool[7];

        public static bool question_1i = false;
        public static bool question_2i = false;
        public static bool question_3i = false;
        public static bool question_4i = false;
        public static bool question_5i = false;
        public static bool question_6i = false;
        public static bool question_7i = false;


        // Beginner
        public static bool[] CompletedQuestionsB = new bool[7];

        public static bool question_1b = false;
        public static bool question_2b = false;
        public static bool question_3b = false;
        public static bool question_4b = false;
        public static bool question_5b = false;
        public static bool question_6b = false;
        public static bool question_7b = false;

        // Answers are correct (Intermediate)
        public static bool[] QuestionsCorrectI = new bool[7];

        public static bool question1i_correct = false;
        public static bool question2i_correct = false;
        public static bool question3i_correct = false;
        public static bool question4i_correct = false;
        public static bool question5i_correct = false;
        public static bool question6i_correct = false;
        public static bool question7i_correct = false;

        // Answers are correct (Beginner)
        public static bool[] QuestionsCorrectB = new bool[7];

        public static bool question1b_correct = false;
        public static bool question2b_correct = false;
        public static bool question3b_correct = false;
        public static bool question4b_correct = false;
        public static bool question5b_correct = false;
        public static bool question6b_correct = false;
        public static bool question7b_correct = false;

        // timer
        public static int timer = 0;

    }
}
