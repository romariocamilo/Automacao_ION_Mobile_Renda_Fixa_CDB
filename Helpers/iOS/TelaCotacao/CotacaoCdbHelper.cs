// using Automacao_ION_Mobile_Renda_Fixa_CDB.Pages;
// using Automacao_ION_Mobile_Renda_Fixa_CDB.Commons;
// using Core_Automacao.Plataformas.Mobile;
// using System.Threading;
// using System.Diagnostics;

// namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.iOS.TelaCotacao
// {
//     public class CotacaoCdbHelper
//     {
//         private readonly StorieExterno _storieExterno;
//         private readonly SelecaoAmbiente _selecaoAmbiente;
//         private readonly BemVindo _bemVindo;
//         private readonly Login _login;
//         private readonly StorieInterno _storieInterno;
//         private readonly Home _home;
//         private readonly Vitrine _vitrine;
//         private readonly VitrineCDBeRendaFixa _vitrineCDBeRendaFixa;
//         public readonly InformacoesGeraisCDB informacoesGeraisCDB;
//         public readonly CotacaoCDB cotacaoCDB;
//         public readonly ConfirmacaoCDB confirmacaoCDB;

//         public CotacaoCdbHelper()
//         {
//             _storieExterno = new StorieExterno();
//             _selecaoAmbiente = new SelecaoAmbiente();
//             _bemVindo = new BemVindo();
//             _login = new Login();
//             _storieInterno = new StorieInterno();
//             _home = new Home();
//             _vitrine = new Vitrine();
//             _vitrineCDBeRendaFixa = new VitrineCDBeRendaFixa();
//             informacoesGeraisCDB = new InformacoesGeraisCDB();
//             cotacaoCDB = new CotacaoCDB();
//             confirmacaoCDB = new ConfirmacaoCDB();
//         }

//         public void AcessoPadraoTelaCotacaoCDB(AppiumService appiumService)
//         {
//             // appiumService.ClicaPorIdAcessibilidade(_selecaoAmbiente.CheckBoxNovoCiam);
//             appiumService.ClicaPorIdAcessibilidade(_selecaoAmbiente.BotaoSeguirParaApp);
//             // appiumService.ClicaPorIdAcessibilidade(_storieExterno.BotaoFechar);

//             // Verificar se está logado
//             if (appiumService.VerificaSeElementoEstaNaTelaPorIdAcessibilidade(_login.BotaoDeslogar).ElementoVisivelNaTela != "Exibido na tela")
//             {
//                 appiumService.ClicaPorIdAcessibilidade(_bemVindo.BotaoJaSouCliente);
//                 // Thread.Sleep(5000);
//                 appiumService.EscrevePorId(_login.CampoAgencia, Constants.AGENCIA); //.EscreveTecladoNativo(_login.CampoAgencia, "1500");
//                 appiumService.EscrevePorId(_login.CampoConta, Constants.CONTA);
//                 appiumService.AguardaElementoSumirDaTela(_login.BotaoValidando, 3); 
//             } else {
//                 // appiumService.ClicaPorIdAcessibilidade(_login.BotaoDeslogar);
//                 // appiumService.ClicaPorId(_login.BotaoGavetaSair); 
//                 // appiumService.ClicaPorIdDeAcessibilidadeCasoApareca(_storieExterno.BotaoFechar, 2);
//                 // appiumService.ClicaPorIdAcessibilidade(_bemVindo.BotaoJaSouCliente);
//                 // // Thread.Sleep(5000);
//                 // appiumService.EscrevePorId(_login.CampoAgencia, Constants.agencia); //.EscreveTecladoNativo(_login.CampoAgencia, "1500");
//                 // appiumService.EscrevePorId(_login.CampoConta, Constants.conta);
//                 appiumService.AguardaElementoSumirDaTela(_login.BotaoValidando, 3); 
//             }

//             Thread.Sleep(3000);
//             // Esse trecho de digitar um dígito a mais só está aqui porque no meu emulador tem um bug que o botão entrar não aparece no login,
//             // então tenho que digitar 1230011 e apagar o último 1
//             appiumService.EscrevePorId(_login.CampoSenha, Constants.SENHA + "1");
//             appiumService.EscreveTecladoNativo(_login.CampoSenha, "Apagar", true);
//             appiumService.ClicaPorNameEParteDoTexto(_login.BotaoEntrar, _login.BotaoEntrar.TextoEsperado);
//             appiumService.ClicaPorIdDeAcessibilidadeCasoApareca(_storieInterno.BotaoFechar, 30);
//              Process.Start("afplay","/System/Library/Sounds/Blow.aiff");
//             // Login Final


//             appiumService.ClicaPorIdAcessibilidade(_home.MenuVitrine);
           
