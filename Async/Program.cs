using System;
using System.Threading;
using System.Threading.Tasks;

public class AsyncExample
{
    public static async Task Main(string[] args)
    {
        // CancellationTokenSource oluşturuluyor
        var cts = new CancellationTokenSource();

        // Bir asenkron işlemi başlatıyoruz ve iptal token'ını geçiriyoruz
        var task = LongRunningOperationAsync(cts.Token);

        // Kullanıcıdan iptal komutu bekliyoruz
        Console.WriteLine("İptal etmek için bir tuşa basın...");
        Console.ReadKey();

        // İptal işlemi başlatılıyor
        
        cts.Cancel();

        try
        {
            // İşlem bitene kadar bekliyoruz
            await task;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("İşlem iptal edildi.");
            Console.ReadKey();
        }
    }

    // Asenkron işlem metodu
    public static async Task LongRunningOperationAsync(CancellationToken token)
    {
        for (int i = 0; i < 10; i++)
        {
            // İptal kontrolü yapılır
            
            token.ThrowIfCancellationRequested();

            Console.WriteLine($"İşlem {i + 1}/10...");
            await Task.Delay(1000); // 1 saniye bekleme (simüle edilen uzun işlem)
        }

        Console.WriteLine("İşlem tamamlandı.");
    }
}
