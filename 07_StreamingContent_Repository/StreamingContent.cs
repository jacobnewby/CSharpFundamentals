using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public enum GenreType { Drama = 1, Action, Horror, Comedy, Documentary, RomCom, Indie, SciFi }
    public class StreamingContent
    {
        public StreamingContent(string title, int starRating, float runTime, string summary, bool isFamilyFriendly, string movieRating, GenreType genre)
        {
            Title = title;
            StarRating = starRating;
            RunTime = runTime;
            Summary = summary;
            IsFamilyFriendly = isFamilyFriendly;
            MovieRating = movieRating;
            Genre = genre;
        }
        public StreamingContent()
        {

        }


        public string Title { get; set; }
        public int StarRating { get; set; }
        public float RunTime { get; set; }
        public string Summary { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public string MovieRating { get; set; }
        public GenreType Genre { get; set; }

    }
}
