using csharp_wpf_demo.Common.Model;
using csharp_wpf_demo.Extensions;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Collections.ObjectModel;

namespace csharp_wpf_demo.ViewModels
{
    class SettingViewModel: BindableBase
    {
        public SettingViewModel(IRegionManager regionManager)
        {
            MenuBars = new ObservableCollection<MenuBar>();
            CreateMenuBar();

            NavigateCommand = new DelegateCommand<MenuBar>(Navigate);

            // regionManage初始化
            this.regionManager = regionManager;
        }
        /// <summary>
        /// 导航命令
        /// </summary>
        public DelegateCommand<MenuBar> NavigateCommand { get; private set; }

        /// <summary>
        /// 区域管理
        /// </summary>
        private readonly IRegionManager regionManager;

        /// <summary>
        /// 菜单参数，用户数据绑定
        /// </summary>
        private ObservableCollection<MenuBar> menuBars;

        public ObservableCollection<MenuBar> MenuBars
        {
            get { return menuBars; }
            set { menuBars = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 菜单数据
        /// </summary>
        public void CreateMenuBar()
        {
            MenuBars.Add(new MenuBar() { Icon = "Home", Title = "个性化", NameSpace = "SkinView" });
            MenuBars.Add(new MenuBar() { Icon = "Note", Title = "系统设置", NameSpace = "ConfigView" });
            MenuBars.Add(new MenuBar() { Icon = "NotePlusOutline", Title = "关于更多", NameSpace = "AboutView" });
        }

        /// <summary>
        /// 命令
        /// </summary>
        /// <param name="obj"></param>
        private void Navigate(MenuBar obj)
        {
            // 导航跳转
            if (obj == null || string.IsNullOrWhiteSpace(obj.NameSpace))
                return;

            regionManager.Regions[PrismManager.SettingsViewRegionName].RequestNavigate(obj.NameSpace);
        }
    }
}
