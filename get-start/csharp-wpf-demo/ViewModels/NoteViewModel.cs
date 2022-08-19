using csharp_wpf_demo.Common.Model;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace csharp_wpf_demo.ViewModels
{
    class NoteViewModel:BindableBase
    {
        public NoteViewModel()
        {
            Console.WriteLine("构造函数");
            NoteList = new ObservableCollection<TaskList>();
            createNoteListData();
            AddNoteCommand = new DelegateCommand(AddNode);
            Console.WriteLine("*****************node 执行");
        }

        /// <summary>
        /// 添加待办
        /// </summary>
        public DelegateCommand AddNoteCommand { get; private set; }
        
        public void AddNode()
        {
            IsRightDrawerOpen = true;
        }

        /// <summary>
        /// NodeView界面右侧抽屉是否打开
        /// </summary>
        private bool isRightDrawerOpen;

        public bool IsRightDrawerOpen
        {
            get { return isRightDrawerOpen; }
            set { isRightDrawerOpen = value; RaisePropertyChanged(); }
        }


        // 数据绑定
        private ObservableCollection<TaskList> noteList;

        public ObservableCollection<TaskList> NoteList
        {
            get { return noteList; }
            set { noteList = value; RaisePropertyChanged(); }
        }

        public void createNoteListData()
        {
            NoteList = new ObservableCollection<TaskList>();

            for (int i = 0; i < 50; i++)
            {
                NoteList.Add(new TaskList() { Id = i + 1, Title = "待办" + ++i, Content = "待办事项", Status = 0, CreateDate = new DateTime(), UpdateDate = new DateTime() });
            }
        }

    }
}
