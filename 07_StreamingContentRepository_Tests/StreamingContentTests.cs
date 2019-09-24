using System;
using System.Collections.Generic;
using _07_StreamingContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_StreamingContentRepository_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void StreamingContentObject()
        {
            //AAAA Patern

            //Arange
            StreamingContent content = new StreamingContent();

            //Act
            content.Title = "I Love You, Man!";
            string expected = "I Love You, Man!";

            //Assert
            Assert.AreEqual(expected, content.Title);

            StreamingContent contentTwo = new StreamingContent("I Love You, Man!", 4, 1.45f, "Something", false, "R", GenreType.Comedy);

            string expectedTitle = "I Love You, Man!";
            int expectedStarRating = 4;
            float expectedRunTime = 1.45f;
            string expectedSummary = "Something";
            bool expectedIsFamilyFriendly = false;
            string expectedMovieRating = "R";
            GenreType expectedGenre = GenreType.Comedy;

            Assert.AreEqual(expectedTitle, contentTwo.Title);
            Assert.AreEqual(expectedStarRating, contentTwo.StarRating);
            Assert.AreEqual(expectedRunTime, contentTwo.RunTime);
            Assert.AreEqual(expectedSummary, contentTwo.Summary);
            Assert.AreEqual(expectedIsFamilyFriendly, contentTwo.IsFamilyFriendly);
            Assert.AreEqual(expectedMovieRating, contentTwo.MovieRating);
            Assert.AreEqual(expectedGenre, contentTwo.Genre);



        }

        [TestMethod]
        public void AddToList_AddStreamingContentObject_ListCountShouldBeCorrectInt()
        {
            //Arrange
            StreamingContentRepository streamingRepo = new StreamingContentRepository();
            List<StreamingContent> contents = streamingRepo.GetStreamingContentList();

            StreamingContent content = new StreamingContent("Forest Gump", 5, 2.30f, "Interesting story", false, "R", GenreType.Drama);
            StreamingContent contentTwo = new StreamingContent("We're the Millers", 4, 1.50f, "Funny", false, "R", GenreType.Comedy);
            StreamingContent contentThree = new StreamingContent("Zombieland", 4, 1.30f, "Funny Horror", false, "R", GenreType.Horror);

            //Act
            int expected = 3;

            streamingRepo.AddToList(content);
            streamingRepo.AddToList(contentTwo);
            streamingRepo.AddToList(contentThree);

            int actual = contents.Count;

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void RemoveStreamingContentFromList_RemovingStreamingContentObjectFromList_ListCountShouldBeCorrectInt()
        {

            //Arrange
            StreamingContentRepository streamingRepo = new StreamingContentRepository();
            List<StreamingContent> contents = streamingRepo.GetStreamingContentList();

            StreamingContent content = new StreamingContent("Forest Gump", 5, 2.30f, "Interesting story", false, "R", GenreType.Drama);
            StreamingContent contentTwo = new StreamingContent("We're the Millers", 4, 1.50f, "Funny", false, "R", GenreType.Comedy);
            StreamingContent contentThree = new StreamingContent("Zombieland", 4, 1.30f, "Funny Horror", false, "R", GenreType.Horror);

            //Act
            int expected = 2;

            streamingRepo.AddToList(content);
            streamingRepo.AddToList(contentTwo);
            streamingRepo.AddToList(contentThree);

            streamingRepo.RemoveStreamingContentFromList("Zombieland");

            int actual = contents.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
