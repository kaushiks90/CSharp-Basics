using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS._6._0
{
    //Auto Property is available for get as well as get set
    //There cannot be private set and private get in Auto property 
    class ReadOnlyAutoPropertyAndInitializer
    {
        public ICollection<Double> Temperatures1 { get; set; } = new List<Double> { 38.5, 40 };
        public ICollection<Double> Temperatures2 { private get; set; } = new List<Double> { 38.5, 40 };
        public ICollection<Double> Temperatures3 { private get; set; } = new List<Double> { 38.5, 40 };
        public ICollection<Double> Temperatures4 {  get; private set; } = new List<Double> { 38.5, 40 };

       // public ICollection<Double> Temperatures5 { private get; private set; } = new List<Double> { 38.5, 40 };
        public ICollection<Double> Temperatures { get; } = new List<Double> { 38.5, 40 };
        public DotNetAssistant DotNetAssistants { get; } = DotNetAssistant.Experienced;
    }
    public enum DotNetAssistant
    {
        NewBie,
        Experienced,
        God
    }
}
