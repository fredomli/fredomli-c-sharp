using csharp_wpf_demo.Common.Model;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System;

namespace csharp_wpf_demo.ViewModels
{
    class MainViewModel:BindableBase
    {
        /// <summary>
        /// 菜单对象初始化
        /// </summary>
        public MainViewModel()
        {
            MenuBars = new ObservableCollection<MenuBar>();
            CreateMenuBar();
        }

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
        void CreateMenuBar()
        {
            MenuBars.Add(new MenuBar() { Icon = "Home",Title = "首页",NameSpace = "IndexView"});
            MenuBars.Add(new MenuBar() { Icon = "Note", Title = "待办事项", NameSpace = "NoteView" });
            MenuBars.Add(new MenuBar() { Icon = "NotePlusOutline", Title = "备忘录", NameSpace = "MemoView" });
            MenuBars.Add(new MenuBar() { Icon = "Cog", Title = "设置", NameSpace = "SettingView" });
        }
    }
}
