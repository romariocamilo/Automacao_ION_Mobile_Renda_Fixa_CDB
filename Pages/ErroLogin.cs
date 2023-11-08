using Core_Automacao.Models.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class ErroLogin
    {
        public ElementoMobile TextoNaoFoiPossivelConectar { get; set; }
        public ElementoMobile BotaoFechar { get; set; }

        public ErroLogin()
        {
            TextoNaoFoiPossivelConectar = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "com.itau.investimentos.debug:id/error_title_text", "Não foi possível conectar", string.Empty, string.Empty);
            BotaoFechar = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "com.itau.investimentos.debug:id/left_button", string.Empty, string.Empty, string.Empty);
        }
    }
}