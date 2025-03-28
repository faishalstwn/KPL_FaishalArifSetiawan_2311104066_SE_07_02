using System;
using System.IO;
using Newtonsoft.Json;
using Tp7;

public class DataMahasiswa2311104066
{
    public Nama Nama { get; set; }  
    public string Nim { get; set; }
    public string Fakultas { get; set; }
    public static void ReadJSON()
    {
        string filePath = "tp7_1_2311104066.json"; 
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File JSON tidak ditemukan!");
            return;
        }

        string jsonData = File.ReadAllText(filePath);

        Console.WriteLine("Isi JSON yang dibaca:");
        Console.WriteLine(jsonData);

        DataMahasiswa2311104066? mahasiswa = JsonConvert.DeserializeObject<DataMahasiswa2311104066>(jsonData);


        Console.WriteLine($"Nama {mahasiswa?.Nama?.depan} {mahasiswa?.Nama?.belakang} dengan nim {mahasiswa?.Nim} dari fakultas {mahasiswa?.Fakultas}");
    }
}
