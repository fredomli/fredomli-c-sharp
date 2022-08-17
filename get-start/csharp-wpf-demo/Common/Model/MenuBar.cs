using Prism.Mvvm;
using System;


namespace csharp_wpf_demo.Common.Model
{
    class MenuBar:BindableBase
    {
        private String icon;
        /// <summary>
        /// 菜单图标
        /// </summary>
        public String Icon
        {
            get { return icon; }
            set { icon = value; }
        }

        private String title;
        /// <summary>
        /// 菜单名称
        /// </summary>
        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        private String nameSpace;
        /// <summary>
        /// 菜单命名空间
        /// </summary>
        public String NameSpace
        {
            get { return nameSpace; }
            set { nameSpace = value; }
        }

    }
}
