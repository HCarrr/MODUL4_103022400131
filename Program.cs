/*class KodePaket
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
*/

class MesinKopi
{
    enum State { Off, Standby, Brewing, Maintenance };

    public static void Main(String[] args)
    {
        State state = State.Off;
        String[] stateNames = { "Off", "Standby", "Brewing", "Maintenance" };
        while (true) {
            
            Console.Write("Enter Command : ");
            String command = Console.ReadLine();
            bool valid = false;
            switch (state)
            {
                case State.Off:
                    if (command == "POWER_ON") {
                        state = State.Standby;
                        Console.WriteLine("Mesin Off berubah menjadi " + stateNames[(int)state]);
                        valid = true;
                    } 
                break;
                case State.Standby:
                    if (command == "START_BREW") {
                        state = State.Brewing;
                        Console.WriteLine("Mesin Standby berubah menjadi " + stateNames[(int)state]);
                        valid = true;
                    } else if (command == "POWER_OFF") {
                        state = State.Off;
                        Console.WriteLine("Mesin Standby berubah menjadi " + stateNames[(int)state]);
                        valid = true;
                    } else if (command == "START_MAINTENANCE") {
                        state = State.Maintenance;
                        Console.WriteLine("Mesin Standby berubah menjadi " + stateNames[(int)state]);
                        valid = true;
                    }
                break;
                case State.Brewing:
                    if (command == "FINISH_BREW") {
                        state = State.Standby;
                        Console.WriteLine("Mesin Brewing berubah menjadi " + stateNames[(int)state]);
                        valid = true;
                    }
                break;
                case State.Maintenance: 
                    if (command == "FINISH_MAINTENANCE") {
                        state = State.Standby;
                        Console.WriteLine("Mesin Maintenance berubah menjadi " + stateNames[(int)state]);
                        valid = true;
                    }
                break;
            }
            if (!valid)
            {
                Console.WriteLine("Perubahan State Tidak Valid");
            }
        }
    }
}