﻿using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class CByteArray : CVariable, IByteSource
    {
        public string InternalType { get; set; }
        public override string REDType => string.IsNullOrEmpty(InternalType) ? base.REDType : InternalType;

        public CByteArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public byte[] Bytes { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            var arraysize = file.ReadUInt32();
            Bytes = file.ReadBytes((int) arraysize);
        }

        public override void Write(BinaryWriter file)
        {
            if (Bytes != null && Bytes.Length != 0)
            {
                file.Write((uint)Bytes.Length);
                file.Write(Bytes);
            }
            else
            {

            }
        }

        public override CVariable SetValue(object val)
        {
            switch (val)
            {
                case byte[] bytes:
                    Bytes = bytes;
                    break;
                case CByteArray cvar:
                    this.Bytes = cvar.Bytes;
                    break;
            }

            return this;
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CByteArray(cr2w, parent, name);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = (CByteArray) base.Copy(context);

            if (Bytes == null) return copy;
            
            var newbytes = new byte[Bytes.Length];
            Bytes.CopyTo(newbytes, 0);
            copy.Bytes = newbytes;
            
            return copy;
        }

        public override Control GetEditor()
        {
            var editor = new ByteArrayEditor {Variable = this};
            return editor;
        }

        public override string ToString()
        {
            if (Bytes == null)
                return "0 bytes";
            else
                return  Bytes.Length + " bytes";
        }

        //public override void SerializeToXml(XmlWriter xw)
        //{
        //    DataContractSerializer ser = new DataContractSerializer(this.GetType());
        //    using (var ms = new MemoryStream())
        //    {
        //        ser.WriteStartObject(xw, this);
        //        ser.WriteObjectContent(xw, this);
        //        xw.WriteElementString("Length", Bytes.Length.ToString());
        //        if (Bytes.Length > 0)
        //        {
        //            xw.WriteElementString("Bytes", HexStr(Bytes));
        //        }
        //        ser.WriteEndObject(xw);
        //    }
        //}
    }
}