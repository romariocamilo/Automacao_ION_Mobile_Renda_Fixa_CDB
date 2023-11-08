using Automacao_ION_Mobile_Renda_Fixa_CDB.Pages;
using Automacao_ION_Mobile_Renda_Fixa_CDB.Commons;
using Core_Automacao.Plataformas.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.Android.Contratacao.TelaCotacao
{
    public class CotacaoCdbHelper
    {
        public readonly InformacoesGeraisCDB informacoesGeraisCDB;
        public readonly CotacaoCDB cotacaoCDB;

        public CotacaoCdbHelper()
        {
            informacoesGeraisCDB = new InformacoesGeraisCDB();
            cotacaoCDB = new CotacaoCDB();
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
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoDoisReaisInsercaoRapida, cotacaoCDB.BotaoDoisReaisInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoTresReaisInsercaoRapida, cotacaoCDB.BotaoTresReaisInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ScrollCarroselParaDireitaPorIdParandoComTexto(cotacaoCDB.TrilhoBotoesInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoQuatroReaisInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoEsperadoAndroid);
        }

        public void VerificaBotaoVoltarTelaCotacaoHelper(AppiumServiceNew appiumServiceNew)
        {
            appiumServiceNew.ClicaNoElementoMobile(cotacaoCDB.BotaoVoltar);
            appiumServiceNew.BuscaElementoMobile(informacoesGeraisCDB.BotaoInvestir);
        }

        public void VerificaBotoesInsercaoRapidaHelper(AppiumServiceNew appiumServiceNew)
        {
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoDoisReaisInsercaoRapida, cotacaoCDB.BotaoDoisReaisInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoTresReaisInsercaoRapida, cotacaoCDB.BotaoTresReaisInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ScrollCarroselParaDireitaPorIdParandoComTexto(cotacaoCDB.TrilhoBotoesInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoQuatroReaisInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoEsperadoAndroid);

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
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);  
            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.BotaoContinuar);
        }

        public void VerificaBotaoContinuarDesabilitadoHelper(AppiumServiceNew appiumServiceNew)
        {
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);

            //appiumServiceNew.VerificaSeElementoEstaNaTelaPorId(cotacaoCDB.BotaoContinuar);
            //appiumServiceNew.EscreveTecladoNativo(cotacaoCDB.TextoValorRS000, "1");
            //appiumServiceNew.OcultaTecladoNativo();
            //appiumServiceNew.VerificaSeElementoEstaNaTelaPorId(cotacaoCDB.BotaoContinuar);
        }
    }
}