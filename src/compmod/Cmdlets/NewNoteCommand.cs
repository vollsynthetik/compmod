using System.Management.Automation;
using CompMod.Enums;
using CompMod.Objects;

namespace CompMod.Cmdlets
{
  [Cmdlet(Verbs.Common.New, "Note")]
  public class NewNoteCommand : Cmdlet
  {
    public NewNoteCommand() 
    {
      Velocity = 100;
    }

    [Parameter(Mandatory=true)]
    public Pitch Pitch { get; set; }

    [Parameter(Mandatory=false)]
    public int Velocity { get; set; }

    [Parameter(Mandatory=true)]
    public double Duration { get; set; }

    protected override void ProcessRecord()
    {
      WriteObject(new Note(Pitch, Velocity, Duration));
    }
  }
}