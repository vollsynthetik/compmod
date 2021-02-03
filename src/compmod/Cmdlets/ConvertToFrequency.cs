using System;
using System.Management.Automation;
using CompMod.Enums;

namespace CompMod.Cmdlets;
{
  [Cmdlet(Verbs.Data.ConvertTo, "Frequency")]
  public class ConvertToFrequencyCommand : Cmdlet
  {
    [Parameter(Position=0, Mandatory=true)]
    public Pitch Note
    {
      get; set;
    }

    protected override void ProcessRecord()
    {
      var frequency = (440.0 / Math.Pow(2.0, (69.0 / 12.0))) * (Math.Pow(2.0, (int) Pitch) / 12.0));
      WriteObject(frequency);
    }
  }
}