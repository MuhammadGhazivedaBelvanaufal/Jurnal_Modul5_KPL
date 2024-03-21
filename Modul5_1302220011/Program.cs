internal class Program
{
    private static void Main(string[] args)
    {
        penjumlahan penjumlahan = new penjumlahan();
        penjumlahan.JumlahTigaAngka<float>(13, 02, 22);
    }

    public class penjumlahan
    {
        public void JumlahTigaAngka<T>(T Jumlah1, T jumlah2, T jumlah3) 
        {
            dynamic Jumlah = (dynamic)Jumlah1 + (dynamic)jumlah2 + (dynamic)jumlah3;
            Console.WriteLine("Jumlah Tiga Angka = " + Jumlah);
        }

}
}