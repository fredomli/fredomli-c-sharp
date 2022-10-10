using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace csharp_mes_demo.Mvvm.Notify
{
    /// <summary>
    /// 摘要:
    ///     向客户端发出某一属性值已更改的通知。
    /// </summary>
    public abstract class BindableBase 
    {
        /// <summary>
        /// 摘要：
        ///     当属性值发生变更时触发该方法。
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 摘要：
        ///     当属性值发生变更时执行该方法。
        /// </summary>
        /// <param name="propertyName"></param>
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null){
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
