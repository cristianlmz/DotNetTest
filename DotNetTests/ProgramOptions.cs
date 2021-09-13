using System;

namespace DotNetTests
{
    class ProgramOptions
    {
        public int ID { get; set; }
        public string SiteID { get; set; }
        public bool IsActive { get; set; }
        public TimeSpan Interval { get; set; }
    }
}
