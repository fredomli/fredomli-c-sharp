﻿
using System.Windows;
using System.Windows.Input;

namespace csharp_wpf_demo.Views
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();

            // btnMin btnMax btnClose
            btnMin.Click += (s, e) => { this.WindowState = WindowState.Minimized; };
            btnMax.Click += (s, e) => {
                if(this.WindowState == WindowState.Maximized)
                {
                    this.WindowState = WindowState.Normal;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                }
            };
            btnClose.Click += (s, e) => { this.Close(); };

            // 鼠标拖动事件
            ColorZone.MouseMove += (s, e) => {
                if (e.LeftButton == MouseButtonState.Pressed)
                    this.DragMove();
            };
            // ColorZone双击放大或缩小
            ColorZone.MouseDoubleClick += (s, e) => {
                if (this.WindowState == WindowState.Normal)
                {
                    this.WindowState = WindowState.Maximized;
                }
                else
                {
                    this.WindowState = WindowState.Normal;
                }
            };

            // 点击侧边栏关闭事件
            menuBar.SelectionChanged += (s, e) =>
            {
                // 关闭左侧抽屉
                drawerHost.IsLeftDrawerOpen = false;
            };
        }
    }
}
