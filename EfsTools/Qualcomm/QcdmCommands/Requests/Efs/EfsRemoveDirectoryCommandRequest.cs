﻿using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsRmdir)]
    internal class EfsRemoveDirectoryCommandRequest : BaseSubSystemCommandRequest
    {
        private readonly string _name;

        public EfsRemoveDirectoryCommandRequest(string name)
        {
            _name = name;
        }

        public override byte[] GetData()
        {
            var data = new byte[5 + _name.Length];
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(Encoding.ASCII.GetBytes(_name), 0, data, 4, _name.Length);
            data[4 + _name.Length] = 0;
            return data;
        }
    }
}