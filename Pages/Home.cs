using Core_Automacao.Models.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class Home
    {
        public ElementoMobile MenuVitrine { get; set; }

        public Home()
        {
            MenuVitrine = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "tab_vitrine", "vitrine", string.Empty, string.Empty);
        }
    }
}