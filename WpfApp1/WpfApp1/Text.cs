using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Text : ObservableObject
    {
        private string mainWindowtext;
        public string MainWindowText { get => mainWindowtext; set => Set(ref mainWindowtext, value); }
    }
}
