using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MSiccDev.Libs.iOS.SystemColors
{
    public partial class SystemColorsIosResourceDictionary
    {
        public SystemColorsIosResourceDictionary()
        {
            InitializeComponent();

            this.Add(nameof(ISystemColors.SystemRed), DependencyService.Get<ISystemColors>().SystemRed);
            this.Add(nameof(ISystemColors.SystemOrange), DependencyService.Get<ISystemColors>().SystemOrange);
            this.Add(nameof(ISystemColors.SystemYellow), DependencyService.Get<ISystemColors>().SystemYellow);
            this.Add(nameof(ISystemColors.SystemGreen), DependencyService.Get<ISystemColors>().SystemGreen);
            this.Add(nameof(ISystemColors.SystemMint), DependencyService.Get<ISystemColors>().SystemMint);
            this.Add(nameof(ISystemColors.SystemTeal), DependencyService.Get<ISystemColors>().SystemTeal);
            this.Add(nameof(ISystemColors.SystemCyan), DependencyService.Get<ISystemColors>().SystemCyan);
            this.Add(nameof(ISystemColors.SystemBlue), DependencyService.Get<ISystemColors>().SystemBlue);
            this.Add(nameof(ISystemColors.SystemIndigo), DependencyService.Get<ISystemColors>().SystemIndigo);
            this.Add(nameof(ISystemColors.SystemPurple), DependencyService.Get<ISystemColors>().SystemPurple);
            this.Add(nameof(ISystemColors.SystemPink), DependencyService.Get<ISystemColors>().SystemPink);
            this.Add(nameof(ISystemColors.SystemBrown), DependencyService.Get<ISystemColors>().SystemBrown);


            this.Add(nameof(ISystemColors.SystemGray), DependencyService.Get<ISystemColors>().SystemGray);
            this.Add(nameof(ISystemColors.SystemGray2), DependencyService.Get<ISystemColors>().SystemGray2);
            this.Add(nameof(ISystemColors.SystemGray3), DependencyService.Get<ISystemColors>().SystemGray3);
            this.Add(nameof(ISystemColors.SystemGray4), DependencyService.Get<ISystemColors>().SystemGray4);
            this.Add(nameof(ISystemColors.SystemGray5), DependencyService.Get<ISystemColors>().SystemGray5);
            this.Add(nameof(ISystemColors.SystemGray6), DependencyService.Get<ISystemColors>().SystemGray6);

            this.Add(nameof(ISystemColors.SystemLabel), DependencyService.Get<ISystemColors>().SystemLabel);
            this.Add(nameof(ISystemColors.SecondaryLabel), DependencyService.Get<ISystemColors>().SecondaryLabel);
            this.Add(nameof(ISystemColors.TertiaryLabel), DependencyService.Get<ISystemColors>().TertiaryLabel);
            this.Add(nameof(ISystemColors.QuaternaryLabel), DependencyService.Get<ISystemColors>().QuaternaryLabel);

            this.Add(nameof(ISystemColors.Placeholder), DependencyService.Get<ISystemColors>().Placeholder);
            this.Add(nameof(ISystemColors.Separator), DependencyService.Get<ISystemColors>().Separator);
            this.Add(nameof(ISystemColors.OpaqueSeparator), DependencyService.Get<ISystemColors>().OpaqueSeparator);
            this.Add(nameof(ISystemColors.LinkColor), DependencyService.Get<ISystemColors>().LinkColor);

            this.Add(nameof(ISystemColors.FillColor), DependencyService.Get<ISystemColors>().FillColor);
            this.Add(nameof(ISystemColors.SecondaryFillColor), DependencyService.Get<ISystemColors>().SecondaryFillColor);
            this.Add(nameof(ISystemColors.TertiaryFillColor), DependencyService.Get<ISystemColors>().TertiaryFillColor);
            this.Add(nameof(ISystemColors.QuaternaryFillColor), DependencyService.Get<ISystemColors>().QuaternaryFillColor);

            this.Add(nameof(ISystemColors.SystemBackgroundColor), DependencyService.Get<ISystemColors>().SystemBackgroundColor);
            this.Add(nameof(ISystemColors.SecondarySystemBackgroundColor), DependencyService.Get<ISystemColors>().SecondarySystemBackgroundColor);
            this.Add(nameof(ISystemColors.TertiarySystemBackgroundColor), DependencyService.Get<ISystemColors>().TertiarySystemBackgroundColor);

            this.Add(nameof(ISystemColors.SystemGroupedBackgroundColor), DependencyService.Get<ISystemColors>().SystemGroupedBackgroundColor);
            this.Add(nameof(ISystemColors.SecondarySystemGroupedBackgroundColor), DependencyService.Get<ISystemColors>().SecondarySystemGroupedBackgroundColor);
            this.Add(nameof(ISystemColors.TertiarySystemGroupedBackgroundColor), DependencyService.Get<ISystemColors>().TertiarySystemGroupedBackgroundColor);

            this.Add(nameof(ISystemColors.DarkTextColor), DependencyService.Get<ISystemColors>().DarkTextColor);
            this.Add(nameof(ISystemColors.LightTextColor), DependencyService.Get<ISystemColors>().LightTextColor);

        }
    }
}
