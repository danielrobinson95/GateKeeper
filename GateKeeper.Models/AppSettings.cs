using System;

namespace GateKeeper.Models
{
    public class AppSettings
    {
        public int PauseLength { get; set; }
        public int IterationCount { get; set; }
        public string DtmfToneUrl { get; set; }
    }
}
