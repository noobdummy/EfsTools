using System;
using System.Linq;
using System.Collections.Generic;
using BinarySerialization;
using Newtonsoft.Json;
using EfsTools.Items.Base;
using EfsTools.Items.Data;
using EfsTools.Attributes;
using EfsTools.Utils;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp2/additional_dial_string", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class AdditionalDialString : ItemBase
    {
        private byte[] _value1;


        public byte[] _value2;

        public string Value1String
        {
            get => StringUtils.GetString(_value1);
            set => _value1 = StringUtils.GetBytes(value, 20);
        }

        public string Value2String
        {
            get => StringUtils.GetString(_value2);
            set => _value2 = StringUtils.GetBytes(value, 20);
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/nas/aggression_management", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AggressionManagement : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/data/3gpp/ps/allow_infinite_throt", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class AllowInfiniteThrot : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp2/always_on_config_info", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class AlwaysOnConfigInfo : ItemBase
    {
        public byte Field1 { get; set; }


        public byte Field2 { get; set; }


        public uint Field3 { get; set; }


        public byte Field4 { get; set; }


        public byte Field5 { get; set; }


        public byte Field6 { get; set; }


        public uint Field7 { get; set; }
    }

    [Serializable]
    [EfsFile("/data/andsf_copy.xml", false, 0x81B6)]
    [Attributes(9)]
    public sealed class AndsfCopyXml : MultiLineStringsItemBase
    {
    }

    [Serializable]
    [EfsFile("/data/andsf.xml", false, 0x81B6)]
    [Attributes(9)]
    public sealed class AndsfXml : MultiLineStringsItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/modem/data/3gpp/ps/apn_reject/apn_reject_name.txt", false, 0x81FF)]
    [Attributes(9)]
   public sealed class ApnRejectNameTxt : ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/ds/atcop/atcop_cops_auto_mode.txt", false, 0x81FF)]
    [Attributes(9)]
   public sealed class AtcopCopsAutoModeTxt : ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/data/3gpp/lteps/attach_profile", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class AttachProfile: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020724", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AwsAptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020723", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AwsAptCharTblPaRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020725", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AwsAptCharTblPout0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020726", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AwsAptCharTblPout1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020727", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AwsAptCharTblPout2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020728", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AwsAptCharTblPout3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020729", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AwsAptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020730", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AwsAptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020731", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AwsAptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020732", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AwsAptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020722", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AwsAptCharTblTypeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022592", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class B11AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022591", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class B11AptCharTblPaRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022593", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class B11AptCharTblPout0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022594", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class B11AptCharTblPout1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022595", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class B11AptCharTblPout2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022596", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class B11AptCharTblPout3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022597", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class B11AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022598", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class B11AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022599", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class B11AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022600", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class B11AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022590", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class B11AptCharTblTypeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/hdr/cp/sap/backofftimel2", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Backofftimel2 : ItemBase
    {
        public ushort Field1 { get; set; }


        public ushort Field2 { get; set; }


        public ushort Field3 { get; set; }


        public ushort Field4 { get; set; }


        public ushort Field5 { get; set; }


        public ushort Field6 { get; set; }


        public ushort Field7 { get; set; }


        public ushort Field8 { get; set; }


        public ushort Field9 { get; set; }


        public ushort Field10 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/hdr/cp/hmp/backofftimesession", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Backofftimesession : ItemBase
    {
        public ushort Field1 { get; set; }


        public ushort Field2 { get; set; }


        public ushort Field3 { get; set; }


        public ushort Field4 { get; set; }


        public ushort Field5 { get; set; }


        public ushort Field6 { get; set; }


        public ushort Field7 { get; set; }


        public ushort Field8 { get; set; }


        public ushort Field9 { get; set; }


        public ushort Field10 { get; set; }
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/modem/lte/rrc/csp/band_priority_list", false, 0x81FF)]
    [Attributes(9)]
   public sealed class BandPriorityList : ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020022", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc0AntGainDelta : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021075", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc0AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021076", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc0AptCharTblPout0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021077", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc0AptCharTblPout1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021078", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc0AptCharTblPout2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021079", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc0AptCharTblPout3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021080", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc0AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021081", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc0AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021082", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc0AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021083", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc0AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021006", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc0PaSmpsPdmLevelTemp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021336", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc0TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021141", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc10AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021142", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc10AptCharTblPout0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021143", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc10AptCharTblPout1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021144", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc10AptCharTblPout2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021145", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc10AptCharTblPout3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021146", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc10AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021147", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc10AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021148", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc10AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021149", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc10AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021012", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc10PaSmpsPdmLevelTemp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021342", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc10TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021152", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc11AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021153", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc11AptCharTblPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021154", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc11AptCharTblPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021155", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc11AptCharTblPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021156", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc11AptCharTblPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021157", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc11AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021158", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc11AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021159", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc11AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021160", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc11AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021013", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc11PaSmpsPdmLevelTemp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021343", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc11TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021163", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc14AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021164", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc14AptCharTblPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021165", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc14AptCharTblPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021166", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc14AptCharTblPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021167", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc14AptCharTblPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021168", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc14AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021169", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc14AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021170", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc14AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021171", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc14AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021014", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc14PaSmpsPdmLevelTemp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021344", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc14TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021174", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc15AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021175", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc15AptCharTblPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021176", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc15AptCharTblPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021177", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc15AptCharTblPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021178", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc15AptCharTblPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021179", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc15AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021180", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc15AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021181", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc15AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021182", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc15AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021015", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc15PaSmpsPdmLevelTemp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021345", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc15TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020023", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc1AntGainDelta : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021086", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc1AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021087", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc1AptCharTblPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021088", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc1AptCharTblPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021089", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc1AptCharTblPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021090", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc1AptCharTblPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021091", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc1AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021092", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc1AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021093", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc1AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021094", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc1AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021007", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc1PaSmpsPdmLevelTemp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021337", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc1TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020024", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc3AntGainDelta : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021097", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc3AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021098", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc3AptCharTblPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021099", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc3AptCharTblPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021100", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc3AptCharTblPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021101", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc3AptCharTblPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021102", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc3AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021103", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc3AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021104", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc3AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021105", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc3AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021008", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc3PaSmpsPdmLevelTemp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021338", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc3TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020025", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc4AntGainDelta : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021108", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc4AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021109", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc4AptCharTblPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021110", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc4AptCharTblPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021111", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc4AptCharTblPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021112", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc4AptCharTblPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021113", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc4AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021114", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc4AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021115", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc4AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021116", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc4AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021009", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc4PaSmpsPdmLevelTemp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021339", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc4TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020026", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc5AntGainDelta : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021119", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc5AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021120", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc5AptCharTblPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021121", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc5AptCharTblPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021122", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc5AptCharTblPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021123", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc5AptCharTblPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021124", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc5AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021125", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc5AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021126", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc5AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021127", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc5AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021010", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc5PaSmpsPdmLevelTemp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021340", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc5TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020027", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc6AntGainDelta : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021130", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc6AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021131", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc6AptCharTblPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021132", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc6AptCharTblPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021133", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc6AptCharTblPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021134", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Bc6AptCharTblPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021135", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc6AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021136", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc6AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021137", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc6AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021138", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc6AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021011", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc6PaSmpsPdmLevelTemp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021341", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc6TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/sd/bst_tbl", false, 0x81FF)]
    [Attributes(9)]
   public sealed class BstTbl : ItemBase
    {
        /*[JsonIgnore]
		[ConvertEndian]
		public ushort Length
        {
            get => _length;
            set
            {
                if (value > 40)
                {
                    _length = 40;
                }
                else
                {
                    _length = value;
                }
            }
        }

        private ushort _length;*/

        [FieldOffset(0)]
        [FieldCount(58)]
        public byte[] Value
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020948", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeFall2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020949", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeFall3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020950", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeFall4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020951", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeFall5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020947", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeFallCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020943", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeRise2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020944", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeRise3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020945", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeRise4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020946", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeRise5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020942", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeRiseCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020958", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeFall2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020959", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeFall3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020960", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeFall4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020961", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeFall5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020957", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeFallCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020953", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeRise2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020954", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeRise3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020955", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeRise4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020956", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeRise5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020952", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeRiseCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020918", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeFall2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020919", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeFall3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020920", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeFall4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020921", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeFall5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020917", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeFallCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020476", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeOffset2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020477", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeOffset3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020478", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeOffset4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020479", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeOffset5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020475", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020913", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeRise2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020914", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeRise3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020915", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeRise4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020916", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeRise5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020912", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeRiseCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020473", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1Wcdma1900RxfIciCalDataCar0 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020474", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1Wcdma1900RxfIciCalDataCar1 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020480", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma1900VgaGainOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020928", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeFall2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020929", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeFall3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020930", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeFall4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020931", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeFall5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020927", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeFallCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020923", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeRise2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020924", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeRise3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020925", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeRise4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020926", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeRise5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020922", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeRiseCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020968", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeFall2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020969", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeFall3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020970", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeFall4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020971", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeFall5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020967", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeFallCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020963", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeRise2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020964", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeRise3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020965", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeRise4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020966", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeRise5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020962", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeRiseCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020938", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeFall2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020939", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeFall3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020940", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeFall4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020941", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeFall5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020937", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeFallCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020550", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeOffset2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020551", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeOffset3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020552", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeOffset4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020553", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeOffset5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020549", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020933", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeRise2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020934", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeRise3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020935", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeRise4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020936", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeRise5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020932", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeRiseCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020547", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1Wcdma900RxfIciCalDataCar0 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020548", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1Wcdma900RxfIciCalDataCar1 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020554", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1Wcdma900VgaGainOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022585", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB11LnaRangeOffset2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022586", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB11LnaRangeOffset3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022587", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB11LnaRangeOffset4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022588", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB11LnaRangeOffset5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022584", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB11LnaRangeOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022582", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1WcdmaB11RxfIciCalDataCar0 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022583", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1WcdmaB11RxfIciCalDataCar1 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022589", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB11VgaGainOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023812", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB4LnaRangeOffset2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023813", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB4LnaRangeOffset3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023814", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB4LnaRangeOffset4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023815", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB4LnaRangeOffset5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023811", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB4LnaRangeOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023809", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1WcdmaB4RxfIciCalDataCar0 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023810", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1WcdmaB4RxfIciCalDataCar1 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023816", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB4VgaGainOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022560", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB5LnaRangeOffset2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022561", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB5LnaRangeOffset3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022562", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB5LnaRangeOffset4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022563", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB5LnaRangeOffset5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022559", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB5LnaRangeOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022557", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1WcdmaB5RxfIciCalDataCar0 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022558", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1WcdmaB5RxfIciCalDataCar1 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022565", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaB5VgaGainOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020978", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeFall2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020979", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeFall3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020980", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeFall4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020981", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeFall5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020977", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeFallCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020973", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeRise2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020974", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeRise3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020975", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeRise4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020976", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeRise5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020972", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeRiseCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021737", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc0Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021740", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021741", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021738", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc0Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021739", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc0Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021742", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021724", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021729", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc0Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021730", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021731", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc0Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021732", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021733", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc0Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021734", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021735", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc0Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021736", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021725", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021726", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021753", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023390", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021727", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc0VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021728", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021992", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc10Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021995", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc10Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021996", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc10Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021993", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc10Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021994", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc10Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021997", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc10IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021979", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc10IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021984", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc10Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021985", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc10Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021986", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc10Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021987", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc10Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021988", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc10Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021989", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc10Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021990", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc10Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021991", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc10Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021980", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc10RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021981", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc10RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022008", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc10TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023395", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc10TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021982", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc10VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021983", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc10VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022043", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc14Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022046", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc14Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022047", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc14Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022044", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc14Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022045", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc14Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022048", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc14IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022030", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc14IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022035", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc14Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022036", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc14Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022037", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc14Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022038", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc14Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022039", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc14Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022040", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc14Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022041", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc14Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022042", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc14Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022031", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc14RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022032", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc14RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022059", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc14TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023396", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc14TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022033", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc14VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022034", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc14VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022094", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc15Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022097", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022098", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022095", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc15Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022096", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022099", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022081", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022086", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc15Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022087", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022088", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc15Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022089", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022090", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc15Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022091", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022092", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc15Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022093", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022082", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022083", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022110", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023397", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022084", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc15VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022085", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021788", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc1Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021791", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021792", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021789", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc1Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021790", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc1Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021793", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021775", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021780", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc1Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021781", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021782", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc1Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021783", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021784", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc1Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021785", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021786", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc1Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021787", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021776", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021777", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021804", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023391", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021778", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc1VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021779", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021839", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc4Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021842", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc4Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021843", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc4Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021840", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc4Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021841", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc4Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021844", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc4IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021826", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc4IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021831", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc4Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021832", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc4Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021833", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc4Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021834", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc4Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021835", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc4Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021836", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc4Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021837", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc4Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021838", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc4Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021827", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc4RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021828", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc4RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021855", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc4TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023392", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc4TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021829", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc4VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021830", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc4VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021890", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc5Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021893", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021894", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021891", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc5Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021892", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc5Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021895", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021877", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021882", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc5Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021883", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021884", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc5Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021885", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021886", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc5Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021887", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021888", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc5Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021889", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021878", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021879", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021906", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023393", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021880", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc5VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021881", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021941", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc6Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021944", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021945", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021942", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc6Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021943", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc6Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021946", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021928", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021933", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc6Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021934", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021935", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc6Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021936", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021937", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc6Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021938", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021939", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc6Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021940", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021929", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021930", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021957", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023394", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6TxLimVsTempSarLvls : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021931", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C2Bc6VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021932", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/c2k_switch_2_srlte", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2kSwitch2Srlte : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021722", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2ThermBins : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023251", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc0Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023252", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc0Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023253", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc0Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023254", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc0Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023255", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc0Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023256", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc0Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023257", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc0Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023258", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc0Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023247", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc0RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023249", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc0VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023250", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc0VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023336", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc10Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023337", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc10Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023338", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc10Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023339", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc10Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023340", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc10Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023341", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc10Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023342", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc10Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023343", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc10Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023332", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc10RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023334", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc10VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023335", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc10VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023353", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc14Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023354", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc14Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023355", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc14Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023356", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc14Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023357", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc14Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023358", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc14Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023359", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc14Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023360", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc14Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023349", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc14RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023351", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc14VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023352", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc14VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023370", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc15Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023371", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc15Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023372", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc15Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023373", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc15Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023374", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc15Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023375", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc15Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023376", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc15Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023377", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc15Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023366", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc15RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023368", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc15VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023369", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc15VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023268", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc1Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023269", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc1Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023270", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc1Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023271", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc1Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023272", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc1Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023273", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc1Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023274", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc1Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023275", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc1Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023264", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc1RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023266", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc1VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023267", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc1VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023285", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc4Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023286", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc4Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023287", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc4Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023288", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc4Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023289", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc4Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023290", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc4Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023291", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc4Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023292", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc4Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023281", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc4RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023283", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc4VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023284", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc4VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023302", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc5Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023303", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc5Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023304", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc5Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023305", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc5Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023306", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc5Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023307", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc5Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023308", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc5Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023309", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc5Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023298", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc5RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023300", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc5VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023301", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc5VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023319", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc6Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023320", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc6Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023321", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc6Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023322", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc6Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023323", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc6Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023324", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc6Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023325", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc6Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023326", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc6Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023315", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc6RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023317", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class C3Bc6VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023318", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc6VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [Subscription]
    [EfsFile("/policyman/call_mode", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CallMode : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/data/3gpp/call_orig_allowed_before_ps_attach", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CallOrigAllowedBeforePsAttach : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/policyman/carrier_policy.xml", false, 0x81FF)]
    [Attributes(9)]
    public sealed class CarrierPolicyXml : MultiLineStringsItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025143", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0DoBc01xIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021605", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0DoBc0DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025129", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0DoBc0HdrIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020000", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0DoBc0Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025141", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0DoBc10HdrIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022912", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0DoBc15DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022911", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0DoBc15Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021606", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0DoBc1DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020001", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0DoBc1Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020002", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0DoBc6Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024136", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteB12DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023048", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteB25DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023042", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteB25Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024141", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteB4Im2 : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025130", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteB51xIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025131", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteB5LteIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024010", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteBc12Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021609", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteBc13DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020018", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteBc13Im3 : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020010", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteBc13Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020011", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteBc17Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022920", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteBc2DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022919", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteBc2Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023724", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteBc4DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020009", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteBc4Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025204", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteBc5DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024009", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteBc5Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025140", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc10DoBc01xIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023046", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc10DoBc0DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023040", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc10DoBc0Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025138", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc10DoBc101xIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025139", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc10DoBc10HdrIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023047", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc10DoBc1DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023041", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc10DoBc1Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023050", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc10LteB25DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023044", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc10LteB25Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025142", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc10LteB51xIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024008", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15DoBc0Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025148", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15DoBc151xIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022918", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15DoBc15DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025134", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15DoBc15HdrIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022917", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15DoBc15Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022916", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15DoBc1DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024830", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15DoBc1GnssIm3Desense : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022915", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15DoBc1Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025128", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteB12B171x3rdHarmonicDesense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024138", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteB12DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024828", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteB251xIm3Desense : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024827", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteB2B25LteIm3Desense : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025135", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteB41xIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025136", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteB4LteIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025137", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteB5LteIm2Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024014", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteBc12Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025720", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteBc17DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025719", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteBc17Sar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025206", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteBc25DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025207", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteBc25Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022924", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteBc2DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022923", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteBc2Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022926", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteBc4DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022925", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteBc4Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025205", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteBc5DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024013", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteBc5Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021607", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1DoBc0DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020003", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1DoBc0Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025144", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1DoBc11xIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022914", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1DoBc15DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024829", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1DoBc15GnssIm3Desense : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022913", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1DoBc15Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021608", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1DoBc1DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025132", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1DoBc1HdrIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020004", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1DoBc1Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020005", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1DoBc6Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024137", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteB12DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025146", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteB21xIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025147", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteB251xIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023049", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteB25DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023045", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteB25Im3 : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023043", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteB25Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025133", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteB2B25LteIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024140", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteB2Im3 : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024803", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteB4GnssIm3Desense : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024012", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteBc12Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021610", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteBc13DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020013", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteBc13Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020014", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteBc17Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022922", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteBc2DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022921", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteBc2Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023725", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteBc4DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020012", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteBc4Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024843", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteBc5DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024011", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteBc5Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022928", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc4DoBc4DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022927", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc4DoBc4Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022930", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc4LteBc5DsiSar : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022929", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc4LteBc5Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020006", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc6DoBc0Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020007", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc6DoBc1Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025145", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc6DoBc61xIm3Desense : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020008", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc6DoBc6Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020016", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc6LteBc13Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020017", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc6LteBc17Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020015", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc6LteBc4Sar : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020438", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc0PaSmpsAptNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020439", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc0PaSmpsAptPdm0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020440", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc0PaSmpsAptPdm1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020441", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc0PaSmpsAptPdm2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020442", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc0PaSmpsAptPdm3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020443", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc0PaSmpsAptPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020444", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc0PaSmpsAptPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020445", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc0PaSmpsAptPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020446", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc0PaSmpsAptPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020437", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc0PaSmpsAptRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020983", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc10PaSmpsAptNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020984", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc10PaSmpsAptPdm0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020985", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc10PaSmpsAptPdm1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020986", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc10PaSmpsAptPdm2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020987", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc10PaSmpsAptPdm3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020988", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc10PaSmpsAptPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020989", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc10PaSmpsAptPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020990", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc10PaSmpsAptPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020991", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc10PaSmpsAptPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020982", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc10PaSmpsAptRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021054", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc11PaSmpsAptNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021055", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc11PaSmpsAptPdm0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021056", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc11PaSmpsAptPdm1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021057", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc11PaSmpsAptPdm2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021058", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc11PaSmpsAptPdm3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021059", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc11PaSmpsAptPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021060", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc11PaSmpsAptPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021061", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc11PaSmpsAptPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021062", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc11PaSmpsAptPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021053", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc11PaSmpsAptRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021064", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc14PaSmpsAptNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021065", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc14PaSmpsAptPdm0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021066", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc14PaSmpsAptPdm1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021067", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc14PaSmpsAptPdm2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021068", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc14PaSmpsAptPdm3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021069", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc14PaSmpsAptPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021070", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc14PaSmpsAptPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021071", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc14PaSmpsAptPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021072", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc14PaSmpsAptPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021063", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc14PaSmpsAptRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020522", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc15PaSmpsAptNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020523", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc15PaSmpsAptPdm0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020524", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc15PaSmpsAptPdm1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020525", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc15PaSmpsAptPdm2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020526", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc15PaSmpsAptPdm3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020527", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc15PaSmpsAptPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020528", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc15PaSmpsAptPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020529", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc15PaSmpsAptPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020530", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc15PaSmpsAptPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020521", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc15PaSmpsAptRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020512", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc1PaSmpsAptNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020513", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc1PaSmpsAptPdm0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020514", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc1PaSmpsAptPdm1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020515", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc1PaSmpsAptPdm2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020516", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc1PaSmpsAptPdm3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020517", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc1PaSmpsAptPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020518", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc1PaSmpsAptPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020519", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc1PaSmpsAptPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020520", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc1PaSmpsAptPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020511", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc1PaSmpsAptRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021024", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc3PaSmpsAptNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021025", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc3PaSmpsAptPdm0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021026", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc3PaSmpsAptPdm1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021027", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc3PaSmpsAptPdm2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021028", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc3PaSmpsAptPdm3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021029", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc3PaSmpsAptPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021030", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc3PaSmpsAptPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021031", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc3PaSmpsAptPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021032", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc3PaSmpsAptPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021023", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc3PaSmpsAptRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021034", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc4PaSmpsAptNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021035", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc4PaSmpsAptPdm0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021036", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc4PaSmpsAptPdm1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021037", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc4PaSmpsAptPdm2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021038", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc4PaSmpsAptPdm3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021039", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc4PaSmpsAptPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021040", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc4PaSmpsAptPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021041", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc4PaSmpsAptPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021042", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc4PaSmpsAptPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021033", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc4PaSmpsAptRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021044", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc5PaSmpsAptNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021045", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc5PaSmpsAptPdm0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021046", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc5PaSmpsAptPdm1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021047", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc5PaSmpsAptPdm2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021048", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc5PaSmpsAptPdm3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021049", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc5PaSmpsAptPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021050", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc5PaSmpsAptPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021051", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc5PaSmpsAptPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021052", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc5PaSmpsAptPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021043", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc5PaSmpsAptRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020686", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc6ExpLpmHdetVsAgcV2 : SeventeenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020687", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc6LpmHdetOffV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020688", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc6LpmHdetSpnV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020448", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc6PaSmpsAptNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020449", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc6PaSmpsAptPdm0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020450", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc6PaSmpsAptPdm1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020451", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc6PaSmpsAptPdm2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020452", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc6PaSmpsAptPdm3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020453", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc6PaSmpsAptPout0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020454", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc6PaSmpsAptPout1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020455", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc6PaSmpsAptPout2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020456", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaBc6PaSmpsAptPout3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020447", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc6PaSmpsAptRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023751", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC01xSpurTable : ItemBase
    {
        [FieldOffset(0)]
        [FieldCount(30)]
        public QmslRxSpurTableNvType[] SpurInfo
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022762", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc01xRxSwitchpoints : ItemBase
    {
        [FieldOffset(0)]
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022766", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc01xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022768", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc01xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022767", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc01xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022763", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022765", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022764", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024787", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022769", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022770", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022771", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022772", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023727", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024142", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025507", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022933", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023849", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024771", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc0TxHdetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024755", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc0TxHdetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024739", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025585", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025593", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023196", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022941", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0TxMultiLinData : ItemBase
    {
        [FieldOffset(0)]
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023877", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0TxMultiLinV2Data : ItemBase
    {
        [FieldOffset(0)]
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024210", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0TxMultiLinV3Data : ItemBase
    {
        [FieldOffset(0)]
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023212", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc0TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022837", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc101xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022841", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc101xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022843", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc101xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022842", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc101xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022838", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022840", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022839", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024792", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10HdetModRange : ItemBase
    {
        [FieldOffset(0)]
        [FieldCount(8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [FieldOffset(1)]
        [FieldCount(8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022844", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022845", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022846", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022847", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023732", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024147", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025512", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10TxEtDelay : ItemBase
    {
        [FieldOffset(0)]
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022938", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023854", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024776", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc10TxHdetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024760", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc10TxHdetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024744", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025590", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025598", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023201", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022946", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023882", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024215", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023217", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc10TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022777", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc11xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022781", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc11xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022783", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc11xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022782", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc11xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022852", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc141xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022856", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc141xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022858", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc141xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022857", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc141xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022853", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022855", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022854", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024793", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022859", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022860", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022861", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022862", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023733", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024148", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025513", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022939", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023855", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024777", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc14TxHdetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024761", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc14TxHdetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024745", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025591", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025599", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023202", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022947", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023883", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024216", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023218", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc14TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022867", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc151xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022871", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc151xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022873", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc151xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022872", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc151xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022868", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022870", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022869", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024794", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022874", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022875", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022876", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022877", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023734", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024149", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025514", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022940", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023856", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024778", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc15TxHdetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024762", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc15TxHdetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024746", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025592", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025600", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023203", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022948", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023884", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024217", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023219", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc15TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022778", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022780", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022779", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024788", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022784", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022785", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022786", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022787", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023728", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024143", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025508", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022934", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023850", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024772", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc1TxHdetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024756", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc1TxHdetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024740", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025586", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025594", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023197", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022942", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023878", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024211", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023213", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc1TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022792", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc41xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022796", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc41xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022798", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc41xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022797", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc41xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022793", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022795", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022794", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024789", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022799", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022800", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022801", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022802", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023729", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024144", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025509", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022935", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023851", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024773", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc4TxHdetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024757", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc4TxHdetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024741", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025587", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025595", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023198", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022943", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023879", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024212", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023214", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc4TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022807", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc51xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022811", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc51xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022813", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc51xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022812", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc51xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022808", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022810", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022809", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024790", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022814", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022815", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022816", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022817", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023730", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024145", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025510", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022936", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023852", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024774", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc5TxHdetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024758", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc5TxHdetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024742", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025588", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025596", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023199", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022944", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023880", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024213", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023215", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc5TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022822", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc61xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022826", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc61xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022828", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc61xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022827", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc61xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022823", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022825", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022824", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024791", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022829", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022830", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022831", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022832", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023731", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024146", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025511", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022937", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023853", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024775", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc6TxHdetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024759", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc6TxHdetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024743", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025589", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025597", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023200", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022945", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023881", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024214", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023216", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0Bc6TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023755", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC0HdrSpurTable : ItemBase
    {
        [FieldCount(30)]
        public QmslRxSpurTableNvType[] SpurInfo
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023752", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC11xSpurTable : ItemBase
    {
        [FieldCount(30)]
        public QmslRxSpurTableNvType[] SpurInfo
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022773", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc01xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022774", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc0Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022776", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc0DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022775", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc0DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022848", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc101xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022849", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc10Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022851", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc10DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022850", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc10DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022788", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc11xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022863", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc141xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022864", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc14Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022866", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc14DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022865", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc14DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022878", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc151xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022879", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc15Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022881", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc15DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022880", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc15DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022789", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc1Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022791", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc1DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022790", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc1DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022803", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc41xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022804", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc4Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022806", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc4DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022805", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc4DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022818", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc51xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022819", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc5Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022821", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc5DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022820", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc5DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022833", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc61xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022834", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc6Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022836", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc6DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022835", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1Bc6DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023756", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC1HdrSpurTable : ItemBase
    {
        [FieldCount(30)]
        public QmslRxSpurTableNvType[] SpurInfo
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023753", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC21xSpurTable : ItemBase
    {
        [FieldCount(30)]
        public QmslRxSpurTableNvType[] SpurInfo
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021743", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc01xEncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021723", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc01xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021745", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc01xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021747", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc01xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021746", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc01xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023398", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023400", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023399", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021770", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024795", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021771", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0HdetOffV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021772", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0HdetSpnV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023422", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023423", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023424", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023425", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023735", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021744", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021762", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0TxApt0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021763", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0TxApt1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021764", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0TxApt2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021765", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0TxApt3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024150", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025515", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023743", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023857", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024779", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0TxHdetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024763", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0TxHdetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021773", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021748", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024747", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021754", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxLin0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021755", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxLin1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021756", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxLin2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021757", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxLin3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025601", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025609", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023204", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022949", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023885", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024218", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021758", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxPdm0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021759", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxPdm1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021760", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxPdm2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021761", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxPdm3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021766", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0TxPwrFreqComp0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021767", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0TxPwrFreqComp1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021768", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0TxPwrFreqComp2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021769", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0TxPwrFreqComp3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023220", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc0TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021998", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc101xEncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021978", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc101xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022000", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc101xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022002", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc101xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022001", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc101xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023413", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023415", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023414", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022025", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024800", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022026", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10HdetOffV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022027", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10HdetSpnV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023442", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023443", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023444", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023445", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023740", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021999", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022017", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10TxApt0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022018", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10TxApt1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022019", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10TxApt2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022020", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10TxApt3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024155", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025520", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023748", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023862", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024784", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10TxHdetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024768", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10TxHdetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022028", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022003", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024752", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022009", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxLin0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022010", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxLin1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022011", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxLin2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022012", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxLin3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025606", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025614", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023209", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022954", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023890", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024223", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022013", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxPdm0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022014", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxPdm1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022015", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxPdm2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022016", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxPdm3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022021", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10TxPwrFreqComp0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022022", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10TxPwrFreqComp1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022023", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10TxPwrFreqComp2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022024", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10TxPwrFreqComp3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023225", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc10TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021794", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc11xEncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021774", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc11xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021796", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc11xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021798", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc11xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021797", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc11xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022049", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc141xEncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022029", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc141xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022051", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc141xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022053", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc141xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022052", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc141xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023416", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023418", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023417", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022076", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024801", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022077", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14HdetOffV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022078", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14HdetSpnV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023446", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023447", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023448", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023449", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023741", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022050", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022068", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14TxApt0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022069", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14TxApt1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022070", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14TxApt2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022071", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14TxApt3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024156", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025521", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023749", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023863", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024785", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14TxHdetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024769", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14TxHdetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022079", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022054", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024753", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022060", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxLin0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022061", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxLin1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022062", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxLin2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022063", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxLin3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025607", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025615", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023210", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022955", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023891", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024224", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022064", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxPdm0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022065", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxPdm1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022066", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxPdm2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022067", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxPdm3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022072", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14TxPwrFreqComp0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022073", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14TxPwrFreqComp1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022074", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14TxPwrFreqComp2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022075", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14TxPwrFreqComp3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023226", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc14TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022100", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc151xEncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022080", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc151xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022102", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc151xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022104", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc151xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022103", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc151xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023419", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023421", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023420", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022127", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc15ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024802", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022128", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15HdetOffV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022129", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15HdetSpnV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023450", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023451", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023452", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023453", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023742", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022101", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022119", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc15TxApt0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022120", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc15TxApt1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022121", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc15TxApt2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022122", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc15TxApt3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024157", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025522", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023750", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023864", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024786", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc15TxHdetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024770", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc15TxHdetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022130", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc15TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022105", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc15TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024754", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022111", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxLin0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022112", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxLin1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022113", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxLin2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022114", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxLin3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025608", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025616", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023211", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022956", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023892", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024225", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022115", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxPdm0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022116", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxPdm1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022117", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxPdm2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022118", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxPdm3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022123", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc15TxPwrFreqComp0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022124", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc15TxPwrFreqComp1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022125", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc15TxPwrFreqComp2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022126", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc15TxPwrFreqComp3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023227", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc15TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023401", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023403", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023402", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021821", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024796", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021822", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1HdetOffV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021823", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1HdetSpnV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023426", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023427", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023428", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023429", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023736", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021795", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021813", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxApt0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021814", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxApt1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021815", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxApt2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021816", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxApt3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024151", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025516", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023744", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023858", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024780", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxHdetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024764", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxHdetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021824", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021799", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024748", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021805", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxLin0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021806", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxLin1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021807", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxLin2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021808", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxLin3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025602", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025610", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023205", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022950", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023886", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024219", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021809", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxPdm0: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021810", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxPdm1: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021811", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxPdm2: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021812", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxPdm3: SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021817", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxPwrFreqComp0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021818", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxPwrFreqComp1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021819", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxPwrFreqComp2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021820", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxPwrFreqComp3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023221", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc1TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021845", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc41xEncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021825", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc41xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021847", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc41xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021849", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc41xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021848", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc41xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023404", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023406", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023405", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021872", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024797", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset { get; set; }

        [FieldCount(8)]
        public short[] UpperBoundOffset { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021873", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4HdetOffV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021874", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4HdetSpnV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023430", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023431", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023432", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023433", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023737", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021846", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021864", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxApt0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021865", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxApt1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021866", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxApt2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021867", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxApt3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024152", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxEptDpdConfigParams : ItemBase
    {
        private TxXptDpdConfigParamsDataType _xptCfgParams = new TxXptDpdConfigParamsDataType();
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025517", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023745", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023859", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024781", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxHdetVsFreq : ItemBase
    {
        [FieldCount(16)]
        public sbyte[] HdetVsFreq { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024765", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxHdetVsTemp : ItemBase
    {
        [FieldCount(8)]
        public sbyte[] HdetVsTemp { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021875", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021850", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024749", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021856", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021857", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021858", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021859", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025603", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025611", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023206", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022951", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023887", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024220", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021860", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021861", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021862", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021863", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021868", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxPwrFreqComp0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021869", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxPwrFreqComp1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021870", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxPwrFreqComp2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021871", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxPwrFreqComp3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023222", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc4TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa0PowerSlope { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa1PowerSlope { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa2PowerSlope { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa3PowerSlope { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021896", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc51xEncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021876", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc51xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021898", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc51xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021900", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc51xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021899", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc51xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023407", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023409", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023408", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021923", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024798", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset { get; set; }

        [FieldCount(8)]
        public short[] UpperBoundOffset { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021924", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5HdetOffV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021925", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5HdetSpnV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023434", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023435", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023436", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023437", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023738", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021897", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021915", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxApt0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021916", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxApt1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021917", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxApt2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021918", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxApt3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024153", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025518", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023746", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023860", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024782", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxHdetVsFreq : ItemBase
    {
        [FieldCount(16)]
        public sbyte[] HdetVsFreq { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024766", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxHdetVsTemp : ItemBase
    {
        [FieldCount(8)]
        public sbyte[] HdetVsTemp { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021926", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021901", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024750", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021907", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021908", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021909", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021910", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025604", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025612", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023207", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022952", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023888", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024221", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021911", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021912", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021913", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021914", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021919", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxPwrFreqComp0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021920", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxPwrFreqComp1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021921", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxPwrFreqComp2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021922", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxPwrFreqComp3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023223", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc5TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa0PowerSlope { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa1PowerSlope { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa2PowerSlope { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa3PowerSlope { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021947", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc61xEncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021927", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc61xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021949", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc61xTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021951", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc61xTxDataSwitchpoints : ItemBase
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021950", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc61xTxVoiceSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023410", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023412", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023411", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021974", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024799", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6HdetModRange : ItemBase
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset { get; set; }

        [FieldCount(8)]
        public short[] UpperBoundOffset { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021975", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6HdetOffV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021976", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6HdetSpnV2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023438", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6HdrTxAccessSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023439", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6HdrTxDor0Switchpoints : ItemBase
    {
        public short Rri0G1G0Fall { get; set; }


        public short Rri0G0G1Rise { get; set; }


        public short Rri0G2G1Fall { get; set; }


        public short Rri0G1G2Rise { get; set; }


        public short Rri0G3G2Fall { get; set; }


        public short Rri0G2G3Rise { get; set; }


        public short Rri0FallTimeHyst { get; set; }


        public short Rri1G1G0Fall { get; set; }


        public short Rri1G0G1Rise { get; set; }


        public short Rri1G2G1Fall { get; set; }


        public short Rri1G1G2Rise { get; set; }


        public short Rri1G3G2Fall { get; set; }


        public short Rri1G2G3Rise { get; set; }


        public short Rri1FallTimeHyst { get; set; }


        public short Rri2G1G0Fall { get; set; }


        public short Rri2G0G1Rise { get; set; }


        public short Rri2G2G1Fall { get; set; }


        public short Rri2G1G2Rise { get; set; }


        public short Rri2G3G2Fall { get; set; }


        public short Rri2G2G3Rise { get; set; }


        public short Rri2FallTimeHyst { get; set; }


        public short Rri3G1G0Fall { get; set; }


        public short Rri3G0G1Rise { get; set; }


        public short Rri3G2G1Fall { get; set; }


        public short Rri3G1G2Rise { get; set; }


        public short Rri3G3G2Fall { get; set; }


        public short Rri3G2G3Rise { get; set; }


        public short Rri3FallTimeHyst { get; set; }


        public short Rri4G1G0Fall { get; set; }


        public short Rri4G0G1Rise { get; set; }


        public short Rri4G2G1Fall { get; set; }


        public short Rri4G1G2Rise { get; set; }


        public short Rri4G3G2Fall { get; set; }


        public short Rri4G2G3Rise { get; set; }


        public short Rri4FallTimeHyst { get; set; }


        public short Rri5G1G0Fall { get; set; }


        public short Rri5G0G1Rise { get; set; }


        public short Rri5G2G1Fall { get; set; }


        public short Rri5G1G2Rise { get; set; }


        public short Rri5G3G2Fall { get; set; }


        public short Rri5G2G3Rise { get; set; }


        public short Rri5FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023440", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6HdrTxDoraSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023441", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6HdrTxDorbMcSwitchpoints : ItemBase
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023739", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6HdrTxPwrLimData : ItemBase
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021948", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021966", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxApt0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021967", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxApt1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021968", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxApt2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021969", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxApt3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024154", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxEptDpdConfigParams : ItemBase
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025519", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxEtDelay : ItemBase
    {
        public int Delay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023747", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxExpLpmHdet : ItemBase
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023861", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024783", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxHdetVsFreq : ItemBase
    {
        [FieldCount(16)]
        public sbyte[] HdetVsFreq { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024767", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxHdetVsTemp : ItemBase
    {
        [FieldCount(8)]
        public sbyte[] HdetVsTemp { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021977", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021952", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024751", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxLimVsTempVsFreq : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021958", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021959", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021960", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021961", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025605", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025613", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023208", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxMultiLinAptAdj : ItemBase
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022953", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023889", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024222", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021962", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021963", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021964", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021965", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021970", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxPwrFreqComp0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021971", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxPwrFreqComp1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021972", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxPwrFreqComp2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021973", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxPwrFreqComp3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023224", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2Bc6TxPwrTempComp : ItemBase
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa0PowerSlope { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa1PowerSlope { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa2PowerSlope { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa3PowerSlope { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023757", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC2HdrSpurTable : ItemBase
    {
        [FieldCount(30)]
        public QmslRxSpurTableNvType[] SpurInfo { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023754", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC31xSpurTable : ItemBase
    {
        [FieldCount(30)]
        public QmslRxSpurTableNvType[] SpurInfo { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023474", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3B14DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023477", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3B15DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023245", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc01xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023454", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc0Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023456", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc0DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023455", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc0DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023330", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc101xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023469", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc10Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023471", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc10DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023470", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc10DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023262", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc11xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023347", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc141xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023472", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc14Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023473", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc14DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023364", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc151xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023475", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc15Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023476", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc15DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023457", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc1Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023459", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc1DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023458", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc1DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023279", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc41xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023460", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc4Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023462", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc4DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023461", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc4DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023296", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc51xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023463", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc5Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023465", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc5DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023464", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc5DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023313", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc61xRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023466", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc6Dor0ARxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023468", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc6DorbMcRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023467", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3Bc6DorbScRxSwitchpoints : ItemBase
    {
        public byte Ic0Active { get; set; }


        public byte Ic0Swpt1Type { get; set; }


        public short Ic0Swpt1FallOrHyst { get; set; }


        public short Ic0Swpt1RiseOrBackoff { get; set; }


        public short Ic0Swpt1FallHold { get; set; }


        public short Ic0Swpt1RiseHold { get; set; }


        public byte Ic0Swpt2Type { get; set; }


        public short Ic0Swpt2FallOrHyst { get; set; }


        public short Ic0Swpt2RiseOrBackoff { get; set; }


        public short Ic0Swpt2FallHold { get; set; }


        public short Ic0Swpt2RiseHold { get; set; }


        public byte Ic0Swpt3Type { get; set; }


        public short Ic0Swpt3FallOrHyst { get; set; }


        public short Ic0Swpt3RiseOrBackoff { get; set; }


        public short Ic0Swpt3FallHold { get; set; }


        public short Ic0Swpt3RiseHold { get; set; }


        public byte Ic0Swpt4Type { get; set; }


        public short Ic0Swpt4FallOrHyst { get; set; }


        public short Ic0Swpt4RiseOrBackoff { get; set; }


        public short Ic0Swpt4FallHold { get; set; }


        public short Ic0Swpt4RiseHold { get; set; }


        public byte Ic1Active { get; set; }


        public byte Ic1Swpt1Type { get; set; }


        public short Ic1Swpt1FallOrHyst { get; set; }


        public short Ic1Swpt1RiseOrBackoff { get; set; }


        public short Ic1Swpt1FallHold { get; set; }


        public short Ic1Swpt1RiseHold { get; set; }


        public byte Ic1Swpt2Type { get; set; }


        public short Ic1Swpt2FallOrHyst { get; set; }


        public short Ic1Swpt2RiseOrBackoff { get; set; }


        public short Ic1Swpt2FallHold { get; set; }


        public short Ic1Swpt2RiseHold { get; set; }


        public byte Ic1Swpt3Type { get; set; }


        public short Ic1Swpt3FallOrHyst { get; set; }


        public short Ic1Swpt3RiseOrBackoff { get; set; }


        public short Ic1Swpt3FallHold { get; set; }


        public short Ic1Swpt3RiseHold { get; set; }


        public byte Ic1Swpt4Type { get; set; }


        public short Ic1Swpt4FallOrHyst { get; set; }


        public short Ic1Swpt4RiseOrBackoff { get; set; }


        public short Ic1Swpt4FallHold { get; set; }


        public short Ic1Swpt4RiseHold { get; set; }


        public byte Ic2Active { get; set; }


        public byte Ic2Swpt1Type { get; set; }


        public short Ic2Swpt1FallOrHyst { get; set; }


        public short Ic2Swpt1RiseOrBackoff { get; set; }


        public short Ic2Swpt1FallHold { get; set; }


        public short Ic2Swpt1RiseHold { get; set; }


        public byte Ic2Swpt2Type { get; set; }


        public short Ic2Swpt2FallOrHyst { get; set; }


        public short Ic2Swpt2RiseOrBackoff { get; set; }


        public short Ic2Swpt2FallHold { get; set; }


        public short Ic2Swpt2RiseHold { get; set; }


        public byte Ic2Swpt3Type { get; set; }


        public short Ic2Swpt3FallOrHyst { get; set; }


        public short Ic2Swpt3RiseOrBackoff { get; set; }


        public short Ic2Swpt3FallHold { get; set; }


        public short Ic2Swpt3RiseHold { get; set; }


        public byte Ic2Swpt4Type { get; set; }


        public short Ic2Swpt4FallOrHyst { get; set; }


        public short Ic2Swpt4RiseOrBackoff { get; set; }


        public short Ic2Swpt4FallHold { get; set; }


        public short Ic2Swpt4RiseHold { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023758", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaC3HdrSpurTable : ItemBase
    {
        [FieldCount(30)]
        public QmslRxSpurTableNvType[] SpurInfo { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021306", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CdmaPaSmpsOdriveDelay: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020713", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CellAptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020712", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CellAptCharTblPaRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020714", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CellAptCharTblPout0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020715", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CellAptCharTblPout1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020716", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CellAptCharTblPout2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020717", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CellAptCharTblPout3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020718", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CellAptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020719", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CellAptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020720", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CellAptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020721", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CellAptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020711", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CellAptCharTblTypeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/tdscdma/rrc/ciphering_enabled", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CipheringEnabled : ByteItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/therm_monitor/config_test.ini", false, 0x81FF)]
    [Attributes(9)]
   public sealed class ConfigTestIn : ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/modem/lte/rrc/cep/conn_control_barring_optmz_enable", false, 0x81FF)]
    [Attributes(9)]
   public sealed class ConnControlBarringOptmzEnable : ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/modem/lte/rrc/cep/conn_control_param_cfg", false, 0x81FF)]
    [Attributes(9)]
   public sealed class ConnControlParamCfg : ItemBase
    {
    }

    [Serializable]
    [Subscription]
    [EfsFile("/policyman/current_mcc", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CurrentMcc
 : UInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/custom_emerg_info", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class CustomEmergInfo : ItemBase
    {
        [Required]
        public byte Version { get; set; }


        public byte IsEcbmRequired { get; set; }


        public byte HoldConcurrentVoiceCallDuringEmergency { get; set; }


        public byte IsAlternateRedialAlgorithm { get; set; }


        public ulong Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/hdr/cp/ovhd/d2lresel", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class D2lresel : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/data/default_andsf.xml", false, 0x81B6)]
    [Attributes(9)]
    public sealed class DefaultAndsfXml : MultiLineStringsItemBase
    {
    }

    [Serializable]
    [EfsFile("/policyman/device_config.xml", false, 0x81FF)]
    [Attributes(9)]
    public sealed class DeviceConfigXml : MultiLineStringsItemBase
    {
    }

    [Serializable]
    [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/device_mode", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class DeviceMode : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/lte/rrc/cap/diff_fdd_tdd_fgi_enable", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class DiffFddTddFgiEnable : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/lte/rrc/cap/disable_cap_ies", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class DisableCapIes : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023786", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class DivWcdma1800LnaRangeOffset2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023787", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class DivWcdma1800LnaRangeOffset3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023788", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class DivWcdma1800LnaRangeOffset4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023789", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class DivWcdma1800LnaRangeOffset5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023785", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class DivWcdma1800LnaRangeOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023783", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class DivWcdma1800RxfIciCalDataCar0 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023784", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class DivWcdma1800RxfIciCalDataCar1 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023790", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class DivWcdma1800VgaGainOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024125", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class DoInternalDeviceCal : ItemBase
    {
        public TxIntDevCalNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp/ds_3gpp_mtu", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Ds3gppMtu: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/data/1x/707/ds707_ehrpd_mtu", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Ds707EhrpdMtu: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/data/ds_andsf_config.txt", false, 0x81B6)]
    [Attributes(9)]
    public sealed class DsAndsfConfigTxt : MultiLineStringsItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/data/dsd/ds_apn_switching", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class DsApnSwitching : ByteItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/data/ds_dsd_apm_rules.txt", false, 0x81B6)]
    [Attributes(9)]
   public sealed class DsDsdApmRulesTxt : ItemBase
    {
    }

    [Serializable]
    [Subscription]
    [EfsFile("/data/ds_dsd_attach_profile.txt", false, 0x81B6)]
    [Attributes(9)]
    public sealed class DsDsdAttachProfileTxt : WindowsMultiLineStringsItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/data/ds_eps_kamgr_pdn.txt", false, 0x8186)]
    [Attributes(9)]
   public sealed class DsEpsKamgrPdnTxt : ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp2/ds_ppp_ctl_packet_on_dos", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class DsPppCtlPacketOnDos : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/data/dynamic_port_cfg", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class DynamicPortCfg : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021330", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Edge1800SmpsPdmTbl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021331", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Edge1900SmpsPdmTbl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021328", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Edge850SmpsPdmTbl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021329", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Edge900SmpsPdmTbl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/nas/ehplmn", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Ehplmn : SixtyOneByteItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/modem/hdr/cp/scp/ehrpdnetworksetting", false, 0x81FF)]
    [Attributes(9)]
   public sealed class Ehrpdnetworksetting : ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp2/ehrpd_partial_context", false, 0x81FF)]
    [Attributes(9)]
   public sealed class EhrpdPartialContext : ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp2/ehrpd_to_hrpd_fallback", false, 0x81FF)]
    [Attributes(9)]
   public sealed class EhrpdToHrpdFallback : ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/pdp_profiles/embedded_call_prof_num", false, 0x81FF)]
    [Attributes(9)]
   public sealed class EmbeddedCallProfNum : ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/pdp_profiles/embedded_call_prof_nums", false, 0x81FF)]
    [Attributes(9)]
   public sealed class EmbeddedCallProfNums : ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/nas/emm_nas_nv_items", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class EmmNasNvItems : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020787", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class EtModeEnable : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/nas/exclude_ptmsi_type_field", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ExcludePtmsiTypeField : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/tdscdma/rrc/fake_sec_enabled", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class FakeSecEnabled : ByteItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/modem/uim/gstk/feature_bmsk", false, 0x81FF)]
    [Attributes(9)]
   public sealed class FeatureBmsk : ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [NvItemId(73763)]
    [Subscription]
    [EfsFile("/nv/item_files/modem/uim/mmgsdi/features_status_list", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class FeaturesStatusList : ItemBase
    {
        [Required]
        public byte Version { get; set; }

        [FieldCount(63)]
        public byte[] Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/nas/forced_irat", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ForcedIrat : ByteItemBase
    {
    }

    [Serializable]
    [Subscription]
    [EfsFile("/policyman/freq_list", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class FreqList
 : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp2/full_jcdma_feature", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class FullJcdmaFeature : ByteItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/modem/geran/grr/g2l_blind_redir_after_csfb_control", false, 0x81FF)]
    [Attributes(9)]
   public sealed class G2lBlindRedirAfterCsfbControl : ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/get_net_auto_mode", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GetNetAutoMode : ItemBase
    {
        [Required]
        public byte Version { get; set; }


        public ushort Value { get; set; }


        public ushort Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/gps/cgps/sm/gnss_1x_up_supl_enable", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gnss1xUpSuplEnable : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/gps/cgps/sm/gnss_agps_rat_pref_config", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GnssAgpsRatPrefConfig : ItemBase
    {
        public byte Field1 { get; set; }


        public ushort Field2 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/gps/cgps/sm/gnss_lpp_enable", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GnssLppEnable : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/gps/cgps/sm/gnss_nv_efs_sm_e911_config", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GnssNvEfsSmE911Config : UInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/lte/rrc/irat/gsm", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm : UInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024196", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800CharPredistEnvGain : SixtyFourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022897", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800ColdTempCompPclPwrOffset8psk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022896", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800ColdTempCompPclPwrOffsetGsmk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024604", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800EdgeEnhTempComp : ItemBase
    {
        public GsmEnhtempcompTempType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020910", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800EdgePaRangeUltraLoToLo: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022908", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800EnvGainF1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022909", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800EnvGainF2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022910", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800EnvGainF3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024600", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800GmskEnhTempComp : ItemBase
    {
        public GsmEnhtempcompTempType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022895", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800HotTempCompPclPwrOffset8psk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022894", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800HotTempCompPclPwrOffsetGsmk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020904", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800PaRangeR1ToR2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020905", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800PaRangeR2ToR3: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020906", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800PaRangeR3ToR4: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021541", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800SarBackOffLimitSlot1 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021542", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800SarBackOffLimitSlot2 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021543", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800SarBackOffLimitSlot3 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021544", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800SarBackOffLimitSlot4 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021545", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800SarBackOffLimitSlot5 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021334", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800SmpsPdmCal: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024192", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800SmpsPdmPerPaRangeTbl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023874", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1800TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024197", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900CharPredistEnvGain : SixtyFourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022893", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900ColdTempCompPclPwrOffset8psk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022892", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900ColdTempCompPclPwrOffsetGsmk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024605", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900EdgeEnhTempComp : ItemBase
    {
        public GsmEnhtempcompTempType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020911", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900EdgePaRangeUltraLoToLo: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022905", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900EnvGainF1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022906", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900EnvGainF2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022907", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900EnvGainF3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024601", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900GmskEnhTempComp : ItemBase
    {
        public GsmEnhtempcompTempType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022891", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900HotTempCompPclPwrOffset8psk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022890", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900HotTempCompPclPwrOffsetGsmk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020907", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900PaRangeR1ToR2: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020908", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900PaRangeR2ToR3: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020909", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900PaRangeR3ToR4: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021546", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900SarBackOffLimitSlot1 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021547", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900SarBackOffLimitSlot2 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021548", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900SarBackOffLimitSlot3 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021549", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900SarBackOffLimitSlot4 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021550", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900SarBackOffLimitSlot5 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021335", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900SmpsPdmCal: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024193", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900SmpsPdmPerPaRangeTbl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023875", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm1900TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/mcs/lmtsmgr/coex/blank/gsm1_victim_gsm2_aggr", false, 0x81FF)]
    [Attributes(9)]
   public sealed class Gsm1VictimGsm2Aggr : ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/mcs/lmtsmgr/coex/blank/gsm2_victim_gsm1_aggr", false, 0x81FF)]
    [Attributes(9)]
   public sealed class Gsm2VictimGsm1Aggr : ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024194", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850CharPredistEnvGain : SixtyFourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022889", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850ColdTempCompPclPwrOffset8psk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022888", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850ColdTempCompPclPwrOffsetGsmk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024602", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850EdgeEnhTempComp : ItemBase
    {
        public GsmEnhtempcompTempType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022902", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850EnvGainF1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022903", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850EnvGainF2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022904", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850EnvGainF3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024598", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850GmskEnhTempComp : ItemBase
    {
        public GsmEnhtempcompTempType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022887", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850HotTempCompPclPwrOffset8psk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022886", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850HotTempCompPclPwrOffsetGsmk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021531", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850SarBackOffLimitSlot1 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021532", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850SarBackOffLimitSlot2 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021533", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850SarBackOffLimitSlot3 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021534", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850SarBackOffLimitSlot4 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021535", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850SarBackOffLimitSlot5 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021332", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850SmpsPdmCal: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024190", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850SmpsPdmPerPaRangeTbl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023873", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm850TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024195", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900CharPredistEnvGain : SixtyFourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022885", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900ColdTempCompPclPwrOffset8psk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022884", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900ColdTempCompPclPwrOffsetGsmk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024603", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900EdgeEnhTempComp : ItemBase
    {
        public GsmEnhtempcompTempType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022899", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900EnvGainF1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022900", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900EnvGainF2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022901", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900EnvGainF3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024599", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900GmskEnhTempComp : ItemBase
    {
        public GsmEnhtempcompTempType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022883", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900HotTempCompPclPwrOffset8psk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022882", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900HotTempCompPclPwrOffsetGsmk : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021536", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900SarBackOffLimitSlot1 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021537", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900SarBackOffLimitSlot2 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021538", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900SarBackOffLimitSlot3 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021539", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900SarBackOffLimitSlot4 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021540", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900SarBackOffLimitSlot5 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021333", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900SmpsPdmCal: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024191", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900SmpsPdmPerPaRangeTbl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023872", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Gsm900TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025038", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800AmamTempComp : ItemBase
    {
        [FieldCount(16)]
        public sbyte[] AmamTempComp { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025578", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800EnhApt : ItemBase
    {
        public GsmTxEnhAptDataType EnhAptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025110", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800EnhTempComp : ItemBase
    {
        [FieldCount(256)]
        public short[] TempcompTable { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025006", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800EnvGain : ItemBase
    {
        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF1 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF2 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF3 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025014", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800KvCal : ItemBase
    {
        public uint KvCalValue { get; set; }


        public ushort KvCalLowChan { get; set; }


        public ushort KvCalHighChan { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025054", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800LinearTxGainParam : ItemBase
    {
        public GsmTxLinearTxGainParamDataType TxGainParam { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024998", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800LnaSwpt : ItemBase
    {
        public GsmRxLnaSwptType GsmRxLnaSwpt { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025062", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800MultislotMaxTxPwr : ItemBase
    {
        [FieldCount(5)]
        public short[] GsmMultislotTxPwrGmsk { get; set; }

        [FieldCount(5)]
        public short[] GsmMultislotTxPwr8psk { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025428", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800PaRangeMap : ItemBase
    {
        public byte PaRangeMap { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024990", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800PaSwpt : ItemBase
    {
        public GsmTxPaSwptDataType GsmPaSwptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025070", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800PolarPathDelay : ItemBase
    {
        public short PolarPathDelay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025118", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800PolarRampProfile : ItemBase
    {
        public GsmTxPolarRampProfileDataType PolarParampLut { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025078", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800PowerLevels : ItemBase
    {
        [FieldCount(16)]
        public short[] GsmPowerLevels { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024966", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800RxCalData : ItemBase
    {
        public byte RxCalChanSize { get; set; }

        [FieldCount(16)]
        public short[] RxCalChanList { get; set; }

        [FieldCount(4)]
        public GsmRxFreqCompDataType[] RxFreqCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025030", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800SarBackoff : ItemBase
    {
        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot1 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot2 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot3 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot4 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot5 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025086", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800SmpsPdmTbl : ItemBase
    {
        public GsmTxSmpsPdmDataType SmpsPdmData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025046", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800TempComp : ItemBase
    {
        public GsmTxTempCompDataType TempCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024974", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800TxCalData : ItemBase
    {
        public byte TxCalChanSize { get; set; }

        [FieldCount(3)]
        public ushort[] TxCalChan { get; set; }


        public short AmamMaxDbm { get; set; }


        public byte RgiForPred { get; set; }


        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025102", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800TxGtrThresh : ItemBase
    {
        public GsmTxGtrThreshDataType GtrThresh { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025094", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800TxRxAntTuner : ItemBase
    {
        public RfcommonAntTunerDataType AntTunerRx { get; set; }


        public RfcommonAntTunerDataType AntTunerTx { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024982", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800TxTiming : ItemBase
    {
        public GsmTxTimingDataType GsmTxTimingData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025022", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1800Vbatt : ItemBase
    {
        [FieldCount(3)]
        public ushort[] VbattLevels { get; set; }


        public GsmTxVbattCompDataType VbattCompValueLo { get; set; }


        public GsmTxVbattCompDataType VbattCompValueHi { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025039", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900AmamTempComp : ItemBase
    {
        [FieldCount(16)]
        public sbyte[] AmamTempComp { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025579", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900EnhApt : ItemBase
    {
        public GsmTxEnhAptDataType EnhAptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025111", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900EnhTempComp : ItemBase
    {
        [FieldCount(256)]
        public short[] TempcompTable { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025007", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900EnvGain : ItemBase
    {
        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF1 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF2 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF3 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025015", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900KvCal : ItemBase
    {
        public uint KvCalValue { get; set; }


        public ushort KvCalLowChan { get; set; }


        public ushort KvCalHighChan { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025055", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900LinearTxGainParam : ItemBase
    {
        public GsmTxLinearTxGainParamDataType TxGainParam { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024999", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900LnaSwpt : ItemBase
    {
        public GsmRxLnaSwptType GsmRxLnaSwpt { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025063", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900MultislotMaxTxPwr : ItemBase
    {
        [FieldCount(5)]
        public short[] GsmMultislotTxPwrGmsk { get; set; }

        [FieldCount(5)]
        public short[] GsmMultislotTxPwr8psk { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025429", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900PaRangeMap : ItemBase
    {
        public byte PaRangeMap { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024991", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900PaSwpt : ItemBase
    {
        public GsmTxPaSwptDataType GsmPaSwptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025071", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900PolarPathDelay : ItemBase
    {
        public short PolarPathDelay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025119", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900PolarRampProfile : ItemBase
    {
        public GsmTxPolarRampProfileDataType PolarParampLut { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025079", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900PowerLevels : ItemBase
    {
        [FieldCount(16)]
        public short[] GsmPowerLevels { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024967", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900RxCalData : ItemBase
    {
        public byte RxCalChanSize { get; set; }

        [FieldCount(16)]
        public short[] RxCalChanList { get; set; }

        [FieldCount(4)]
        public GsmRxFreqCompDataType[] RxFreqCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025031", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900SarBackoff : ItemBase
    {
        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot1 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot2 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot3 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot4 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot5 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025087", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900SmpsPdmTbl : ItemBase
    {
        public GsmTxSmpsPdmDataType SmpsPdmData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025047", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900TempComp : ItemBase
    {
        public GsmTxTempCompDataType TempCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024975", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900TxCalData : ItemBase
    {
        public byte TxCalChanSize { get; set; }

        [FieldCount(3)]
        public ushort[] TxCalChan { get; set; }


        public short AmamMaxDbm { get; set; }


        public byte RgiForPred { get; set; }


        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025103", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900TxGtrThresh : ItemBase
    {
        public GsmTxGtrThreshDataType GtrThresh { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025095", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900TxRxAntTuner : ItemBase
    {
        public RfcommonAntTunerDataType AntTunerRx { get; set; }


        public RfcommonAntTunerDataType AntTunerTx { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024983", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900TxTiming : ItemBase
    {
        public GsmTxTimingDataType GsmTxTimingData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025023", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm1900Vbatt : ItemBase
    {
        [FieldCount(3)]
        public ushort[] VbattLevels { get; set; }


        public GsmTxVbattCompDataType VbattCompValueLo { get; set; }


        public GsmTxVbattCompDataType VbattCompValueHi { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025036", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850AmamTempComp : ItemBase
    {
        [FieldCount(16)]
        public sbyte[] AmamTempComp { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025576", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850EnhApt : ItemBase
    {
        public GsmTxEnhAptDataType EnhAptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025108", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850EnhTempComp : ItemBase
    {
        [FieldCount(256)]
        public short[] TempcompTable { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025004", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850EnvGain : ItemBase
    {
        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF1 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF2 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF3 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025012", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850KvCal : ItemBase
    {
        public uint KvCalValue { get; set; }


        public ushort KvCalLowChan { get; set; }


        public ushort KvCalHighChan { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025052", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850LinearTxGainParam : ItemBase
    {
        public GsmTxLinearTxGainParamDataType TxGainParam { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024996", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850LnaSwpt : ItemBase
    {
        public GsmRxLnaSwptType GsmRxLnaSwpt { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025060", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850MultislotMaxTxPwr : ItemBase
    {
        [FieldCount(5)]
        public short[] GsmMultislotTxPwrGmsk { get; set; }

        [FieldCount(5)]
        public short[] GsmMultislotTxPwr8psk { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025426", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850PaRangeMap : ItemBase
    {
        public byte PaRangeMap { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024988", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850PaSwpt : ItemBase
    {
        public GsmTxPaSwptDataType GsmPaSwptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025068", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850PolarPathDelay : ItemBase
    {
        public short PolarPathDelay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025116", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850PolarRampProfile : ItemBase
    {
        public GsmTxPolarRampProfileDataType PolarParampLut { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025076", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850PowerLevels : ItemBase
    {
        [FieldCount(16)]
        public short[] GsmPowerLevels { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024964", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850RxCalData : ItemBase
    {
        public byte RxCalChanSize { get; set; }

        [FieldCount(16)]
        public short[] RxCalChanList { get; set; }

        [FieldCount(4)]
        public GsmRxFreqCompDataType[] RxFreqCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025028", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850SarBackoff : ItemBase
    {
        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot1 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot2 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot3 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot4 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot5 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025084", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850SmpsPdmTbl : ItemBase
    {
        public GsmTxSmpsPdmDataType SmpsPdmData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025044", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850TempComp : ItemBase
    {
        public GsmTxTempCompDataType TempCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024972", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850TxCalData : ItemBase
    {
        public byte TxCalChanSize { get; set; }

        [FieldCount(3)]
        public ushort[] TxCalChan { get; set; }


        public short AmamMaxDbm { get; set; }


        public byte RgiForPred { get; set; }


        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025100", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850TxGtrThresh : ItemBase
    {
        public GsmTxGtrThreshDataType GtrThresh { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025092", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850TxRxAntTuner : ItemBase
    {
        public RfcommonAntTunerDataType AntTunerRx { get; set; }


        public RfcommonAntTunerDataType AntTunerTx { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024980", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850TxTiming : ItemBase
    {
        public GsmTxTimingDataType GsmTxTimingData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025020", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm850Vbatt : ItemBase
    {
        [FieldCount(3)]
        public ushort[] VbattLevels { get; set; }


        public GsmTxVbattCompDataType VbattCompValueLo { get; set; }


        public GsmTxVbattCompDataType VbattCompValueHi { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025037", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900AmamTempComp : ItemBase
    {
        [FieldCount(16)]
        public sbyte[] AmamTempComp { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025577", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900EnhApt : ItemBase
    {
        public GsmTxEnhAptDataType EnhAptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025109", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900EnhTempComp : ItemBase
    {
        [FieldCount(256)]
        public short[] TempcompTable { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025005", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900EnvGain : ItemBase
    {
        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF1 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF2 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF3 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025013", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900KvCal : ItemBase
    {
        public uint KvCalValue { get; set; }


        public ushort KvCalLowChan { get; set; }


        public ushort KvCalHighChan { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025053", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900LinearTxGainParam : ItemBase
    {
        public GsmTxLinearTxGainParamDataType TxGainParam { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024997", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900LnaSwpt : ItemBase
    {
        public GsmRxLnaSwptType GsmRxLnaSwpt { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025061", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900MultislotMaxTxPwr : ItemBase
    {
        [FieldCount(5)]
        public short[] GsmMultislotTxPwrGmsk { get; set; }

        [FieldCount(5)]
        public short[] GsmMultislotTxPwr8psk { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025427", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900PaRangeMap : ItemBase
    {
        public byte PaRangeMap { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024989", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900PaSwpt : ItemBase
    {
        public GsmTxPaSwptDataType GsmPaSwptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025069", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900PolarPathDelay : ItemBase
    {
        public short PolarPathDelay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025117", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900PolarRampProfile : ItemBase
    {
        public GsmTxPolarRampProfileDataType PolarParampLut { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025077", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900PowerLevels : ItemBase
    {
        [FieldCount(16)]
        public short[] GsmPowerLevels { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024965", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900RxCalData : ItemBase
    {
        public byte RxCalChanSize { get; set; }

        [FieldCount(16)]
        public short[] RxCalChanList { get; set; }

        [FieldCount(4)]
        public GsmRxFreqCompDataType[] RxFreqCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025029", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900SarBackoff : ItemBase
    {
        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot1 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot2 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot3 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot4 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot5 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025085", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900SmpsPdmTbl : ItemBase
    {
        public GsmTxSmpsPdmDataType SmpsPdmData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025045", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900TempComp : ItemBase
    {
        public GsmTxTempCompDataType TempCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024973", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900TxCalData : ItemBase
    {
        public byte TxCalChanSize { get; set; }

        [FieldCount(3)]
        public ushort[] TxCalChan { get; set; }


        public short AmamMaxDbm { get; set; }


        public byte RgiForPred { get; set; }


        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025101", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900TxGtrThresh : ItemBase
    {
        public GsmTxGtrThreshDataType GtrThresh { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025093", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900TxRxAntTuner : ItemBase
    {
        public RfcommonAntTunerDataType AntTunerRx { get; set; }


        public RfcommonAntTunerDataType AntTunerTx { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024981", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900TxTiming : ItemBase
    {
        public GsmTxTimingDataType GsmTxTimingData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025021", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC0Gsm900Vbatt : ItemBase
    {
        [FieldCount(3)]
        public ushort[] VbattLevels { get; set; }


        public GsmTxVbattCompDataType VbattCompValueLo { get; set; }


        public GsmTxVbattCompDataType VbattCompValueHi { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025042", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800AmamTempComp : ItemBase
    {
        [FieldCount(16)]
        public sbyte[] AmamTempComp { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025582", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800EnhApt : ItemBase
    {
        public GsmTxEnhAptDataType EnhAptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025114", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800EnhTempComp : ItemBase
    {
        [FieldCount(256)]
        public short[] TempcompTable { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025010", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800EnvGain : ItemBase
    {
        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF1 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF2 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF3 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025018", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800KvCal : ItemBase
    {
        public uint KvCalValue { get; set; }


        public ushort KvCalLowChan { get; set; }


        public ushort KvCalHighChan { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025058", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800LinearTxGainParam : ItemBase
    {
        public GsmTxLinearTxGainParamDataType TxGainParam { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025002", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800LnaSwpt : ItemBase
    {
        public GsmRxLnaSwptType GsmRxLnaSwpt { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025066", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800MultislotMaxTxPwr : ItemBase
    {
        [FieldCount(5)]
        public short[] GsmMultislotTxPwrGmsk { get; set; }

        [FieldCount(5)]
        public short[] GsmMultislotTxPwr8psk { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025432", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800PaRangeMap : ItemBase
    {
        public byte PaRangeMap { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024994", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800PaSwpt : ItemBase
    {
        public GsmTxPaSwptDataType GsmPaSwptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025074", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800PolarPathDelay : ItemBase
    {
        public short PolarPathDelay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025122", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800PolarRampProfile : ItemBase
    {
        public GsmTxPolarRampProfileDataType PolarParampLut { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025082", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800PowerLevels : ItemBase
    {
        [FieldCount(16)]
        public short[] GsmPowerLevels { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024970", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800RxCalData : ItemBase
    {
        public byte RxCalChanSize { get; set; }

        [FieldCount(16)]
        public short[] RxCalChanList { get; set; }

        [FieldCount(4)]
        public GsmRxFreqCompDataType[] RxFreqCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025034", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800SarBackoff : ItemBase
    {
        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot1 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot2 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot3 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot4 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot5 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025090", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800SmpsPdmTbl : ItemBase
    {
        public GsmTxSmpsPdmDataType SmpsPdmData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025050", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800TempComp : ItemBase
    {
        public GsmTxTempCompDataType TempCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024978", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800TxCalData : ItemBase
    {
        public byte TxCalChanSize { get; set; }

        [FieldCount(3)]
        public ushort[] TxCalChan { get; set; }


        public short AmamMaxDbm { get; set; }


        public byte RgiForPred { get; set; }


        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025106", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800TxGtrThresh : ItemBase
    {
        public GsmTxGtrThreshDataType GtrThresh { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025098", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800TxRxAntTuner : ItemBase
    {
        public RfcommonAntTunerDataType AntTunerRx { get; set; }


        public RfcommonAntTunerDataType AntTunerTx { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024986", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800TxTiming : ItemBase
    {
        public GsmTxTimingDataType GsmTxTimingData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025026", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1800Vbatt : ItemBase
    {
        [FieldCount(3)]
        public ushort[] VbattLevels { get; set; }


        public GsmTxVbattCompDataType VbattCompValueLo { get; set; }


        public GsmTxVbattCompDataType VbattCompValueHi { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025043", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900AmamTempComp : ItemBase
    {
        [FieldCount(16)]
        public sbyte[] AmamTempComp { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025583", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900EnhApt : ItemBase
    {
        public GsmTxEnhAptDataType EnhAptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025115", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900EnhTempComp : ItemBase
    {
        [FieldCount(256)]
        public short[] TempcompTable { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025011", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900EnvGain : ItemBase
    {
        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF1 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF2 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF3 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025019", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900KvCal : ItemBase
    {
        public uint KvCalValue { get; set; }


        public ushort KvCalLowChan { get; set; }


        public ushort KvCalHighChan { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025059", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900LinearTxGainParam : ItemBase
    {
        public GsmTxLinearTxGainParamDataType TxGainParam { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025003", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900LnaSwpt : ItemBase
    {
        public GsmRxLnaSwptType GsmRxLnaSwpt { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025067", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900MultislotMaxTxPwr : ItemBase
    {
        [FieldCount(5)]
        public short[] GsmMultislotTxPwrGmsk { get; set; }

        [FieldCount(5)]
        public short[] GsmMultislotTxPwr8psk { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025433", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900PaRangeMap : ItemBase
    {
        public byte PaRangeMap { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024995", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900PaSwpt : ItemBase
    {
        public GsmTxPaSwptDataType GsmPaSwptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025075", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900PolarPathDelay : ItemBase
    {
        public short PolarPathDelay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025123", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900PolarRampProfile : ItemBase
    {
        public GsmTxPolarRampProfileDataType PolarParampLut { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025083", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900PowerLevels : ItemBase
    {
        [FieldCount(16)]
        public short[] GsmPowerLevels { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024971", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900RxCalData : ItemBase
    {
        public byte RxCalChanSize { get; set; }

        [FieldCount(16)]
        public short[] RxCalChanList { get; set; }

        [FieldCount(4)]
        public GsmRxFreqCompDataType[] RxFreqCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025035", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900SarBackoff : ItemBase
    {
        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot1 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot2 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot3 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot4 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot5 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025091", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900SmpsPdmTbl : ItemBase
    {
        public GsmTxSmpsPdmDataType SmpsPdmData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025051", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900TempComp : ItemBase
    {
        public GsmTxTempCompDataType TempCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024979", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900TxCalData : ItemBase
    {
        public byte TxCalChanSize { get; set; }

        [FieldCount(3)]
        public ushort[] TxCalChan { get; set; }


        public short AmamMaxDbm { get; set; }


        public byte RgiForPred { get; set; }


        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025107", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900TxGtrThresh : ItemBase
    {
        public GsmTxGtrThreshDataType GtrThresh { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025099", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900TxRxAntTuner : ItemBase
    {
        public RfcommonAntTunerDataType AntTunerRx { get; set; }


        public RfcommonAntTunerDataType AntTunerTx { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024987", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900TxTiming : ItemBase
    {
        public GsmTxTimingDataType GsmTxTimingData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025027", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm1900Vbatt : ItemBase
    {
        [FieldCount(3)]
        public ushort[] VbattLevels { get; set; }


        public GsmTxVbattCompDataType VbattCompValueLo { get; set; }


        public GsmTxVbattCompDataType VbattCompValueHi { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025040", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850AmamTempComp : ItemBase
    {
        [FieldCount(16)]
        public sbyte[] AmamTempComp { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025580", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850EnhApt : ItemBase
    {
        public GsmTxEnhAptDataType EnhAptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025112", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850EnhTempComp : ItemBase
    {
        [FieldCount(256)]
        public short[] TempcompTable { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025008", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850EnvGain : ItemBase
    {
        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF1 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF2 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF3 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025016", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850KvCal : ItemBase
    {
        public uint KvCalValue { get; set; }


        public ushort KvCalLowChan { get; set; }


        public ushort KvCalHighChan { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025056", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850LinearTxGainParam : ItemBase
    {
        public GsmTxLinearTxGainParamDataType TxGainParam { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025000", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850LnaSwpt : ItemBase
    {
        public GsmRxLnaSwptType GsmRxLnaSwpt { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025064", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850MultislotMaxTxPwr : ItemBase
    {
        [FieldCount(5)]
        public short[] GsmMultislotTxPwrGmsk { get; set; }

        [FieldCount(5)]
        public short[] GsmMultislotTxPwr8psk { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025430", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850PaRangeMap : ItemBase
    {
        public byte PaRangeMap { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024992", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850PaSwpt : ItemBase
    {
        public GsmTxPaSwptDataType GsmPaSwptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025072", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850PolarPathDelay : ItemBase
    {
        public short PolarPathDelay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025120", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850PolarRampProfile : ItemBase
    {
        public GsmTxPolarRampProfileDataType PolarParampLut { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025080", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850PowerLevels : ItemBase
    {
        [FieldCount(16)]
        public short[] GsmPowerLevels { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024968", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850RxCalData : ItemBase
    {
        public byte RxCalChanSize { get; set; }

        [FieldCount(16)]
        public short[] RxCalChanList { get; set; }

        [FieldCount(4)]
        public GsmRxFreqCompDataType[] RxFreqCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025032", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850SarBackoff : ItemBase
    {
        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot1 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot2 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot3 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot4 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot5 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025088", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850SmpsPdmTbl : ItemBase
    {
        public GsmTxSmpsPdmDataType SmpsPdmData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025048", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850TempComp : ItemBase
    {
        public GsmTxTempCompDataType TempCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024976", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850TxCalData : ItemBase
    {
        public byte TxCalChanSize { get; set; }

        [FieldCount(3)]
        public ushort[] TxCalChan { get; set; }


        public short AmamMaxDbm { get; set; }


        public byte RgiForPred { get; set; }


        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025104", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850TxGtrThresh : ItemBase
    {
        public GsmTxGtrThreshDataType GtrThresh { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025096", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850TxRxAntTuner : ItemBase
    {
        public RfcommonAntTunerDataType AntTunerRx { get; set; }


        public RfcommonAntTunerDataType AntTunerTx { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024984", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850TxTiming : ItemBase
    {
        public GsmTxTimingDataType GsmTxTimingData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025024", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm850Vbatt : ItemBase
    {
        [FieldCount(3)]
        public ushort[] VbattLevels { get; set; }


        public GsmTxVbattCompDataType VbattCompValueLo { get; set; }


        public GsmTxVbattCompDataType VbattCompValueHi { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025041", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900AmamTempComp : ItemBase
    {
        [FieldCount(16)]
        public sbyte[] AmamTempComp { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025581", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900EnhApt : ItemBase
    {
        public GsmTxEnhAptDataType EnhAptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025113", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900EnhTempComp : ItemBase
    {
        [FieldCount(256)]
        public short[] TempcompTable { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025009", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900EnvGain : ItemBase
    {
        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF1 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF2 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF3 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025017", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900KvCal : ItemBase
    {
        public uint KvCalValue { get; set; }


        public ushort KvCalLowChan { get; set; }


        public ushort KvCalHighChan { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025057", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900LinearTxGainParam : ItemBase
    {
        public GsmTxLinearTxGainParamDataType TxGainParam { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025001", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900LnaSwpt : ItemBase
    {
        public GsmRxLnaSwptType GsmRxLnaSwpt { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025065", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900MultislotMaxTxPwr : ItemBase
    {
        [FieldCount(5)]
        public short[] GsmMultislotTxPwrGmsk { get; set; }

        [FieldCount(5)]
        public short[] GsmMultislotTxPwr8psk { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025431", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900PaRangeMap : ItemBase
    {
        public byte PaRangeMap { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024993", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900PaSwpt : ItemBase
    {
        public GsmTxPaSwptDataType GsmPaSwptData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025073", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900PolarPathDelay : ItemBase
    {
        public short PolarPathDelay { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025121", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900PolarRampProfile : ItemBase
    {
        public GsmTxPolarRampProfileDataType PolarParampLut { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025081", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900PowerLevels : ItemBase
    {
        [FieldCount(16)]
        public short[] GsmPowerLevels { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024969", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900RxCalData : ItemBase
    {
        public byte RxCalChanSize { get; set; }

        [FieldCount(16)]
        public short[] RxCalChanList { get; set; }

        [FieldCount(4)]
        public GsmRxFreqCompDataType[] RxFreqCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025033", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900SarBackoff : ItemBase
    {
        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot1 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot2 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot3 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot4 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot5 { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025089", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900SmpsPdmTbl : ItemBase
    {
        public GsmTxSmpsPdmDataType SmpsPdmData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025049", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900TempComp : ItemBase
    {
        public GsmTxTempCompDataType TempCompData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024977", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900TxCalData : ItemBase
    {
        public byte TxCalChanSize { get; set; }

        [FieldCount(3)]
        public ushort[] TxCalChan { get; set; }


        public short AmamMaxDbm { get; set; }


        public byte RgiForPred { get; set; }


        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025105", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900TxGtrThresh : ItemBase
    {
        public GsmTxGtrThreshDataType GtrThresh { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025097", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900TxRxAntTuner : ItemBase
    {
        public RfcommonAntTunerDataType AntTunerRx { get; set; }


        public RfcommonAntTunerDataType AntTunerTx { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024985", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900TxTiming : ItemBase
    {
        public GsmTxTimingDataType GsmTxTimingData { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025025", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmC2Gsm900Vbatt : ItemBase
    {
        [FieldCount(3)]
        public ushort[] VbattLevels { get; set; }


        public GsmTxVbattCompDataType VbattCompValueLo { get; set; }


        public GsmTxVbattCompDataType VbattCompValueHi { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025584", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmDebug : ItemBase
    {
        [FieldCount(2)]
        public uint[] SpareNv { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024597", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmEnhTempCompEnable : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022898", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class GsmTempCompPclPwrScaling : SixteenInt16ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/mcs/lmtsmgr/coex/blank/gsm_victim_1x_aggr", false, 0x81FF)]
    [Attributes(9)]
   public sealed class GsmVictim1xAggr : ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/mcs/lmtsmgr/coex/blank/gsm_victim_hdr_aggr", false, 0x81FF)]
    [Attributes(9)]
   public sealed class GsmVictimHdrAggr : ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/mcs/lmtsmgr/coex/blank/gsm_victim_wcdma_aggr", false, 0x81FF)]
    [Attributes(9)]
   public sealed class GsmVictimWcdmaAggr : ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/hdr/srch/hdr_acq_div_enable", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class HdrAcqDivEnable : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/hdr/srch/hdr_acq_div_thresh0", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class HdrAcqDivThresh0: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/hdr/srch/hdr_acq_div_thresh1", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class HdrAcqDivThresh1: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020019", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class HdrBc0HalfDuplex : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022931", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class HdrBc15HalfDuplex : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020020", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class HdrBc1HalfDuplex : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022932", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class HdrBc4HalfDuplex : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020021", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class HdrBc6HalfDuplex : TenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/hdr/mac/hdr_dtx_cfg", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class HdrDtxCfg: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021692", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class HdrThermalStateLimits : EightUInt16ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/mcs/lmtsmgr/coex/blank/hdr_victim_gsm_aggr", false, 0x81FF)]
    [Attributes(9)]
   public sealed class HdrVictimGsmAggr : ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp2/hrpd_ipv6_config_info", false, 0x81FF)]
    [Attributes(9)]
   public sealed class HrpdIpv6ConfigInfo : ItemBase
    {
    }

    [Serializable]
    [NvItemId(67218)]
    [EfsFile("/nv/item_files/ims/IMS_enable", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImsEnable : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/ims/imshandoverconfig", false, 0x81FF)]
    [Attributes(9)]
    public sealed class ImsHandoverConfig : MultiLineStringsItemBase
    {
    }

    [Serializable]
    [EfsFile("/efsprofiles/imshandoverconfig", false, 0x81FF)]
    [Attributes(9)]
    public sealed class ImsHandoverConfigProfile : MultiLineStringsItemBase
    {
    }

    [Serializable]
    [Subscription]
    [NvItemId(70287)]
    [EfsFile("/nv/item_files/ims/ims_hybrid_enable", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImsHybridEnable : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(69673)]
    [EfsFile("/nv/item_files/ims/ims_operation_mode", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImsOperationMode : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(73713)]
    [EfsFile("/nv/item_files/ims/ims_rat_ho_config", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImsRatHoConfig : ItemBase
    {
        [Required]
        public byte Version { get; set; }


        public uint ImsHoHystTimerEpdgLte { get; set; }


        public uint ImsHoHystTimerEpdg1x { get; set; }


        public uint ImsHoHystTimerEpdgWifi { get; set; }


        public byte ImsHoEnabled { get; set; }
    }

    [Serializable]
    [NvItemId(67233)]
    [EfsFile("/nv/item_files/ims/ims_rtp_loop_back_enabled", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImsRtpLoopBackEnabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(67283)]
    [EfsFile("/nv/item_files/ims/ims_scr_amr_nb_enabled", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImsScrAmrNbEnabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(67284)]
    [EfsFile("/nv/item_files/ims/ims_scr_amr_wb_enabled", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImsScrAmrWbEnabled : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/ims/ims_sip_config", false, 0x81FF)]
    [Attributes(9)]
   public sealed class ImsSipConfig : OneThousandTwentyFourByteItemBase
    {
    }

    [Serializable]
    [Subscription]
    [NvItemId(69689)]
    [EfsFile("/nv/item_files/ims/ims_user_agent", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImsUserAgent : ItemBase
    {
        [JsonIgnore] [FieldCount(1024)] private byte[] _value;

        public string ValueString
        {
            get => StringUtils.GetString(_value);
            set => _value = StringUtils.GetBytes(value, 1024);
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020691", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImtAptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020690", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImtAptCharTblPaRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020692", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImtAptCharTblPout0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020693", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImtAptCharTblPout1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020694", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImtAptCharTblPout2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020695", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImtAptCharTblPout3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020696", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImtAptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020697", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImtAptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020698", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImtAptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020699", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImtAptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020689", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class ImtAptCharTblTypeList : FourByteItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [EfsFile("/eHRPD/initial_sequence_number.txt", false, 0x81FF)]
    [Attributes(9)]
   public sealed class InitialSequenceNumberTxt : ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/tdscdma/rrc/integrity_enabled", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class IntegrityEnabled : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp2/internal_auth", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class InternalAuth : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024126", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class InternalDeviceCalStatus : ItemBase
    {
        public TxIntDevCalNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/datamodem/protocols/ip6_default_mtu", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Ip6DefaultMtu: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/datamodem/protocols/ip6_include_rdnss_opt", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Ip6IncludeRdnssOpt : ByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/nas/irat_search_timer", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class IratSearchTimer : UInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/data/iwlan_s2b_config.txt", false, 0x81B6)]
    [Attributes(9)]
    public sealed class IwlanS2bConfigTxt : MultiLineStringsItemBase
    {
    }

    [Serializable]
    [EfsFile("/data/iwlan_s2b_config.xml", false, 0x81B6)]
    [Attributes(9)]
    public sealed class IwlanS2bConfigXml : MultiLineStringsItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/jcdma/jcdma_mode", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class JcdmaMode : ByteItemBase
    {
    }

    public enum Lte3gppReleaseVerValue : byte
    {
        /*Rel8 versions*/
        Rel8 = 0x10,
        Rel8Dec08 = 0x11,
        Rel8Mar09 = 0x12,
        Rel8Jun09 = 0x13,
        Rel8Sep09 = 0x14,
        Rel8Dec09 = 0x15,
        Rel8Mar10 = 0x16,
        Rel8Jun10 = 0x17,
        Rel8Sep10 = 0x18,
        Rel8Dec10 = 0x19,

        /*Rel 9 versions*/
        Rel9 = 0x20,
        Rel9Mar10 = 0x21,
        Rel9Jun10 = 0x22,
        Rel9Sep10 = 0x23,

        /*Rel 10 versions*/
        Rel10Jun11 = 0x40, /*June 2011 release*/
        Rel10Sep11 = 0x41,
        Rel10Dec11 = 0x42,
        Rel10Mar12 = 0x43,
        Rel10Jun12 = 0x44,
        Rel10Sep12 = 0x45,

        /*Rel 11 versions*/
        Rel11 = 128,
        Rel11Jun13 = 129,
        Rel11Dec13 = 130
    }

    [Serializable]
    [EfsFile("/nv/item_files/modem/lte/lte_3gpp_release_ver", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class Lte3gppReleaseVer : ItemBase
    {
        [JsonIgnore]
        public byte Value { get; set; }

        public string StringValue
        {
            get => $"{(Lte3gppReleaseVerValue) Value}";
            set => Value = EnumUtils.ParseEnumByte(typeof(Lte3gppReleaseVerValue), value);
        }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024051", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10AgcPaOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024052", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10AgcTxOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024124", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10AmprNs03 : SixteenByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024078", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024108", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024107", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10AptCharTblPaRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024109", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10AptCharTblPout0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024110", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10AptCharTblPout1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024111", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10AptCharTblPout2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024112", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10AptCharTblPout3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024113", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024114", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024115", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024116", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024106", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10AptCharTblTypeList : FourUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024082", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024080", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C1Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024089", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C1Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024084", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C1ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024086", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C1LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024083", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C1LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024081", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C1NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024090", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C1RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024087", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C1RxGain : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024088", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C1RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024085", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C1RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025301", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C2LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025299", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C2RxGain : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025297", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C2RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025302", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C3LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025300", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C3RxGain : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025298", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10C3RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025217", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB10CaBcConfig : LteBandsConfigBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024105", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10Db10SarBackOffLimit : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024123", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10DefaultSmpsBias: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024079", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024049", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10EncBtf : Int32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024075", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10ExpHdetVsAgc : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024715", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10HdetHpmThreshold : ItemBase
    {
        public ushort Enable { get; set; }


        public ushort Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024077", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10HdetOffSpan : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024047", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024042", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025303", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10IntraCaRxGainVsFreq : ThreeHundredEightyFourSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024046", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024041", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024096", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10MaxTxPowerDb10 : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024050", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10MaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024941", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10MinTxPowerDb10 : ItemBase
    {
        public ushort Enable { get; set; }


        public short Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024062", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10MprBasedPaSwitchpointsShift : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024038", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024055", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10PaCompensateUpDown : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024053", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10PaGainUpDownTime : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024057", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10PaRangeMap : FourSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024059", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10PaRiseFallThreshold : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024093", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10PaSmpsGst : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024095", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10PaSmpsGstTemp : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024094", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10PaSmpsOdrive: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024040", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024039", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10RxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024048", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10RxfMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024044", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10RxGain : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024045", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024043", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024118", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10RxOnFallDelay: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024117", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10RxOnRiseDelay: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024058", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024065", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxAgcOffset : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024060", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024092", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxCarrierFeedthroughComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024074", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxCompVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024064", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxDigitalGainComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024541", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxEptDpdConfigParams : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024070", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxGainIndex0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024071", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxGainIndex1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024072", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxGainIndex2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024073", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxGainIndex3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024101", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxGainIndexForApt0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024102", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxGainIndexForApt1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024103", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxGainIndexForApt2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024104", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxGainIndexForApt3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024119", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short AdvanceTime { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024076", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxLimitVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024061", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxLimitVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024561", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxLimVsTempVsFreq : ItemBase
    {
        public byte MatrixEnabled { get; set; }

        [FieldCount(128)]
        public sbyte[] LimVsTempVsFreq { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024066", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxLinMaster0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024067", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxLinMaster1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024068", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxLinMaster2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024069", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxLinMaster3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024097", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxLinMasterForApt0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024098", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxLinMasterForApt1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024099", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxLinMasterForApt2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024100", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxLinMasterForApt3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024056", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxLinVsTemp : SixtyFourSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025684", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Enabled { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025640", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Enabled { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024091", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024063", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxMprBackoff : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024120", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024122", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024235", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024054", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxRotAnglePaState : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025541", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB10TxXptDelay : ItemBase
    {
        public byte NumActiveEntries { get; set; }

        [FieldCount(16)]
        public ushort[] UpperBoundChannels { get; set; }

        [FieldCount(16)]
        public int[] DelayLtebw5mhz { get; set; }

        [FieldCount(16)]
        public int[] DelayLtebw10mhz { get; set; }

        [FieldCount(16)]
        public int[] DelayLtebw20mhz { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020041", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11AgcPaOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020042", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11AgcTxOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020068", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021457", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021456", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11AptCharTblPaRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021458", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11AptCharTblPout0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021459", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11AptCharTblPout1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021460", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11AptCharTblPout2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021461", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11AptCharTblPout3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021462", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021463", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021464", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021465", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021455", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11AptCharTblTypeList : FourUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020072", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020070", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C1Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020079", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C1Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020074", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C1ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020076", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C1LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020073", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C1LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020071", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C1NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020080", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C1RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020077", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C1RxGain : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024199", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C1RxGainI : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020078", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C1RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020075", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C1RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025308", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C2LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025306", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C2RxGain : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025304", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C2RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025309", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C3LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025307", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C3RxGain : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025305", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11C3RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025218", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB11CaBcConfig : LteBandsConfigBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021314", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11Db10SarBackOffLimit : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024024", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11DefaultSmpsBias: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020069", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020039", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11EncBtf : Int32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020065", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11ExpHdetVsAgc : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024716", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11HdetHpmThreshold : ItemBase
    {
        public ushort Enable { get; set; }


        public ushort Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020067", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11HdetOffSpan : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020037", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020032", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025310", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11IntraCaRxGainVsFreq : ThreeHundredEightyFourSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020036", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020031", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020999", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11MaxTxPowerDb10 : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020040", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11MaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024942", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11MinTxPowerDb10 : ItemBase
    {
        public ushort Enable { get; set; }


        public short Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020052", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11MprBasedPaSwitchpointsShift : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020028", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020045", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11PaCompensateUpDown : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020043", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11PaGainUpDownTime : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020047", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11PaRangeMap : FourSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020049", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11PaRiseFallThreshold : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020766", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11PaSmpsGst : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020768", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11PaSmpsGstTemp : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020767", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11PaSmpsOdrive: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020030", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020029", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11RxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020038", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11RxfMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020034", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11RxGain : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020035", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020033", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022393", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11RxOnFallDelay: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022379", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11RxOnRiseDelay: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020048", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020055", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxAgcOffset : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020050", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020082", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxCarrierFeedthroughComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020064", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxCompVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020054", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxDigitalGainComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024166", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxEptDpdConfigParams : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020060", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxGainIndex0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020061", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxGainIndex1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020062", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxGainIndex2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020063", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxGainIndex3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021267", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxGainIndexForApt0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021268", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxGainIndexForApt1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021269", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxGainIndexForApt2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021270", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxGainIndexForApt3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023835", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short AdvanceTime { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020066", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxLimitVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020051", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxLimitVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024562", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxLimVsTempVsFreq : ItemBase
    {
        public byte MatrixEnabled { get; set; }

        [FieldCount(128)]
        public sbyte[] LimVsTempVsFreq { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020056", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxLinMaster0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020057", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxLinMaster1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020058", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxLinMaster2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020059", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxLinMaster3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021211", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxLinMasterForApt0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021212", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxLinMasterForApt1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021213", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxLinMasterForApt2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021214", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxLinMasterForApt3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020046", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxLinVsTemp : SixtyFourSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025685", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Enabled { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025641", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Enabled { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020081", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020053", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxMprBackoff : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022964", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023901", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024236", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020044", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxRotAnglePaState : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025542", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB11TxXptDelay : ItemBase
    {
        public byte NumActiveEntries { get; set; }

        [FieldCount(16)]
        public ushort[] UpperBoundChannels { get; set; }

        [FieldCount(16)]
        public int[] DelayLtebw5mhz { get; set; }

        [FieldCount(16)]
        public int[] DelayLtebw10mhz { get; set; }

        [FieldCount(16)]
        public int[] DelayLtebw20mhz { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022145", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12AgcPaOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022146", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12AgcTxOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022172", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022203", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022202", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12AptCharTblPaRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022204", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12AptCharTblPout0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022205", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12AptCharTblPout1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022206", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12AptCharTblPout2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022207", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12AptCharTblPout3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022208", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022209", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022210", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022211", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022201", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12AptCharTblTypeList : FourUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025193", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12BandedgeMaxpowerBackoff : ItemBase
    {
        public byte Enable { get; set; }


        public byte LowerbandBackoff { get; set; }


        public byte UpperbandBackoff { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025194", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12BandedgeMaxpowerPaBackoff : ItemBase
    {
        public byte Enable { get; set; }


        public byte LowerbandPaSwitchptBackoff { get; set; }


        public byte UpperbandPaSwitchptBackoff { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022176", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022174", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C1Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022183", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C1Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022178", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C1ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022180", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C1LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022177", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C1LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022175", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C1NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022184", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C1RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022181", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C1RxGain : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022182", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C1RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022179", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C1RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025263", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C2LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025261", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C2RxGain : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025259", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C2RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025264", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C3LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025262", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C3RxGain : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025260", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12C3RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025219", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB12CaBcConfig : LteBandsConfigBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022200", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12Db10SarBackOffLimit : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024025", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12DefaultSmpsBias: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022173", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022143", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12EncBtf : Int32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022169", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12ExpHdetVsAgc : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024717", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12HdetHpmThreshold : ItemBase
    {
        public ushort Enable { get; set; }


        public ushort Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022171", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12HdetOffSpan : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022141", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022136", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025265", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12IntraCaRxGainVsFreq : ThreeHundredEightyFourSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022140", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022135", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022191", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12MaxTxPowerDb10 : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022144", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12MaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024943", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12MinTxPowerDb10 : ItemBase
    {
        public ushort Enable { get; set; }


        public short Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022156", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12MprBasedPaSwitchpointsShift : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022132", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022149", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12PaCompensateUpDown : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022147", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12PaGainUpDownTime : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022151", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12PaRangeMap : FourSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022153", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12PaRiseFallThreshold : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022188", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12PaSmpsGst : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022190", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12PaSmpsGstTemp : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022189", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12PaSmpsOdrive: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022134", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022133", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12RxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022142", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12RxfMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022138", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12RxGain : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022139", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022137", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022152", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022159", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxAgcOffset : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022154", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022186", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxCarrierFeedthroughComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022168", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxCompVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022158", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxDigitalGainComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024167", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxEptDpdConfigParams : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022164", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxGainIndex0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022165", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxGainIndex1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022166", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxGainIndex2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022167", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxGainIndex3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022196", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxGainIndexForApt0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022197", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxGainIndexForApt1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022198", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxGainIndexForApt2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022199", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxGainIndexForApt3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023836", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxGtrThresh : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short AdvanceTime { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022170", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxLimitVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022155", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxLimitVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024563", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxLimVsTempVsFreq : ItemBase
    {
        public byte MatrixEnabled { get; set; }

        [FieldCount(128)]
        public sbyte[] LimVsTempVsFreq { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022160", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxLinMaster0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022161", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxLinMaster1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022162", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxLinMaster2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022163", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxLinMaster3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022192", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxLinMasterForApt0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022193", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxLinMasterForApt1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022194", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxLinMasterForApt2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022195", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxLinMasterForApt3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022150", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxLinVsTemp : SixtyFourSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025686", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxLinVsTempVsFreqPIn : ItemBase
    {
        public byte Enabled { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025642", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxLinVsTempVsFreqPOut : ItemBase
    {
        public byte Enabled { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022185", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022157", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxMprBackoff : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022965", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxMultiLinData : ItemBase
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023902", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxMultiLinV2Data : ItemBase
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024237", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxMultiLinV3Data : ItemBase
    {
        public VariantMarker VariantDataMarker { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022148", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxRotAnglePaState : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025543", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB12TxXptDelay : ItemBase
    {
        public byte NumActiveEntries { get; set; }

        [FieldCount(16)]
        public ushort[] UpperBoundChannels { get; set; }

        [FieldCount(16)]
        public int[] DelayLtebw5mhz { get; set; }

        [FieldCount(16)]
        public int[] DelayLtebw10mhz { get; set; }

        [FieldCount(16)]
        public int[] DelayLtebw20mhz { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020140", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13AmprNs07 : SixteenByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020683", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13AmprNs07Offset : ThreeByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020685", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13AmprPaBackoff : TwoByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021468", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13AptCharTblNumPwrList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021467", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13AptCharTblPaRangeList : FourByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021469", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13AptCharTblPout0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021470", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13AptCharTblPout1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021471", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13AptCharTblPout2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021472", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13AptCharTblPout3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021473", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13AptCharTblSmps0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021474", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13AptCharTblSmps1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021475", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13AptCharTblSmps2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021476", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13AptCharTblSmps3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021466", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13AptCharTblTypeList : FourUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020212", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13C1RxGainI : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025270", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13C2LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025268", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13C2RxGain : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025266", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13C2RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025271", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13C3LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025269", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13C3RxGain : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025267", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13C3RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025220", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB13CaBcConfig : LteBandsConfigBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021315", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13Db10SarBackOffLimit : EightUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024026", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13DefaultSmpsBias: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024718", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13HdetHpmThreshold : ItemBase
    {
        public ushort Enable { get; set; }


        public ushort Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025272", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13IntraCaRxGainVsFreq : ThreeHundredEightyFourSByteItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021000", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13MaxTxPowerDb10 : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024944", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13MinTxPowerDb10 : ItemBase
    {
        public ushort Enable { get; set; }


        public short Value { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020769", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13PaSmpsGst : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020771", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13PaSmpsGstTemp : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020770", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13PaSmpsOdrive: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020211", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13RxGainI : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022394", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13RxOnFallDelay: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022380", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13RxOnRiseDelay: UInt16ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024168", true, 0xE1FF)]
    [Attributes(9)]
   public sealed class LteB13TxEptDpdConfigParams : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021271", true, 0xE1FF)]
    [Attributes(9)]
    {
    }

    {


