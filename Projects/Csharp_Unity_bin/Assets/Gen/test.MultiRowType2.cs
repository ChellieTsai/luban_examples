
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.test
{
public sealed partial class MultiRowType2 : Luban.BeanBase
{
    public MultiRowType2(ByteBuf _buf) 
    {
        ID = _buf.ReadInt();
        X = _buf.ReadInt();
        Y = _buf.ReadFloat();
    }

    public static MultiRowType2 DeserializeMultiRowType2(ByteBuf _buf)
    {
        return new test.MultiRowType2(_buf);
    }

    public readonly int ID;
    public readonly int X;
    public readonly float Y;
   
    public const int __ID__ = 540474971;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + ID + ","
        + "x:" + X + ","
        + "y:" + Y + ","
        + "}";
    }
}

}

