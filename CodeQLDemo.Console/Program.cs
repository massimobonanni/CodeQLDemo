using System;
using System.Security.Cryptography;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

var des = new DESCryptoServiceProvider(); // 🔥 Weak algorithm
des.GenerateKey();
des.GenerateIV();
