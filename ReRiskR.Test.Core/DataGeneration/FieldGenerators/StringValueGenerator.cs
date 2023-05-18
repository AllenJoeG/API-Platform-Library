namespace ReRiskR.Test.Core.DataGeneration.FieldGenerators
{
    public class StringValueGenerator
    {
        private readonly string _seedValue;
        private readonly bool _generateUniqueValue;

        public StringValueGenerator(bool generateUniqueValue, string seedValue)
        {
            _generateUniqueValue = generateUniqueValue;
            _seedValue = seedValue;
        }

        //If Unique bool flagged, attach unique GUID to provided seedValue
        public override string ToString()
        {
            return !_generateUniqueValue ?
                _seedValue : $"{_seedValue}_{Guid.NewGuid()}";
        }
    }
}