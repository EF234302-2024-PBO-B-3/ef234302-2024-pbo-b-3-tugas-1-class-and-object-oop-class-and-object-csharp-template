using System.Globalization;
namespace ClassAndObject.TokoSepeda

{
    public class Sepeda
    {
        public string Merk;
        public string Tipe;
        public double Berat;

        public Sepeda(string merk, string tipe, double berat)
        {
            Merk = merk;
            Tipe = tipe;
            Berat = berat;
        }

        public void TampilkanInformasi()
        {
            string beratFormatted = Berat.ToString("F1", CultureInfo.InvariantCulture);
            Console.WriteLine($"Merek: {Merk}, Tipe: {Tipe}, Berat: {beratFormatted} kg");
        }
    }
}
