using System.Management.Automation;

namespace CompMod
{
  [Cmdlet(Verbs.Common.New, "Note")]
  public class NewNoteCommand : Cmdlet
  {
    [Parameter(Mandatory=true)]
    public string Name
    {
      get { return name; }
      set { name = value; }
    }
    private string name;

    protected override void ProcessRecord()
    {
      WriteObject("Hello " + name + "!");
    }
  }
}