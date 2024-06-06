using System;

namespace app.Models
{
    public class Rule
    {
        public string Name { get; set; }
        public string[] Conditions { get; set; }
        public string[] Effects { get; set; }
        public bool IsStandalone { get; set; }
    }
}
