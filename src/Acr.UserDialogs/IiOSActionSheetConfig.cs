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


    public enum IiOSActionSheetArrowDirections
    {
        Top,
        Left,
        Right,
        Bottom,
        Any,
        Unknown
    }
}
