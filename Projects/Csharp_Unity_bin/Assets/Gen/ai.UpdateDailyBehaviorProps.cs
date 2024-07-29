
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.ai
{
public sealed partial class UpdateDailyBehaviorProps : ai.Service
{
    public UpdateDailyBehaviorProps(ByteBuf _buf)  : base(_buf) 
    {
        SATIETY_KEY = _buf.ReadString();
        ENERGY_KEY = _buf.ReadString();
        MOOD_KEY = _buf.ReadString();
        SATIETY_LOWER_THRESHOLD_KEY = _buf.ReadString();
        SATIETY_UPPER_THRESHOLD_KEY = _buf.ReadString();
        ENERGY_LOWER_THRESHOLD_KEY = _buf.ReadString();
        ENERGY_UPPER_THRESHOLD_KEY = _buf.ReadString();
        MOOD_LOWER_THRESHOLD_KEY = _buf.ReadString();
        MOOD_UPPER_THRESHOLD_KEY = _buf.ReadString();
    }

    public static UpdateDailyBehaviorProps DeserializeUpdateDailyBehaviorProps(ByteBuf _buf)
    {
        return new ai.UpdateDailyBehaviorProps(_buf);
    }

    public readonly string SATIETY_KEY;
    public readonly string ENERGY_KEY;
    public readonly string MOOD_KEY;
    public readonly string SATIETY_LOWER_THRESHOLD_KEY;
    public readonly string SATIETY_UPPER_THRESHOLD_KEY;
    public readonly string ENERGY_LOWER_THRESHOLD_KEY;
    public readonly string ENERGY_UPPER_THRESHOLD_KEY;
    public readonly string MOOD_LOWER_THRESHOLD_KEY;
    public readonly string MOOD_UPPER_THRESHOLD_KEY;
   
    public const int __ID__ = -61887372;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + ID + ","
        + "node_name:" + NODE_NAME + ","
        + "satiety_key:" + SATIETY_KEY + ","
        + "energy_key:" + ENERGY_KEY + ","
        + "mood_key:" + MOOD_KEY + ","
        + "satiety_lower_threshold_key:" + SATIETY_LOWER_THRESHOLD_KEY + ","
        + "satiety_upper_threshold_key:" + SATIETY_UPPER_THRESHOLD_KEY + ","
        + "energy_lower_threshold_key:" + ENERGY_LOWER_THRESHOLD_KEY + ","
        + "energy_upper_threshold_key:" + ENERGY_UPPER_THRESHOLD_KEY + ","
        + "mood_lower_threshold_key:" + MOOD_LOWER_THRESHOLD_KEY + ","
        + "mood_upper_threshold_key:" + MOOD_UPPER_THRESHOLD_KEY + ","
        + "}";
    }
}

}

