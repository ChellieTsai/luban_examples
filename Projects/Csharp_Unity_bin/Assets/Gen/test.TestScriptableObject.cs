
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
public sealed partial class TestScriptableObject : Luban.BeanBase
{
    public TestScriptableObject(ByteBuf _buf) 
    {
        ID = _buf.ReadInt();
        DESC = _buf.ReadString();
        RATE = _buf.ReadFloat();
        NUM = _buf.ReadInt();
        V2 = vec2.Deserializevec2(_buf);
        V3 = ExternalTypeUtil.NewVector3(vec3.Deserializevec3(_buf));
        V4 = vec4.Deserializevec4(_buf);
    }

    public static TestScriptableObject DeserializeTestScriptableObject(ByteBuf _buf)
    {
        return new test.TestScriptableObject(_buf);
    }

    public readonly int ID;
    public readonly string DESC;
    public readonly float RATE;
    public readonly int NUM;
    public readonly vec2 V2;
    public readonly System.Numerics.Vector3 V3;
    public readonly vec4 V4;
   
    public const int __ID__ = -1896814350;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + ID + ","
        + "desc:" + DESC + ","
        + "rate:" + RATE + ","
        + "num:" + NUM + ","
        + "v2:" + V2 + ","
        + "v3:" + V3 + ","
        + "v4:" + V4 + ","
        + "}";
    }
}

}

