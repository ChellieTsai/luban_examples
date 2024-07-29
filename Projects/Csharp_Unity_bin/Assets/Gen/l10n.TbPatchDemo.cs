
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.l10n
{
public partial class TbPatchDemo
{
    private readonly System.Collections.Generic.Dictionary<int, l10n.PatchDemo> _dataMap;
    private readonly System.Collections.Generic.List<l10n.PatchDemo> _dataList;
    
    public TbPatchDemo(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, l10n.PatchDemo>();
        _dataList = new System.Collections.Generic.List<l10n.PatchDemo>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            l10n.PatchDemo _v;
            _v = l10n.PatchDemo.DeserializePatchDemo(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, l10n.PatchDemo> DataMap => _dataMap;
    public System.Collections.Generic.List<l10n.PatchDemo> DataList => _dataList;

    public l10n.PatchDemo GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public l10n.PatchDemo Get(int key) => _dataMap[key];
    public l10n.PatchDemo this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

