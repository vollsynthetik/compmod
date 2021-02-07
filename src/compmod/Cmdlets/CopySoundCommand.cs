using System.Management.Automation;
using CompMod.Enums;
using CompMod.Objects;

namespace CompMod.Cmdlets
{
  [Cmdlet(Verbs.Common.Copy, "Sound")]
  public class CopySoundCommand : Cmdlet
  {
    [Parameter(Mandatory=true, Position = 0)]
    public Sound Sound { get; set; }

    protected override void ProcessRecord()
    {
      WriteObject(sound.Copy());
    }
  }
}