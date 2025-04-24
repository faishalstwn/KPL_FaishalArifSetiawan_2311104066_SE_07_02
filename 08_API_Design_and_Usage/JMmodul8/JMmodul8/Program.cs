using System;

class Program
{
    static void Main(string[] args)
    {
        string configPath = "bank_transfer_config.json";
        BankTransferConfig config = BankTransferConfig.LoadConfig(configPath);

        string prompt = config.lang == "en" ? "Please insert the amount of money to transfer:" : "Masukkan jumlah uang yang akan di-transfer:";
        Console.WriteLine(prompt);
        int amount = int.Parse(Console.ReadLine());

        int fee = amount <= config.transfer.threshold ? config.transfer.low_fee : config.transfer.high_fee;
        int total = amount + fee;

        if (config.lang == "en")
        {
            Console.WriteLine("Transfer fee = " + fee);
            Console.WriteLine("Total amount = " + total);
        }
        else
        {
            Console.WriteLine("Biaya transfer = " + fee);
            Console.WriteLine("Total biaya = " + total);
        }

        Console.WriteLine(config.lang == "en" ? "Select transfer method:" : "Pilih metode transfer:");
        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        Console.ReadLine(); // method selection

        string confirmationPrompt = config.lang == "en"
            ? $"Please type \"{config.confirmation.en}\" to confirm the transaction:"
            : $"Ketik \"{config.confirmation.id}\" untuk mengkonfirmasi transaksi:";
        Console.WriteLine(confirmationPrompt);

        string confirmInput = Console.ReadLine();
        bool confirmed = (config.lang == "en" && confirmInput == config.confirmation.en) ||
                         (config.lang == "id" && confirmInput == config.confirmation.id);

        if (confirmed)
        {
            Console.WriteLine(config.lang == "en" ? "The transfer is completed" : "Proses transfer berhasil");
        }
        else
        {
            Console.WriteLine(config.lang == "en" ? "Transfer is cancelled" : "Transfer dibatalkan");
        }
    }
}
