using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGithub
{
    public class SuperSecretClassNameDontWorryAboutItLikeYoureNotGoingToGuessThisAnyways
    {
        public string SecretVariable1 { get; set; }
        public string SecretVariable2 { get; set; }
        public double SuperSecretVariable1 { get; set; }
        public int UltraSecretVariable { get; set; }
        public static int EpicVariable { get; set; }

        public SuperSecretClassNameDontWorryAboutItLikeYoureNotGoingToGuessThisAnyways(string secretVariable1, string secretVariable2, double superSecretVariable1, int ultraSecretVariable)
        {
            EpicVariable++;
            SecretVariable1 = secretVariable1;
            SecretVariable2 = secretVariable2;
            SuperSecretVariable1 = superSecretVariable1;
            UltraSecretVariable = ultraSecretVariable;
        }
    }
}
