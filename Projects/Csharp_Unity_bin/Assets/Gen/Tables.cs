
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;

namespace cfg
{
public partial class Tables
{
    public ai.TbBlackboard TBBLACKBOARD {get; }
    public ai.TbBehaviorTree TBBEHAVIORTREE {get; }
    public common.TbGlobalConfig TBGLOBALCONFIG {get; }
    /// <summary>
    /// 道具表
    /// </summary>
    public item.TbItem TBITEM {get; }
    public l10n.TbL10NDemo TBL10NDEMO {get; }
    public l10n.TbPatchDemo TBPATCHDEMO {get; }
    public tag.TbTestTag TBTESTTAG {get; }
    public test.TbFullTypes TBFULLTYPES {get; }
    public test.TbSingleton TBSINGLETON {get; }
    public test.TbNotIndexList TBNOTINDEXLIST {get; }
    public test.TbMultiUnionIndexList TBMULTIUNIONINDEXLIST {get; }
    public test.TbMultiIndexList TBMULTIINDEXLIST {get; }
    public test.TbDataFromMisc TBDATAFROMMISC {get; }
    public test.TbMultiRowRecord TBMULTIROWRECORD {get; }
    public test.TbTestMultiColumn TBTESTMULTICOLUMN {get; }
    public test.TbMultiRowTitle TBMULTIROWTITLE {get; }
    public test.TbTestNull TBTESTNULL {get; }
    public test.TbDemoPrimitive TBDEMOPRIMITIVE {get; }
    public test.TbTestString TBTESTSTRING {get; }
    public test.TbDemoGroup TBDEMOGROUP {get; }
    public test.TbDemoGroup_C TBDEMOGROUP_C {get; }
    public test.TbDemoGroup_S TBDEMOGROUP_S {get; }
    public test.TbDemoGroup_E TBDEMOGROUP_E {get; }
    public test.TbTestGlobal TBTESTGLOBAL {get; }
    public test.TbTestBeRef TBTESTBEREF {get; }
    public test.TbTestBeRef2 TBTESTBEREF2 {get; }
    public test.TbTestRef TBTESTREF {get; }
    public test.TbTestSize TBTESTSIZE {get; }
    public test.TbTestSet TBTESTSET {get; }
    public test.TbDetectCsvEncoding TBDETECTCSVENCODING {get; }
    public test.TbItem2 TBITEM2 {get; }
    public test.TbTestIndex TBTESTINDEX {get; }
    public test.TbTestMap TBTESTMAP {get; }
    public test.TbExcelFromJson TBEXCELFROMJSON {get; }
    public test.TbCompositeJsonTable1 TBCOMPOSITEJSONTABLE1 {get; }
    public test.TbCompositeJsonTable2 TBCOMPOSITEJSONTABLE2 {get; }
    public test.TbCompositeJsonTable3 TBCOMPOSITEJSONTABLE3 {get; }
    public test.TbExcelFromJsonMultiRow TBEXCELFROMJSONMULTIROW {get; }
    public test.TbTestScriptableObject TBTESTSCRIPTABLEOBJECT {get; }
    public test.TbPath TBPATH {get; }
    public test.TbTestMapper TBTESTMAPPER {get; }
    public test.TbDefineFromExcel2 TBDEFINEFROMEXCEL2 {get; }

