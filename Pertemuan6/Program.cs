using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace Pertemuan6
{
    class NamaDosen {
        public string Lengkap { get; set; }
        public int Panggilan { get; set; }
    }

    class Dosen {
        public NamaDosen Nama { get; set; }
        public string NIP { get; set; }
        public string Prodi { get; set; }
        public string Status { get; set; }
        public List<string> Telepon { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string hasilBaca = File.ReadAllText("/Users/johan/Projects/Pertemuan6/Pertemuan6/input.json");

            List<Dosen> listDosen = JsonSerializer.Deserialize<List<Dosen>>(hasilBaca);

            for (int i = 0; i < listDosen.Count; i++) {
                Console.WriteLine(listDosen[i].Nama.Panggilan);

                List<string> listTelepon = listDosen[i].Telepon;
                for (int j = 0; j < listTelepon.Count; j++) {
                    Console.WriteLine("No telp ke-{0} = {1}", j+1, listTelepon[j]);
                }
            }
        }
    }
}
