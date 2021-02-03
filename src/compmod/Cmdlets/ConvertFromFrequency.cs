using System;
using System.Management.Automation;
using CompMod.Enums;

namespace CompMod.Cmdlets
{
  [Cmdlet(Verbs.Data.ConvertTo, "Frequency")]
  public class ConvertToFrequencyCommand : Cmdlet
  {
    [Parameter(Position=0, Mandatory=true)]
    public double Frequency
    {
      get; set;
    }

    protected override void ProcessRecord()
    {
      var midiNoteRaw = 12 * Log2((Frequency / 440.0) * Math.Pow(2, (69.0 / 12.0)));
    	if (midiNoteRaw < 0 || midiNoteRaw > 127)
      {
        WriteError("The given frequency is either too low or to high");
        return;
      }

      var midiNote = Enum.Parse(typeof(Pitch), Math.Round(midiNoteRaw).ToString());
      WriteObject(midiNote);
    }
  }
}