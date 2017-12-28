using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System_PowerBlock
{
    class SystemPowerControl
    {
        TimerCallback timeHanlde;
        Timer timer;
        private double _curPower;  //текущая мощность
        private int _internalTime; //внутренее время
        private double _airConsum; //расход воздуха

        public SystemState sysState; //состояние системы
        public Controller PIreg;  //регулятор
        public BlockObject block; //объект управления
        
        public SystemPowerControl()
        {
            PIreg = new Controller();
            block = new BlockObject();
            sysState = new SystemState();
        }
        public  void SetInitParams(int quant_time, double initpower) //установка начальных параметор 
        {
            sysState.time = quant_time; //время квантования
            sysState.powers.Add(initpower); //начальная  требуемая мощность
            sysState.outputs.Add(0); //выход объекта в момент времени 0
            sysState.eps.Add(sysState.powers[0] - sysState.outputs[0]);//
        }
        public void ResetInitParams() //сброс параметров
        {
            sysState.time = 0;
            sysState.powers.Remove(sysState.powers.Count);
            sysState.powers.Remove(sysState.outputs.Count);
            sysState.powers.Remove(sysState.eps.Count);
        }
        public bool isInit() //проверяет инициализирована ли система
        {
            return ((sysState.time == 0 && sysState.powers.Count == 0) ? false : true);
        }

        public void Hit() //шаг системы
        {
            sysState.signals.Add(PIreg.Core(this.sysState)); 
            this.sysState.iteration++;

        }
    }
}
