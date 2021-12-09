
using MSiccDev.Libs.iOS.SystemColors;

using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Dependency(typeof(SystemColors))]
namespace MSiccDev.Libs.iOS.SystemColors
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Code Notifications", "XI0002:Notifies you from using newer Apple APIs when targeting an older OS version", Justification = "<Pending>")]

    //https://developer.apple.com/design/human-interface-guidelines/ios/visual-design/color/
    //https://developer.apple.com/documentation/uikit/uicolor/ui_element_colors

    public class SystemColors : ISystemColors
    {
        #region System Colors
        public Color SystemRed => UIColor.SystemRedColor.ToColor();
        public Color SystemOrange => UIColor.SystemOrangeColor.ToColor();
        public Color SystemYellow => UIColor.SystemYellowColor.ToColor();
        public Color SystemGreen => UIColor.SystemGreenColor.ToColor();
        public Color SystemMint => UIColor.SystemMintColor.ToColor();
        public Color SystemTeal => UIColor.SystemTealColor.ToColor();
        public Color SystemCyan => UIColor.SystemCyanColor.ToColor();
        public Color SystemBlue => UIColor.SystemBlueColor.ToColor();
        public Color SystemIndigo => UIColor.SystemIndigoColor.ToColor();
        public Color SystemPurple => UIColor.SystemPurpleColor.ToColor();
        public Color SystemPink => UIColor.SystemPinkColor.ToColor();
        public Color SystemBrown => UIColor.SystemBrownColor.ToColor();


        public Color SystemGray => UIColor.SystemGrayColor.ToColor();
        public Color SystemGray2 => UIColor.SystemGray2Color.ToColor();
        public Color SystemGray3 => UIColor.SystemGray3Color.ToColor();
        public Color SystemGray4 => UIColor.SystemGray4Color.ToColor();
        public Color SystemGray5 => UIColor.SystemGray5Color.ToColor();
        public Color SystemGray6 => UIColor.SystemGray6Color.ToColor();
        #endregion

        #region UI Element Colors
        public Color SystemLabel => UIColor.LabelColor.ToColor();
        public Color SecondaryLabel => UIColor.SecondaryLabelColor.ToColor();
        public Color TertiaryLabel => UIColor.TertiaryLabelColor.ToColor();
        public Color QuaternaryLabel => UIColor.QuaternaryLabelColor.ToColor();
        public Color Placeholder => UIColor.PlaceholderTextColor.ToColor();
        public Color Separator => UIColor.SeparatorColor.ToColor();
        public Color OpaqueSeparator => UIColor.SeparatorColor.ToColor();
        public Color LinkColor => UIColor.SeparatorColor.ToColor();

        public Color FillColor => UIColor.SystemFillColor.ToColor();
        public Color SecondaryFillColor => UIColor.SecondarySystemFillColor.ToColor();
        public Color TertiaryFillColor => UIColor.TertiarySystemFillColor.ToColor();
        public Color QuaternaryFillColor => UIColor.QuaternarySystemFillColor.ToColor();

        public Color SystemBackgroundColor => UIColor.SystemBackgroundColor.ToColor();
        public Color SecondarySystemBackgroundColor => UIColor.SecondarySystemBackgroundColor.ToColor();
        public Color TertiarySystemBackgroundColor => UIColor.TertiarySystemBackgroundColor.ToColor();

        public Color SystemGroupedBackgroundColor => UIColor.SystemGroupedBackgroundColor.ToColor();
        public Color SecondarySystemGroupedBackgroundColor => UIColor.SecondarySystemGroupedBackgroundColor.ToColor();
        public Color TertiarySystemGroupedBackgroundColor => UIColor.TertiarySystemGroupedBackgroundColor.ToColor();

        public Color DarkTextColor => UIColor.DarkTextColor.ToColor();
        public Color LightTextColor => UIColor.LightTextColor.ToColor();

        #endregion


    }

}
