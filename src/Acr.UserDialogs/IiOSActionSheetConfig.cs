using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Acr.UserDialogs
{
    public interface IiOSActionSheetConfig
    {
        public Rectangle SourceRectangle { get; set; }
        public object SourceView { get; set; }
        public object SourceBarButtonView { get; set; }
        public IiOSActionSheetArrowDirections ArrowDirections { get; set; }
    }

    [Flags]
    public enum IiOSActionSheetArrowDirections
    {
        Top = 1,
        Left = 2,
        Right = 4,
        Bottom = 8,
        Any = 16,
        Unknown = 32
    }
}
