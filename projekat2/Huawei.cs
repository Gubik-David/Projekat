using System.Collections.Generic;

namespace projekat2
{
    class Huawei : Mobilni
    {
        private readonly ModelTelefona Model;
        public Boja Boja { get; set; }
        public enum ModelTelefona
        {
            P40,
            MateXs,
            Y7p,
            Enjoy10
        }

        public Huawei(ModelTelefona Model, string BojaT)
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
            switch (Model)
            {
                case ModelTelefona.P40:
                    CPU = "Kirin 990 5G";
                    RAM = 8;
                    Memorija = 256;
                    GPU = "Mali-G76 MP16";
                    VelicinaEkrana = 6.1;
                    break;
                case ModelTelefona.MateXs:
                    CPU = "Kirin 990 5G";
                    RAM = 8;
                    Memorija = 512;
                    GPU = "Mali-G76 MP16";
                    VelicinaEkrana = 8.0;
                    break;
                case ModelTelefona.Y7p:
                    CPU = "Kirin 710F";
                    RAM = 4;
                    Memorija = 64;
                    GPU = "Mali-G51 MP4";
                    VelicinaEkrana = 6.39;
                    break;
                case ModelTelefona.Enjoy10:
                    CPU = "Kirin 710F";
                    RAM = 6;
                    Memorija = 64;
                    GPU = "Mali-G51 MP4";
                    VelicinaEkrana = 6.39;
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
            return "Huawei"; 
        }
        public static string ModelToString(string model)
        {
            if (model == "Enjoy10") return "Enjoy 10";
            else if (model == "MateXs") return "Mate Xs";
            else return model;
        }
    }
}
