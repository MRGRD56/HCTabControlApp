using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HCTabControlApp
{
    public class Tab : NotifyPropertyChanged
    {
        public Tab(string header)
        {
            Header = header;
            NewHeader = header;
        }

        private string _header;

        public string Header
        {
            get => _header;
            set
            {
                if (value == _header) return;
                _header = value;
                OnPropertyChanged();
            }
        }

        public string NewHeader { get; set; }
        
        public ICommand UpdateHeaderCommand => new Command<object>(() =>
        {
            Header = NewHeader;
        });
    }
}
