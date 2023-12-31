using Core_Automacao.Models.Mobile;
using System;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class PoliticaPrivacidade
    {
        public ElementoMobile BotaoVoltar { get; set; }
        public ElementoMobile TextoPoliticaPrivacidade { get; set; }
        public ElementoMobile TextoTratamentoDadosPessoais { get; set; }
        public ElementoMobile TextoInformativoItau { get; set; }
        public ElementoMobile TextoInformativoItemResumo { get; set; }
        public ElementoMobile BotaoDadosColetados { get; set; }
        public ElementoMobile TextoInformativoDadosColetados { get; set; }
        public ElementoMobile BotaoFinalidadeUsoDados { get; set; }
        public ElementoMobile TextoFinalidadeUsoDados { get; set; }
        public ElementoMobile BotaoDadosBiometricos { get; set; }
        public ElementoMobile TextoDadosBiometricos { get; set; }
        public ElementoMobile BotaoCompartilhamentoDados { get; set; }
        public ElementoMobile TextoInformativoCompartilhamentoDados { get; set; }

        public PoliticaPrivacidade()
        {
            BotaoVoltar = new ElementoMobile(TipoIdentificador.IdAcessibilidade, TipoIdentificador.IdAcessibilidade, "Voltar", "Voltar", string.Empty, string.Empty);
            TextoPoliticaPrivacidade = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "toolbarTitle", string.Empty, "Política de Privacidade", "Política de Privacidade");
            TextoTratamentoDadosPessoais = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "detailTitle", string.Empty, "Tratamento de dados pessoais", string.Empty);
            TextoInformativoItau = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "textInfo", string.Empty, "O Itaú Unibanco S.A. e demais empresas do Conglomerado Itaú (”Itaú”) tratam dados pessoais de pessoas físicas (como clientes, representantes e sócios/acionistas de clientes pessoa jurídica) para diversas finalidades relacionadas ao desempenho de nossas atividades.", string.Empty);
            TextoInformativoItemResumo = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "textInfo", string.Empty, "Nesse item resumimos as principais informações sobre como coletamos e usamos dados pessoais. Para maiores informações, inclusive sobre os seus direitos em relação aos seus dados pessoais (como de correção, acesso aos dados e informações sobre o tratamento, eliminação, bloqueio, exclusão, oposição e portabilidade de dados pessoais), acesse a nossa Política de Privacidade em nossos canais digitais.", string.Empty);
            BotaoDadosColetados = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "btnExpandable", string.Empty, "Dados coletados", string.Empty);
            TextoInformativoDadosColetados = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "expandable_text_details", string.Empty, "Os dados pessoais coletados e tratados pelo Itaú podem incluir dados cadastrais, financeiros, transacionais ou outros dados, que podem ser fornecidos diretamente por você ou obtidos em decorrência da prestação de serviços ou fornecimento de produtos pelo Itaú a você ou a você relacionados, bem como obtidos de outras fontes conforme permitido na legislação aplicável, tais como fontes públicas, empresas do Conglomerado Itaú, outras instituições do sistema financeiro, parceiros ou fornecedores, bem como, empresas e órgãos com os quais o Conglomerado Itaú tenha alguma relação contratual e com os quais você possua vínculo.", string.Empty);
            BotaoFinalidadeUsoDados = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "btnExpandable", string.Empty, "Finalidades de uso dos dados", string.Empty);
            TextoFinalidadeUsoDados = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "expandable_text_details", string.Empty, @" 
Poderemos usar os dados pessoais para diversas finalidades relacionadas ao desempenho de nossas atividades, na forma prevista na Política de Privacidade, como por exemplo: 
I. oferta, divulgação, prestação de serviços e fornecimento de produtos; 
II. execução de contrato e de etapas prévias ao contrato, incluindo a avaliação dos produtos e serviços mais adequados ao seu perfil, bem como atividades de crédito, financeiras, de investimento, cobrança e demais atividades do Conglomerado Itaú; 
III. cumprimento de obrigações legais e regulatórias; 
IV. atendimento de requisições de autoridades administrativas e judiciais; 
V. exercício regular de direitos, inclusive em processsos administrativos, judiciais e arbitrais; 
VI. análise, gerenciamento e tratamento de potenciais riscos, incluindo os de crédito, fraude e segurança; 
VII. verificação da sua identidade e dados pessoais, inclusive dados biométricos, para fins de autenticação, segurança e/ou prevenção à fraude; 
VIII. verificação, análise e tratamento de dados pessoais para fins de avaliação, manutenção e aprimoramento dos nossos serviços; 
IX. hipóteses de legítimo interesse, como desenvolvimento e ofertas de produtos e serviços do Conglomerado Itaú.", string.Empty);
            BotaoDadosBiometricos = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "btnExpandable", string.Empty, "Dados biométricos", string.Empty);
            TextoDadosBiometricos = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "expandable_text_details", string.Empty, "Poderemos utilizar sua biometria facial e/ou digital em produtos e/ou serviços das empresas do Conglomerado Itaú para processos de identificação e/ou autenticação em sistemas eletrônicos próprios ou de terceiros para fins de segurança e prevenção a fraudes.", string.Empty);
            BotaoCompartilhamentoDados = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "btnExpandable", string.Empty, "Compartilhamento dos dados", string.Empty);
            TextoInformativoCompartilhamentoDados = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "expandable_text_details", string.Empty, "Os seus dados pessoais poderão ser compartilhados para as finalidades previstas neste documento e na nossa Política de Privacidade, como, por exemplo, entre as empresas do Conglomerado Itaú, com prestadores de serviços e fornecedores localizados no Brasil ou no exterior, bureaus de crédito de acordo com as regras aplicáveis à atividade, órgão reguladores e entidades públicas, inclusive administrativas e judiciais, e ainda, com parceiros estratégicos para possibilitar a oferta de produtos e serviços. Apenas compartilhamos dados na medida necessária, com segurança e de acordo com a legislação aplicável.", string.Empty);
        }
    }
}