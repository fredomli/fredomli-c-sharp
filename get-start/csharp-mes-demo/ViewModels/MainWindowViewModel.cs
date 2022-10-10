

using csharp_mes_demo.Mvvm.Notify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mes_demo.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            Test = 1;
        }

        private int test;
        public int Test
        {
            get { return test; }
            set { test = value; RaisePropertyChanged(); }
        }
    }
}
