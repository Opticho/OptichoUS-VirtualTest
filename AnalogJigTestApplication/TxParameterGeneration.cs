using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogJigTestApplication
{
    class TxParameterGeneration
    {
        double elementPitch = 0.3;
        double fs = 160000000.0; //160MHZ
        double c0 = 1480000.0;

        public UInt32[] TxDelayCalcualtor(int channel, int steerAngle)
        {
            UInt32[] TxDelay = new UInt32[channel];
            Int32[] TxDelayTemp = new Int32[channel];

            double ts = 1 / fs;
            double d0 = c0 * ts;

            double[] txPosition = new double[channel];

            for(int i = 0; i < channel; i++)
            {
                txPosition[i] = elementPitch * ((double)(i + 1) / 2.0 - 0.5);
            }

            double angle = steerAngle * Math.PI / 180.0;

            for (int i = 0; i < channel; i++)
            {
                double txDistance = txPosition[i] * Math.Sin(angle);
                double Temp = txDistance / d0;
                TxDelayTemp[i] = MathMethod.ROUND(Temp);
            }

            int minTxDelay = MathMethod.MIN(TxDelayTemp);

            for (int i = 0; i < TxDelay.Count(); i++)
            {
                TxDelay[i] = (uint)(1024 - (TxDelayTemp[i] - minTxDelay));
            }

            return TxDelay;
        }

        public uint[] TxPulseGenerator(double txFrequency)
        {
            uint[] txPulse = new uint[8];

            int pulseLength = MathMethod.ROUND(fs / (txFrequency * 1000000));

            if (pulseLength % 2 == 1) pulseLength = pulseLength + 1;

            txPulse[0] = (uint)((pulseLength / 2) << 1) + 1;
            txPulse[1] = (uint)((pulseLength / 2) << 1) + 0;
            txPulse[2] = 0;
            txPulse[3] = 0;
            txPulse[4] = 0;
            txPulse[5] = 0;
            txPulse[6] = 0;
            txPulse[7] = 0;

            return txPulse;
        }

    }
}
