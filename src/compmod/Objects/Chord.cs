using System;
using System.Collections.Genric;

namespace CompMod.Objects
{
  public class Chord
  {
    public Chord(IList<Note> notes)
    {
      Notes = notes;
    }

    public IList<Note> Notes { get; set; }

    public override Chord Copy()
    {
      var copy = new List<Notes>();
      foreach (var note in Notes)
        copy.Add(note.Copy());

      return new Chord(copy);
    }
  }
}