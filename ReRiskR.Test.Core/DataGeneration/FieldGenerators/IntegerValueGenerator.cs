//Straightforward random Int32 number generator for testing

namespace ReRiskR.Test.Core.DataGeneration.FieldGenerators
{
    public class IntegerValueGenerator
    {
        private readonly int _maxValue;

        public IntegerValueGenerator(int maxValue = Int32.MaxValue)
        {
            _maxValue = maxValue;
        }

        public int Value()
        {
            return new Random().Next(1, _maxValue);
        }

        public static int RandomInt => 
            new IntegerValueGenerator().Value();
    }
}
