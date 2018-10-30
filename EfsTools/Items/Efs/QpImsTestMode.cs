using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qp_ims_test_mode", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsTestMode
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }

        [Optional]
        [ElementsCount(3)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Reserver { get; set; }
    }
}