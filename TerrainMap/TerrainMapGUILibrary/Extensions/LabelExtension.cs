﻿using System.ComponentModel;
using System.Windows.Forms;
using TerrainMapGUILibrary.Themes;

namespace TerrainMapGUILibrary.Extensions
{
    internal class LabelExtension : Label
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool TabStop
        {
            get { return false; }
            set { base.TabStop = false; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new int TabIndex
        {
            get { return 0; }
            set { base.TabIndex = 0; }
        }

        public LabelExtension()
            : base()
        {
            Font = FontTheme.Normal();
            TabStop = false;
            TabIndex = 0;
        }
    }
}
