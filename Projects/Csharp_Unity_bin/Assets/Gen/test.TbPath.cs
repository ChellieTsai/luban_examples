
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
public partial class TbPath
{
    private readonly System.Collections.Generic.Dictionary<int, test.Path> _dataMap;
    private readonly System.Collections.Generic.List<test.Path> _dataList;
    
    public TbPath(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, test.Path>();
        _dataList = new System.Collections.Generic.List<test.Path>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            test.Path _v;
            _v = test.Path.DeserializePath(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, test.Path> DataMap => _dataMap;
    public System.Collections.Generic.List<test.Path> DataList => _dataList;

    public test.Path GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.Path Get(int key) => _dataMap[key];
    public test.Path this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

