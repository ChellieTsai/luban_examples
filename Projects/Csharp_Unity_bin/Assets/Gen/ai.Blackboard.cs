
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
public sealed partial class Blackboard : Luban.BeanBase
{
    public Blackboard(ByteBuf _buf) 
    {
        NAME = _buf.ReadString();
        DESC = _buf.ReadString();
        PARENT_NAME = _buf.ReadString();
        PARENT_NAME_Ref = null;
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);KEYS = new System.Collections.Generic.List<ai.BlackboardKey>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { ai.BlackboardKey _e0;  _e0 = ai.BlackboardKey.DeserializeBlackboardKey(_buf); KEYS.Add(_e0);}}
    }

    public static Blackboard DeserializeBlackboard(ByteBuf _buf)
    {
        return new ai.Blackboard(_buf);
    }

    public readonly string NAME;
    public readonly string DESC;
    public readonly string PARENT_NAME;
    public ai.Blackboard PARENT_NAME_Ref;
    public readonly System.Collections.Generic.List<ai.BlackboardKey> KEYS;
   
    public const int __ID__ = 1576193005;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        PARENT_NAME_Ref = tables.TBBLACKBOARD.GetOrDefault(PARENT_NAME);
        foreach (var _e in KEYS) { _e?.ResolveRef(tables); }
    }

    public override string ToString()
    {
        return "{ "
        + "name:" + NAME + ","
        + "desc:" + DESC + ","
        + "parent_name:" + PARENT_NAME + ","
        + "keys:" + Luban.StringUtil.CollectionToString(KEYS) + ","
        + "}";
    }
}

}

