// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerReturnTakePointRewardScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerReturnTakePointRewardScRsp.proto</summary>
  public static partial class PlayerReturnTakePointRewardScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerReturnTakePointRewardScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReturnTakePointRewardScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZQbGF5ZXJSZXR1cm5UYWtlUG9pbnRSZXdhcmRTY1JzcC5wcm90bxoOSXRl",
            "bUxpc3QucHJvdG8ifQogUGxheWVyUmV0dXJuVGFrZVBvaW50UmV3YXJkU2NS",
            "c3ASEwoLRkpGSEVQRUNJTUsYCyABKA0SEwoLQUxIQ0lHQ0hCRkoYDyABKA0S",
            "HgoLSEVQRUNLT0hGQUgYCSABKAsyCS5JdGVtTGlzdBIPCgdyZXRjb2RlGAYg",
            "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardScRsp), global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardScRsp.Parser, new[]{ "FJFHEPECIMK", "ALHCIGCHBFJ", "HEPECKOHFAH", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerReturnTakePointRewardScRsp : pb::IMessage<PlayerReturnTakePointRewardScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerReturnTakePointRewardScRsp> _parser = new pb::MessageParser<PlayerReturnTakePointRewardScRsp>(() => new PlayerReturnTakePointRewardScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerReturnTakePointRewardScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardScRsp(PlayerReturnTakePointRewardScRsp other) : this() {
      fJFHEPECIMK_ = other.fJFHEPECIMK_;
      aLHCIGCHBFJ_ = other.aLHCIGCHBFJ_;
      hEPECKOHFAH_ = other.hEPECKOHFAH_ != null ? other.hEPECKOHFAH_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardScRsp Clone() {
      return new PlayerReturnTakePointRewardScRsp(this);
    }

    /// <summary>Field number for the "FJFHEPECIMK" field.</summary>
    public const int FJFHEPECIMKFieldNumber = 11;
    private uint fJFHEPECIMK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FJFHEPECIMK {
      get { return fJFHEPECIMK_; }
      set {
        fJFHEPECIMK_ = value;
      }
    }

    /// <summary>Field number for the "ALHCIGCHBFJ" field.</summary>
    public const int ALHCIGCHBFJFieldNumber = 15;
    private uint aLHCIGCHBFJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ALHCIGCHBFJ {
      get { return aLHCIGCHBFJ_; }
      set {
        aLHCIGCHBFJ_ = value;
      }
    }

    /// <summary>Field number for the "HEPECKOHFAH" field.</summary>
    public const int HEPECKOHFAHFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.ItemList hEPECKOHFAH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList HEPECKOHFAH {
      get { return hEPECKOHFAH_; }
      set {
        hEPECKOHFAH_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerReturnTakePointRewardScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerReturnTakePointRewardScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FJFHEPECIMK != other.FJFHEPECIMK) return false;
      if (ALHCIGCHBFJ != other.ALHCIGCHBFJ) return false;
      if (!object.Equals(HEPECKOHFAH, other.HEPECKOHFAH)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FJFHEPECIMK != 0) hash ^= FJFHEPECIMK.GetHashCode();
      if (ALHCIGCHBFJ != 0) hash ^= ALHCIGCHBFJ.GetHashCode();
      if (hEPECKOHFAH_ != null) hash ^= HEPECKOHFAH.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (hEPECKOHFAH_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(HEPECKOHFAH);
      }
      if (FJFHEPECIMK != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(FJFHEPECIMK);
      }
      if (ALHCIGCHBFJ != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ALHCIGCHBFJ);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (hEPECKOHFAH_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(HEPECKOHFAH);
      }
      if (FJFHEPECIMK != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(FJFHEPECIMK);
      }
      if (ALHCIGCHBFJ != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ALHCIGCHBFJ);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (FJFHEPECIMK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FJFHEPECIMK);
      }
      if (ALHCIGCHBFJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ALHCIGCHBFJ);
      }
      if (hEPECKOHFAH_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HEPECKOHFAH);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerReturnTakePointRewardScRsp other) {
      if (other == null) {
        return;
      }
      if (other.FJFHEPECIMK != 0) {
        FJFHEPECIMK = other.FJFHEPECIMK;
      }
      if (other.ALHCIGCHBFJ != 0) {
        ALHCIGCHBFJ = other.ALHCIGCHBFJ;
      }
      if (other.hEPECKOHFAH_ != null) {
        if (hEPECKOHFAH_ == null) {
          HEPECKOHFAH = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        HEPECKOHFAH.MergeFrom(other.HEPECKOHFAH);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 74: {
            if (hEPECKOHFAH_ == null) {
              HEPECKOHFAH = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(HEPECKOHFAH);
            break;
          }
          case 88: {
            FJFHEPECIMK = input.ReadUInt32();
            break;
          }
          case 120: {
            ALHCIGCHBFJ = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 74: {
            if (hEPECKOHFAH_ == null) {
              HEPECKOHFAH = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(HEPECKOHFAH);
            break;
          }
          case 88: {
            FJFHEPECIMK = input.ReadUInt32();
            break;
          }
          case 120: {
            ALHCIGCHBFJ = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
