using Automacao_ION_Mobile_Renda_Fixa_CDB.Pages;
using Automacao_ION_Mobile_Renda_Fixa_CDB.Commons;
using Core_Automacao.Plataformas.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.Android.Contratacao.TelaCotacao
{
    public class CotacaoCdbHelper
    {
        private readonly StorieExterno _storieExterno;
        private readonly SelecaoAmbiente _selecaoAmbiente;
        private readonly BemVindo _bemVindo;
        private readonly Login _login;
        private readonly Biometria _biometria;
        private readonly StorieInterno _storieInterno;
        private readonly Home _home;
        private readonly Vitrine _vitrine;
        private readonly VitrineCDBeRendaFixa _vitrineCDBeRendaFixa;
        public readonly InformacoesGeraisCDB informacoesGeraisCDB;
        public readonly CotacaoCDB cotacaoCDB;
        //public readonly ConfirmacaoCDB confirmacaoCDB;

        public CotacaoCdbHelper()
        {
            _storieExterno = new StorieExterno();
            _selecaoAmbiente = new SelecaoAmbiente();
            _bemVindo = new BemVindo();
            _login = new Login();
            _biometria = new Biometria();
            _storieInterno = new StorieInterno();
            _home = new Home();
            _vitrine = new Vitrine();
            _vitrineCDBeRendaFixa = new VitrineCDBeRendaFixa();
            informacoesGeraisCDB = new InformacoesGeraisCDB();
            cotacaoCDB = new CotacaoCDB();
            //confirmacaoCDB = new ConfirmacaoCDB();
        }

        public void SnapShotTelaCotacaoHelper(AppiumServiceNew appiumServiceNew)
        {
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.BotaoVoltar);
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoPaginacao);
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoTituloCDBDiItau);
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoDisponivelParaAplicacao);
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoAplicar);
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoValorRS000);
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoDataAplicacao);
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoNaoAlteraDataAplicacao);
            var listaElementos = appiumServiceNew.BuscaVariosElementoMobile(cotacaoCDB.BotaoUmRealInsercaoRapida);
            cotacaoCDB.BotaoUmRealInsercaoRapida = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementos, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);

            listaElementos = appiumServiceNew.BuscaVariosElementoMobile(cotacaoCDB.BotaoDoisReaisInsercaoRapida);
            cotacaoCDB.BotaoDoisReaisInsercaoRapida = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementos, cotacaoCDB.BotaoDoisReaisInsercaoRapida.TextoEsperadoAndroid);

            listaElementos = appiumServiceNew.BuscaVariosElementoMobile(cotacaoCDB.BotaoTresReaisInsercaoRapida);
            cotacaoCDB.BotaoTresReaisInsercaoRapida = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementos, cotacaoCDB.BotaoTresReaisInsercaoRapida.TextoEsperadoAndroid);

            appiumServiceNew.ScrollCarroselParaDireitaPorIdParandoComTexto(cotacaoCDB.TrilhoBotoesInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoEsperadoAndroid);

            listaElementos = appiumServiceNew.BuscaVariosElementoMobile(cotacaoCDB.BotaoQuatroReaisInsercaoRapida);
            cotacaoCDB.BotaoQuatroReaisInsercaoRapida = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementos, cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoEsperadoAndroid);
        }

        public void VerificaBotaoVoltarTelaCotacaoHelper(AppiumServiceNew appiumServiceNew)
        {
            appiumServiceNew.ClicaNoElementoMobile(cotacaoCDB.BotaoVoltar);
            appiumServiceNew.BuscaElementoMobile(informacoesGeraisCDB.BotaoInvestir);
        }

        public void VerificaBotoesInsercaoRapidaHelper(AppiumServiceNew appiumServiceNew)
        {
            var listaElementos = appiumServiceNew.BuscaVariosElementoMobile(cotacaoCDB.BotaoUmRealInsercaoRapida);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(listaElementos, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(listaElementos, cotacaoCDB.BotaoDoisReaisInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(listaElementos, cotacaoCDB.BotaoTresReaisInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ScrollCarroselParaDireitaPorIdParandoComTexto(cotacaoCDB.TrilhoBotoesInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoEsperadoAndroid);
            listaElementos = appiumServiceNew.BuscaVariosElementoMobile(cotacaoCDB.BotaoQuatroReaisInsercaoRapida);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(listaElementos, cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoEsperadoAndroid);

            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoValorRS000);
        }

        public void VerificaMensagemValorMinimoHelper(AppiumServiceNew appiumServiceNew)
        {
            appiumServiceNew.EscreveTecladoNativo(cotacaoCDB.TextoValorRS000, "1");
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoMensagemValorMinimo);
        }

        public void VerificaMensagemValorMultiploHelper(AppiumServiceNew appiumServiceNew)
        {
            appiumServiceNew.EscreveTecladoNativo(cotacaoCDB.TextoValorRS000, "101");
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoMensagemValorMultiplo);
        }

        public void VerificaMensagemValorMaximoHelper(AppiumServiceNew appiumServiceNew)
        {
            Uteis uteis = new Uteis();
            uteis.AcessoPadraoTelaCotacaoCDBAndroid(appiumServiceNew, Constants.AGENCIA, Constants.CONTA, Constants.SENHA);

            appiumServiceNew.EscreveTecladoNativo(cotacaoCDB.TextoValorRS000, "9000000000");
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoMensagemValorMaximo);
        }

        public void VerificaMensagemSemSaldoHelper(AppiumServiceNew appiumServiceNew)
        {
            appiumServiceNew.EscreveTecladoNativo(cotacaoCDB.TextoValorRS000, "600000000");
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoMensagemSemSaldo);
        }

        public int VerificaQuebraDeLinhaValorGrandeHelper(AppiumServiceNew appiumServiceNew)
        {
            var valorAntesQuebra = appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoValorRS000).ElementoAndroid.Location.Y;
            appiumServiceNew.EscreveTecladoNativo(cotacaoCDB.TextoValorRS000, "1000000000");
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoValorRS000);

            return valorAntesQuebra;
        }

        public void VerificaBotaoContinuarHabilitadoHelper(AppiumServiceNew appiumServiceNew)
        {
            var listaElementos = appiumServiceNew.BuscaVariosElementoMobile(cotacaoCDB.BotaoUmRealInsercaoRapida);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(listaElementos, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
            
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.BotaoContinuar);
        }

        public void VerificaBotaoContinuarDesabilitadoHelper(AppiumServiceNew appiumServiceNew)
        {
            var listaElementos = appiumServiceNew.BuscaVariosElementoMobile(cotacaoCDB.BotaoUmRealInsercaoRapida);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(listaElementos, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);

            //appiumServiceNew.VerificaSeElementoEstaNaTelaPorId(cotacaoCDB.BotaoContinuar);
            //appiumServiceNew.EscreveTecladoNativo(cotacaoCDB.TextoValorRS000, "1");
            //appiumServiceNew.OcultaTecladoNativo();
            //appiumServiceNew.VerificaSeElementoEstaNaTelaPorId(cotacaoCDB.BotaoContinuar);
        }
    }
}