using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    // Reuse your BlogPost class
    public class BlogPost
    {
        string authorName;
        string title;
        string text;
        string publicationDate;

        public BlogPost(string authorName, string title, string text, string publicationDate)
        {
            this.authorName = authorName;
            this.title = title;
            this.text = text;
            this.publicationDate = publicationDate;
        }
    }
}
