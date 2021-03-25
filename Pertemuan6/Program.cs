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
        public string Telepon { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string hasilBaca = File.ReadAllText("/Users/johan/Projects/Pertemuan6/Pertemuan6/input.json");

            List<Dosen> listDosen = JsonSerializer.Deserialize<List<Dosen>>(hasilBaca);

            for (int i = 0; i < listDosen.Count; i++) {
                Console.WriteLine( listDosen[i].Telepon);
            }
        }
    }
}
