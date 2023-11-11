using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lumino
{
    public partial class ColumnEditor : UserControl
    {
        public byte Values
        {
            get
            {
                int result = 0;

                result += this.LED0.Checked ? 1 : 0;
                result += this.LED1.Checked ? 2 : 0;
                result += this.LED2.Checked ? 4 : 0;
                result += this.LED3.Checked ? 8 : 0;
                result += this.LED4.Checked ? 16 : 0;
                result += this.LED5.Checked ? 32 : 0;
                result += this.LED6.Checked ? 64 : 0;

                return (byte)result;
            }

            set
            {
                this.m_Values = value;

                byte mask = 1;
                this.LED0.Checked = (this.m_Values & mask) > 0;

                mask <<= 1;
                this.LED1.Checked = (this.m_Values & mask) > 0;

                mask <<= 1;
                this.LED2.Checked = (this.m_Values & mask) > 0;

                mask <<= 1;
                this.LED3.Checked = (this.m_Values & mask) > 0;

                mask <<= 1;
                this.LED4.Checked = (this.m_Values & mask) > 0;

                mask <<= 1;
                this.LED5.Checked = (this.m_Values & mask) > 0;

                mask <<= 1;
                this.LED6.Checked = (this.m_Values & mask) > 0;
            }
        }
        private byte m_Values;

        public ColumnEditor()
        {
            InitializeComponent();
        }
    }
}
