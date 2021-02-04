using System;

namespace CompMod.Objects
{
  public class Rest : Sound
  {
    public Rest(double duration)
    {
      Duration = duration;
    }

    public double Duration { get; set; }
  }
}