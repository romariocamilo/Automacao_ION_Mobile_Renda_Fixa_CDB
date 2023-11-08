using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB
{
    public class AuxiliarGeral
    {
        public string LeJsonCapabilities(string nomeArquivo)
        {
            try
            {
                return File.ReadAllText(nomeArquivo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dictionary<string, object> RetornaCapabilitiesConfiguradas(string _json)
        {
            try
            {
                return JsonConvert.DeserializeObject<Dictionary<string, object>>(_json);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}