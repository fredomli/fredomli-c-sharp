using csharp_wpf_demo.Common.Model;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace csharp_wpf_demo.ViewModels
{
    class IndexViewModel : BindableBase
    {
        public IndexViewModel()
        {
            TaskBars = new ObservableCollection<TaskBar>();
            CreateTaskBars();
            CreateTestList();
        }

        // 当属性值改变的时候，执行RaisePropertyChanged()发送通知
        private ObservableCollection<TaskBar> taskBars;

        public ObservableCollection<TaskBar> TaskBars
        {
            get { return taskBars; }
            set { taskBars = value;  RaisePropertyChanged(); }
        }

        /// <summary>
        /// 待办列表
        /// </summary>
        private ObservableCollection<TaskList> tasklist;

        public ObservableCollection<TaskList> TaskList
        {
            get { return tasklist; }
            set { tasklist = value; RaisePropertyChanged(); }
        }
        /// <summary>
        /// 备忘录
        /// </summary>
        private ObservableCollection<MemoList> memolist;

        public ObservableCollection<MemoList> MemoList
        {
            get { return memolist; }
            set { memolist = value; RaisePropertyChanged(); }
        }
        /// <summary>
        /// 任务栏数据
        /// </summary>
        void CreateTaskBars()
        {
            TaskBars.Add(new TaskBar() { Iocn = "ClockFast", Title = "汇总", Content = "125", Color = "#FF0CA0FF", Target = "" });
            TaskBars.Add(new TaskBar() { Iocn = "ClockCheckOutline", Title = "已完成", Content = "75", Color = "#FF1ECA3A", Target = "" });
            TaskBars.Add(new TaskBar() { Iocn = "ChartLineVariant", Title = "完成率", Content = "60%", Color = "#FF02C6DC", Target = "" });
            TaskBars.Add(new TaskBar() { Iocn = "PlaylistStar", Title = "备忘录", Content = "19", Color = "#FFFFA000", Target = "" });
        }

        /// <summary>
        /// 备忘录和任务列表测试数据
        /// </summary>
        void CreateTestList()
        {
            TaskList = new ObservableCollection<TaskList>(); 
            MemoList = new ObservableCollection<MemoList>();

            for (int i = 0; i < 50; i++)
            {
                TaskList.Add(new TaskList() { Id = i+1, Title="待办" + ++i, Content="待办事项", Status = 0,CreateDate = new DateTime(), UpdateDate = new DateTime()});
            }

            for (int i = 0; i < 50; i++)
            {
                MemoList.Add(new MemoList() { Id = i+1, Title = "备忘" + ++i, Content = "备忘录", Status = 0, CreateDate = new DateTime(), UpdateDate = new DateTime() });
            }
        }
    }
}
