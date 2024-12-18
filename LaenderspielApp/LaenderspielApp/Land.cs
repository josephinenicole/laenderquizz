namespace LaenderspielApp
{
    public class Land
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Hauptstadt { get; set; }
        public string Bilddatei { get; set; }
        public string KategorieWert { get; set; } 

        public Land(int id, string name, string hauptstadt, string bilddatei)
        {
            ID = id;
            Name = name;
            Hauptstadt = hauptstadt;
            Bilddatei = bilddatei;
        }
    }

}
