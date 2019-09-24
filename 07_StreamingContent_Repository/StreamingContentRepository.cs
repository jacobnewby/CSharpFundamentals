using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository
    {
        List<StreamingContent> _streamingContentList = new List<StreamingContent>();

        public void AddToList(StreamingContent content)
        {
            _streamingContentList.Add(content);
        }

        public List<StreamingContent> GetStreamingContentList()
        {
            return _streamingContentList;
        }

        public void RemoveStreamingContentFromList(string title)
        {
            foreach (StreamingContent movie in _streamingContentList)
            {
                if (movie.Title == title)
                {
                    _streamingContentList.Remove(movie);
                    break;
                }
            }

        }

        public void SeedList()
        {
            StreamingContent movie = new StreamingContent("MIB", 4, 1.45f, "Aliens", true, "PG", GenreType.Action);
            StreamingContent movieTwo = new StreamingContent("Zombieland", 4, 1.30f, "Zombies", false, "R", GenreType.Horror);
            StreamingContent movieThree = new StreamingContent("We're the Millers", 4, 1.35f, "Funny", false, "R", GenreType.Comedy);

            AddToList(movie);
            AddToList(movieTwo);
            AddToList(movieThree);
        }
    }
}
