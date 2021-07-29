using System;
using System.ComponentModel;

namespace TheBlogProject.Enums
{
    public enum ModerationType
    {
        [Description("Political propaganda")]
        Political,
        [Description("Offensive language")]
        Language,
        [Description("Drug references")]
        Drugs,
        [Description("Threatening Speech")]
        Threatening,
        [Description("Sexual content")]
        Sexual,
        [Description("Hate Speech")]
        HateSpeech,
        [Description("Targeted shaming")]
        Shaming
    }
}
