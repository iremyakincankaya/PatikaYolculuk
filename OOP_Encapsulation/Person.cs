namespace OOP_Encapsulation
{
    public class Person
    {
        private string ad;
        private string soyad;
        private DateTime dogumTarihi;

        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }
        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }
        public DateTime DogumTarihi
        {
            get
            {
                return dogumTarihi;
            }
            set
            {
                if (value <= DateTime.Now)
                {
                    dogumTarihi = value;
                }
                else
                {
                    Console.WriteLine("Doğum tarihi bugünden büyük olamaz!");
                }
            }
        }
        public void Bilgiler()
        {
            Console.WriteLine($"Ad Soyad-Dogum Tarihi : {ad} {soyad}-{dogumTarihi.ToShortDateString()}");
        }
    }
}

