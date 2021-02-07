using System.Collections.Generic;
using System.Management.Automation;
using CompMod.Enums;
using CompMod.Objects;

namespace CompMod.Cmdlets
{
  [Cmdlet(Verbs.Common.New, "Track")]
  public class NewTrackCommand : Cmdlet
  {
    public NewTrackCommand() 
    {
      Sounds = new List<Sound>();
    }

    [Parameter(Mandatory=false, Position=0)]
    public int Bpm { get; set; }

    [Parameter(Mandatory=false, Position=1)]
    public IList<Sound> Sounds { get; set; }

    protected override void ProcessRecord()
    {
      WriteObject(new Track(Bpm, Sounds));
    }
  }
}