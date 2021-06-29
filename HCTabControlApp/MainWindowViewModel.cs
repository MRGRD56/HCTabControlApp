using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCTabControlApp
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Tab> Tabs1 { get; } = new();
        public ObservableCollection<Tab> Tabs2 { get; } = new();

        public MainWindowViewModel()
        {
            Tabs1.Add(new Tab("One"));
            Tabs1.Add(new Tab("Two"));
            Tabs1.Add(new Tab("Three"));

            Tabs2.Add(new Tab("One"));
            Tabs2.Add(new Tab("Two"));
            Tabs2.Add(new Tab("Three"));
        }
    }
}
