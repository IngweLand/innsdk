// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: hero_unit_stat_formula_definition_dto.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Ingweland.Fog.Inn.Models.Hoh {

  /// <summary>Holder for reflection information generated from hero_unit_stat_formula_definition_dto.proto</summary>
  public static partial class HeroUnitStatFormulaDefinitionDtoReflection {

    #region Descriptor
    /// <summary>File descriptor for hero_unit_stat_formula_definition_dto.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeroUnitStatFormulaDefinitionDtoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitoZXJvX3VuaXRfc3RhdF9mb3JtdWxhX2RlZmluaXRpb25fZHRvLnByb3Rv",
            "IrABCiBIZXJvVW5pdFN0YXRGb3JtdWxhRGVmaW5pdGlvbkRUTxIKCgJpZBgB",
            "IAEoCRI2CgR1bml0GAIgASgLMiguSGVyb1VuaXRTdGF0Rm9ybXVsYURlZmlu",
            "aXRpb25GYWN0b3JzRHRvEkgKDHJhcml0eV91bml0cxgDIAMoCzIyLkhlcm9V",
            "bml0U3RhdEZvcm11bGFEZWZpbml0aW9uVW5pdFJhcml0eUZhY3RvcnNEdG8i",
            "gQEKMUhlcm9Vbml0U3RhdEZvcm11bGFEZWZpbml0aW9uVW5pdFJhcml0eUZh",
            "Y3RvcnNEdG8SEQoJcmFyaXR5X2lkGAEgASgJEjkKB2ZhY3RvcnMYAiABKAsy",
            "KC5IZXJvVW5pdFN0YXRGb3JtdWxhRGVmaW5pdGlvbkZhY3RvcnNEdG8iTAon",
            "SGVyb1VuaXRTdGF0Rm9ybXVsYURlZmluaXRpb25GYWN0b3JzRHRvEg4KBm5v",
            "cm1hbBgBIAEoAhIRCglhc2NlbnNpb24YAiABKAJCH6oCHEluZ3dlbGFuZC5G",
            "b2cuSW5uLk1vZGVscy5Ib2hiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionDTO), global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionDTO.Parser, new[]{ "Id", "Unit", "RarityUnits" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionUnitRarityFactorsDto), global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionUnitRarityFactorsDto.Parser, new[]{ "RarityId", "Factors" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionFactorsDto), global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionFactorsDto.Parser, new[]{ "Normal", "Ascension" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HeroUnitStatFormulaDefinitionDTO : pb::IMessage<HeroUnitStatFormulaDefinitionDTO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HeroUnitStatFormulaDefinitionDTO> _parser = new pb::MessageParser<HeroUnitStatFormulaDefinitionDTO>(() => new HeroUnitStatFormulaDefinitionDTO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HeroUnitStatFormulaDefinitionDTO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionDtoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroUnitStatFormulaDefinitionDTO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroUnitStatFormulaDefinitionDTO(HeroUnitStatFormulaDefinitionDTO other) : this() {
      id_ = other.id_;
      unit_ = other.unit_ != null ? other.unit_.Clone() : null;
      rarityUnits_ = other.rarityUnits_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroUnitStatFormulaDefinitionDTO Clone() {
      return new HeroUnitStatFormulaDefinitionDTO(this);
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

    /// <summary>Field number for the "unit" field.</summary>
    public const int UnitFieldNumber = 2;
    private global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionFactorsDto unit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionFactorsDto Unit {
      get { return unit_; }
      set {
        unit_ = value;
      }
    }

    /// <summary>Field number for the "rarity_units" field.</summary>
    public const int RarityUnitsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionUnitRarityFactorsDto> _repeated_rarityUnits_codec
        = pb::FieldCodec.ForMessage(26, global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionUnitRarityFactorsDto.Parser);
    private readonly pbc::RepeatedField<global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionUnitRarityFactorsDto> rarityUnits_ = new pbc::RepeatedField<global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionUnitRarityFactorsDto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionUnitRarityFactorsDto> RarityUnits {
      get { return rarityUnits_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HeroUnitStatFormulaDefinitionDTO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HeroUnitStatFormulaDefinitionDTO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(Unit, other.Unit)) return false;
      if(!rarityUnits_.Equals(other.rarityUnits_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (unit_ != null) hash ^= Unit.GetHashCode();
      hash ^= rarityUnits_.GetHashCode();
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
      if (unit_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Unit);
      }
      rarityUnits_.WriteTo(output, _repeated_rarityUnits_codec);
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
      if (unit_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Unit);
      }
      rarityUnits_.WriteTo(ref output, _repeated_rarityUnits_codec);
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
      if (unit_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unit);
      }
      size += rarityUnits_.CalculateSize(_repeated_rarityUnits_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HeroUnitStatFormulaDefinitionDTO other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.unit_ != null) {
        if (unit_ == null) {
          Unit = new global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionFactorsDto();
        }
        Unit.MergeFrom(other.Unit);
      }
      rarityUnits_.Add(other.rarityUnits_);
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
            if (unit_ == null) {
              Unit = new global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionFactorsDto();
            }
            input.ReadMessage(Unit);
            break;
          }
          case 26: {
            rarityUnits_.AddEntriesFrom(input, _repeated_rarityUnits_codec);
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
            if (unit_ == null) {
              Unit = new global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionFactorsDto();
            }
            input.ReadMessage(Unit);
            break;
          }
          case 26: {
            rarityUnits_.AddEntriesFrom(ref input, _repeated_rarityUnits_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HeroUnitStatFormulaDefinitionUnitRarityFactorsDto : pb::IMessage<HeroUnitStatFormulaDefinitionUnitRarityFactorsDto>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HeroUnitStatFormulaDefinitionUnitRarityFactorsDto> _parser = new pb::MessageParser<HeroUnitStatFormulaDefinitionUnitRarityFactorsDto>(() => new HeroUnitStatFormulaDefinitionUnitRarityFactorsDto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HeroUnitStatFormulaDefinitionUnitRarityFactorsDto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionDtoReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroUnitStatFormulaDefinitionUnitRarityFactorsDto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroUnitStatFormulaDefinitionUnitRarityFactorsDto(HeroUnitStatFormulaDefinitionUnitRarityFactorsDto other) : this() {
      rarityId_ = other.rarityId_;
      factors_ = other.factors_ != null ? other.factors_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroUnitStatFormulaDefinitionUnitRarityFactorsDto Clone() {
      return new HeroUnitStatFormulaDefinitionUnitRarityFactorsDto(this);
    }

    /// <summary>Field number for the "rarity_id" field.</summary>
    public const int RarityIdFieldNumber = 1;
    private string rarityId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RarityId {
      get { return rarityId_; }
      set {
        rarityId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "factors" field.</summary>
    public const int FactorsFieldNumber = 2;
    private global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionFactorsDto factors_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionFactorsDto Factors {
      get { return factors_; }
      set {
        factors_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HeroUnitStatFormulaDefinitionUnitRarityFactorsDto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HeroUnitStatFormulaDefinitionUnitRarityFactorsDto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RarityId != other.RarityId) return false;
      if (!object.Equals(Factors, other.Factors)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RarityId.Length != 0) hash ^= RarityId.GetHashCode();
      if (factors_ != null) hash ^= Factors.GetHashCode();
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
      if (RarityId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RarityId);
      }
      if (factors_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Factors);
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
      if (RarityId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RarityId);
      }
      if (factors_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Factors);
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
      if (RarityId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RarityId);
      }
      if (factors_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Factors);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HeroUnitStatFormulaDefinitionUnitRarityFactorsDto other) {
      if (other == null) {
        return;
      }
      if (other.RarityId.Length != 0) {
        RarityId = other.RarityId;
      }
      if (other.factors_ != null) {
        if (factors_ == null) {
          Factors = new global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionFactorsDto();
        }
        Factors.MergeFrom(other.Factors);
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
            RarityId = input.ReadString();
            break;
          }
          case 18: {
            if (factors_ == null) {
              Factors = new global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionFactorsDto();
            }
            input.ReadMessage(Factors);
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
            RarityId = input.ReadString();
            break;
          }
          case 18: {
            if (factors_ == null) {
              Factors = new global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionFactorsDto();
            }
            input.ReadMessage(Factors);
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HeroUnitStatFormulaDefinitionFactorsDto : pb::IMessage<HeroUnitStatFormulaDefinitionFactorsDto>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HeroUnitStatFormulaDefinitionFactorsDto> _parser = new pb::MessageParser<HeroUnitStatFormulaDefinitionFactorsDto>(() => new HeroUnitStatFormulaDefinitionFactorsDto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HeroUnitStatFormulaDefinitionFactorsDto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ingweland.Fog.Inn.Models.Hoh.HeroUnitStatFormulaDefinitionDtoReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroUnitStatFormulaDefinitionFactorsDto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroUnitStatFormulaDefinitionFactorsDto(HeroUnitStatFormulaDefinitionFactorsDto other) : this() {
      normal_ = other.normal_;
      ascension_ = other.ascension_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroUnitStatFormulaDefinitionFactorsDto Clone() {
      return new HeroUnitStatFormulaDefinitionFactorsDto(this);
    }

    /// <summary>Field number for the "normal" field.</summary>
    public const int NormalFieldNumber = 1;
    private float normal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Normal {
      get { return normal_; }
      set {
        normal_ = value;
      }
    }

    /// <summary>Field number for the "ascension" field.</summary>
    public const int AscensionFieldNumber = 2;
    private float ascension_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Ascension {
      get { return ascension_; }
      set {
        ascension_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HeroUnitStatFormulaDefinitionFactorsDto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HeroUnitStatFormulaDefinitionFactorsDto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Normal, other.Normal)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Ascension, other.Ascension)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Normal != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Normal);
      if (Ascension != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Ascension);
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
      if (Normal != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Normal);
      }
      if (Ascension != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Ascension);
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
      if (Normal != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Normal);
      }
      if (Ascension != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Ascension);
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
      if (Normal != 0F) {
        size += 1 + 4;
      }
      if (Ascension != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HeroUnitStatFormulaDefinitionFactorsDto other) {
      if (other == null) {
        return;
      }
      if (other.Normal != 0F) {
        Normal = other.Normal;
      }
      if (other.Ascension != 0F) {
        Ascension = other.Ascension;
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
          case 13: {
            Normal = input.ReadFloat();
            break;
          }
          case 21: {
            Ascension = input.ReadFloat();
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
          case 13: {
            Normal = input.ReadFloat();
            break;
          }
          case 21: {
            Ascension = input.ReadFloat();
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
