namespace Banquer;

public class Client
{
    public Client(string nomClient)
    {
        Nom = nomClient;
        Saldo = 0;
    }
    public string Nom { get; }
    
    public int Saldo { get; set; } = 0;


}