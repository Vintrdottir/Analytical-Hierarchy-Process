using System.Collections.Generic;


namespace AHP
{
    public class Alternative
    {
        public string name { get; set; }
        private Dictionary<Parameter, double> alternativePriority = new Dictionary<Parameter, double>();
        public void Set(Parameter key, double value)
        {
            if (alternativePriority.ContainsKey(key))
            {
                alternativePriority[key] = value;
            }
            else
            {
                alternativePriority.Add(key, value);
            }
        }
        public double Get(Parameter key)
        {
            double result = 0;
            if (alternativePriority.ContainsKey(key))
            {
                result = alternativePriority[key];
            }
            return result;
        }
    }
}
