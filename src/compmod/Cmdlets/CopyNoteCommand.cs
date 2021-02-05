using System.Management.Automation;
using CompMod.Enums;
using CompMod.Objects;

namespace CompMod.Cmdlets
{
  [Cmdlet(Verbs.Common.Copy, "Note")]
  public class CopyNoteCommand : Cmdlet
  {
    [Parameter(Mandatory=true, Position = 0)]
    public Note Note { get; set; }

    protected override void ProcessRecord()
    {
      WriteObject(new Note(Note.Pitch, Note.Velocity, Note.Duration));
    }
  }
}