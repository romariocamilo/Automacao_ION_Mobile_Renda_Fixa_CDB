using Automacao_ION_Mobile_Renda_Fixa_CDB.Pages;
using Core_Automacao.Plataformas.Mobile;
using System.ComponentModel;
using System.Threading;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Commons
{
    public class Uteis
    {
        private readonly StorieExterno _storieExterno;
        private readonly SelecaoAmbiente _selecaoAmbiente;
        private readonly BemVindo _bemVindo;
        private readonly Login _login;
        private readonly ErroLogin _erroLogin;
        private readonly Biometria _biometria;
        private readonly StorieInterno _storieInterno;
        private readonly Home _home;
        private readonly Vitrine _vitrine;
        private readonly Lupa _lupa;
        private readonly VitrineCDBeRendaFixa _vitrineCDBeRendaFixa;
        private readonly InformacoesGeraisCDB _informacoesGeraisCDB;
        // private readonly CotacaoCDB _cotacaoCDB;
        // private readonly ConfirmacaoCDB _confirmacaoCDB;
        // private readonly PoliticaPrivacidade _politicaPrivacidade;
        private readonly Campanhas _campanhas;
        private readonly Carteira _carteira;

        public Uteis()
        {
            _storieExterno = new StorieExterno();
            _selecaoAmbiente = new SelecaoAmbiente();
            _bemVindo = new BemVindo();
            _login = new Login();
            _erroLogin = new ErroLogin();
            _biometria = new Biometria();
            _storieInterno = new StorieInterno();
            _home = new Home();
            _vitrine = new Vitrine();
            _lupa = new Lupa();
            _vitrineCDBeRendaFixa = new VitrineCDBeRendaFixa();
            _informacoesGeraisCDB = new InformacoesGeraisCDB();
            _campanhas = new Campanhas();
            _carteira = new Carteira();
        }

        public void AcessoPadraoTelaCotacaoCDBAndroid(AppiumServiceNew appiumServiceNew, string agencia, string conta, string senha)
        {
            bool fluxoCarrosel = true;
            bool fluxoLupa = false;

            appiumServiceNew.ClicCasoApareca(_storieExterno.BotaoFechar, 5);
            //appiumServiceNew.ClicaNoElementoMobile(_selecaoAmbiente.CheckBoxNovoCiam);
            //appiumServiceNew.ClicaNoElementoMobile(_selecaoAmbiente.BotaoSeguirParaApp);
            appiumServiceNew.ClicaNoElementoMobile(_bemVindo.BotaoJaSouCliente);
            appiumServiceNew.BuscaElementoMobile(_login.CampoAgencia);
            appiumServiceNew.EscreveNoElementoMobile(_login.CampoAgencia, agencia);
            appiumServiceNew.EscreveNoElementoMobile(_login.CampoConta, conta);
            appiumServiceNew.AguardaElementoSumirDaTela(_login.BotaoValidando, 3);
            appiumServiceNew.EscreveNoElementoMobile(_login.CampoSenha, senha);
            appiumServiceNew.ClicaNoElementoMobile(_login.BotaoEntrar);


            //PROD
            appiumServiceNew.ClicaNoElementoMobile(_biometria.BotaoAgoraNaoAutenticator);
            appiumServiceNew.ClicaNoElementoMobile(_biometria.BotaoAgoraNao);
            appiumServiceNew.ClicaNoElementoMobile(_biometria.BotaoLembrarMaisTarde);

            try
            {
                appiumServiceNew.ClicCasoApareca(_storieInterno.BotaoFechar, 10);
                appiumServiceNew.ClicaNoElementoMobile(_home.MenuVitrine);
            }
            catch
            {
                appiumServiceNew.ClicaNoElementoMobile(_home.MenuVitrine);
            }

            try
            {
                appiumServiceNew.ScrollCarroselParaDireitaPorIdParandoComTexto(_vitrine.TrilhoCardProdutos, _vitrine.CardCdbRendaFixaAndroid, _vitrine.CardCdbRendaFixaAndroid.TextoEsperadoAndroid);
                var listaPesquisaCardsCarrossel = appiumServiceNew.BuscaVariosElementoMobile(_vitrine.CardCdbRendaFixaAndroid);
                appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(listaPesquisaCardsCarrossel, "CDB e Renda Fixa");
            }
            catch
            {
                fluxoCarrosel = false;
                fluxoLupa = true;
                appiumServiceNew.ClicaNoElementoMobile(_vitrine.BotaoLupaPesquisa);
                appiumServiceNew.EscreveNoElementoMobile(_lupa.CampoPesquisa, "CDB DI Itaú");
                var listaPesquisa = appiumServiceNew.BuscaVariosElementoMobile(_lupa.OpcaoCDBDIItau);
                appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(listaPesquisa, "CDB DI Itaú");
                appiumServiceNew.ClicaNoElementoMobile(_informacoesGeraisCDB.BotaoFecharDica);
                appiumServiceNew.ClicaNoElementoMobile(_informacoesGeraisCDB.BotaoInvestir);
            }

            if (fluxoCarrosel && !fluxoLupa)
            {
                var listaProdutosVitrine = appiumServiceNew.BuscaVariosElementoMobile(_vitrineCDBeRendaFixa.TextoTituloCDBDI);
                appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(listaProdutosVitrine, _vitrineCDBeRendaFixa.TextoTituloCDBDI.TextoEsperadoAndroid);
                appiumServiceNew.ClicaNoElementoMobile(_informacoesGeraisCDB.BotaoFecharDica);
                appiumServiceNew.ClicaNoElementoMobile(_informacoesGeraisCDB.BotaoInvestir);
            }

        }


        // public void AcessoPadraoTelaValorCDBAndroid(AppiumService appiumService, string agencia, string conta, string senha)
        // {
        //     appiumService.ClicaPorId(_storieExterno.BotaoFechar);
        //     //appiumService.ClicaPorId(_selecaoAmbiente.CheckBoxNovoCiam);
        //     appiumService.ClicaPorId(_selecaoAmbiente.BotaoSeguirParaApp);
        //     appiumService.ClicaPorId(_bemVindo.BotaoJaSouCliente);
        //     appiumService.BuscaPorId(_login.CampoAgencia);
        //     appiumService.EscrevePorId(_login.CampoAgencia, agencia);
        //     appiumService.EscrevePorId(_login.CampoConta, conta);
        //     appiumService.AguardaElementoSumirDaTela(_login.BotaoValidando, 3);
        //     appiumService.EscreveTecladoNativo(_login.CampoSenha, senha);
        //     appiumService.ClicaPorId(_login.BotaoEntrar);
        //     //appiumService.ClicaPorId(_biometria.BotaoAgoraNao);
        //     //appiumService.ClicaPorId(_biometria.BotaoLembrarMaisTarde);
        //     appiumService.ClicaPorIdCasoApareca(_storieInterno.BotaoFechar, 15);
        //     appiumService.ClicaPorClasseETextoCasoApareca(_campanhas.BotaoFechar, _campanhas.BotaoFechar.TextoEsperado, 15);
        //     Thread.Sleep(10000);
        //     appiumService.ScrollDeBaixoParaCima();
        //     appiumService.ScrollDeBaixoParaCima();
        //     appiumService.ClicaPorIdAcessibilidade(_carteira.BotaoCDB);
        //     Thread.Sleep(5000);
        //     appiumService.ScrollDeBaixoParaCima();
        //     appiumService.ClicaPorXpath(_carteira.BotaoOpcoesCDB);
        //     appiumService.ClicaPorClasseETexto(_carteira.BotaoResgatar, _carteira.BotaoResgatar.TextoEsperado);
        // }
    }
}