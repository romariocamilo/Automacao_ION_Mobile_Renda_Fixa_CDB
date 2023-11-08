using Core_Automacao.Models.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class Login
    {
        public ElementoMobile CampoAgencia { get; private set; }
        public ElementoMobile CampoConta { get; private set; }
        public ElementoMobile CampoSenha { get; private set; }
        public ElementoMobile BotaoEntrar { get; private set; }
        public ElementoMobile BotaoValidando { get; private set; }
        public ElementoMobile BotaoDeslogar { get; private set; }
        public ElementoMobile BotaoGavetaSair { get; private set; }

        public Login()
        {
            CampoAgencia = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.Id, "agencyEditText", "textField_agency", string.Empty, string.Empty);
            CampoConta = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.Id, "accountEditText", identificadorIos: "textField_cc", string.Empty, string.Empty);
            CampoSenha = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.Id, "passwordEditText", identificadorIos: "textField_password", string.Empty, string.Empty);

            BotaoEntrar = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "loginButton", identificadorIos: "Entrar", string.Empty, string.Empty);
            BotaoValidando = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "loginButton", identificadorIos: "Validando...", string.Empty, string.Empty);
            BotaoDeslogar = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.Id, "loginButton", identificadorIos: "button_userOptions", string.Empty, string.Empty);
            BotaoGavetaSair = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.Id, "loginButton", identificadorIos: "button_close", string.Empty, string.Empty);
        }
    }
}