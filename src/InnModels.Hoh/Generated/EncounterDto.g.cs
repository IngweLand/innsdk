// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: encounter_dto.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Ingweland.Fog.Inn.Models.Hoh {

  /// <summary>Holder for reflection information generated from encounter_dto.proto</summary>
  public static partial class EncounterDtoReflection {

    #region Descriptor
    /// <summary>File descriptor for encounter_dto.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterDtoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNlbmNvdW50ZXJfZHRvLnByb3RvGhtlbmNvdW50ZXJfZGV0YWlsc19kdG8u",
            "cHJvdG8iSQoMRW5jb3VudGVyRHRvEhIKCmRpZmZpY3VsdHkYASABKAkSJQoH",
            "ZGV0YWlscxgCIAEoCzIULkVuY291bnRlckRldGFpbHNEdG9CH6oCHEluZ3dl",
            "bGFuZC5Gb2cuSW5uLk1vZGVscy5Ib2hiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Ingweland.Fog.Inn.Models.Hoh.EncounterDetailsDtoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Ingweland.Fog.Inn.Models.Hoh.EncounterDto), global::Ingweland.Fog.Inn.Models.Hoh.EncounterDto.Parser, new[]{ "Difficulty", "Details" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EncounterDto : pb::IMessage<EncounterDto>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EncounterDto> _parser = new pb::MessageParser<EncounterDto>(() => new EncounterDto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EncounterDto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ingweland.Fog.Inn.Models.Hoh.EncounterDtoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EncounterDto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EncounterDto(EncounterDto other) : this() {
      difficulty_ = other.difficulty_;
      details_ = other.details_ != null ? other.details_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EncounterDto Clone() {
      return new EncounterDto(this);
    }

    /// <summary>Field number for the "difficulty" field.</summary>
    public const int DifficultyFieldNumber = 1;
    private string difficulty_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Difficulty {
      get { return difficulty_; }
      set {
        difficulty_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "details" field.</summary>
    public const int DetailsFieldNumber = 2;
    private global::Ingweland.Fog.Inn.Models.Hoh.EncounterDetailsDto details_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Ingweland.Fog.Inn.Models.Hoh.EncounterDetailsDto Details {
      get { return details_; }
      set {
        details_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EncounterDto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EncounterDto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Difficulty != other.Difficulty) return false;
      if (!object.Equals(Details, other.Details)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Difficulty.Length != 0) hash ^= Difficulty.GetHashCode();
      if (details_ != null) hash ^= Details.GetHashCode();
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
      if (Difficulty.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Difficulty);
      }
      if (details_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Details);
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
      if (Difficulty.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Difficulty);
      }
      if (details_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Details);
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
      if (Difficulty.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Difficulty);
      }
      if (details_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Details);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EncounterDto other) {
      if (other == null) {
        return;
      }
      if (other.Difficulty.Length != 0) {
        Difficulty = other.Difficulty;
      }
      if (other.details_ != null) {
        if (details_ == null) {
          Details = new global::Ingweland.Fog.Inn.Models.Hoh.EncounterDetailsDto();
        }
        Details.MergeFrom(other.Details);
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
          case 10: {
            Difficulty = input.ReadString();
            break;
          }
          case 18: {
            if (details_ == null) {
              Details = new global::Ingweland.Fog.Inn.Models.Hoh.EncounterDetailsDto();
            }
            input.ReadMessage(Details);
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
          case 10: {
            Difficulty = input.ReadString();
            break;
          }
          case 18: {
            if (details_ == null) {
              Details = new global::Ingweland.Fog.Inn.Models.Hoh.EncounterDetailsDto();
            }
            input.ReadMessage(Details);
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
