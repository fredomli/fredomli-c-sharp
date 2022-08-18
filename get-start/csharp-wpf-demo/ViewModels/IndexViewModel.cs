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
        }

        // 当属性值改变的时候，执行RaisePropertyChanged()发送通知
        private ObservableCollection<TaskBar> taskBars;

        public ObservableCollection<TaskBar> TaskBars
        {
            get { return taskBars; }
            set { taskBars = value;  RaisePropertyChanged(); }
        }


        void CreateTaskBars()
        {
            TaskBars.Add(new TaskBar() { Iocn = "ClockFast", Title = "汇总", Content = "125", Color = "#FF0CA0FF", Target = "" });
            TaskBars.Add(new TaskBar() { Iocn = "ClockCheckOutline", Title = "已完成", Content = "75", Color = "#FF1ECA3A", Target = "" });
            TaskBars.Add(new TaskBar() { Iocn = "ChartLineVariant", Title = "完成率", Content = "60%", Color = "#FF02C6DC", Target = "" });
            TaskBars.Add(new TaskBar() { Iocn = "PlaylistStar", Title = "备忘录", Content = "19", Color = "#FFFFA000", Target = "" });
        }
    }
}
