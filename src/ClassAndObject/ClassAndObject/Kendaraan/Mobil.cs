namespace ClassAndObject.Kendaraan
{
    public class Mobil
    {
        public string Merk;
        public string Model;
        public int TahunProduksi;

        public Mobil(string merk, string model, int tahunProduksi)
        {
            Merk = merk;
            Model = model;
            TahunProduksi = tahunProduksi;
        }

        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Model: {Model}, Tahun Produksi: {TahunProduksi}");
        }
    }
}
