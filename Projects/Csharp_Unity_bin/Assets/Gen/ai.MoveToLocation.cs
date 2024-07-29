
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
public sealed partial class MoveToLocation : ai.Task
{
    public MoveToLocation(ByteBuf _buf)  : base(_buf) 
    {
        ACCEPTABLE_RADIUS = _buf.ReadFloat();
    }

    public static MoveToLocation DeserializeMoveToLocation(ByteBuf _buf)
    {
        return new ai.MoveToLocation(_buf);
    }

    public readonly float ACCEPTABLE_RADIUS;
   
    public const int __ID__ = -969953113;
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
        + "decorators:" + Luban.StringUtil.CollectionToString(DECORATORS) + ","
        + "services:" + Luban.StringUtil.CollectionToString(SERVICES) + ","
        + "ignore_restart_self:" + IGNORE_RESTART_SELF + ","
        + "acceptable_radius:" + ACCEPTABLE_RADIUS + ","
        + "}";
    }
}

}

