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
        public Color SystemRed => NSColor.SystemRedColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SystemOrange => NSColor.SystemOrangeColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SystemYellow => NSColor.SystemYellowColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SystemGreen => NSColor.SystemGreenColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SystemMint => NSColor.SystemMintColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SystemTeal => NSColor.SystemTealColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SystemCyan => NSColor.SystemCyanColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SystemBlue => NSColor.SystemBlueColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SystemIndigo => NSColor.SystemIndigoColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SystemPurple => NSColor.SystemPurpleColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SystemPink => NSColor.SystemPinkColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SystemBrown => NSColor.SystemBrownColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SystemGray => NSColor.SystemGrayColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        #endregion

        #region UI Element Colors
        public Color SystemLabel => NSColor.LabelColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SecondaryLabel => NSColor.SecondaryLabelColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color TertiaryLabel => NSColor.TertiaryLabelColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color QuaternaryLabel => NSColor.QuaternaryLabelColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color Placeholder => NSColor.PlaceholderTextColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color Separator => NSColor.SeparatorColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color LinkColor => NSColor.LinkColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);

        public Color AlternateSelectedControlTextcColor => NSColor.AlternateSelectedControlText.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public List<Color> AlternatingContentBackgroundColors => NSColor.AlternatingContentBackgroundColors.Select(color => color.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace)).ToList();
        public Color ControlAccent => NSColor.ControlAccentColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color ControlBackgroundColor => NSColor.ControlBackground.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color ControlColor => NSColor.Control.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color ControlTextColor => NSColor.ControlText.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color DisabledControlTextColor => NSColor.DisabledControlText.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color FindHighlightColor => NSColor.FindHighlightColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color GridColor => NSColor.Grid.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color HeaderTextColor => NSColor.Grid.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color KeyboardFocusIndicatorColor => NSColor.KeyboardFocusIndicator.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);

        //public Color ScrubberTexturedBackgroundColor => NSColor.ScrubberTexturedBackgroundColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);

        public Color SelectedControlColor => NSColor.SelectedControl.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SelectedControlTextcolor => NSColor.SelectedControlText.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SelectedMenuItemColor => NSColor.SelectedMenuItem.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SelectedMenuItemTextColor => NSColor.SelectedMenuItemText.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SelectedTextBackgroundColor => NSColor.SelectedTextBackground.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color SelectedTextColor => NSColor.SelectedText.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color ShadowColor => NSColor.Shadow.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color TextBackgroundColor => NSColor.TextBackground.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color TextColor => NSColor.Text.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color UnderPageBackgroundColor => NSColor.UnderPageBackgroundColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color UnemphasizedSelectedContentBackgroundColor => NSColor.UnemphasizedSelectedContentBackgroundColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color UnemphasizedSelectedTextContentBackgroundColor => NSColor.UnemphasizedSelectedTextBackgroundColor.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color WindowBackgroundColor => NSColor.WindowBackground.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);
        public Color WindowFrameColor => NSColor.WindowFrame.ToColor(this.UseP3ColorSpace ? NSColorSpace.DisplayP3ColorSpace : NSColorSpace.SRGBColorSpace);

        public bool UseP3ColorSpace { get; set; } = true;
        #endregion
    }
}
