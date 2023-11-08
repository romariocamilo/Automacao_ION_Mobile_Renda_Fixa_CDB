using Core_Automacao.Models.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class Campanhas
    {
        public ElementoMobile BotaoFechar { get; private set; }

        public Campanhas()
        {
            BotaoFechar = new ElementoMobile(TipoIdentificador.Class, TipoIdentificador.NaoDefinido, "android.widget.Button", string.Empty, "Fechar", string.Empty);
        }
    }
}
