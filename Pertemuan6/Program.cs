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

        public Dosen(string Nama, string NIP, string Prodi, string Status) {
            this.Nama = Nama;
            this.NIP = NIP;
            this.Prodi = Prodi;
            this.Status = Status;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Dosen> arrDosen = new List<Dosen>();

            Dosen dosenJohan = new Dosen("Johan", "1234", "RPL", "Profesional");
            arrDosen.Add(dosenJohan);

            Dosen dosenMichael = new Dosen("Michael", "1111", "RPL", "Tetap");
            arrDosen.Add(dosenMichael);

            JsonSerializerOptions jsonOption = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(arrDosen, jsonOption);

            File.WriteAllText("/Users/johan/Projects/Pertemuan6/Pertemuan6/dosen.json", jsonString);
        }
    }
}
