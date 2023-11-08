using Core_Automacao.Models.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class Carteira
    {
        public ElementoMobile BotaoCDB { get; private set; }
        public ElementoMobile BotaoOpcoesCDB { get; private set; }
        public ElementoMobile BotaoResgatar { get; private set; }

        public Carteira()
        {
            BotaoCDB = new ElementoMobile(TipoIdentificador.IdAcessibilidade, TipoIdentificador.NaoDefinido, "Mais detalhes sobre CDB, Renda Fixa e Estruturados", string.Empty, string.Empty, string.Empty);
            BotaoOpcoesCDB = new ElementoMobile(TipoIdentificador.Xpath, TipoIdentificador.NaoDefinido, "(//android.widget.ImageButton[@content-desc=\"Mais opções do produto\"])[1]", string.Empty, string.Empty, string.Empty);
            BotaoResgatar = new ElementoMobile(TipoIdentificador.Class, TipoIdentificador.NaoDefinido, "android.widget.Button", "Resgatar", string.Empty, string.Empty);
        }
    }
}
