using System;

namespace ConsoleApp3
{
    [Serializable]
    internal class NeroNet
    {
        public decimal weight = 0.5m;
        public decimal LastError { get; private set; }
        public decimal Smoothing { get; private set; } = 0.00001m;
        public decimal ProcessInputData(decimal input) => input * weight;
        public decimal RestoreInputData(decimal output) => output / weight;
        public bool IsDone => _isdone;
        private bool _isdone;
        public int Iteration => _iteration;
        private int _iteration;

        public void Train(decimal input, decimal expectedResult)
        {
            int i = 0;
            do
            {
                i++;
                var actualResult = input * weight;
                LastError = expectedResult - actualResult;
                var correction = (LastError / actualResult) * Smoothing;
                weight += correction;
                _iteration = i;

            } while (LastError > Smoothing || LastError < -Smoothing);
            _isdone = true;
        }

        //public void SaveModel(string path)
        //{
        //    if (_isdone)
        //    {
        //      // File.WriteAllText(path,JsonConvert.SerializeObject(this));
        //    }
        //}
    }
}
