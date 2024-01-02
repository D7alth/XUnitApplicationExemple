namespace domain.tests;
using domain.entities;

public class UnitTest1
{
    [Fact(DisplayName = "Unit Test 1")]
    public void Test1()
    {
      // principio AAA: 

      // Arrange
      var title = "titulo da materia";
      var content = "coteudo da mateira";
      var publishDate = DateTime.Now;
      var pathTumbnail = "http://x.jpg";
      var tags = new List<string>() {"tag1", "tag2", "tag3"};

      // Act
      var post = new Post(title, content, publishDate, pathTumbnail, tags);

      //Assert
      Assert.Equal(title, post.Title);
      Assert.Equal(content, post.Content);
      Assert.Equal(publishDate, post.PublishDate);
      Assert.Equal(pathTumbnail, post.PathTumbnail);
      Assert.Equal(tags, post.Tags);

    }
    [Theory(DisplayName = "Theory test")]
    [InlineData("test", "Content")]
    public void Test2(string title, string content)
    {
      // principio AAA: 

      // Arrange
      var publishDate = DateTime.Now;
      var pathTumbnail = "http://x.jpg";
      var tags = new List<string>() {"tag1", "tag2", "tag3"};

      // Act
      var post = new Post(title, content, publishDate, pathTumbnail, tags);

      //Assert
      Assert.Equal(title, post.Title);
      Assert.Equal(content, post.Content);
      Assert.Equal(publishDate, post.PublishDate);
      Assert.Equal(pathTumbnail, post.PathTumbnail);
      Assert.Equal(tags, post.Tags);

    }
}