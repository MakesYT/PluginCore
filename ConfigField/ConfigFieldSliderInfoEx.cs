namespace PluginCore;

public class ConfigFieldSliderInfoEx : ConfigFieldExBase
{
    public int MaxValue
    {
        get;
        set;
    }
    public int MinValue
    {
        get;
        set;
    }
    public int Step
    {
        get;
        set;
    }
    public ConfigFieldSliderInfoEx(int minValue, int maxValue, int step)
    {
        MinValue = minValue;
        MaxValue = maxValue;
        Step = step;
    }
}