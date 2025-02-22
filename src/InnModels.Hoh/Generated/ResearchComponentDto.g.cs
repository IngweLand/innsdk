// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: research_component_dto.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Ingweland.Fog.Inn.Models.Hoh {

  /// <summary>Holder for reflection information generated from research_component_dto.proto</summary>
  public static partial class ResearchComponentDtoReflection {

    #region Descriptor
    /// <summary>File descriptor for research_component_dto.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResearchComponentDtoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxyZXNlYXJjaF9jb21wb25lbnRfZHRvLnByb3RvGhpyZXNlYXJjaF9yZXdh",
            "cmRzX2R0by5wcm90bxoacmVzZWFyY2hfZGV0YWlsc19kdG8ucHJvdG8ibgoU",
            "UmVzZWFyY2hDb21wb25lbnREVE8SCgoCaWQYASABKAkSJAoHZGV0YWlscxgD",
            "IAEoCzITLlJlc2VhcmNoRGV0YWlsc0R0bxIkCgdyZXdhcmRzGAQgASgLMhMu",
            "UmVzZWFyY2hSZXdhcmRzRHRvQh+qAhxJbmd3ZWxhbmQuRm9nLklubi5Nb2Rl",
            "bHMuSG9oYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Ingweland.Fog.Inn.Models.Hoh.ResearchRewardsDtoReflection.Descriptor, global::Ingweland.Fog.Inn.Models.Hoh.ResearchDetailsDtoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Ingweland.Fog.Inn.Models.Hoh.ResearchComponentDTO), global::Ingweland.Fog.Inn.Models.Hoh.ResearchComponentDTO.Parser, new[]{ "Id", "Details", "Rewards" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ResearchComponentDTO : pb::IMessage<ResearchComponentDTO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResearchComponentDTO> _parser = new pb::MessageParser<ResearchComponentDTO>(() => new ResearchComponentDTO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ResearchComponentDTO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ingweland.Fog.Inn.Models.Hoh.ResearchComponentDtoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResearchComponentDTO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResearchComponentDTO(ResearchComponentDTO other) : this() {
      id_ = other.id_;
      details_ = other.details_ != null ? other.details_.Clone() : null;
      rewards_ = other.rewards_ != null ? other.rewards_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResearchComponentDTO Clone() {
      return new ResearchComponentDTO(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "details" field.</summary>
    public const int DetailsFieldNumber = 3;
    private global::Ingweland.Fog.Inn.Models.Hoh.ResearchDetailsDto details_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Ingweland.Fog.Inn.Models.Hoh.ResearchDetailsDto Details {
      get { return details_; }
      set {
        details_ = value;
      }
    }

    /// <summary>Field number for the "rewards" field.</summary>
    public const int RewardsFieldNumber = 4;
    private global::Ingweland.Fog.Inn.Models.Hoh.ResearchRewardsDto rewards_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Ingweland.Fog.Inn.Models.Hoh.ResearchRewardsDto Rewards {
      get { return rewards_; }
      set {
        rewards_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ResearchComponentDTO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ResearchComponentDTO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(Details, other.Details)) return false;
      if (!object.Equals(Rewards, other.Rewards)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (details_ != null) hash ^= Details.GetHashCode();
      if (rewards_ != null) hash ^= Rewards.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (details_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Details);
      }
      if (rewards_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Rewards);
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (details_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Details);
      }
      if (rewards_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Rewards);
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
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (details_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Details);
      }
      if (rewards_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rewards);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ResearchComponentDTO other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.details_ != null) {
        if (details_ == null) {
          Details = new global::Ingweland.Fog.Inn.Models.Hoh.ResearchDetailsDto();
        }
        Details.MergeFrom(other.Details);
      }
      if (other.rewards_ != null) {
        if (rewards_ == null) {
          Rewards = new global::Ingweland.Fog.Inn.Models.Hoh.ResearchRewardsDto();
        }
        Rewards.MergeFrom(other.Rewards);
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
            Id = input.ReadString();
            break;
          }
          case 26: {
            if (details_ == null) {
              Details = new global::Ingweland.Fog.Inn.Models.Hoh.ResearchDetailsDto();
            }
            input.ReadMessage(Details);
            break;
          }
          case 34: {
            if (rewards_ == null) {
              Rewards = new global::Ingweland.Fog.Inn.Models.Hoh.ResearchRewardsDto();
            }
            input.ReadMessage(Rewards);
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
            Id = input.ReadString();
            break;
          }
          case 26: {
            if (details_ == null) {
              Details = new global::Ingweland.Fog.Inn.Models.Hoh.ResearchDetailsDto();
            }
            input.ReadMessage(Details);
            break;
          }
          case 34: {
            if (rewards_ == null) {
              Rewards = new global::Ingweland.Fog.Inn.Models.Hoh.ResearchRewardsDto();
            }
            input.ReadMessage(Rewards);
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
