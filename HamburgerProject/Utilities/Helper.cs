using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerProject.Utilities
{
    public class Helper
    {
        public static void Temizle(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is ComboBox)
                {
                    ComboBox cmb = (ComboBox)control;
                    //ComboBox comboBox = control as ComboBox;
                    cmb.SelectedIndex = 0;
                }
                else if (control is CheckBox) 
                {
                    CheckBox checkBox = control as CheckBox;
                    checkBox.Checked = false;
                }
                else if (control is  RadioButton)
                {
                    RadioButton radioButton = control as RadioButton;
                    if(radioButton.Text == "Küçük") 
                    {
                        radioButton.Checked = true;
                    }
                    radioButton.Checked = false;
                }
                else if (control is TextBox)
                {
                    TextBox txt = control as TextBox;
                    txt.Clear();
                }
                else if (control is NumericUpDown)
                {
                    //((NumericUpDown)control).Value = 0;
                    NumericUpDown numericUpDown = control as NumericUpDown;
                    numericUpDown.Value = 0;
                }
                else if (control is GroupBox)
                {
                    GroupBox groupBox = control as GroupBox;
                    Temizle(groupBox.Controls);
                    
                }
                else if  (control is FlowLayoutPanel)
                {
                    FlowLayoutPanel flowLayoutPanel = control as FlowLayoutPanel;
                    Temizle(flowLayoutPanel.Controls);
                }
            }


        }

            
        
    }
}