    public Tables(System.Func<string, ByteBuf> loader)
    {
        TBBLACKBOARD = new ai.TbBlackboard(loader("ai_tbblackboard"));
        TBBEHAVIORTREE = new ai.TbBehaviorTree(loader("ai_tbbehaviortree"));
        TBGLOBALCONFIG = new common.TbGlobalConfig(loader("common_tbglobalconfig"));
        TBITEM = new item.TbItem(loader("item_tbitem"));
        TBL10NDEMO = new l10n.TbL10NDemo(loader("l10n_tbl10ndemo"));
        TBPATCHDEMO = new l10n.TbPatchDemo(loader("l10n_tbpatchdemo"));
        TBTESTTAG = new tag.TbTestTag(loader("tag_tbtesttag"));
        TBFULLTYPES = new test.TbFullTypes(loader("test_tbfulltypes"));
        TBSINGLETON = new test.TbSingleton(loader("test_tbsingleton"));
        TBNOTINDEXLIST = new test.TbNotIndexList(loader("test_tbnotindexlist"));
        TBMULTIUNIONINDEXLIST = new test.TbMultiUnionIndexList(loader("test_tbmultiunionindexlist"));
        TBMULTIINDEXLIST = new test.TbMultiIndexList(loader("test_tbmultiindexlist"));
        TBDATAFROMMISC = new test.TbDataFromMisc(loader("test_tbdatafrommisc"));
        TBMULTIROWRECORD = new test.TbMultiRowRecord(loader("test_tbmultirowrecord"));
        TBTESTMULTICOLUMN = new test.TbTestMultiColumn(loader("test_tbtestmulticolumn"));
        TBMULTIROWTITLE = new test.TbMultiRowTitle(loader("test_tbmultirowtitle"));
        TBTESTNULL = new test.TbTestNull(loader("test_tbtestnull"));
        TBDEMOPRIMITIVE = new test.TbDemoPrimitive(loader("test_tbdemoprimitive"));
        TBTESTSTRING = new test.TbTestString(loader("test_tbteststring"));
        TBDEMOGROUP = new test.TbDemoGroup(loader("test_tbdemogroup"));
        TBDEMOGROUP_C = new test.TbDemoGroup_C(loader("test_tbdemogroup_c"));
        TBDEMOGROUP_S = new test.TbDemoGroup_S(loader("test_tbdemogroup_s"));
        TBDEMOGROUP_E = new test.TbDemoGroup_E(loader("test_tbdemogroup_e"));
        TBTESTGLOBAL = new test.TbTestGlobal(loader("test_tbtestglobal"));
        TBTESTBEREF = new test.TbTestBeRef(loader("test_tbtestberef"));
        TBTESTBEREF2 = new test.TbTestBeRef2(loader("test_tbtestberef2"));
        TBTESTREF = new test.TbTestRef(loader("test_tbtestref"));
        TBTESTSIZE = new test.TbTestSize(loader("test_tbtestsize"));
        TBTESTSET = new test.TbTestSet(loader("test_tbtestset"));
        TBDETECTCSVENCODING = new test.TbDetectCsvEncoding(loader("test_tbdetectcsvencoding"));
        TBITEM2 = new test.TbItem2(loader("test_tbitem2"));
        TBTESTINDEX = new test.TbTestIndex(loader("test_tbtestindex"));
        TBTESTMAP = new test.TbTestMap(loader("test_tbtestmap"));
        TBEXCELFROMJSON = new test.TbExcelFromJson(loader("test_tbexcelfromjson"));
        TBCOMPOSITEJSONTABLE1 = new test.TbCompositeJsonTable1(loader("test_tbcompositejsontable1"));
        TBCOMPOSITEJSONTABLE2 = new test.TbCompositeJsonTable2(loader("test_tbcompositejsontable2"));
        TBCOMPOSITEJSONTABLE3 = new test.TbCompositeJsonTable3(loader("test_tbcompositejsontable3"));
        TBEXCELFROMJSONMULTIROW = new test.TbExcelFromJsonMultiRow(loader("test_tbexcelfromjsonmultirow"));
        TBTESTSCRIPTABLEOBJECT = new test.TbTestScriptableObject(loader("test_tbtestscriptableobject"));
        TBPATH = new test.TbPath(loader("test_tbpath"));
        TBTESTMAPPER = new test.TbTestMapper(loader("test_tbtestmapper"));
        TBDEFINEFROMEXCEL2 = new test.TbDefineFromExcel2(loader("test_tbdefinefromexcel2"));
        ResolveRef();
    }
    
    private void ResolveRef()
    {
        TBBLACKBOARD.ResolveRef(this);
        TBBEHAVIORTREE.ResolveRef(this);
        TBGLOBALCONFIG.ResolveRef(this);
        TBITEM.ResolveRef(this);
        TBL10NDEMO.ResolveRef(this);
        TBPATCHDEMO.ResolveRef(this);
        TBTESTTAG.ResolveRef(this);
        TBFULLTYPES.ResolveRef(this);
        TBSINGLETON.ResolveRef(this);
        TBNOTINDEXLIST.ResolveRef(this);
        TBMULTIUNIONINDEXLIST.ResolveRef(this);
        TBMULTIINDEXLIST.ResolveRef(this);
        TBDATAFROMMISC.ResolveRef(this);
        TBMULTIROWRECORD.ResolveRef(this);
        TBTESTMULTICOLUMN.ResolveRef(this);
        TBMULTIROWTITLE.ResolveRef(this);
        TBTESTNULL.ResolveRef(this);
        TBDEMOPRIMITIVE.ResolveRef(this);
        TBTESTSTRING.ResolveRef(this);
        TBDEMOGROUP.ResolveRef(this);
        TBDEMOGROUP_C.ResolveRef(this);
        TBDEMOGROUP_S.ResolveRef(this);
        TBDEMOGROUP_E.ResolveRef(this);
        TBTESTGLOBAL.ResolveRef(this);
        TBTESTBEREF.ResolveRef(this);
        TBTESTBEREF2.ResolveRef(this);
        TBTESTREF.ResolveRef(this);
        TBTESTSIZE.ResolveRef(this);
        TBTESTSET.ResolveRef(this);
        TBDETECTCSVENCODING.ResolveRef(this);
        TBITEM2.ResolveRef(this);
        TBTESTINDEX.ResolveRef(this);
        TBTESTMAP.ResolveRef(this);
        TBEXCELFROMJSON.ResolveRef(this);
        TBCOMPOSITEJSONTABLE1.ResolveRef(this);
        TBCOMPOSITEJSONTABLE2.ResolveRef(this);
        TBCOMPOSITEJSONTABLE3.ResolveRef(this);
        TBEXCELFROMJSONMULTIROW.ResolveRef(this);
        TBTESTSCRIPTABLEOBJECT.ResolveRef(this);
        TBPATH.ResolveRef(this);
        TBTESTMAPPER.ResolveRef(this);
        TBDEFINEFROMEXCEL2.ResolveRef(this);
    }
}

}
