﻿using System.ComponentModel;
using System.Windows.Forms;
using TerrainMapGUILibrary.Resources.Fonts;

namespace TerrainMapGUILibrary.Extensions
{
    internal class CheckBoxExtension : CheckBox
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool TabStop
        {
            get
            {
                return false;
            }
            set
            {
                base.TabStop = false;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new int TabIndex
        {
            get
            {
                return 0;
            }
            set
            {
                base.TabIndex = 0;
            }
        }

        public CheckBoxExtension()
        {
            Font = FontHelper.GetFont();
            TabStop = false;
            TabIndex = 0;
        }
    }
}
