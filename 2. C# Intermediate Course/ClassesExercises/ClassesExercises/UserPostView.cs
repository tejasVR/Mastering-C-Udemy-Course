using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercises
{
    public class UserPostView
    {
        static void Main(string[] args)
        {
            VoteOnPost();
        }

        public static void VoteOnPost()
        {
            var post = new Post("Tejas' Lawn", "My lawn is very green", DateTime.Now);
            var input = Console.ReadLine().ToLower().Trim();
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Here is a sample post");
                Console.WriteLine("Title : {0}"
                    + Environment.NewLine +
                    "Decription: {1}"
                    + Environment.NewLine +
                    "Date Written: {2}", post.Title, post.Decription, post.DateWritten);

                Console.WriteLine("If you would like to vote on this post, please 'up' to up-vote or 'down' to down-vote");
            }
            else if (input == "up")
            {
                post.UpVote();
                Console.WriteLine("Thanks for the up-vote! This post now has {0} votes!", post.Votes);
            }
            else if (input == "down")
            {
                post.DownVote();
                Console.WriteLine("Thanks for the down-vote! This post now has {0} votes!", post.Votes);
            }
        }
    }

}
