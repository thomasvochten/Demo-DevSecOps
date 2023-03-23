﻿using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Let's get this party started!");

// Deliberately hardcoded password
var password = "pass@word1";
Console.WriteLine("Password is: " + password);

// Something silly
var x = -1;
if (x < 0)
{
  new ArgumentException("x must be nonnegative");
}

// TODO: Create more vulnerabilities to test Sonarcloud such as a weak hashing algorithm

// Create a SHA1 hash
var sha1 = SHA1.Create();
var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
Console.WriteLine("Hash is: " + hash);