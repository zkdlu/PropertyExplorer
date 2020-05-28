using System;
using System.Windows;

namespace PropertyExplorer.Models
{
    public class DoubleProperty : Property<double>
    {
        public DoubleProperty(string name, Func<double> getter, Action<double> setter) : base(name, getter, setter)
        {
        }
    }
}
