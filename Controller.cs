using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_PowerBlock
{
    class Controller
    {
        private double _gain; //коэф усиления
        private double _integral; //интегральный коэф
        public bool configured; //флаг конфигурирования

        public void SetPIControllerParam(double k, double t) //установка параметров регулятора
        {
            configured = true;
            this._gain = k;
            this._integral = t;
        }
        public void ResetPIControllerParam() //сброс параметров регулятора
        {
            this._gain = 0;
            this._integral = 0;
            configured = false;
        }
        public bool isConfigured() //проверят настройку регулятора
        {
            return configured;
        }
        public double Core(SystemState state) //возвращает управляющее воздействие
        {
            int it = state.iteration;
            return 26.62 * state.eps[it] + (it - 1 < 0 ? 0 : state.signals[it - 1]) - 26.19 * (it - 1 < 0 ? 0 : state.eps[it - 1]);
        }
      
    }
}
