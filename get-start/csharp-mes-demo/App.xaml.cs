
using DryIoc;
using Prism.DryIoc;
using Prism.Ioc;
using csharp_mes_demo.Views;
using System.Windows;


namespace csharp_mes_demo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Views.MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // index nav
            //containerRegistry.RegisterForNavigation<IndexView, IndexViewModel>();
            //containerRegistry.RegisterForNavigation<NoteView, NoteViewModel>();
            //containerRegistry.RegisterForNavigation<MemoView, MemoViewModel>();
            //containerRegistry.RegisterForNavigation<SettingView, SettingViewModel>();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
        }
    }
}
