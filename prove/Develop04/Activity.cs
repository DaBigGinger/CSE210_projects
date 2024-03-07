using System;

public abstract class Activity
{
    protected int duration;

    public Activity(int duration)
    {
        this.duration = duration;
    }

    public abstract void Start();

    public abstract void End();
}
