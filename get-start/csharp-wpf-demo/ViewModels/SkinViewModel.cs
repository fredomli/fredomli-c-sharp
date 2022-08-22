using MaterialDesignColors;
using MaterialDesignColors.ColorManipulation;
using MaterialDesignThemes.Wpf;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace csharp_wpf_demo.ViewModels
{
    class SkinViewModel : BindableBase
    {
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        public SkinViewModel()
        {
            ChangeHueCommand = new DelegateCommand<Object>(ChangeHue);
        }

        private bool _isDarkTheme;
        
        public bool IsDarkTheme
        {
            get { return _isDarkTheme; }
            set { if (SetProperty(ref _isDarkTheme, value))
                {
                    ModifyTheme(theme => theme.SetBaseTheme(value ? Theme.Dark : Theme.Light));
                }
            }
        }


        public IEnumerable<ISwatch> Swatches { get; } = SwatchHelper.Swatches;

        public DelegateCommand<Object> ChangeHueCommand { get; private set; }

        private void ChangeHue(object obj)
        {
            var hue = (Color)obj;

            ITheme theme = paletteHelper.GetTheme();
            theme.PrimaryLight = new ColorPair(hue.Lighten());
            theme.PrimaryMid = new ColorPair(hue);
            theme.PrimaryDark = new ColorPair(hue.Darken());

            paletteHelper.SetTheme(theme);
        }

        private static void  ModifyTheme(Action<ITheme> modifycationAction)
        {
            var paletteHelper = new PaletteHelper();
            ITheme theme = paletteHelper.GetTheme();
            modifycationAction?.Invoke(theme);
            paletteHelper.SetTheme(theme);
        }
    }
}
