
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import (
    "demo/luban"
)

import "errors"

type AiBlackboard struct {
    Name string
    Desc string
    ParentName string
    Keys []*AiBlackboardKey
}

const TypeId_AiBlackboard = 1576193005

func (*AiBlackboard) GetTypeId() int32 {
    return 1576193005
}

func NewAiBlackboard(_buf *luban.ByteBuf) (_v *AiBlackboard, err error) {
    _v = &AiBlackboard{}
    { if _v.Name, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.Desc, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.ParentName, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    {_v.Keys = make([]*AiBlackboardKey, 0); var _n0_ int; if _n0_, err = _buf.ReadSize(); err != nil { err = errors.New("error"); return}; for i0 := 0 ; i0 < _n0_ ; i0++ { var _e0_ *AiBlackboardKey; { if _e0_, err = NewAiBlackboardKey(_buf); err != nil { err = errors.New("error"); return } }; _v.Keys = append(_v.Keys, _e0_) } }
    return
}

