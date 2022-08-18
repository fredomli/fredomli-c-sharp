using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism.Ioc;
using Prism.DryIoc;
using Prism.Mvvm;
using csharp_wpf_demo.Views;
using csharp_wpf_demo.ViewModels;

namespace csharp_wpf_demo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>

    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Views.MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<IndexView, IndexViewModel>();
            containerRegistry.RegisterForNavigation<NoteView, NoteViewModel>();
            containerRegistry.RegisterForNavigation<MemoView, MemoViewModel>();
            containerRegistry.RegisterForNavigation<SettingView, SettingViewModel>();
        }

        // 手动加载ViewModel
        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
            // ViewModelLocationProvider.Register<NoteView,NoteViewModel>();
        }
    }
}
