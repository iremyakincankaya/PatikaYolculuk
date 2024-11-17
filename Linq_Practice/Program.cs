using Linq_Practice;

// yazar listesi oluşturma
List<Authors> authors = new List<Authors>()
{ 
    new Authors( 1,"Orhan Pamuk"),
    new Authors( 2,"Elif Şafak"),
    new Authors( 3,"Ahmet Ümit")
};

//kitap listesi olusturma
List<Books> books = new List<Books>()
{
    new Books(1,"Kar",1),
    new Books(2,"İstanbul",1),
    new Books(3,"10 Minutes 38 Seconds in This Strange World",2),
    new Books(4,"Kar",3)
};

//join ie yazar ve kitap listelerini bağlama
var booksWithAuthors = books.Join(authors,
    authors => authors.AuthorId,
    books => books.AuthorId,
    (books, authors) => new
    {
        NewBook = books.Title,
        AuthorName = authors.AuthorName,
    }
    );
//oluşan yeni listeyi ekrana yazdırma
foreach (var book in booksWithAuthors)
{
    Console.WriteLine($"Kitap Adı: {book.NewBook} ----- Yazar Adı: {book.AuthorName}");
}
Console.ReadKey();
    