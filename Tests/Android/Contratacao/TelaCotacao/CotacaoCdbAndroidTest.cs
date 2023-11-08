using Automacao_ION_Mobile_Renda_Fixa_CDB.Commons;
using Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.Android.Contratacao.TelaCotacao;
using Core_Automacao.Models.Mobile;
using Core_Automacao.Plataformas.Mobile;
using NUnit.Framework;
//using Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.Android.Contratacao.TelaCotacao;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Tests.Android.Contratacao.TelaCotacao
{
    public class CotacaoCdbAndroidTest
    {
        private readonly CotacaoCdbHelper _cotacaoCdbHelper;
        private AppiumServiceNew _service;
        private Uteis _uteis;

        private const string NAO_EXECUTA_ACESSO_PADRAO = "NAO_EXECUTA_ACESSO_PADRAO";

        public CotacaoCdbAndroidTest()
        {
            _cotacaoCdbHelper = new CotacaoCdbHelper();
            _uteis = new Uteis();
        }

        [SetUp, Retry(1)]
        public void Setup()
        {
            var categoria = TestContext.CurrentContext.Test.Properties.Get("Category");
            _service = new AppiumServiceNew(PlataformaMobile.Android);

            if (categoria is not NAO_EXECUTA_ACESSO_PADRAO)
            {
                _uteis.AcessoPadraoTelaCotacaoCDBAndroid(_service, Constants.AGENCIA, Constants.CONTA, Constants.SENHA);
            }
        }

        [TearDown]
        public void TearDown()
        {
            if (_service is not null)
            {
                _service.Desliga_Conexao();
            }
        }

        [Test, Retry(1), Order(1)]
        public void SnapShotTelaCotacaoTest()
        {
            _cotacaoCdbHelper.SnapShotTelaCotacaoHelper(_service);

            Assert.IsNotNull(_cotacaoCdbHelper.cotacaoCDB.BotaoVoltar.ElementoAndroid);
            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoPaginacao.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.TextoPaginacao.TextoObtido);
            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoTituloCDBDiItau.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.TextoTituloCDBDiItau.TextoObtido.Substring(0, 14));
            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoDisponivelParaAplicacao.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.TextoDisponivelParaAplicacao.TextoObtido.Substring(0, 30));
            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoAplicar.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.TextoAplicar.TextoObtido);
            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoValorRS000.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.TextoValorRS000.TextoObtido);
            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoDataAplicacao.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.TextoDataAplicacao.TextoObtido);
            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoNaoAlteraDataAplicacao.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.TextoNaoAlteraDataAplicacao.TextoObtido);
            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.BotaoUmRealInsercaoRapida.TextoObtido);
            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.BotaoDoisReaisInsercaoRapida.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.BotaoDoisReaisInsercaoRapida.TextoObtido);
            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.BotaoTresReaisInsercaoRapida.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.BotaoTresReaisInsercaoRapida.TextoObtido);
            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoObtido);
        }

        [Test, Retry(1), Order(2)]
        public void VerificaBotaoVoltarTelaCotacaoTest()
        {
            _cotacaoCdbHelper.VerificaBotaoVoltarTelaCotacaoHelper(_service);

            Assert.AreEqual(_cotacaoCdbHelper.informacoesGeraisCDB.BotaoInvestir.TextoEsperadoAndroid, _cotacaoCdbHelper.informacoesGeraisCDB.BotaoInvestir.TextoObtido);
        }

        [Test, Retry(1), Order(3)]
        public void VerificaBotoesInsercaoRapidaTest()
        {
            _cotacaoCdbHelper.VerificaBotoesInsercaoRapidaHelper(_service);

            Assert.AreEqual("R$10,00", _cotacaoCdbHelper.cotacaoCDB.TextoValorRS000.TextoObtido);
        }

        [Test, Retry(1), Order(4)]
        public void VerificaMensagemValorMinimoTest()
        {
            _cotacaoCdbHelper.VerificaMensagemValorMinimoHelper(_service);

            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoMensagemValorMinimo.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.TextoMensagemValorMinimo.TextoObtido);
        }

        [Test, Retry(1), Order(5)]
        public void VerificaMensagemValorMultiploTest()
        {
            _cotacaoCdbHelper.VerificaMensagemValorMultiploHelper(_service);

            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoMensagemValorMultiplo.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.TextoMensagemValorMultiplo.TextoObtido);
        }

        [Test, Retry(1), Order(6), Ignore("HOMOLOGAÇÃO")]
        [Category(NAO_EXECUTA_ACESSO_PADRAO)]
        public void VerificaMensagemValorMaximoTest()
        {
            _cotacaoCdbHelper.VerificaMensagemValorMaximoHelper(_service);

            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoMensagemValorMaximo.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.TextoMensagemValorMaximo.TextoObtido);
        }

        [Test, Retry(1), Order(7)]
        public void VerificaMensagemSemSaldoTest()
        {
            _cotacaoCdbHelper.VerificaMensagemSemSaldoHelper(_service);

            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoMensagemSemSaldo.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.TextoMensagemSemSaldo.TextoObtido);
        }

        [Test, Retry(1), Order(8)]
        public void VerificaQuebraDeLinhaValorGrandeTest()
        {
            int valorAntesQuebra = _cotacaoCdbHelper.VerificaQuebraDeLinhaValorGrandeHelper(_service);

            Assert.IsTrue(valorAntesQuebra < _cotacaoCdbHelper.cotacaoCDB.TextoValorRS000.ElementoAndroid.Location.Y);
        }

        [Test, Retry(1), Order(9)]
        public void VerificaBotaoContinuarHabilitadoTest()
        {
            _cotacaoCdbHelper.VerificaBotaoContinuarHabilitadoHelper(_service);

            Assert.IsNotNull(_cotacaoCdbHelper.cotacaoCDB.BotaoContinuar.ElementoAndroid);
            Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.BotaoContinuar.TextoEsperadoAndroid, _cotacaoCdbHelper.cotacaoCDB.BotaoContinuar.TextoObtido);
        }

        [Test, Retry(1), Order(10), Ignore("Cria método")]
        public void VerificaBotaoContinuarDesabilitadoTest()
        {
            _cotacaoCdbHelper.VerificaBotaoContinuarDesabilitadoHelper(_service);

            Assert.AreEqual("Não exibido na tela", _cotacaoCdbHelper.cotacaoCDB.BotaoContinuar.ElementoVisivelNaTela);
        }
    }
}