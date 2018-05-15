using System;

namespace ClassesExercises
{
    public class Post
    {
        public string Title { get; private set; }
        public string Decription { get; private set; }
        public DateTime DateWritten { get; private set; }
        public int Votes { get; private set; }

        public Post(string title, string description, DateTime dateWritten)
        {
            this.Title = title;
            this.Decription = description;
            this.DateWritten = dateWritten;
        }

        public void UpVote()
        {
            this.Votes++;
        }

        public void DownVote()
        {
            this.Votes--;
        }

        
    }

}
