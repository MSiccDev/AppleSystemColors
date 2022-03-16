using System.Collections.Generic;

using Xamarin.Forms;

namespace MSiccDev.Libs.AppleSystemColors
{
    public interface ISystemColorsMacOS
    {
        Color SystemRed { get; }
        Color SystemOrange { get; }
        Color SystemYellow { get; }
        Color SystemGreen { get; }
        Color SystemMint { get; }
        Color SystemTeal { get; }
        Color SystemCyan { get; }
        Color SystemBlue { get; }
        Color SystemIndigo { get; }
        Color SystemPurple { get; }
        Color SystemPink { get; }
        Color SystemBrown { get; }
        Color SystemGray { get; }
        Color SystemLabel { get; }
        Color SecondaryLabel { get; }
        Color TertiaryLabel { get; }
        Color QuaternaryLabel { get; }
        Color Placeholder { get; }
        Color Separator { get; }
        Color LinkColor { get; }
        Color AlternateSelectedControlTextcColor { get; }
        List<Color> AlternatingContentBackgroundColors { get; }
        Color ControlAccent { get; }
        Color ControlBackgroundColor { get; }
        Color ControlColor { get; }
        Color ControlTextColor { get; }
        Color DisabledControlTextColor { get; }
        Color FindHighlightColor { get; }
        Color GridColor { get; }
        Color HeaderTextColor { get; }
        Color KeyboardFocusIndicatorColor { get; }
        Color ScrubberTexturedBackgroundColor { get; }
        Color SelectedControlColor { get; }
        Color SelectedControlTextcolor { get; }
        Color SelectedMenuItemColor { get; }
        Color SelectedMenuItemTextColor { get; }
        Color SelectedTextBackgroundColor { get; }
        Color SelectedTextColor { get; }
        Color ShadowColor { get; }
        Color TextBackgroundColor { get; }
        Color TextColor { get; }
        Color UnderPageBackgroundColor { get; }
        Color UnemphasizedSelectedContentBackgroundColor { get; }
        Color UnemphasizedSelectedTextContentBackgroundColor { get; }
        Color WindowBackgroundColor { get; }
        Color WindowFrameColor { get; }
    }
}