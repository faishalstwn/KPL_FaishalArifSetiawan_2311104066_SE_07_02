using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Modul15_2311104066.Models;

namespace Modul15_NIM.Services
{
    public class SecureUserDatabase
    {
        private string filePath = "user_data.json";
        private List<User> users;

        public SecureUserDatabase()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
            else
            {
                users = new List<User>();
            }
        }

        public bool Register(string username, string password)
        {
            if (!IsValidUsername(username) || !IsValidPassword(password, username))
            {
                return false;
            }

            string passwordHash = HashPassword(password);

            if (users.Exists(u => u.Username == username))
            {
                Console.WriteLine("Username sudah terdaftar.");
                return false;
            }

            users.Add(new User { Username = username, PasswordHash = passwordHash });
            SaveToFile();
            return true;
        }

        public bool Login(string username, string password)
        {
            string passwordHash = HashPassword(password);
            return users.Exists(u => u.Username == username && u.PasswordHash == passwordHash);
        }

        private void SaveToFile()
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        private bool IsValidUsername(string username)
        {
            if (username.Length < 5 || username.Length > 20 || !Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
            {
                Console.WriteLine("Username harus terdiri dari 5-20 karakter alfanumerik.");
                return false;
            }
            return true;
        }

        private bool IsValidPassword(string password, string username)
        {
            if (password.Length < 8 || password.Length > 20)
            {
                Console.WriteLine("Password harus antara 8-20 karakter.");
                return false;
            }
            if (!Regex.IsMatch(password, @"[!@#$%^&*]"))
            {
                Console.WriteLine("Password harus mengandung minimal satu karakter spesial (!@#$%^&*).");
                return false;
            }
            if (password.Contains(username))
            {
                Console.WriteLine("Password tidak boleh mengandung username.");
                return false;
            }
            return true;
        }
    }
}