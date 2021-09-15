﻿using System.ComponentModel;

namespace MudBlazor
{
    public enum PopoverPlacement
    {
        [Description("top-left")]
        TopLeft,
        [Description("top-center")]
        TopCenter,
        [Description("top-right")]
        TopRight,
        [Description("center-left")]
        CenterLeft,
        [Description("center-center")]
        CenterCenter,
        [Description("center-right")]
        CenterRight,
        [Description("bottom-left")]
        BottomLeft,
        [Description("bottom-center")]
        BottomCenter,
        [Description("bottom-right")]
        BottomRight,
    }
}