using System.Collections.Generic;

namespace projekat2
{
    class LG : Mobilni
    {
        private readonly ModelTelefona Model;
        public Boja Boja { get; set; }
        public enum ModelTelefona
        {
            Q51,
            W10Alpha,
            K61,
            G8XThinQ
        }
        public LG(ModelTelefona Model, string BojaT)
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
                case ModelTelefona.Q51:
                    CPU = "Mediatek MT6762";
                    RAM = 3;
                    Memorija = 32;
                    GPU = "PowerVR GE8320";
                    VelicinaEkrana = 6.5;
                    break;
                case ModelTelefona.W10Alpha:
                    CPU = "Unisoc SC9863A";
                    RAM = 3;
                    Memorija = 32;
                    GPU = "PowerVR IMG8322";
                    VelicinaEkrana = 5.71;
                    break;
                case ModelTelefona.K61:
                    CPU = "Mediatek MT6765";
                    RAM = 4;
                    Memorija = 128;
                    GPU = "PowerVR GE8320";
                    VelicinaEkrana = 6.5;
                    break;
                case ModelTelefona.G8XThinQ:
                    CPU = "Snapdragon 855";
                    RAM = 6;
                    Memorija = 128;
                    GPU = "Adreno 640";
                    VelicinaEkrana = 6.4;
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
            return "LG"; 
        }
        public static string ModelToString(string model)
        {
            if (model == "W10Alpha") return "W10 Alpha";
            else if (model == "G8XThinQ") return "G8X ThinQ";
            else return model;
        }
    }
}
