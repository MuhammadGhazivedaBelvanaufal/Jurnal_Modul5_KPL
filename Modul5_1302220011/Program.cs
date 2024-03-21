internal class Program
{
    private static void Main(string[] args)
    {
        penjumlahan penjumlahan = new penjumlahan();
        penjumlahan.JumlahTigaAngka<float>(13, 02, 22);

        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(22);
        data.PrintAllData();
    }
    public class penjumlahan
    {
        public void JumlahTigaAngka<T>(T Jumlah1, T jumlah2, T jumlah3)
        {
            dynamic Jumlah = (dynamic)Jumlah1 + (dynamic)jumlah2 + (dynamic)jumlah3;
            Console.WriteLine("Jumlah Tiga Angka = " + Jumlah);
        }
    }
    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                if (storedData[i] > (dynamic)0 && storedData[i] < (dynamic)10)
                {
                    Console.WriteLine($"Data " + i + " berisi: 0" + storedData[i] + ", yang disimpan pada waktu UTC " + inputDates[i]);
                }
                else
                {
                    Console.WriteLine($"Data " + i + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC " + inputDates[i]);
                }
            }
        }
    }
}