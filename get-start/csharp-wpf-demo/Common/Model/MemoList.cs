using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_wpf_demo.Common.Model
{
    /// <summary>
    /// 备忘录
    /// </summary>
    class MemoList : BaseDto
    {
        private String title;
        private String content;
        private int status;

        /// <summary>
        /// 标题
        /// </summary>
        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        /// 内容
        /// </summary>
        public String Content
        {
            get { return content; }
            set { content = value; }
        }

        /// <summary>
        /// 状态
        /// </summary>
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
