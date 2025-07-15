using System;
using System.Security.Cryptography;
using System.Data.SqlClient;

public class SmellCode
{
    // Expose Sensitive Data
    public void ExposeSensitiveData()
    {
        string password = Console.ReadLine();
        Console.WriteLine("Your password is: " + password);
    }

    // Weak Cryptography
    public void EncryptData()
    {
        //var des = new DESCryptoServiceProvider(); // 🔥 Weak algorithm
        //des.GenerateKey();
        //des.GenerateIV();
    }

    // SQL Injection Risk
    public void SQLInjection(string username)
    {
        //var query = "SELECT * FROM Users WHERE Username = '" + username + "'";
        //var command = new SqlCommand(query, new SqlConnection("..."));
        //command.ExecuteReader();
    }

    // Credential hard coded
    public void CredentialsHardcoded()
    {
        //string apiKey = "12345-ABCDE";
    }
}