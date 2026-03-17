class KodePaket
{
    String[] namaPaket = { "Basic", "Standard", "Premium", "Unlimited", "Gaming", "Streaming" , "Family", "Business", "Student", "Traveler" };
    String[] kodePaket = { "P201", "P202", "P203", "P204", "P205", "P206", "P207", "P208", "P209", "P210" };

    public int getNamaPaket(String nama)
    {
        for (int i = 0; i < kodePaket.Length; i++)
        {
            if (namaPaket[i] == nama)
            {
                return i;
            }
        }
        return -1; 
    }

    static void Main(string[] args)
    {
        KodePaket paket = new KodePaket();
        Console.Write("Masukkan nama paket: ");
        String inputNama = Console.ReadLine();
        int index = paket.getNamaPaket(inputNama);
        if (index != -1)
        {
            Console.WriteLine("Kode paket untuk " + inputNama + " adalah: " + paket.kodePaket[index]);
        }
        else
        {
            Console.WriteLine("Nama paket tidak ditemukan.");
        }
    }
};
