using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_PowerBlock
{
    class SystemState
    {
        public int iteration;  //номер итерации
        public int time;  //время квантования
        public List<double> powers;  //входная мощность
        public List<double> eps;  //разница между ввыходом и входной мощностью
        public List<double> signals; //управляющие воздействия
        public List<double> outputs; //выходы

        public SystemState()
        {
            iteration = 0; //начальная итерация - 0
            time = 0; //время -0
            powers = new List<double>();
            eps = new List<double>();
            signals = new List<double>();
            outputs = new List<double>();
        }
    }
}
