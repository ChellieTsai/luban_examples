
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
public sealed partial class GetOwnerPlayer : ai.Service
{
    public GetOwnerPlayer(ByteBuf _buf)  : base(_buf) 
    {
        PLAYER_ACTOR_KEY = _buf.ReadString();
    }

    public static GetOwnerPlayer DeserializeGetOwnerPlayer(ByteBuf _buf)
    {
        return new ai.GetOwnerPlayer(_buf);
    }

    public readonly string PLAYER_ACTOR_KEY;
   
    public const int __ID__ = -999247644;
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
        + "player_actor_key:" + PLAYER_ACTOR_KEY + ","
        + "}";
    }
}

}

