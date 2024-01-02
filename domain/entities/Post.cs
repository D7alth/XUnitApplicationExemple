using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain.entities
{
  public class Post(string _Title, string _Content, DateTime _PublishDate, string _PathTumbnail, List<string> _Tags)
  {
        public string? Title { get; private set; } = _Title;
        public string? Content { get; private set; } = _Content;
        public DateTime PublishDate { get; private set; } = _PublishDate;
        public string? PathTumbnail { get; private set; } = _PathTumbnail;
        public List<string> Tags { get; private set; } = _Tags;
  }
}