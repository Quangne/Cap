using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap
{
    public class WelcomeModel
    {
        public string ImageSource { get; set; }
        public string BackGroundImageSource { get; set; }
        public string Title { get; set; }
        public string HelpText { get; set; }
        public bool IsShow1 { get; set; }
        public bool IsShow2 { get; set; }
        public Thickness MarginImage { get; set; }
    }
}
