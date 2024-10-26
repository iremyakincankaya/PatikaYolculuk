using IMDBList;

List<Filmler> list = new List<Filmler>();

while (true)
{

    Console.WriteLine("Listeye eklemek istediğiniz filmin adını girin: ");
    string filmAdi = Console.ReadLine();

    Console.WriteLine("Listeye eklemek istediğiniz filmin imdb puanını girin: ");
    double imdbPuan = Convert.ToDouble(Console.ReadLine());

    Filmler yeniFilm = new Filmler(filmAdi, imdbPuan);

    list.Add(yeniFilm);
    Console.WriteLine("Film eklemek istiyor musunuz? (E/H)");

    if (Console.ReadLine().ToLower() != "e")
    {

        Console.Clear();
        foreach (Filmler film in list)
        {
            Console.WriteLine($"Filmin adı: {film.Ad} IMDB Puanı: {film.IMDB}");

        }

        Console.WriteLine("---------------------------");
        Console.WriteLine("IMDB Puanı 4-9 arasındakiler:");

        foreach (Filmler film in list.Where(x => x.IMDB > 4 && x.IMDB < 9))
        {
            Console.WriteLine($"Filmin adı: {film.Ad} IMDB Puanı: {film.IMDB}");

        }
        Console.WriteLine("---------------------------");
        Console.WriteLine("Film adı A ile başlayanlar:");

        foreach (Filmler film in list.Where(x => x.Ad.StartsWith('a') == true || x.Ad.StartsWith('A') == true))
        {
            Console.WriteLine($"Filmin adı: {film.Ad} IMDB Puanı: {film.IMDB}");

        }

        Console.ReadKey();
        return;
    }


}



