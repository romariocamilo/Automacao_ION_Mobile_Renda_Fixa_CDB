using Automacao_ION_Mobile_Renda_Fixa_CDB.Commons;
using Core_Automacao.Models.Mobile;
using Core_Automacao.Plataformas.Mobile;
using NUnit.Framework;
using Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.Android.Contratacao.TelaConfirmacao;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Tests.Android.Contratacao.TelaConfirmacao
{
    public class ConfirmacaoCdbAndroidTest
    {
        private readonly ConfirmacaoCdbHelper _confirmacaoCdbHelper;
        private AppiumServiceNew _service;
        private Uteis _uteis;

        public ConfirmacaoCdbAndroidTest()
        {
            _confirmacaoCdbHelper = new ConfirmacaoCdbHelper();
            _uteis = new Uteis();
        }

        [SetUp, Retry(1)]
        public void Setup()
        {
            _service = new AppiumServiceNew(PlataformaMobile.Android);
            _uteis.AcessoPadraoTelaCotacaoCDBAndroid(_service, Constants.AGENCIA, Constants.CONTA, Constants.SENHA);
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
        public void SnapShotTelaConfirmaçãoTest()
        {
            _confirmacaoCdbHelper.SnapShotTelaConfirmaçãoHelper(_service);

            Assert.IsNotNull(_confirmacaoCdbHelper.confirmacaoCDB.BotaoVoltar.ElementoAndroid);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.Paginacao.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.Paginacao.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoTituloCDB.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoTituloCDB.TextoObtido.Substring(0, 14));
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoTituloConfirmacao.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoTituloConfirmacao.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoValorASerAplicado.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoValorASerAplicado.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoValorMonetario.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoValorMonetario.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoDataSolicitacao.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoDataSolicitacao.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoDataSolicitacaoHoje.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoDataSolicitacaoHoje.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoRendaFixaPosFixado.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoRendaFixaPosFixado.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoProdutoCDBDIItau.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoProdutoCDBDIItau.TextoObtido.Substring(0, 14));
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoRentabilidade.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoRentabilidade.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoValorPorcentagemRentabilidade.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoValorPorcentagemRentabilidade.TextoObtido.Substring(6, 8));
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoRisco.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoRisco.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoValorRisco.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoValorRisco.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoImpostoRenda.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoImpostoRenda.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.Texto180Dias.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.Texto180Dias.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.Texto225Porcento.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.Texto225Porcento.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.Texto181_360Dias.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.Texto181_360Dias.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.Texto20Porcento.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.Texto20Porcento.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.Texto361_720Dias.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.Texto361_720Dias.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.Texto175Porcento.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.Texto175Porcento.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoAcima720Dias.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoAcima720Dias.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.Texto15Porcento.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.Texto15Porcento.TextoObtido);
            //Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoResgate.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoResgate.TextoObtido);
            //Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoValorResgate.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoValorResgate.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.CampoIdentificacaoComprovante.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.CampoIdentificacaoComprovante.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoInformativoResgate.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoInformativoResgate.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoInformativoIof.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoInformativoIof.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoInformativoComprovante.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoInformativoComprovante.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoInformativoFgc.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoInformativoFgc.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.TextoInformativoLgpd.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.TextoInformativoLgpd.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.BotaoPoliticaPrivacidade.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.BotaoPoliticaPrivacidade.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.BotaoConfirmar.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.BotaoConfirmar.TextoObtido);
        }

        [Test, Retry(1), Order(2)]
        public void VerificaBotaoVoltarTelaConfimacaoTest()
        {
            _confirmacaoCdbHelper.VerificaBotaoVoltarTelaConfimacaoHelper(_service);

            Assert.AreEqual(_confirmacaoCdbHelper.cotacaoCDB.TextoPaginacao.TextoEsperadoAndroid, _confirmacaoCdbHelper.cotacaoCDB.TextoPaginacao.TextoObtido);
        }

        [Test, Retry(1), Order(3)]
        public void VerificaCampoIdentificacaoComprovanteTest()
        {
            string textoIdentificacao = "texto identificacao";

            _confirmacaoCdbHelper.VerificaCampoIdentificacaoComprovanteHelper(_service, textoIdentificacao);

            Assert.AreEqual(textoIdentificacao, _confirmacaoCdbHelper.confirmacaoCDB.CampoIdentificacaoComprovante.TextoObtido);
        }

        [Test, Retry(1), Order(4)]
        public void VerificaBotaoPoliticaPrivacidadeTest()
        {
            _confirmacaoCdbHelper.VerificaBotaoPoliticaPrivacidadeHelper(_service);

            Assert.AreEqual(_confirmacaoCdbHelper.politicaPrivacidade.TextoPoliticaPrivacidade.TextoEsperadoAndroid, _confirmacaoCdbHelper.politicaPrivacidade.TextoPoliticaPrivacidade.TextoObtido);
        }

        [Test, Retry(1), Order(5)]
        public void VerificaBotaoVoltarPoliticaPrivacidadeTest()
        {
            _confirmacaoCdbHelper.VerificaBotaoVoltarPoliticaPrivacidadeHelper(_service);

            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.BotaoPoliticaPrivacidade.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.BotaoPoliticaPrivacidade.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.confirmacaoCDB.BotaoConfirmar.TextoEsperadoAndroid, _confirmacaoCdbHelper.confirmacaoCDB.BotaoConfirmar.TextoObtido);
        }

        [Test, Retry(1), Order(6)]
        public void VerificaConteudoPoliticaPrivacidadeTest()
        {
            _confirmacaoCdbHelper.VerificaConteudoPoliticaPrivacidadeHelper(_service);

            Assert.IsNotNull(_confirmacaoCdbHelper.politicaPrivacidade.BotaoVoltar.ElementoAndroid);
            Assert.AreEqual(_confirmacaoCdbHelper.politicaPrivacidade.TextoPoliticaPrivacidade.TextoEsperadoAndroid, _confirmacaoCdbHelper.politicaPrivacidade.TextoPoliticaPrivacidade.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.politicaPrivacidade.TextoTratamentoDadosPessoais.TextoEsperadoAndroid, _confirmacaoCdbHelper.politicaPrivacidade.TextoTratamentoDadosPessoais.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.politicaPrivacidade.TextoInformativoItau.TextoEsperadoAndroid, _confirmacaoCdbHelper.politicaPrivacidade.TextoInformativoItau.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.politicaPrivacidade.TextoInformativoItemResumo.TextoEsperadoAndroid, _confirmacaoCdbHelper.politicaPrivacidade.TextoInformativoItemResumo.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.politicaPrivacidade.BotaoDadosColetados.TextoEsperadoAndroid, _confirmacaoCdbHelper.politicaPrivacidade.BotaoDadosColetados.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.politicaPrivacidade.TextoInformativoDadosColetados.TextoEsperadoAndroid, _confirmacaoCdbHelper.politicaPrivacidade.TextoInformativoDadosColetados.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.politicaPrivacidade.BotaoFinalidadeUsoDados.TextoEsperadoAndroid, _confirmacaoCdbHelper.politicaPrivacidade.BotaoFinalidadeUsoDados.TextoObtido);
            //Assert.AreEqual(_confirmacaoCdbHelper.politicaPrivacidade.TextoFinalidadeUsoDados.TextoEsperadoAndroid, _confirmacaoCdbHelper.politicaPrivacidade.TextoFinalidadeUsoDados.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.politicaPrivacidade.BotaoDadosBiometricos.TextoEsperadoAndroid, _confirmacaoCdbHelper.politicaPrivacidade.BotaoDadosBiometricos.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.politicaPrivacidade.TextoDadosBiometricos.TextoEsperadoAndroid, _confirmacaoCdbHelper.politicaPrivacidade.TextoDadosBiometricos.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.politicaPrivacidade.BotaoCompartilhamentoDados.TextoEsperadoAndroid, _confirmacaoCdbHelper.politicaPrivacidade.BotaoCompartilhamentoDados.TextoObtido);
            Assert.AreEqual(_confirmacaoCdbHelper.politicaPrivacidade.TextoInformativoCompartilhamentoDados.TextoEsperadoAndroid, _confirmacaoCdbHelper.politicaPrivacidade.TextoInformativoCompartilhamentoDados.TextoObtido);
        }
    }
}