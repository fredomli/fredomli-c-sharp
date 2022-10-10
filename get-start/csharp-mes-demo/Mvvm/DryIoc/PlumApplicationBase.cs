using csharp_mes_demo.Mvvm.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace csharp_mes_demo.Mvvm.DryIoc
{
    /// <summary>
    /// 摘要：
    ///     启动程序基类。
    /// </summary>
    public abstract class PlumApplicationBase : Application
    {

        public PlumContainerProvider Container { get; }
        /// <summary>
        /// 摘要：
        ///     创建应用程序的主窗体，是程序的入口，使用该方法设置启动窗体。
        /// </summary>
        /// <returns></returns>
        protected abstract Window CreateShell();

        /// <summary>
        /// 摘要：
        ///     配置ViewModel加载器。
        /// </summary>
        protected abstract void ConfigureViewModelLocator();

        /// <summary>
        /// 摘要：
        ///     应用程序的容器注册。
        /// </summary>
        /// <param name="containerRegistry"></param>
        protected abstract void RegisterTypes(PlumContainerRegistry containerRegistry);
    }
}
