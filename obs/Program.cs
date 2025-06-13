namespace obs
{
    internal static class Program
    {
        // Dictionary<ANAHTAR, DEGER>
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
            List<Ogrenci> ogrenciler= new List<Ogrenci>();
            List<Ders> dersler= new List<Ders>();
            Dictionary<Ogrenci, List<Not>> notlar = new Dictionary<Ogrenci, List<Not>>(); //öðrenci kim hangi dersten kaç aldý
        }

        
    }
}