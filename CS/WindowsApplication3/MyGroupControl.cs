using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Drawing;
using DevExpress.Skins;
using DevExpress.Utils;

namespace WindowsApplication3 {
    public class MyGroupControl : GroupControl {

        protected override ObjectPainter CreatePainter() {
            if (LookAndFeel.ActiveStyle == DevExpress.LookAndFeel.ActiveLookAndFeelStyle.Skin) return new MyGroupObjectPainter(this, LookAndFeel.ActiveLookAndFeel);
            return base.CreatePainter();
        }
    }
    public class MyGroupObjectPainter : SkinGroupObjectPainter {

        public MyGroupObjectPainter(IPanelControlOwner owner, ISkinProvider provider) : base(owner, provider) { }

        protected override Size CalcCaptionTextSize(GroupObjectInfoArgs info) {
            int left, top, right, bottom;
            CalcContentMargins(info, out left, out top, out right, out bottom);
            int width = info.Bounds.Width - left - right;
            int height = info.Bounds.Height - top - bottom;
            Size size = info.AppearanceCaption.CalcTextSize(info.Cache,
                info.AppearanceCaption.GetStringFormat(GetTextOptions()), info.Caption,
                IsVerticalCaption(info) ? height : width).ToSize();
            return size;
        }

        protected override void CalcCaptionElementsNormal(GroupObjectInfoArgs info, Rectangle caption) {
            int left, top, right, bottom;
            CalcContentMargins(info, out left, out top, out right, out bottom);
            base.CalcCaptionElementsNormal(info, caption);
            Rectangle rect = info.TextBounds;
            int textOffset = (caption.Height - (top + info.TextBounds.Height + bottom)) / 2;
            rect.Y -= textOffset;
            rect.Size = CalcCaptionTextSize(info);
            info.TextBounds = rect;
        }
    }
}
