using csharp_wpf_demo.Common.Model;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System;
using Prism.Commands;
using Prism.Regions;
using csharp_wpf_demo.Extensions;

namespace csharp_wpf_demo.ViewModels
{
    class MainViewModel:BindableBase
    {
        /// <summary>
        /// 菜单对象初始化
        /// </summary>
        public MainViewModel(IRegionManager regionManager)
        {
            MenuBars = new ObservableCollection<MenuBar>();
            CreateMenuBar();

            // 命令代理执行对象
            NavigateCommand = new DelegateCommand<MenuBar>(Navigate);

            // 前进后退
            GoBackCommand = new DelegateCommand(() => {
                if (journal != null && journal.CanGoBack)
                    journal.GoBack();
            });

            GoForwardCommand = new DelegateCommand(() => {
                if (journal != null && journal.CanGoForward)
                    journal.GoForward();
            });

            // regionManage初始化
            this.regionManager = regionManager;

        }
        /// <summary>
        /// 导航命令
        /// </summary>
        public DelegateCommand<MenuBar> NavigateCommand { get; private set; }

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
        /// 前进后退命令
        /// </summary>
        private IRegionNavigationJournal journal;

        public DelegateCommand GoBackCommand { get; private set;}

        public DelegateCommand GoForwardCommand { get; private set; }


        /// <summary>
        /// 菜单数据
        /// </summary>
        void CreateMenuBar()
        {
            // 获取数据
            MenuBars.Add(new MenuBar() { Icon = "Home",Title = "首页",NameSpace = "IndexView"});
            MenuBars.Add(new MenuBar() { Icon = "Note", Title = "待办事项", NameSpace = "NoteView" });
            MenuBars.Add(new MenuBar() { Icon = "NotePlusOutline", Title = "备忘录", NameSpace = "MemoView" });
            MenuBars.Add(new MenuBar() { Icon = "Cog", Title = "设置", NameSpace = "SettingView" });
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
          
            regionManager.Regions[PrismManager.MainViewRegionName].RequestNavigate(obj.NameSpace,back =>
            {
                journal = back.Context.NavigationService.Journal;
            });
        }
    }
}
