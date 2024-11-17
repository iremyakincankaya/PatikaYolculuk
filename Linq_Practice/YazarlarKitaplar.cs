using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yazarlar Tablosu(Authors)
//AuthorId(int) - Yazarın benzersiz kimliği
//Name (string) - Yazarın adı
//Kitaplar Tablosu (Books)
//BookId (int) - Kitabın benzersiz kimliği
//Title (string) - Kitabın başlığı
//AuthorId (int) - Kitabın yazarının kimliği (Yazarlar tablosundaki AuthorId ile ilişkilidir)
namespace Linq_Practice
{
    public class Authors
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public Authors(int authorId, string authorName)
        {
            AuthorId = authorId;
            AuthorName = authorName;
        }

    }

    public class Books
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }

        public Books(int bookId, string title, int authorId)
        {
            BookId = bookId;
            Title = title;
            AuthorId = authorId;
        }
    }
}
