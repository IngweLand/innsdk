// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: upgrade_component_dto.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Ingweland.Fog.Inn.Models.Hoh {

  /// <summary>Holder for reflection information generated from upgrade_component_dto.proto</summary>
  public static partial class UpgradeComponentDtoReflection {

    #region Descriptor
    /// <summary>File descriptor for upgrade_component_dto.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpgradeComponentDtoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cht1cGdyYWRlX2NvbXBvbmVudF9kdG8ucHJvdG8aEmR1cmF0aW9uX2R0by5w",
            "cm90bxofYnVpbGRpbmdfcmVxdWlyZW1lbnRzX2R0by5wcm90bxoWd29ya2Vy",
            "X2NvdW50X2R0by5wcm90byK2AQoTVXBncmFkZUNvbXBvbmVudERUTxIKCgJp",
            "ZBgBIAEoCRIYChBuZXh0X2J1aWxkaW5nX2lkGAIgASgJEiIKDHVwZ3JhZGVf",
            "dGltZRgFIAEoCzIMLkR1cmF0aW9uRHRvEi4KDHJlcXVpcmVtZW50cxgHIAEo",
            "CzIYLkJ1aWxkaW5nUmVxdWlyZW1lbnRzRHRvEiUKDHdvcmtlcl9jb3VudBgK",
            "IAEoCzIPLldvcmtlckNvdW50RHRvQh+qAhxJbmd3ZWxhbmQuRm9nLklubi5N",
            "b2RlbHMuSG9oYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Ingweland.Fog.Inn.Models.Hoh.DurationDtoReflection.Descriptor, global::Ingweland.Fog.Inn.Models.Hoh.BuildingRequirementsDtoReflection.Descriptor, global::Ingweland.Fog.Inn.Models.Hoh.WorkerCountDtoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Ingweland.Fog.Inn.Models.Hoh.UpgradeComponentDTO), global::Ingweland.Fog.Inn.Models.Hoh.UpgradeComponentDTO.Parser, new[]{ "Id", "NextBuildingId", "UpgradeTime", "Requirements", "WorkerCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UpgradeComponentDTO : pb::IMessage<UpgradeComponentDTO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UpgradeComponentDTO> _parser = new pb::MessageParser<UpgradeComponentDTO>(() => new UpgradeComponentDTO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UpgradeComponentDTO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ingweland.Fog.Inn.Models.Hoh.UpgradeComponentDtoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpgradeComponentDTO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpgradeComponentDTO(UpgradeComponentDTO other) : this() {
      id_ = other.id_;
      nextBuildingId_ = other.nextBuildingId_;
      upgradeTime_ = other.upgradeTime_ != null ? other.upgradeTime_.Clone() : null;
      requirements_ = other.requirements_ != null ? other.requirements_.Clone() : null;
      workerCount_ = other.workerCount_ != null ? other.workerCount_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpgradeComponentDTO Clone() {
      return new UpgradeComponentDTO(this);
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

    /// <summary>Field number for the "next_building_id" field.</summary>
    public const int NextBuildingIdFieldNumber = 2;
    private string nextBuildingId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NextBuildingId {
      get { return nextBuildingId_; }
      set {
        nextBuildingId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "upgrade_time" field.</summary>
    public const int UpgradeTimeFieldNumber = 5;
    private global::Ingweland.Fog.Inn.Models.Hoh.DurationDto upgradeTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Ingweland.Fog.Inn.Models.Hoh.DurationDto UpgradeTime {
      get { return upgradeTime_; }
      set {
        upgradeTime_ = value;
      }
    }

    /// <summary>Field number for the "requirements" field.</summary>
    public const int RequirementsFieldNumber = 7;
    private global::Ingweland.Fog.Inn.Models.Hoh.BuildingRequirementsDto requirements_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Ingweland.Fog.Inn.Models.Hoh.BuildingRequirementsDto Requirements {
      get { return requirements_; }
      set {
        requirements_ = value;
      }
    }

    /// <summary>Field number for the "worker_count" field.</summary>
    public const int WorkerCountFieldNumber = 10;
    private global::Ingweland.Fog.Inn.Models.Hoh.WorkerCountDto workerCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Ingweland.Fog.Inn.Models.Hoh.WorkerCountDto WorkerCount {
      get { return workerCount_; }
      set {
        workerCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UpgradeComponentDTO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UpgradeComponentDTO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (NextBuildingId != other.NextBuildingId) return false;
      if (!object.Equals(UpgradeTime, other.UpgradeTime)) return false;
      if (!object.Equals(Requirements, other.Requirements)) return false;
      if (!object.Equals(WorkerCount, other.WorkerCount)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (NextBuildingId.Length != 0) hash ^= NextBuildingId.GetHashCode();
      if (upgradeTime_ != null) hash ^= UpgradeTime.GetHashCode();
      if (requirements_ != null) hash ^= Requirements.GetHashCode();
      if (workerCount_ != null) hash ^= WorkerCount.GetHashCode();
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
      if (NextBuildingId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextBuildingId);
      }
      if (upgradeTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UpgradeTime);
      }
      if (requirements_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Requirements);
      }
      if (workerCount_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(WorkerCount);
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
      if (NextBuildingId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextBuildingId);
      }
      if (upgradeTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UpgradeTime);
      }
      if (requirements_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Requirements);
      }
      if (workerCount_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(WorkerCount);
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
      if (NextBuildingId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextBuildingId);
      }
      if (upgradeTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpgradeTime);
      }
      if (requirements_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Requirements);
      }
      if (workerCount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(WorkerCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UpgradeComponentDTO other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.NextBuildingId.Length != 0) {
        NextBuildingId = other.NextBuildingId;
      }
      if (other.upgradeTime_ != null) {
        if (upgradeTime_ == null) {
          UpgradeTime = new global::Ingweland.Fog.Inn.Models.Hoh.DurationDto();
        }
        UpgradeTime.MergeFrom(other.UpgradeTime);
      }
      if (other.requirements_ != null) {
        if (requirements_ == null) {
          Requirements = new global::Ingweland.Fog.Inn.Models.Hoh.BuildingRequirementsDto();
        }
        Requirements.MergeFrom(other.Requirements);
      }
      if (other.workerCount_ != null) {
        if (workerCount_ == null) {
          WorkerCount = new global::Ingweland.Fog.Inn.Models.Hoh.WorkerCountDto();
        }
        WorkerCount.MergeFrom(other.WorkerCount);
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
          case 18: {
            NextBuildingId = input.ReadString();
            break;
          }
          case 42: {
            if (upgradeTime_ == null) {
              UpgradeTime = new global::Ingweland.Fog.Inn.Models.Hoh.DurationDto();
            }
            input.ReadMessage(UpgradeTime);
            break;
          }
          case 58: {
            if (requirements_ == null) {
              Requirements = new global::Ingweland.Fog.Inn.Models.Hoh.BuildingRequirementsDto();
            }
            input.ReadMessage(Requirements);
            break;
          }
          case 82: {
            if (workerCount_ == null) {
              WorkerCount = new global::Ingweland.Fog.Inn.Models.Hoh.WorkerCountDto();
            }
            input.ReadMessage(WorkerCount);
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
          case 18: {
            NextBuildingId = input.ReadString();
            break;
          }
          case 42: {
            if (upgradeTime_ == null) {
              UpgradeTime = new global::Ingweland.Fog.Inn.Models.Hoh.DurationDto();
            }
            input.ReadMessage(UpgradeTime);
            break;
          }
          case 58: {
            if (requirements_ == null) {
              Requirements = new global::Ingweland.Fog.Inn.Models.Hoh.BuildingRequirementsDto();
            }
            input.ReadMessage(Requirements);
            break;
          }
          case 82: {
            if (workerCount_ == null) {
              WorkerCount = new global::Ingweland.Fog.Inn.Models.Hoh.WorkerCountDto();
            }
            input.ReadMessage(WorkerCount);
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
