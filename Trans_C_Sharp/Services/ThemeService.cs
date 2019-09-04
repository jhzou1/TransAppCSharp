using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trans_C_Sharp
{
 public    class ThemeService
    {
        public delegate void NotifyAllTheme();

        public void SetFormTheme(Theme theme, Control fatherControl)
        {
            if (fatherControl is Form)
            {
                Form objFrm = (Form)fatherControl;
                objFrm.BackColor = theme._BackgroudColor;
            }
            Control.ControlCollection sonControls = fatherControl.Controls;
            foreach (Control control in sonControls)
            {
                if (control is Label)
                {
                    Label lbl = (Label)control;
                    lbl.ForeColor = theme._FontColor;
                    continue;
                }
                if (control is Button)
                {
                    Button btn = (Button)control;
                    btn.ForeColor = theme._FontColor;
                    btn.BackColor = theme._BackgroudColor;
                    continue;
                }
                if (control is Panel)
                {
                    Panel panel = (Panel)control;
                    panel.BackColor = theme._BackgroudColor;
                }

                //继续循环
                SetFormTheme(theme, control);
            }
        }

        /// <summary>
        /// 通知所有
        /// </summary>
        public void NotifyAll()
        {
            //这里一旦通知，所有的关联观察者都会收到通知
            NotityEvent();
        }

        public event NotifyAllTheme NotityEvent;

    }
    
}
