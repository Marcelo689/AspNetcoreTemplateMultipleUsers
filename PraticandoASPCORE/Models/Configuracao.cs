namespace PraticandoASPCORE.Models
{
    public class Configuracao
    {
        public string Fruta { get; set; }
        public string Cor { get; set; }
        public string Gosto { get; set; }   
        public string Akuma { get; set; }
        public Configuracao()
        {

        }
        public Configuracao(string fruta, string cor, string gosto, string akuma)
        {
            Fruta = fruta;
            Cor = cor;
            Gosto = gosto;
            Akuma = akuma;
        }
        public Configuracao GetConfigSalva() {
            return new Configuracao
            {
                Akuma = Properties.application.Default.Akuma,
                Cor   = Properties.application.Default.Cor,
                Gosto = Properties.application.Default.Gosto,
                Fruta = Properties.application.Default.Fruta
            };
        }
        public void AtualizaConfiguracao()
        {
            Properties.application.Default.Fruta = Fruta; 
            Properties.application.Default.Cor   = Cor;
            Properties.application.Default.Gosto = Gosto;
            Properties.application.Default.Akuma = Akuma;
            Properties.application.Default.Save();
        }
    }
}
