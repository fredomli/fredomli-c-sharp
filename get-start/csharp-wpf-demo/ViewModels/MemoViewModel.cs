using csharp_wpf_demo.Common.Model;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace csharp_wpf_demo.ViewModels
{
    class MemoViewModel : BindableBase
    {
        public MemoViewModel()
        {
            MemoList = new ObservableCollection<MemoList>();
            createMomeListData();
            AddMemoCommand = new DelegateCommand(AddMemo);
        }

        /// <summary>
        /// 添加备忘录
        /// </summary>
        public DelegateCommand AddMemoCommand { get; private set; }

        public void AddMemo()
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
        private ObservableCollection<MemoList> memoList;

        public ObservableCollection<MemoList> MemoList
        {
            get { return memoList; }
            set { memoList = value; RaisePropertyChanged(); }
        }

        public void createMomeListData()
        {
            MemoList = new ObservableCollection<MemoList>();

            for (int i = 0; i < 50; i++)
            {
                MemoList.Add(new MemoList() { Id = i + 1, Title = "待办" + ++i, Content = "待办事项", Status = 0, CreateDate = new DateTime(), UpdateDate = new DateTime() });
            }
        }

    }
}