//             // Thread.Sleep(2000);
        
//             // appiumService.EM_TESTE_ScrollCarroselParaDireitaPorIdAcessibilidadeParandoComTexto(_vitrine.TrilhoCardProdutos, 
//                                                                                             //    _vitrine.CardCdbRendaFixa, 
//                                                                                             //    _vitrine.CardCdbRendaFixa.TextoEsperado);
//             Process.Start("afplay","/System/Library/Sounds/Frog.aiff");
//             // appiumService.EM_TESTE_ClicaPorParteDoNome(_vitrine.CardCdbRendaFixa, _vitrine.CardCdbRendaFixa.TextoEsperado);
            
//             appiumService.ClicaPorIdAcessibilidade(_vitrineCDBeRendaFixa.BotaoBusca);
//             appiumService.EscrevePorClassName(_vitrineCDBeRendaFixa.BarraBusca, "cdb di itau");
//             appiumService.EM_TESTE_ClicaPorParteDoNome(_vitrineCDBeRendaFixa.CelulaCDB, "search_results_tableview_cell_product_one_name_label");

            
//             appiumService.ClicaPorIdCasoApareca(informacoesGeraisCDB.BotaoFecharDica, 10);
//             appiumService.ClicaPorId(informacoesGeraisCDB.BotaoInvestir);
//         } 


//         public void SnapShotTelaCotacaoHelper(AppiumService appiumService)
//         {
//             appiumService.BuscaPorIdAcessibilidade(cotacaoCDB.BotaoVoltar);
//             appiumService.BuscaPorName(cotacaoCDB.Paginacao);
//             appiumService.BuscaPorIdAcessibilidade(cotacaoCDB.TextoTituloCDB);
//             appiumService.BuscaPorIdAcessibilidade(cotacaoCDB.TextoDisponivelParaAplicacao);
//             appiumService.BuscaPorIdAcessibilidade(cotacaoCDB.TextoAplicar);
//             appiumService.BuscaPorIdAcessibilidade(cotacaoCDB.TextoValorAplicacao);
//             appiumService.BuscaPorIdAcessibilidade(cotacaoCDB.TextoDataAplicacao);
//             // appiumService.BuscaPorId(cotacaoCDB.TextoNaoAlteraDataAplicacao);
//             appiumService.EM_TESTE_BuscaPorIdAcessibilidadeEParteDoTexto(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperado);
//             appiumService.EM_TESTE_BuscaPorIdAcessibilidadeEParteDoTexto(cotacaoCDB.BotaoDoisReaisInsercaoRapida, cotacaoCDB.BotaoDoisReaisInsercaoRapida.TextoEsperado);
//             appiumService.EM_TESTE_BuscaPorIdAcessibilidadeEParteDoTexto(cotacaoCDB.BotaoTresReaisInsercaoRapida, cotacaoCDB.BotaoTresReaisInsercaoRapida.TextoEsperado);
//             // appiumService.ScrollCarroselParaDireitaPorIdParandoComTexto(cotacaoCDB.TrilhoBotoesInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoEsperado);
//             appiumService.EM_TESTE_BuscaPorIdAcessibilidadeEParteDoTexto(cotacaoCDB.BotaoQuatroReaisInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoEsperado);
//         }

//         public void VerificaBotaoVoltarTelaCotacaoHelper(AppiumService appiumService)
//         {
//             appiumService.ClicaPorIdAcessibilidade(cotacaoCDB.BotaoVoltar);
//             appiumService.BuscaPorIdAcessibilidade(informacoesGeraisCDB.TextoCDBDIItau);
//             appiumService.ScrollDeBaixoParaCima();
//             appiumService.ClicaPorIdAcessibilidade(informacoesGeraisCDB.BotaoInfoBanco);
//             appiumService.ScrollDeBaixoParaCima();
//             appiumService.BuscaPorIdAcessibilidade(informacoesGeraisCDB.TextoBancoItauAndroid);
//         }

//         public void VerificaBotoesInsercaoRapidaHelper(AppiumService appiumService)
//         {
//             appiumService.ClicaIdEParteDoTexto(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperado);
//             appiumService.ClicaIdEParteDoTexto(cotacaoCDB.BotaoDoisReaisInsercaoRapida, cotacaoCDB.BotaoDoisReaisInsercaoRapida.TextoEsperado);
//             appiumService.ClicaIdEParteDoTexto(cotacaoCDB.BotaoTresReaisInsercaoRapida, cotacaoCDB.BotaoTresReaisInsercaoRapida.TextoEsperado);
//             // appiumService.ScrollCarroselParaDireitaPorIdParandoComTexto(cotacaoCDB.TrilhoBotoesInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoEsperado);
//             appiumService.ClicaIdEParteDoTexto(cotacaoCDB.BotaoQuatroReaisInsercaoRapida, cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoEsperado);
//             appiumService.BuscaPorId(cotacaoCDB.TextoValorAplicacao);
//         }

