/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Evernote.EDAM.NoteStore
{

  #if !SILVERLIGHT && !NETFX_CORE
  [Serializable]
  #endif
  public partial class NoteFilter : TBase
  {
    private int _order;
    private bool _ascending;
    private string _words;
    private string _notebookGuid;
    private List<string> _tagGuids;
    private string _timeZone;
    private bool _inactive;

    public int Order
    {
      get
      {
        return _order;
      }
      set
      {
        __isset.order = true;
        this._order = value;
      }
    }

    public bool Ascending
    {
      get
      {
        return _ascending;
      }
      set
      {
        __isset.ascending = true;
        this._ascending = value;
      }
    }

    public string Words
    {
      get
      {
        return _words;
      }
      set
      {
        __isset.words = true;
        this._words = value;
      }
    }

    public string NotebookGuid
    {
      get
      {
        return _notebookGuid;
      }
      set
      {
        __isset.notebookGuid = true;
        this._notebookGuid = value;
      }
    }

    public List<string> TagGuids
    {
      get
      {
        return _tagGuids;
      }
      set
      {
        __isset.tagGuids = true;
        this._tagGuids = value;
      }
    }

    public string TimeZone
    {
      get
      {
        return _timeZone;
      }
      set
      {
        __isset.timeZone = true;
        this._timeZone = value;
      }
    }

    public bool Inactive
    {
      get
      {
        return _inactive;
      }
      set
      {
        __isset.inactive = true;
        this._inactive = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT && !NETFX_CORE
    [Serializable]
    #endif
    public struct Isset {
      public bool order;
      public bool ascending;
      public bool words;
      public bool notebookGuid;
      public bool tagGuids;
      public bool timeZone;
      public bool inactive;
    }

    public NoteFilter() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I32) {
              Order = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Bool) {
              Ascending = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Words = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              NotebookGuid = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.List) {
              {
                TagGuids = new List<string>();
                TList _list44 = iprot.ReadListBegin();
                for( int _i45 = 0; _i45 < _list44.Count; ++_i45)
                {
                  string _elem46 = null;
                  _elem46 = iprot.ReadString();
                  TagGuids.Add(_elem46);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              TimeZone = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Bool) {
              Inactive = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("NoteFilter");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.order) {
        field.Name = "order";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Order);
        oprot.WriteFieldEnd();
      }
      if (__isset.ascending) {
        field.Name = "ascending";
        field.Type = TType.Bool;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Ascending);
        oprot.WriteFieldEnd();
      }
      if (Words != null && __isset.words) {
        field.Name = "words";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Words);
        oprot.WriteFieldEnd();
      }
      if (NotebookGuid != null && __isset.notebookGuid) {
        field.Name = "notebookGuid";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(NotebookGuid);
        oprot.WriteFieldEnd();
      }
      if (TagGuids != null && __isset.tagGuids) {
        field.Name = "tagGuids";
        field.Type = TType.List;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, TagGuids.Count));
          foreach (string _iter47 in TagGuids)
          {
            oprot.WriteString(_iter47);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (TimeZone != null && __isset.timeZone) {
        field.Name = "timeZone";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(TimeZone);
        oprot.WriteFieldEnd();
      }
      if (__isset.inactive) {
        field.Name = "inactive";
        field.Type = TType.Bool;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Inactive);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("NoteFilter(");
      sb.Append("Order: ");
      sb.Append(Order);
      sb.Append(",Ascending: ");
      sb.Append(Ascending);
      sb.Append(",Words: ");
      sb.Append(Words);
      sb.Append(",NotebookGuid: ");
      sb.Append(NotebookGuid);
      sb.Append(",TagGuids: ");
      sb.Append(TagGuids);
      sb.Append(",TimeZone: ");
      sb.Append(TimeZone);
      sb.Append(",Inactive: ");
      sb.Append(Inactive);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
