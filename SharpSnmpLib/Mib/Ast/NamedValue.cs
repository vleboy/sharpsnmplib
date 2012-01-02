namespace Lextm.SharpSnmpLib.Mib
{
    public class NamedValue
    {
        public NamedValue(string name, ISmiValue smiValue)
        {
            Name = name;
            Value = smiValue;
        }

        public string Name { get; set; }

        public ISmiValue Value
        {
            get; set;
        }
    }
}