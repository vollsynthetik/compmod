using System;
using CompMod.Enums;

namespace CompMod.Objects
{
  public class Note : Sound
  {
    public Note(Pitch pitch, int velocity, double duration)
    {
      Pitch = pitch;
      Velocity = velocity;
      Duration = duration;
    }

    public Pitch Pitch { get; set; }
    public int Velocity { get; set; }
    public double Duration { get; set; }

    public override Note Copy() => new Note(Pitch, Velocity, Duration);
  }
}