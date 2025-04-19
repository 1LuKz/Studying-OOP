using System;
using StringBuilderExercise.Entities;

namespace StringBuilderExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment comment1 = new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow that's awesome!");
            DateTime dateTime1 = new DateTime(2018, 06, 21, 13, 05, 44);

            Post post1 = new Post(
                dateTime1,
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);

            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Comment comment3 = new Comment("Good Night");
            Comment comment4 = new Comment("May the Force be with you");
            DateTime dateTime2 = new DateTime(2018, 07, 28, 23, 14, 19);

            Post post2 = new Post(
                dateTime2,
                "Good night guys",
                "See you tomorrow",
                5);

            post2.AddComment(comment3);
            post2.AddComment(comment4);

            Console.WriteLine(post1.ToString());
            Console.WriteLine("\n" + post2.ToString());
        }
    }
}