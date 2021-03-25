using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace Pertemuan6
{
    class Dosen {
        public string Nama { get; set; }
        public string NIP { get; set; }
        public string Prodi { get; set; }
        public string Status { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string hasilBaca = File.ReadAllText("/Users/johan/Projects/Pertemuan6/Pertemuan6/input.json");

            Dosen dosenJson = JsonSerializer.Deserialize<Dosen>(hasilBaca);

            Console.WriteLine(dosenJson.Prodi);
        }
    }
}