//         public void VerificaMensagemValorMinimoHelper(AppiumService appiumService)
//         {
//             appiumService.EscreveTecladoNativo(cotacaoCDB.TextoValorAplicacao, "1");
//             appiumService.BuscaPorIdAcessibilidade(cotacaoCDB.TextoMensagemValorMinimoIOS);
//         }

//         public void VerificaMensagemValorMultiploHelper(AppiumService appiumService)
//         {
//             appiumService.EscreveTecladoNativo(cotacaoCDB.TextoValorAplicacao, "101");
//             appiumService.BuscaPorId(cotacaoCDB.TextoMensagemValorMultiploIOS);
//         }

//         public void VerificaMensagemValorMaximoHelper(AppiumService appiumService)
//         {
//             appiumService.EscreveTecladoNativo(cotacaoCDB.TextoValorAplicacao, "10000000000");
//             appiumService.BuscaPorIdAcessibilidade(cotacaoCDB.TextoMensagemValorMaximoIOS);
//         }

//         public void VerificaMensagemSemSaldoHelper(AppiumService appiumService)
//         {
//             // appiumService.ClicaPorId(_storieExterno.BotaoFechar);
//             // appiumService.ClicaPorId(_selecaoAmbiente.CheckBoxNovoCiam);
//             // appiumService.ClicaPorId(_selecaoAmbiente.BotaoSeguirParaApp);
//             // appiumService.ClicaPorId(_bemVindo.BotaoJaSouCliente);
//             // appiumService.EscreveTecladoNativo(_login.CampoAgencia, Constants.agencia);
//             // appiumService.EscreveTecladoNativo(_login.CampoConta, Constants.conta);
//             // appiumService.AguardaElementoSumirDaTela(_login.BotaoValidando, 3);
//             // appiumService.EscreveTecladoNativo(_login.CampoSenha, Constants.senha);
//             // appiumService.ClicaPorId(_login.BotaoEntrar);
//             // appiumService.ClicaPorIdCasoApareca(_storieInterno.BotaoFechar, 30);
//             // appiumService.ClicaPorId(_home.MenuVitrine);
//             // appiumService.ScrollCarroselParaDireitaPorIdParandoComTexto(_vitrine.TrilhoCardProdutos, _vitrine.CardCdbRendaFixa, _vitrine.CardCdbRendaFixa.TextoEsperado);
//             // appiumService.ClicaPorTexto(_vitrine.CardCdbRendaFixa, _vitrine.CardCdbRendaFixa.TextoEsperado);
//             // appiumService.ClicaPorId(_vitrineCDBeRendaFixa.TextoTituloCDBDI);
//             // appiumService.ClicaPorIdCasoApareca(informacoesGeraisCDB.BotaoFecharDica, 10);
//             // appiumService.ClicaPorId(informacoesGeraisCDB.BotaoInvestir);

//             appiumService.EscreveTecladoNativo(cotacaoCDB.TextoValorAplicacao, "600000000");
//             appiumService.BuscaPorIdAcessibilidade(cotacaoCDB.TextoMensagemSemSaldo);
//         }

//         public int VerificaQuebraDeLinhaValorGrandeHelper(AppiumService appiumService)
//         {
//             // TO DO: Descobrir como validar a quebra de linha

//             var valorAntesQuebra = appiumService.BuscaPorId(cotacaoCDB.TextoValorAplicacao).ElementoIOS.Location.Y;
//             appiumService.EscreveTecladoNativo(cotacaoCDB.TextoValorAplicacao, "1000000000");
//             appiumService.BuscaPorId(cotacaoCDB.TextoValorAplicacao);

//             return valorAntesQuebra;
//         }

//         public void VerificaBotaoContinuarHabilitadoHelper(AppiumService appiumService)
//         {
//             appiumService.ClicaIdEParteDoTexto(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperado);
//             appiumService.BuscaPorId(cotacaoCDB.BotaoContinuar);
//         }

//         public void VerificaBotaoContinuarDesabilitadoHelper(AppiumService appiumService)
//         {
//             appiumService.ClicaIdEParteDoTexto(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperado);
//             appiumService.VerificaSeElementoEstaNaTelaPorId(cotacaoCDB.BotaoContinuar);
//             appiumService.EscreveTecladoNativo(cotacaoCDB.TextoValorAplicacao, "1");
//             appiumService.OcultaTecladoNativo();
//             appiumService.VerificaSeElementoEstaNaTelaPorId(cotacaoCDB.BotaoContinuar);
//         }
//     }
// }