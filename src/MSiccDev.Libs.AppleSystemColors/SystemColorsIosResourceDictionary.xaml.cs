
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MSiccDev.Libs.AppleSystemColors
{
    public partial class SystemColorsIosResourceDictionary
    {
        public SystemColorsIosResourceDictionary()
        {
            InitializeComponent();

            this.Add(nameof(ISystemColorsiOS.SystemRed), DependencyService.Get<ISystemColorsiOS>().SystemRed);
            this.Add(nameof(ISystemColorsiOS.SystemOrange), DependencyService.Get<ISystemColorsiOS>().SystemOrange);
            this.Add(nameof(ISystemColorsiOS.SystemYellow), DependencyService.Get<ISystemColorsiOS>().SystemYellow);
            this.Add(nameof(ISystemColorsiOS.SystemGreen), DependencyService.Get<ISystemColorsiOS>().SystemGreen);
            this.Add(nameof(ISystemColorsiOS.SystemMint), DependencyService.Get<ISystemColorsiOS>().SystemMint);
            this.Add(nameof(ISystemColorsiOS.SystemTeal), DependencyService.Get<ISystemColorsiOS>().SystemTeal);
            this.Add(nameof(ISystemColorsiOS.SystemCyan), DependencyService.Get<ISystemColorsiOS>().SystemCyan);
            this.Add(nameof(ISystemColorsiOS.SystemBlue), DependencyService.Get<ISystemColorsiOS>().SystemBlue);
            this.Add(nameof(ISystemColorsiOS.SystemIndigo), DependencyService.Get<ISystemColorsiOS>().SystemIndigo);
            this.Add(nameof(ISystemColorsiOS.SystemPurple), DependencyService.Get<ISystemColorsiOS>().SystemPurple);
            this.Add(nameof(ISystemColorsiOS.SystemPink), DependencyService.Get<ISystemColorsiOS>().SystemPink);
            this.Add(nameof(ISystemColorsiOS.SystemBrown), DependencyService.Get<ISystemColorsiOS>().SystemBrown);


            this.Add(nameof(ISystemColorsiOS.SystemGray), DependencyService.Get<ISystemColorsiOS>().SystemGray);
            this.Add(nameof(ISystemColorsiOS.SystemGray2), DependencyService.Get<ISystemColorsiOS>().SystemGray2);
            this.Add(nameof(ISystemColorsiOS.SystemGray3), DependencyService.Get<ISystemColorsiOS>().SystemGray3);
            this.Add(nameof(ISystemColorsiOS.SystemGray4), DependencyService.Get<ISystemColorsiOS>().SystemGray4);
            this.Add(nameof(ISystemColorsiOS.SystemGray5), DependencyService.Get<ISystemColorsiOS>().SystemGray5);
            this.Add(nameof(ISystemColorsiOS.SystemGray6), DependencyService.Get<ISystemColorsiOS>().SystemGray6);

            this.Add(nameof(ISystemColorsiOS.SystemLabel), DependencyService.Get<ISystemColorsiOS>().SystemLabel);
            this.Add(nameof(ISystemColorsiOS.SecondaryLabel), DependencyService.Get<ISystemColorsiOS>().SecondaryLabel);
            this.Add(nameof(ISystemColorsiOS.TertiaryLabel), DependencyService.Get<ISystemColorsiOS>().TertiaryLabel);
            this.Add(nameof(ISystemColorsiOS.QuaternaryLabel), DependencyService.Get<ISystemColorsiOS>().QuaternaryLabel);

            this.Add(nameof(ISystemColorsiOS.Placeholder), DependencyService.Get<ISystemColorsiOS>().Placeholder);
            this.Add(nameof(ISystemColorsiOS.Separator), DependencyService.Get<ISystemColorsiOS>().Separator);
            this.Add(nameof(ISystemColorsiOS.OpaqueSeparator), DependencyService.Get<ISystemColorsiOS>().OpaqueSeparator);
            this.Add(nameof(ISystemColorsiOS.LinkColor), DependencyService.Get<ISystemColorsiOS>().LinkColor);

            this.Add(nameof(ISystemColorsiOS.FillColor), DependencyService.Get<ISystemColorsiOS>().FillColor);
            this.Add(nameof(ISystemColorsiOS.SecondaryFillColor), DependencyService.Get<ISystemColorsiOS>().SecondaryFillColor);
            this.Add(nameof(ISystemColorsiOS.TertiaryFillColor), DependencyService.Get<ISystemColorsiOS>().TertiaryFillColor);
            this.Add(nameof(ISystemColorsiOS.QuaternaryFillColor), DependencyService.Get<ISystemColorsiOS>().QuaternaryFillColor);

            this.Add(nameof(ISystemColorsiOS.SystemBackgroundColor), DependencyService.Get<ISystemColorsiOS>().SystemBackgroundColor);
            this.Add(nameof(ISystemColorsiOS.SecondarySystemBackgroundColor), DependencyService.Get<ISystemColorsiOS>().SecondarySystemBackgroundColor);
            this.Add(nameof(ISystemColorsiOS.TertiarySystemBackgroundColor), DependencyService.Get<ISystemColorsiOS>().TertiarySystemBackgroundColor);

            this.Add(nameof(ISystemColorsiOS.SystemGroupedBackgroundColor), DependencyService.Get<ISystemColorsiOS>().SystemGroupedBackgroundColor);
            this.Add(nameof(ISystemColorsiOS.SecondarySystemGroupedBackgroundColor), DependencyService.Get<ISystemColorsiOS>().SecondarySystemGroupedBackgroundColor);
            this.Add(nameof(ISystemColorsiOS.TertiarySystemGroupedBackgroundColor), DependencyService.Get<ISystemColorsiOS>().TertiarySystemGroupedBackgroundColor);

            this.Add(nameof(ISystemColorsiOS.DarkTextColor), DependencyService.Get<ISystemColorsiOS>().DarkTextColor);
            this.Add(nameof(ISystemColorsiOS.LightTextColor), DependencyService.Get<ISystemColorsiOS>().LightTextColor);

        }
    }
}
