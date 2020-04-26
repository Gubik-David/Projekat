using System.Collections.Generic;

namespace projekat2
{
    class Samsung : Mobilni
    {
        private readonly ModelTelefona Model;
        public Boja Boja { get; set; }
        public enum ModelTelefona
        {
            S20,
            A71,
            M31,
            Note10
        };
        public Samsung(ModelTelefona Model, string BojaT)
        {
            this.Model = Model;
            Specifikacije();
            Boja = new Boja
            {
                BojaTelefona = BojaT
            };
        }
        private void Specifikacije()
        {
            switch(Model)
            {
                case ModelTelefona.S20:
                    CPU = "Snapdragon 865";
                    RAM = 8;
                    Memorija = 128;
                    GPU = "Adreno 650";
                    VelicinaEkrana = 6.2;
                    break;
                case ModelTelefona.A71:
                    CPU = "Snapdragon 730";
                    RAM = 8;
                    Memorija = 128;
                    GPU = "Adreno 618";
                    VelicinaEkrana = 6.7;
                    break;
                case ModelTelefona.M31:
                    CPU = "Exynos 9611";
                    RAM = 6;
                    Memorija = 128;
                    GPU = "Mali-G72 MP3";
                    VelicinaEkrana = 6.4;
                    break;
                case ModelTelefona.Note10:
                    CPU = "Exynos 9825";
                    RAM = 8;
                    Memorija = 256;
                    GPU = "Mali-G76 MP12";
                    VelicinaEkrana = 6.3;
                    break;
            }
        }
        public Dictionary<string, string> Tabela()
        {
            Dictionary<string, string> tabela = new Dictionary<string, string>();
            tabela.Add("CPU", CPU);
            tabela.Add("RAM", RAM.ToString() + "GB");
            tabela.Add("GPU", GPU);
            tabela.Add("Memorija", Memorija.ToString() + "GB");
            tabela.Add("Velicina Ekrana", VelicinaEkrana.ToString() + "\"");
            tabela.Add("Boja", Boja.BojaTelefona);
            return tabela;
        }
        public override string Proizvodjac()
        { 
            return "Samsung"; 
        }
        public static string ModelToString(string model)
        {
            if (model == "Note10") return "Note 10";
            else return model;
        }
    }
}
