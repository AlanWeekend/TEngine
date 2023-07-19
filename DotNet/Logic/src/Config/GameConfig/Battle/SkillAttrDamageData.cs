//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;


namespace GameConfig.Battle
{
public sealed partial class SkillAttrDamageData :  Bright.Config.BeanBase 
{
    public SkillAttrDamageData(ByteBuf _buf) 
    {
        MagicType = (Battle.SkillMagicType)_buf.ReadInt();
        AttrType = (Battle.SkillAttrDamageType)_buf.ReadInt();
        Param1 = _buf.ReadFloat();
        Param2 = _buf.ReadFloat();
        Param3 = _buf.ReadFloat();
        MaxLimit = _buf.ReadFloat();
        PostInit();
    }

    public static SkillAttrDamageData DeserializeSkillAttrDamageData(ByteBuf _buf)
    {
        return new Battle.SkillAttrDamageData(_buf);
    }

    public Battle.SkillMagicType MagicType { get; private set; }
    public Battle.SkillAttrDamageType AttrType { get; private set; }
    public float Param1 { get; private set; }
    public float Param2 { get; private set; }
    public float Param3 { get; private set; }
    public float MaxLimit { get; private set; }

    public const int __ID__ = -94519547;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "MagicType:" + MagicType + ","
        + "AttrType:" + AttrType + ","
        + "Param1:" + Param1 + ","
        + "Param2:" + Param2 + ","
        + "Param3:" + Param3 + ","
        + "MaxLimit:" + MaxLimit + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}