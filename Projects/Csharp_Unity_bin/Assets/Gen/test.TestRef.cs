
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
public sealed partial class TestRef : Luban.BeanBase
{
    public TestRef(ByteBuf _buf) 
    {
        ID = _buf.ReadInt();
        X1 = _buf.ReadInt();
        X1_Ref = null;
        X1_2 = _buf.ReadInt();
        X1_2_Ref = null;
        X2 = _buf.ReadInt();
        X3 = _buf.ReadInt();
        X4 = _buf.ReadInt();
        X4_Ref = null;
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);A1 = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); A1[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);A2 = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); A2[__index0] = __e0;}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);B1 = new System.Collections.Generic.List<int>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); B1.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);B2 = new System.Collections.Generic.List<int>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); B2.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);C1 = new System.Collections.Generic.HashSet<int>(/*n0 * 3 / 2*/);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); C1.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);C2 = new System.Collections.Generic.HashSet<int>(/*n0 * 3 / 2*/);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); C2.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);D1 = new System.Collections.Generic.Dictionary<int, int>(n0 * 3 / 2);for(var i0 = 0 ; i0 < n0 ; i0++) { int _k0;  _k0 = _buf.ReadInt(); int _v0;  _v0 = _buf.ReadInt();     D1.Add(_k0, _v0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);D2 = new System.Collections.Generic.Dictionary<int, int>(n0 * 3 / 2);for(var i0 = 0 ; i0 < n0 ; i0++) { int _k0;  _k0 = _buf.ReadInt(); int _v0;  _v0 = _buf.ReadInt();     D2.Add(_k0, _v0);}}
        E1 = _buf.ReadInt();
        E2 = _buf.ReadLong();
        E3 = _buf.ReadString();
        F1 = _buf.ReadInt();
        F2 = _buf.ReadLong();
        F3 = _buf.ReadString();
        S1 = test.RefDynamicBase.DeserializeRefDynamicBase(_buf);
    }

    public static TestRef DeserializeTestRef(ByteBuf _buf)
    {
        return new test.TestRef(_buf);
    }

    public readonly int ID;
    public readonly int X1;
    public test.TestBeRef X1_Ref;
    public readonly int X1_2;
    public test.TestBeRef X1_2_Ref;
    public readonly int X2;
    public readonly int X3;
    public readonly int X4;
    public tag.TestTag X4_Ref;
    public readonly int[] A1;
    public test.TestBeRef[] A1_Ref;
    public readonly int[] A2;
    public test.TestBeRef[] A2_Ref;
    public readonly System.Collections.Generic.List<int> B1;
    public System.Collections.Generic.List<test.TestBeRef> B1_Ref;
    public readonly System.Collections.Generic.List<int> B2;
    public System.Collections.Generic.List<test.TestBeRef> B2_Ref;
    public readonly System.Collections.Generic.HashSet<int> C1;
    public System.Collections.Generic.HashSet<test.TestBeRef> C1_Ref;
    public readonly System.Collections.Generic.HashSet<int> C2;
    public System.Collections.Generic.HashSet<test.TestBeRef> C2_Ref;
    public readonly System.Collections.Generic.Dictionary<int, int> D1;
    public System.Collections.Generic.Dictionary<int, test.TestBeRef> D1_Ref;
    public readonly System.Collections.Generic.Dictionary<int, int> D2;
    public System.Collections.Generic.Dictionary<int, test.TestBeRef> D2_Ref;
    public readonly int E1;
    public readonly long E2;
    public readonly string E3;
    public readonly int F1;
    public readonly long F2;
    public readonly string F3;
    public readonly test.RefDynamicBase S1;
   
    public const int __ID__ = -543222491;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        X1_Ref = tables.TBTESTBEREF.GetOrDefault(X1);
        X1_2_Ref = tables.TBTESTBEREF.GetOrDefault(X1_2);
        X4_Ref = tables.TBTESTTAG.GetOrDefault(X4);
        A1_Ref = new test.TestBeRef[A1.Length];
        for (int _i = 0; _i < A1.Length; _i++) { A1_Ref[_i] = tables.TBTESTBEREF.GetOrDefault(A1[_i]); }

        A2_Ref = new test.TestBeRef[A2.Length];
        for (int _i = 0; _i < A2.Length; _i++) { A2_Ref[_i] = tables.TBTESTBEREF.GetOrDefault(A2[_i]); }

        B1_Ref = new System.Collections.Generic.List<test.TestBeRef>();
        foreach (var _v in B1) { B1_Ref.Add(tables.TBTESTBEREF.GetOrDefault(_v)); }

        B2_Ref = new System.Collections.Generic.List<test.TestBeRef>();
        foreach (var _v in B2) { B2_Ref.Add(tables.TBTESTBEREF.GetOrDefault(_v)); }

        C1_Ref = new System.Collections.Generic.HashSet<test.TestBeRef>();
        foreach (var _v in C1) { C1_Ref.Add(tables.TBTESTBEREF.GetOrDefault(_v)); }

        C2_Ref = new System.Collections.Generic.HashSet<test.TestBeRef>();
        foreach (var _v in C2) { C2_Ref.Add(tables.TBTESTBEREF.GetOrDefault(_v)); }

        D1_Ref = new System.Collections.Generic.Dictionary<int, test.TestBeRef>();
        foreach (var kvp in D1) { D1_Ref.Add(kvp.Key, tables.TBTESTBEREF.GetOrDefault(kvp.Value)); }

        D2_Ref = new System.Collections.Generic.Dictionary<int, test.TestBeRef>();
        foreach (var kvp in D2) { D2_Ref.Add(kvp.Key, tables.TBTESTBEREF.GetOrDefault(kvp.Value)); }

        S1?.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + ID + ","
        + "x1:" + X1 + ","
        + "x1_2:" + X1_2 + ","
        + "x2:" + X2 + ","
        + "x3:" + X3 + ","
        + "x4:" + X4 + ","
        + "a1:" + Luban.StringUtil.CollectionToString(A1) + ","
        + "a2:" + Luban.StringUtil.CollectionToString(A2) + ","
        + "b1:" + Luban.StringUtil.CollectionToString(B1) + ","
        + "b2:" + Luban.StringUtil.CollectionToString(B2) + ","
        + "c1:" + Luban.StringUtil.CollectionToString(C1) + ","
        + "c2:" + Luban.StringUtil.CollectionToString(C2) + ","
        + "d1:" + Luban.StringUtil.CollectionToString(D1) + ","
        + "d2:" + Luban.StringUtil.CollectionToString(D2) + ","
        + "e1:" + E1 + ","
        + "e2:" + E2 + ","
        + "e3:" + E3 + ","
        + "f1:" + F1 + ","
        + "f2:" + F2 + ","
        + "f3:" + F3 + ","
        + "s1:" + S1 + ","
        + "}";
    }
}

}

