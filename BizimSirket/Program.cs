using BizimSirket;
//konsol üzerinde unicode karakterlerinini gösterilmesi
Console.OutputEncoding = System.Text.Encoding.UTF8;

//programın kültürünü degistirme
//Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

Calisan c1 = new Calisan("İrem","Manager",300000);
Console.WriteLine(c1);

Console.ReadKey();

