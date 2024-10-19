#region MyRegion
//void SaatiGoster()
////{
////    Console.Clear();
////    Console.WriteLine(DateTime.Now.ToLongDateString());
////    Thread.Sleep(1000); //1 sn akısı uyut
////}

////while (true)
////    SaatiGoster();

////Console.ReadKey();
#endregion


#region MyRegion1
void SaatiGoster1()
{
    Console.Clear();
    Console.WriteLine(DateTime.Now.ToLongTimeString());
    Thread.Sleep(1000); //1 sn akısı uyut
    SaatiGoster1();
}

SaatiGoster1();

Console.ReadKey(); 
#endregion