using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MSiccDev.Libs.AppleSystemColors
{
    public partial class SystemColorsMacOSResourceDictionary
    {
        public SystemColorsMacOSResourceDictionary()
        {
            InitializeComponent();

            this.Add(nameof(ISystemColorsMacOS.SystemRed), DependencyService.Get<ISystemColorsMacOS>().SystemRed);
            this.Add(nameof(ISystemColorsMacOS.SystemOrange), DependencyService.Get<ISystemColorsMacOS>().SystemOrange);
            this.Add(nameof(ISystemColorsMacOS.SystemYellow), DependencyService.Get<ISystemColorsMacOS>().SystemYellow);
            this.Add(nameof(ISystemColorsMacOS.SystemGreen), DependencyService.Get<ISystemColorsMacOS>().SystemGreen);
            this.Add(nameof(ISystemColorsMacOS.SystemMint), DependencyService.Get<ISystemColorsMacOS>().SystemMint);
            this.Add(nameof(ISystemColorsMacOS.SystemTeal), DependencyService.Get<ISystemColorsMacOS>().SystemTeal);
            this.Add(nameof(ISystemColorsMacOS.SystemCyan), DependencyService.Get<ISystemColorsMacOS>().SystemCyan);
            this.Add(nameof(ISystemColorsMacOS.SystemBlue), DependencyService.Get<ISystemColorsMacOS>().SystemBlue);
            this.Add(nameof(ISystemColorsMacOS.SystemIndigo), DependencyService.Get<ISystemColorsMacOS>().SystemIndigo);
            this.Add(nameof(ISystemColorsMacOS.SystemPurple), DependencyService.Get<ISystemColorsMacOS>().SystemPurple);
            this.Add(nameof(ISystemColorsMacOS.SystemPink), DependencyService.Get<ISystemColorsMacOS>().SystemPink);
            this.Add(nameof(ISystemColorsMacOS.SystemBrown), DependencyService.Get<ISystemColorsMacOS>().SystemBrown);
            this.Add(nameof(ISystemColorsMacOS.SystemGray), DependencyService.Get<ISystemColorsMacOS>().SystemGray);

            this.Add(nameof(ISystemColorsMacOS.SystemLabel), DependencyService.Get<ISystemColorsMacOS>().SystemLabel);
            this.Add(nameof(ISystemColorsMacOS.SecondaryLabel), DependencyService.Get<ISystemColorsMacOS>().SecondaryLabel);
            this.Add(nameof(ISystemColorsMacOS.TertiaryLabel), DependencyService.Get<ISystemColorsMacOS>().TertiaryLabel);
            this.Add(nameof(ISystemColorsMacOS.QuaternaryLabel), DependencyService.Get<ISystemColorsMacOS>().QuaternaryLabel);

            this.Add(nameof(ISystemColorsMacOS.Placeholder), DependencyService.Get<ISystemColorsMacOS>().Placeholder);
            this.Add(nameof(ISystemColorsMacOS.Separator), DependencyService.Get<ISystemColorsMacOS>().Separator);
            this.Add(nameof(ISystemColorsMacOS.LinkColor), DependencyService.Get<ISystemColorsMacOS>().LinkColor);
            this.Add(nameof(ISystemColorsMacOS.AlternateSelectedControlTextcColor), DependencyService.Get<ISystemColorsMacOS>().AlternateSelectedControlTextcColor);

            this.Add(nameof(ISystemColorsMacOS.ControlAccent), DependencyService.Get<ISystemColorsMacOS>().ControlAccent);
            this.Add(nameof(ISystemColorsMacOS.ControlBackgroundColor), DependencyService.Get<ISystemColorsMacOS>().ControlBackgroundColor);
            this.Add(nameof(ISystemColorsMacOS.ControlColor), DependencyService.Get<ISystemColorsMacOS>().ControlColor);
            this.Add(nameof(ISystemColorsMacOS.ControlTextColor), DependencyService.Get<ISystemColorsMacOS>().ControlTextColor);
            this.Add(nameof(ISystemColorsMacOS.DisabledControlTextColor), DependencyService.Get<ISystemColorsMacOS>().DisabledControlTextColor);
            this.Add(nameof(ISystemColorsMacOS.FindHighlightColor), DependencyService.Get<ISystemColorsMacOS>().FindHighlightColor);
            this.Add(nameof(ISystemColorsMacOS.GridColor), DependencyService.Get<ISystemColorsMacOS>().GridColor);
            this.Add(nameof(ISystemColorsMacOS.HeaderTextColor), DependencyService.Get<ISystemColorsMacOS>().HeaderTextColor);
            this.Add(nameof(ISystemColorsMacOS.KeyboardFocusIndicatorColor), DependencyService.Get<ISystemColorsMacOS>().KeyboardFocusIndicatorColor);
            this.Add(nameof(ISystemColorsMacOS.ScrubberTexturedBackgroundColor), DependencyService.Get<ISystemColorsMacOS>().ScrubberTexturedBackgroundColor);
            this.Add(nameof(ISystemColorsMacOS.SelectedControlColor), DependencyService.Get<ISystemColorsMacOS>().SelectedControlColor);
            this.Add(nameof(ISystemColorsMacOS.SelectedControlTextcolor), DependencyService.Get<ISystemColorsMacOS>().SelectedControlTextcolor);
            this.Add(nameof(ISystemColorsMacOS.SelectedMenuItemColor), DependencyService.Get<ISystemColorsMacOS>().SelectedMenuItemColor);
            this.Add(nameof(ISystemColorsMacOS.SelectedMenuItemTextColor), DependencyService.Get<ISystemColorsMacOS>().SelectedMenuItemTextColor);
            this.Add(nameof(ISystemColorsMacOS.SelectedTextBackgroundColor), DependencyService.Get<ISystemColorsMacOS>().SelectedTextBackgroundColor);
            this.Add(nameof(ISystemColorsMacOS.SelectedTextColor), DependencyService.Get<ISystemColorsMacOS>().SelectedTextColor);
            this.Add(nameof(ISystemColorsMacOS.ShadowColor), DependencyService.Get<ISystemColorsMacOS>().ShadowColor);
            this.Add(nameof(ISystemColorsMacOS.TextBackgroundColor), DependencyService.Get<ISystemColorsMacOS>().TextBackgroundColor);
            this.Add(nameof(ISystemColorsMacOS.TextColor), DependencyService.Get<ISystemColorsMacOS>().TextColor);
            this.Add(nameof(ISystemColorsMacOS.UnderPageBackgroundColor), DependencyService.Get<ISystemColorsMacOS>().UnderPageBackgroundColor);
            this.Add(nameof(ISystemColorsMacOS.UnemphasizedSelectedContentBackgroundColor), DependencyService.Get<ISystemColorsMacOS>().UnemphasizedSelectedContentBackgroundColor);
            this.Add(nameof(ISystemColorsMacOS.UnemphasizedSelectedTextContentBackgroundColor), DependencyService.Get<ISystemColorsMacOS>().UnemphasizedSelectedTextContentBackgroundColor);
            this.Add(nameof(ISystemColorsMacOS.WindowBackgroundColor), DependencyService.Get<ISystemColorsMacOS>().WindowBackgroundColor);
            this.Add(nameof(ISystemColorsMacOS.WindowFrameColor), DependencyService.Get<ISystemColorsMacOS>().WindowFrameColor);

        }
    }
}
