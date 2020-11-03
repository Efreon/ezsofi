using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RESTApiWs.Services
{
    public class HunCamService : IHunCamService

    {
        public HunCamService()
        {

        }
        public string Camellizer(string text, string lang)
        {
            StringBuilder translatedSentence = new StringBuilder();

            char[] vowels = new char[] { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
            foreach (var i in text)
            {
                if (vowels.Contains(char.ToLower(i)))
                {
                    translatedSentence.Append($"{i}v{i}");
                }
                else
                {
                    translatedSentence.Append(i);
                }
            }
            return translatedSentence.ToString();
        }
    }
}
