using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_PowerBlock
{
    public partial class Form1 : Form
    {
        private SystemPowerControl system;
        public Form1()
        {
            InitializeComponent();
            system = new SystemPowerControl();

        }

        private void SetInitParamBtn_Click(object sender, EventArgs e)
        {
            int time = 0;
            double init_power = 0;
            bool exp = false;
            try
            {
                time = Convert.ToInt32(InternalTimeTextBox.Text);
            }
            catch( FormatException ex)
            {
                MessageBox.Show("Ошибка при преобразовании времени квантования");
                exp = true;
            }

            try
            {
                init_power = Convert.ToDouble(InitPowerTextBox.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка при преобразовании мощности");
                exp = true;
            }
            if(!exp) {
                system.SetInitParams(time, init_power);
                this.SetInitParamBtn.Enabled = false;
            } 
       }

        private void SetRegParamBtn_Click(object sender, EventArgs e)
        {
            double g = 0;
            double t = 0;
            bool exp = false;
            try
            {
                g = Convert.ToInt32(PkoefTextBox.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка при преобразовании коэффициента усиления");
                exp = true;
            }

            try
            {
                t = Convert.ToDouble(TkoefTextBox.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка при преобразовании итегрального коэффициента");
                exp = true;
            }
            if (!exp)
            {
                system.PIreg.SetPIControllerParam(g, t);
                this.SetRegParamBtn.Enabled = false;
            }
        }

        private void ResetInitParamBtn_Click(object sender, EventArgs e)
        {
            InternalTimeTextBox.Text = String.Empty;
            InitPowerTextBox.Text = String.Empty;
            system.ResetInitParams();
            this.SetInitParamBtn.Enabled = true;
        }

        private void ResetRegParamBtn_Click(object sender, EventArgs e)
        {
            PkoefTextBox.Text = String.Empty;
            TkoefTextBox.Text = String.Empty;
            system.PIreg.ResetPIControllerParam();
            this.SetRegParamBtn.Enabled = true;
        }

        private void RunSysBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (system.isInit() && system.PIreg.isConfigured())
                {
                    MessageBox.Show("Система запущена");
                    sysTimer.Interval = system.sysState.time;
                    sysTimer.Enabled = true;
                    sysTimer.Start();
                    RunSysBtn.Enabled = false;
                }
                else throw new Exception();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не заданы параметры регулятора или начальные параметры системы");
            }

        }

        private void AbortSysBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Система остановлена");
            RunSysBtn.Enabled = true;
        }

        private void sysTimer_Tick(object sender, EventArgs e)
        {
            system.Hit();
        }
    }
}
