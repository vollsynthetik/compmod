using System;
using System.Collections.Generic;

public namespace CompMod.Objects
{
  public class Track
  {
    public Track(int bpm)
    {
      Bpm = bpm;
    }

    public Track(int bpm, IList<Sound> sounds) : Track(bpm)
    {
      Sounds = sounds;
    }

    public int Bpm { get; set; }

    public IList<Sound> Sounds { get ; set; }
  }
}