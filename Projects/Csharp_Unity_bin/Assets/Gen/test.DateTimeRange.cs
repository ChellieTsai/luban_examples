
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
public sealed partial class DateTimeRange : Luban.BeanBase
{
    public DateTimeRange(ByteBuf _buf) 
    {
        START_TIME = _buf.ReadLong();
        END_TIME = _buf.ReadLong();
    }

    public static DateTimeRange DeserializeDateTimeRange(ByteBuf _buf)
    {
        return new test.DateTimeRange(_buf);
    }

    public readonly long START_TIME;
    public readonly long END_TIME;
   
    public const int __ID__ = 495315430;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "start_time:" + START_TIME + ","
        + "end_time:" + END_TIME + ","
        + "}";
    }
}

}

