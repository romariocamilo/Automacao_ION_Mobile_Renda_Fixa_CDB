using Core_Automacao.Models.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class Biometria
    {
        public ElementoMobile BotaoAgoraNaoAutenticator { get; private set; }
        public ElementoMobile BotaoAgoraNao { get; private set; }
        public ElementoMobile BotaoLembrarMaisTarde { get; private set; }

        public Biometria()
        {
            BotaoAgoraNaoAutenticator = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "android:id/autofill_save_no", string.Empty, string.Empty, string.Empty);
            BotaoAgoraNao = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "cancelButton", string.Empty, string.Empty, string.Empty);
            BotaoLembrarMaisTarde = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "com.itau.investimentos:id/reminder_later_option_view", string.Empty, string.Empty, string.Empty);
        }
    }
}