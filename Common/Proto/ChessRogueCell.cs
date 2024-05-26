// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueCell.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueCell.proto</summary>
  public static partial class ChessRogueCellReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueCell.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueCellReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRDaGVzc1JvZ3VlQ2VsbC5wcm90bxofQ2hlc3NSb2d1ZUNlbGxTcGVjaWFs",
            "VHlwZS5wcm90bxofQ2hlc3NSb2d1ZUJvYXJkQ2VsbFN0YXR1cy5wcm90bxoV",
            "Q2VsbEFkdmFuY2VJbmZvLnByb3RvIrcCCg5DaGVzc1JvZ3VlQ2VsbBIRCglj",
            "ZWxsX3R5cGUYDyABKA0SDgoGY29sdW1uGA4gASgNEhMKC0tKTURCQ0tHRkFN",
            "GAogASgIEi8KC2NlbGxfc3RhdHVzGAcgASgOMhouQ2hlc3NSb2d1ZUJvYXJk",
            "Q2VsbFN0YXR1cxIQCghpc192YWxpZBgBIAEoCBImCgxhZHZhbmNlX2luZm8Y",
            "BiABKAsyEC5DZWxsQWR2YW5jZUluZm8SCwoDcm93GAwgASgNEhEKCW1hcmtf",
            "dHlwZRgCIAEoDRIKCgJpZBgFIAEoDRIPCgdyb29tX2lkGA0gASgNEjAKDHNw",
            "ZWNpYWxfdHlwZRgLIAEoDjIaLkNoZXNzUm9ndWVDZWxsU3BlY2lhbFR5cGUS",
            "EwoLT09MTklCUEZKTkIYCCADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.CellAdvanceInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueCell), global::EggLink.DanhengServer.Proto.ChessRogueCell.Parser, new[]{ "CellType", "Column", "KJMDBCKGFAM", "CellStatus", "IsValid", "AdvanceInfo", "Row", "MarkType", "Id", "RoomId", "SpecialType", "OOLNIBPFJNB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueCell : pb::IMessage<ChessRogueCell>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueCell> _parser = new pb::MessageParser<ChessRogueCell>(() => new ChessRogueCell());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueCell> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueCellReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCell() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCell(ChessRogueCell other) : this() {
      cellType_ = other.cellType_;
      column_ = other.column_;
      kJMDBCKGFAM_ = other.kJMDBCKGFAM_;
      cellStatus_ = other.cellStatus_;
      isValid_ = other.isValid_;
      advanceInfo_ = other.advanceInfo_ != null ? other.advanceInfo_.Clone() : null;
      row_ = other.row_;
      markType_ = other.markType_;
      id_ = other.id_;
      roomId_ = other.roomId_;
      specialType_ = other.specialType_;
      oOLNIBPFJNB_ = other.oOLNIBPFJNB_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCell Clone() {
      return new ChessRogueCell(this);
    }

    /// <summary>Field number for the "cell_type" field.</summary>
    public const int CellTypeFieldNumber = 15;
    private uint cellType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CellType {
      get { return cellType_; }
      set {
        cellType_ = value;
      }
    }

    /// <summary>Field number for the "column" field.</summary>
    public const int ColumnFieldNumber = 14;
    private uint column_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Column {
      get { return column_; }
      set {
        column_ = value;
      }
    }

    /// <summary>Field number for the "KJMDBCKGFAM" field.</summary>
    public const int KJMDBCKGFAMFieldNumber = 10;
    private bool kJMDBCKGFAM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KJMDBCKGFAM {
      get { return kJMDBCKGFAM_; }
      set {
        kJMDBCKGFAM_ = value;
      }
    }

    /// <summary>Field number for the "cell_status" field.</summary>
    public const int CellStatusFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus cellStatus_ = global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus CellStatus {
      get { return cellStatus_; }
      set {
        cellStatus_ = value;
      }
    }

    /// <summary>Field number for the "is_valid" field.</summary>
    public const int IsValidFieldNumber = 1;
    private bool isValid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsValid {
      get { return isValid_; }
      set {
        isValid_ = value;
      }
    }

    /// <summary>Field number for the "advance_info" field.</summary>
    public const int AdvanceInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.CellAdvanceInfo advanceInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CellAdvanceInfo AdvanceInfo {
      get { return advanceInfo_; }
      set {
        advanceInfo_ = value;
      }
    }

    /// <summary>Field number for the "row" field.</summary>
    public const int RowFieldNumber = 12;
    private uint row_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Row {
      get { return row_; }
      set {
        row_ = value;
      }
    }

    /// <summary>Field number for the "mark_type" field.</summary>
    public const int MarkTypeFieldNumber = 2;
    private uint markType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MarkType {
      get { return markType_; }
      set {
        markType_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 5;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 13;
    private uint roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "special_type" field.</summary>
    public const int SpecialTypeFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType specialType_ = global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType SpecialType {
      get { return specialType_; }
      set {
        specialType_ = value;
      }
    }

    /// <summary>Field number for the "OOLNIBPFJNB" field.</summary>
    public const int OOLNIBPFJNBFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_oOLNIBPFJNB_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> oOLNIBPFJNB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OOLNIBPFJNB {
      get { return oOLNIBPFJNB_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueCell);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueCell other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CellType != other.CellType) return false;
      if (Column != other.Column) return false;
      if (KJMDBCKGFAM != other.KJMDBCKGFAM) return false;
      if (CellStatus != other.CellStatus) return false;
      if (IsValid != other.IsValid) return false;
      if (!object.Equals(AdvanceInfo, other.AdvanceInfo)) return false;
      if (Row != other.Row) return false;
      if (MarkType != other.MarkType) return false;
      if (Id != other.Id) return false;
      if (RoomId != other.RoomId) return false;
      if (SpecialType != other.SpecialType) return false;
      if(!oOLNIBPFJNB_.Equals(other.oOLNIBPFJNB_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CellType != 0) hash ^= CellType.GetHashCode();
      if (Column != 0) hash ^= Column.GetHashCode();
      if (KJMDBCKGFAM != false) hash ^= KJMDBCKGFAM.GetHashCode();
      if (CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) hash ^= CellStatus.GetHashCode();
      if (IsValid != false) hash ^= IsValid.GetHashCode();
      if (advanceInfo_ != null) hash ^= AdvanceInfo.GetHashCode();
      if (Row != 0) hash ^= Row.GetHashCode();
      if (MarkType != 0) hash ^= MarkType.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) hash ^= SpecialType.GetHashCode();
      hash ^= oOLNIBPFJNB_.GetHashCode();
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
      if (IsValid != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsValid);
      }
      if (MarkType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MarkType);
      }
      if (Id != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Id);
      }
      if (advanceInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(AdvanceInfo);
      }
      if (CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        output.WriteRawTag(56);
        output.WriteEnum((int) CellStatus);
      }
      oOLNIBPFJNB_.WriteTo(output, _repeated_oOLNIBPFJNB_codec);
      if (KJMDBCKGFAM != false) {
        output.WriteRawTag(80);
        output.WriteBool(KJMDBCKGFAM);
      }
      if (SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        output.WriteRawTag(88);
        output.WriteEnum((int) SpecialType);
      }
      if (Row != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Row);
      }
      if (RoomId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RoomId);
      }
      if (Column != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Column);
      }
      if (CellType != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CellType);
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
      if (IsValid != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsValid);
      }
      if (MarkType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MarkType);
      }
      if (Id != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Id);
      }
      if (advanceInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(AdvanceInfo);
      }
      if (CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        output.WriteRawTag(56);
        output.WriteEnum((int) CellStatus);
      }
      oOLNIBPFJNB_.WriteTo(ref output, _repeated_oOLNIBPFJNB_codec);
      if (KJMDBCKGFAM != false) {
        output.WriteRawTag(80);
        output.WriteBool(KJMDBCKGFAM);
      }
      if (SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        output.WriteRawTag(88);
        output.WriteEnum((int) SpecialType);
      }
      if (Row != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Row);
      }
      if (RoomId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RoomId);
      }
      if (Column != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Column);
      }
      if (CellType != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CellType);
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
      if (CellType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CellType);
      }
      if (Column != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Column);
      }
      if (KJMDBCKGFAM != false) {
        size += 1 + 1;
      }
      if (CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CellStatus);
      }
      if (IsValid != false) {
        size += 1 + 1;
      }
      if (advanceInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AdvanceInfo);
      }
      if (Row != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Row);
      }
      if (MarkType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MarkType);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoomId);
      }
      if (SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SpecialType);
      }
      size += oOLNIBPFJNB_.CalculateSize(_repeated_oOLNIBPFJNB_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueCell other) {
      if (other == null) {
        return;
      }
      if (other.CellType != 0) {
        CellType = other.CellType;
      }
      if (other.Column != 0) {
        Column = other.Column;
      }
      if (other.KJMDBCKGFAM != false) {
        KJMDBCKGFAM = other.KJMDBCKGFAM;
      }
      if (other.CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        CellStatus = other.CellStatus;
      }
      if (other.IsValid != false) {
        IsValid = other.IsValid;
      }
      if (other.advanceInfo_ != null) {
        if (advanceInfo_ == null) {
          AdvanceInfo = new global::EggLink.DanhengServer.Proto.CellAdvanceInfo();
        }
        AdvanceInfo.MergeFrom(other.AdvanceInfo);
      }
      if (other.Row != 0) {
        Row = other.Row;
      }
      if (other.MarkType != 0) {
        MarkType = other.MarkType;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      if (other.SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        SpecialType = other.SpecialType;
      }
      oOLNIBPFJNB_.Add(other.oOLNIBPFJNB_);
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
          case 8: {
            IsValid = input.ReadBool();
            break;
          }
          case 16: {
            MarkType = input.ReadUInt32();
            break;
          }
          case 40: {
            Id = input.ReadUInt32();
            break;
          }
          case 50: {
            if (advanceInfo_ == null) {
              AdvanceInfo = new global::EggLink.DanhengServer.Proto.CellAdvanceInfo();
            }
            input.ReadMessage(AdvanceInfo);
            break;
          }
          case 56: {
            CellStatus = (global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus) input.ReadEnum();
            break;
          }
          case 66:
          case 64: {
            oOLNIBPFJNB_.AddEntriesFrom(input, _repeated_oOLNIBPFJNB_codec);
            break;
          }
          case 80: {
            KJMDBCKGFAM = input.ReadBool();
            break;
          }
          case 88: {
            SpecialType = (global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType) input.ReadEnum();
            break;
          }
          case 96: {
            Row = input.ReadUInt32();
            break;
          }
          case 104: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 112: {
            Column = input.ReadUInt32();
            break;
          }
          case 120: {
            CellType = input.ReadUInt32();
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
          case 8: {
            IsValid = input.ReadBool();
            break;
          }
          case 16: {
            MarkType = input.ReadUInt32();
            break;
          }
          case 40: {
            Id = input.ReadUInt32();
            break;
          }
          case 50: {
            if (advanceInfo_ == null) {
              AdvanceInfo = new global::EggLink.DanhengServer.Proto.CellAdvanceInfo();
            }
            input.ReadMessage(AdvanceInfo);
            break;
          }
          case 56: {
            CellStatus = (global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus) input.ReadEnum();
            break;
          }
          case 66:
          case 64: {
            oOLNIBPFJNB_.AddEntriesFrom(ref input, _repeated_oOLNIBPFJNB_codec);
            break;
          }
          case 80: {
            KJMDBCKGFAM = input.ReadBool();
            break;
          }
          case 88: {
            SpecialType = (global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType) input.ReadEnum();
            break;
          }
          case 96: {
            Row = input.ReadUInt32();
            break;
          }
          case 104: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 112: {
            Column = input.ReadUInt32();
            break;
          }
          case 120: {
            CellType = input.ReadUInt32();
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