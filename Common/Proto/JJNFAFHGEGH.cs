// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: JJNFAFHGEGH.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from JJNFAFHGEGH.proto</summary>
  public static partial class JJNFAFHGEGHReflection {

    #region Descriptor
    /// <summary>File descriptor for JJNFAFHGEGH.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JJNFAFHGEGHReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFKSk5GQUZIR0VHSC5wcm90bxoTT2ZmZXJpbmdTdGF0ZS5wcm90byKGAQoL",
            "SkpORkFGSEdFR0gSIwoLT0pERUNES0hJTUoYDSABKA4yDi5PZmZlcmluZ1N0",
            "YXRlEhMKC0pDS0xESEpLQU1FGAUgAygNEhMKC0lCRkFDSkRNUE1QGAcgASgN",
            "EhMKC05MR0VLTUpCSUxEGAQgASgNEhMKC0pLREhETURGR0ZDGA4gASgNQh6q",
            "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.OfferingStateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.JJNFAFHGEGH), global::EggLink.DanhengServer.Proto.JJNFAFHGEGH.Parser, new[]{ "OJDECDKHIMJ", "JCKLDHJKAME", "IBFACJDMPMP", "NLGEKMJBILD", "JKDHDMDFGFC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class JJNFAFHGEGH : pb::IMessage<JJNFAFHGEGH>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<JJNFAFHGEGH> _parser = new pb::MessageParser<JJNFAFHGEGH>(() => new JJNFAFHGEGH());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<JJNFAFHGEGH> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.JJNFAFHGEGHReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JJNFAFHGEGH() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JJNFAFHGEGH(JJNFAFHGEGH other) : this() {
      oJDECDKHIMJ_ = other.oJDECDKHIMJ_;
      jCKLDHJKAME_ = other.jCKLDHJKAME_.Clone();
      iBFACJDMPMP_ = other.iBFACJDMPMP_;
      nLGEKMJBILD_ = other.nLGEKMJBILD_;
      jKDHDMDFGFC_ = other.jKDHDMDFGFC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JJNFAFHGEGH Clone() {
      return new JJNFAFHGEGH(this);
    }

    /// <summary>Field number for the "OJDECDKHIMJ" field.</summary>
    public const int OJDECDKHIMJFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.OfferingState oJDECDKHIMJ_ = global::EggLink.DanhengServer.Proto.OfferingState.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.OfferingState OJDECDKHIMJ {
      get { return oJDECDKHIMJ_; }
      set {
        oJDECDKHIMJ_ = value;
      }
    }

    /// <summary>Field number for the "JCKLDHJKAME" field.</summary>
    public const int JCKLDHJKAMEFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_jCKLDHJKAME_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> jCKLDHJKAME_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> JCKLDHJKAME {
      get { return jCKLDHJKAME_; }
    }

    /// <summary>Field number for the "IBFACJDMPMP" field.</summary>
    public const int IBFACJDMPMPFieldNumber = 7;
    private uint iBFACJDMPMP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IBFACJDMPMP {
      get { return iBFACJDMPMP_; }
      set {
        iBFACJDMPMP_ = value;
      }
    }

    /// <summary>Field number for the "NLGEKMJBILD" field.</summary>
    public const int NLGEKMJBILDFieldNumber = 4;
    private uint nLGEKMJBILD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NLGEKMJBILD {
      get { return nLGEKMJBILD_; }
      set {
        nLGEKMJBILD_ = value;
      }
    }

    /// <summary>Field number for the "JKDHDMDFGFC" field.</summary>
    public const int JKDHDMDFGFCFieldNumber = 14;
    private uint jKDHDMDFGFC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JKDHDMDFGFC {
      get { return jKDHDMDFGFC_; }
      set {
        jKDHDMDFGFC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as JJNFAFHGEGH);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(JJNFAFHGEGH other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OJDECDKHIMJ != other.OJDECDKHIMJ) return false;
      if(!jCKLDHJKAME_.Equals(other.jCKLDHJKAME_)) return false;
      if (IBFACJDMPMP != other.IBFACJDMPMP) return false;
      if (NLGEKMJBILD != other.NLGEKMJBILD) return false;
      if (JKDHDMDFGFC != other.JKDHDMDFGFC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OJDECDKHIMJ != global::EggLink.DanhengServer.Proto.OfferingState.None) hash ^= OJDECDKHIMJ.GetHashCode();
      hash ^= jCKLDHJKAME_.GetHashCode();
      if (IBFACJDMPMP != 0) hash ^= IBFACJDMPMP.GetHashCode();
      if (NLGEKMJBILD != 0) hash ^= NLGEKMJBILD.GetHashCode();
      if (JKDHDMDFGFC != 0) hash ^= JKDHDMDFGFC.GetHashCode();
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
      if (NLGEKMJBILD != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NLGEKMJBILD);
      }
      jCKLDHJKAME_.WriteTo(output, _repeated_jCKLDHJKAME_codec);
      if (IBFACJDMPMP != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(IBFACJDMPMP);
      }
      if (OJDECDKHIMJ != global::EggLink.DanhengServer.Proto.OfferingState.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) OJDECDKHIMJ);
      }
      if (JKDHDMDFGFC != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(JKDHDMDFGFC);
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
      if (NLGEKMJBILD != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NLGEKMJBILD);
      }
      jCKLDHJKAME_.WriteTo(ref output, _repeated_jCKLDHJKAME_codec);
      if (IBFACJDMPMP != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(IBFACJDMPMP);
      }
      if (OJDECDKHIMJ != global::EggLink.DanhengServer.Proto.OfferingState.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) OJDECDKHIMJ);
      }
      if (JKDHDMDFGFC != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(JKDHDMDFGFC);
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
      if (OJDECDKHIMJ != global::EggLink.DanhengServer.Proto.OfferingState.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OJDECDKHIMJ);
      }
      size += jCKLDHJKAME_.CalculateSize(_repeated_jCKLDHJKAME_codec);
      if (IBFACJDMPMP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IBFACJDMPMP);
      }
      if (NLGEKMJBILD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NLGEKMJBILD);
      }
      if (JKDHDMDFGFC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JKDHDMDFGFC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(JJNFAFHGEGH other) {
      if (other == null) {
        return;
      }
      if (other.OJDECDKHIMJ != global::EggLink.DanhengServer.Proto.OfferingState.None) {
        OJDECDKHIMJ = other.OJDECDKHIMJ;
      }
      jCKLDHJKAME_.Add(other.jCKLDHJKAME_);
      if (other.IBFACJDMPMP != 0) {
        IBFACJDMPMP = other.IBFACJDMPMP;
      }
      if (other.NLGEKMJBILD != 0) {
        NLGEKMJBILD = other.NLGEKMJBILD;
      }
      if (other.JKDHDMDFGFC != 0) {
        JKDHDMDFGFC = other.JKDHDMDFGFC;
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
          case 32: {
            NLGEKMJBILD = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            jCKLDHJKAME_.AddEntriesFrom(input, _repeated_jCKLDHJKAME_codec);
            break;
          }
          case 56: {
            IBFACJDMPMP = input.ReadUInt32();
            break;
          }
          case 104: {
            OJDECDKHIMJ = (global::EggLink.DanhengServer.Proto.OfferingState) input.ReadEnum();
            break;
          }
          case 112: {
            JKDHDMDFGFC = input.ReadUInt32();
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
          case 32: {
            NLGEKMJBILD = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            jCKLDHJKAME_.AddEntriesFrom(ref input, _repeated_jCKLDHJKAME_codec);
            break;
          }
          case 56: {
            IBFACJDMPMP = input.ReadUInt32();
            break;
          }
          case 104: {
            OJDECDKHIMJ = (global::EggLink.DanhengServer.Proto.OfferingState) input.ReadEnum();
            break;
          }
          case 112: {
            JKDHDMDFGFC = input.ReadUInt32();
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
