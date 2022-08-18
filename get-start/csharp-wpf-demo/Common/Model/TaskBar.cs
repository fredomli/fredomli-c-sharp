using Prism.Mvvm;
using System;

namespace csharp_wpf_demo.Common.Model
{
    class TaskBar : BindableBase {


        /// <summary>
        /// 图标
        /// </summary>
        private String icon;

        /// <summary>
        /// 标题
        /// </summary>
        private String title;

        /// <summary>
        /// 内容
        /// </summary>
        private String content;

        /// <summary>
        /// 背景颜色
        /// </summary>
        private String color;

        /// <summary>
        /// 命名空间，即跳转路由
        /// </summary>
        private String target;

        public String Iocn
        {
            get { return icon; }
            set { icon = value; }
        }

        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        public String Content
        {
            get { return content; }
            set { content = value; }
        }

        public String Color
        {
            get { return color; }
            set { color = value; }
        }

        public String Target
        {
            get { return target; }
            set { target = value; }
        }
    }
}
