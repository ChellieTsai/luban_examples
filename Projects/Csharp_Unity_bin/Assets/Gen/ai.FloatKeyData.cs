
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
public sealed partial class FloatKeyData : ai.KeyData
{
    public FloatKeyData(ByteBuf _buf)  : base(_buf) 
    {
        VALUE = _buf.ReadFloat();
    }

    public static FloatKeyData DeserializeFloatKeyData(ByteBuf _buf)
    {
        return new ai.FloatKeyData(_buf);
    }

    public readonly float VALUE;
   
    public const int __ID__ = -719747885;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "value:" + VALUE + ","
        + "}";
    }
}

}

