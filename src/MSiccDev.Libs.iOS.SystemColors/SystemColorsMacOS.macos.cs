using System;
using System.Collections.Generic;
using System.Linq;

using AppKit;

using MSiccDev.Libs.AppleSystemColors;

using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

//https://developer.apple.com/design/human-interface-guidelines/macos/visual-design/color/

[assembly: Dependency(typeof(SystemColorsMacOS))]
namespace MSiccDev.Libs.AppleSystemColors
{
    public class SystemColorsMacOS : ISystemColorsMacOS
    {
        #region System Colors
        public Color SystemRed => NSColor.SystemRedColor.ToColor();
        public Color SystemOrange => NSColor.SystemOrangeColor.ToColor();
        public Color SystemYellow => NSColor.SystemYellowColor.ToColor();
        public Color SystemGreen => NSColor.SystemGreenColor.ToColor();
        public Color SystemMint => NSColor.SystemMintColor.ToColor();
        public Color SystemTeal => NSColor.SystemTealColor.ToColor();
        public Color SystemCyan => NSColor.SystemCyanColor.ToColor();
        public Color SystemBlue => NSColor.SystemBlueColor.ToColor();
        public Color SystemIndigo => NSColor.SystemIndigoColor.ToColor();
        public Color SystemPurple => NSColor.SystemPurpleColor.ToColor();
        public Color SystemPink => NSColor.SystemPinkColor.ToColor();
        public Color SystemBrown => NSColor.SystemBrownColor.ToColor();
        public Color SystemGray => NSColor.SystemGrayColor.ToColor();
        #endregion

        #region UI Element Colors
        public Color SystemLabel => NSColor.LabelColor.ToColor();
        public Color SecondaryLabel => NSColor.SecondaryLabelColor.ToColor();
        public Color TertiaryLabel => NSColor.TertiaryLabelColor.ToColor();
        public Color QuaternaryLabel => NSColor.QuaternaryLabelColor.ToColor();
        public Color Placeholder => NSColor.PlaceholderTextColor.ToColor();
        public Color Separator => NSColor.SeparatorColor.ToColor();
        public Color LinkColor => NSColor.LinkColor.ToColor();

        public Color AlternateSelectedControlTextcColor => NSColor.AlternateSelectedControlText.ToColor();
        public List<Color> AlternatingContentBackgroundColors => NSColor.AlternatingContentBackgroundColors.Select(color => color.ToColor()).ToList();
        public Color ControlAccent => NSColor.ControlAccentColor.ToColor();
        public Color ControlBackgroundColor => NSColor.ControlBackground.ToColor();
        public Color ControlColor => NSColor.Control.ToColor();
        public Color ControlTextColor => NSColor.ControlText.ToColor();
        public Color DisabledControlTextColor => NSColor.DisabledControlText.ToColor();
        public Color FindHighlightColor => NSColor.FindHighlightColor.ToColor();
        public Color GridColor => NSColor.Grid.ToColor();
        public Color HeaderTextColor => NSColor.Grid.ToColor();
        public Color KeyboardFocusIndicatorColor => NSColor.KeyboardFocusIndicator.ToColor();
        public Color ScrubberTexturedBackgroundColor => NSColor.ScrubberTexturedBackgroundColor.ToColor();
        public Color SelectedControlColor => NSColor.SelectedControl.ToColor();
        public Color SelectedControlTextcolor => NSColor.SelectedControlText.ToColor();
        public Color SelectedMenuItemColor => NSColor.SelectedMenuItem.ToColor();
        public Color SelectedMenuItemTextColor => NSColor.SelectedMenuItemText.ToColor();
        public Color SelectedTextBackgroundColor => NSColor.SelectedTextBackground.ToColor();
        public Color SelectedTextColor => NSColor.SelectedText.ToColor();
        public Color ShadowColor => NSColor.Shadow.ToColor();
        public Color TextBackgroundColor => NSColor.TextBackground.ToColor();
        public Color TextColor => NSColor.Text.ToColor();
        public Color UnderPageBackgroundColor => NSColor.UnderPageBackgroundColor.ToColor();
        public Color UnemphasizedSelectedContentBackgroundColor => NSColor.UnemphasizedSelectedContentBackgroundColor.ToColor();
        public Color UnemphasizedSelectedTextContentBackgroundColor => NSColor.UnemphasizedSelectedTextBackgroundColor.ToColor();
        public Color WindowBackgroundColor => NSColor.WindowBackground.ToColor();
        public Color WindowFrameColor => NSColor.WindowFrame.ToColor();
        #endregion
    }
}
