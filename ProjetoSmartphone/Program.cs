using ProjetoSmartphone.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Nokia nokia = new Nokia("32998709771", "Tijolao", "123456cfder", 8);

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarApp("Whatsapp");

        Iphone iphone = new Iphone("198765243", "AppleSmart", "imei2132", 16);

        iphone.ReceberLigacao();
    }
}