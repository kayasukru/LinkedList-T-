internal class Program
{
    private static void Main(string[] args)
    {
        // LinkedList<T> Temelleri

        //Tanımlama
        var sehirler = new LinkedList<string>();
        sehirler.AddFirst("Bursa"); // ilk eklenen düğüm olduğu için AddFirst() ile ekleniyor
        sehirler.AddFirst("Hatay"); // First ile eklendiği için Hatay ilk oldu
        sehirler.AddLast("İstanbul"); // Son düğüm olarak İstanbul ekleniyor
        sehirler.AddAfter(sehirler.Find("Hatay"), "Ankara"); // Hatay'dan sonraya Ankara ekleniyor
        sehirler.AddBefore(sehirler.First.Next.Next, "Giresun");// İlk düğümden 2 sonraya Giresun ekler
        sehirler.AddAfter(sehirler.Last.Previous, "Sinop"); // En sondan bir önceye Sinop ekler
        sehirler.AddAfter(sehirler.Find("Sinop"), "Zonguldak"); //Sinopu bulur Sinoptan sonraya Zonguldak ekler

        Console.WriteLine("Eleman Listesi:");
        foreach (var item in sehirler)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine("--------------------------------");
        Console.WriteLine();

        Console.WriteLine("İndexli Liste:");
        foreach ( var (value, index) in sehirler.Select( (value, index) => (value, index) ) )
        {
            Console.WriteLine($"{index}. {value}");
        }
        Console.WriteLine();
        Console.WriteLine("--------------------------------");
        Console.WriteLine();

        Console.WriteLine("Gidiş Güzergahı:");
        var eleman = sehirler.First;

        while (eleman != null)
        {
            Console.WriteLine(eleman.Value);
            eleman = eleman.Next;
        }
        Console.WriteLine();
        Console.WriteLine("--------------------------------");
        Console.WriteLine();

        Console.WriteLine("Dönüş Güzergahı:");
        eleman = sehirler.Last;

        while (eleman != null)
        {
            Console.WriteLine(eleman.Value);
            eleman = eleman.Previous;
        }
    }
}