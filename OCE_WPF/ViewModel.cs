using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCE_WPF
{
    class ViewModel : BaseViewModel
    {
        private string _textBoxText;
        
        public DelegateCommand Command { get; set; }
        public string TextBoxText 
        { 
            get => _textBoxText;
            set
            {
                if(_textBoxText != value)
                {
                    _textBoxText = value;
                    RaisePropertyChanged();
                }
            }
        }

        public ViewModel()
        {
            TextBoxText = "Hello, World!";
        }
    }
}
