// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mlagents_envs/communicator_objects/observation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Unity.MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from mlagents_envs/communicator_objects/observation.proto</summary>
  internal static partial class ObservationReflection {

    #region Descriptor
    /// <summary>File descriptor for mlagents_envs/communicator_objects/observation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ObservationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRtbGFnZW50c19lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL29ic2VydmF0",
            "aW9uLnByb3RvEhRjb21tdW5pY2F0b3Jfb2JqZWN0cyKPAwoQT2JzZXJ2YXRp",
            "b25Qcm90bxINCgVzaGFwZRgBIAMoBRJEChBjb21wcmVzc2lvbl90eXBlGAIg",
            "ASgOMiouY29tbXVuaWNhdG9yX29iamVjdHMuQ29tcHJlc3Npb25UeXBlUHJv",
            "dG8SGQoPY29tcHJlc3NlZF9kYXRhGAMgASgMSAASRgoKZmxvYXRfZGF0YRgE",
            "IAEoCzIwLmNvbW11bmljYXRvcl9vYmplY3RzLk9ic2VydmF0aW9uUHJvdG8u",
            "RmxvYXREYXRhSAASIgoaY29tcHJlc3NlZF9jaGFubmVsX21hcHBpbmcYBSAD",
            "KAUSHAoUZGltZW5zaW9uX3Byb3BlcnRpZXMYBiADKAUSRAoQb2JzZXJ2YXRp",
            "b25fdHlwZRgHIAEoDjIqLmNvbW11bmljYXRvcl9vYmplY3RzLk9ic2VydmF0",
            "aW9uVHlwZVByb3RvEgwKBG5hbWUYCCABKAkaGQoJRmxvYXREYXRhEgwKBGRh",
            "dGEYASADKAJCEgoQb2JzZXJ2YXRpb25fZGF0YSopChRDb21wcmVzc2lvblR5",
            "cGVQcm90bxIICgROT05FEAASBwoDUE5HEAEqQAoUT2JzZXJ2YXRpb25UeXBl",
            "UHJvdG8SCwoHREVGQVVMVBAAEg8KC0dPQUxfU0lHTkFMEAEiBAgCEAIiBAgD",
            "EANCJaoCIlVuaXR5Lk1MQWdlbnRzLkNvbW11bmljYXRvck9iamVjdHNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Unity.MLAgents.CommunicatorObjects.CompressionTypeProto), typeof(global::Unity.MLAgents.CommunicatorObjects.ObservationTypeProto), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Unity.MLAgents.CommunicatorObjects.ObservationProto), global::Unity.MLAgents.CommunicatorObjects.ObservationProto.Parser, new[]{ "Shape", "CompressionType", "CompressedData", "FloatData", "CompressedChannelMapping", "DimensionProperties", "ObservationType", "Name" }, new[]{ "ObservationData" }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Unity.MLAgents.CommunicatorObjects.ObservationProto.Types.FloatData), global::Unity.MLAgents.CommunicatorObjects.ObservationProto.Types.FloatData.Parser, new[]{ "Data" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Enums
  internal enum CompressionTypeProto {
    [pbr::OriginalName("NONE")] None = 0,
    [pbr::OriginalName("PNG")] Png = 1,
  }

  internal enum ObservationTypeProto {
    [pbr::OriginalName("DEFAULT")] Default = 0,
    [pbr::OriginalName("GOAL_SIGNAL")] GoalSignal = 1,
  }

  #endregion

  #region Messages
  internal sealed partial class ObservationProto : pb::IMessage<ObservationProto> {
    private static readonly pb::MessageParser<ObservationProto> _parser = new pb::MessageParser<ObservationProto>(() => new ObservationProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ObservationProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Unity.MLAgents.CommunicatorObjects.ObservationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObservationProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObservationProto(ObservationProto other) : this() {
      shape_ = other.shape_.Clone();
      compressionType_ = other.compressionType_;
      compressedChannelMapping_ = other.compressedChannelMapping_.Clone();
      dimensionProperties_ = other.dimensionProperties_.Clone();
      observationType_ = other.observationType_;
      name_ = other.name_;
      switch (other.ObservationDataCase) {
        case ObservationDataOneofCase.CompressedData:
          CompressedData = other.CompressedData;
          break;
        case ObservationDataOneofCase.FloatData:
          FloatData = other.FloatData.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObservationProto Clone() {
      return new ObservationProto(this);
    }

    /// <summary>Field number for the "shape" field.</summary>
    public const int ShapeFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_shape_codec
        = pb::FieldCodec.ForInt32(10);
    private readonly pbc::RepeatedField<int> shape_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Shape {
      get { return shape_; }
    }

    /// <summary>Field number for the "compression_type" field.</summary>
    public const int CompressionTypeFieldNumber = 2;
    private global::Unity.MLAgents.CommunicatorObjects.CompressionTypeProto compressionType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Unity.MLAgents.CommunicatorObjects.CompressionTypeProto CompressionType {
      get { return compressionType_; }
      set {
        compressionType_ = value;
      }
    }

    /// <summary>Field number for the "compressed_data" field.</summary>
    public const int CompressedDataFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString CompressedData {
      get { return observationDataCase_ == ObservationDataOneofCase.CompressedData ? (pb::ByteString) observationData_ : pb::ByteString.Empty; }
      set {
        observationData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        observationDataCase_ = ObservationDataOneofCase.CompressedData;
      }
    }

    /// <summary>Field number for the "float_data" field.</summary>
    public const int FloatDataFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Unity.MLAgents.CommunicatorObjects.ObservationProto.Types.FloatData FloatData {
      get { return observationDataCase_ == ObservationDataOneofCase.FloatData ? (global::Unity.MLAgents.CommunicatorObjects.ObservationProto.Types.FloatData) observationData_ : null; }
      set {
        observationData_ = value;
        observationDataCase_ = value == null ? ObservationDataOneofCase.None : ObservationDataOneofCase.FloatData;
      }
    }

    /// <summary>Field number for the "compressed_channel_mapping" field.</summary>
    public const int CompressedChannelMappingFieldNumber = 5;
    private static readonly pb::FieldCodec<int> _repeated_compressedChannelMapping_codec
        = pb::FieldCodec.ForInt32(42);
    private readonly pbc::RepeatedField<int> compressedChannelMapping_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> CompressedChannelMapping {
      get { return compressedChannelMapping_; }
    }

    /// <summary>Field number for the "dimension_properties" field.</summary>
    public const int DimensionPropertiesFieldNumber = 6;
    private static readonly pb::FieldCodec<int> _repeated_dimensionProperties_codec
        = pb::FieldCodec.ForInt32(50);
    private readonly pbc::RepeatedField<int> dimensionProperties_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> DimensionProperties {
      get { return dimensionProperties_; }
    }

    /// <summary>Field number for the "observation_type" field.</summary>
    public const int ObservationTypeFieldNumber = 7;
    private global::Unity.MLAgents.CommunicatorObjects.ObservationTypeProto observationType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Unity.MLAgents.CommunicatorObjects.ObservationTypeProto ObservationType {
      get { return observationType_; }
      set {
        observationType_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 8;
    private string name_ = "";
    /// <summary>
    /// Optional name of the observation.
    /// This will be set to the ISensor name when writing,
    /// and read into the ObservationSpec in the low-level API
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private object observationData_;
    /// <summary>Enum of possible cases for the "observation_data" oneof.</summary>
    public enum ObservationDataOneofCase {
      None = 0,
      CompressedData = 3,
      FloatData = 4,
    }
    private ObservationDataOneofCase observationDataCase_ = ObservationDataOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObservationDataOneofCase ObservationDataCase {
      get { return observationDataCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearObservationData() {
      observationDataCase_ = ObservationDataOneofCase.None;
      observationData_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ObservationProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ObservationProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!shape_.Equals(other.shape_)) return false;
      if (CompressionType != other.CompressionType) return false;
      if (CompressedData != other.CompressedData) return false;
      if (!object.Equals(FloatData, other.FloatData)) return false;
      if(!compressedChannelMapping_.Equals(other.compressedChannelMapping_)) return false;
      if(!dimensionProperties_.Equals(other.dimensionProperties_)) return false;
      if (ObservationType != other.ObservationType) return false;
      if (Name != other.Name) return false;
      if (ObservationDataCase != other.ObservationDataCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= shape_.GetHashCode();
      if (CompressionType != 0) hash ^= CompressionType.GetHashCode();
      if (observationDataCase_ == ObservationDataOneofCase.CompressedData) hash ^= CompressedData.GetHashCode();
      if (observationDataCase_ == ObservationDataOneofCase.FloatData) hash ^= FloatData.GetHashCode();
      hash ^= compressedChannelMapping_.GetHashCode();
      hash ^= dimensionProperties_.GetHashCode();
      if (ObservationType != 0) hash ^= ObservationType.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= (int) observationDataCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      shape_.WriteTo(output, _repeated_shape_codec);
      if (CompressionType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) CompressionType);
      }
      if (observationDataCase_ == ObservationDataOneofCase.CompressedData) {
        output.WriteRawTag(26);
        output.WriteBytes(CompressedData);
      }
      if (observationDataCase_ == ObservationDataOneofCase.FloatData) {
        output.WriteRawTag(34);
        output.WriteMessage(FloatData);
      }
      compressedChannelMapping_.WriteTo(output, _repeated_compressedChannelMapping_codec);
      dimensionProperties_.WriteTo(output, _repeated_dimensionProperties_codec);
      if (ObservationType != 0) {
        output.WriteRawTag(56);
        output.WriteEnum((int) ObservationType);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += shape_.CalculateSize(_repeated_shape_codec);
      if (CompressionType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CompressionType);
      }
      if (observationDataCase_ == ObservationDataOneofCase.CompressedData) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(CompressedData);
      }
      if (observationDataCase_ == ObservationDataOneofCase.FloatData) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FloatData);
      }
      size += compressedChannelMapping_.CalculateSize(_repeated_compressedChannelMapping_codec);
      size += dimensionProperties_.CalculateSize(_repeated_dimensionProperties_codec);
      if (ObservationType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ObservationType);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ObservationProto other) {
      if (other == null) {
        return;
      }
      shape_.Add(other.shape_);
      if (other.CompressionType != 0) {
        CompressionType = other.CompressionType;
      }
      compressedChannelMapping_.Add(other.compressedChannelMapping_);
      dimensionProperties_.Add(other.dimensionProperties_);
      if (other.ObservationType != 0) {
        ObservationType = other.ObservationType;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      switch (other.ObservationDataCase) {
        case ObservationDataOneofCase.CompressedData:
          CompressedData = other.CompressedData;
          break;
        case ObservationDataOneofCase.FloatData:
          if (FloatData == null) {
            FloatData = new global::Unity.MLAgents.CommunicatorObjects.ObservationProto.Types.FloatData();
          }
          FloatData.MergeFrom(other.FloatData);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10:
          case 8: {
            shape_.AddEntriesFrom(input, _repeated_shape_codec);
            break;
          }
          case 16: {
            compressionType_ = (global::Unity.MLAgents.CommunicatorObjects.CompressionTypeProto) input.ReadEnum();
            break;
          }
          case 26: {
            CompressedData = input.ReadBytes();
            break;
          }
          case 34: {
            global::Unity.MLAgents.CommunicatorObjects.ObservationProto.Types.FloatData subBuilder = new global::Unity.MLAgents.CommunicatorObjects.ObservationProto.Types.FloatData();
            if (observationDataCase_ == ObservationDataOneofCase.FloatData) {
              subBuilder.MergeFrom(FloatData);
            }
            input.ReadMessage(subBuilder);
            FloatData = subBuilder;
            break;
          }
          case 42:
          case 40: {
            compressedChannelMapping_.AddEntriesFrom(input, _repeated_compressedChannelMapping_codec);
            break;
          }
          case 50:
          case 48: {
            dimensionProperties_.AddEntriesFrom(input, _repeated_dimensionProperties_codec);
            break;
          }
          case 56: {
            observationType_ = (global::Unity.MLAgents.CommunicatorObjects.ObservationTypeProto) input.ReadEnum();
            break;
          }
          case 66: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ObservationProto message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      internal sealed partial class FloatData : pb::IMessage<FloatData> {
        private static readonly pb::MessageParser<FloatData> _parser = new pb::MessageParser<FloatData>(() => new FloatData());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<FloatData> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Unity.MLAgents.CommunicatorObjects.ObservationProto.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public FloatData() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public FloatData(FloatData other) : this() {
          data_ = other.data_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public FloatData Clone() {
          return new FloatData(this);
        }

        /// <summary>Field number for the "data" field.</summary>
        public const int DataFieldNumber = 1;
        private static readonly pb::FieldCodec<float> _repeated_data_codec
            = pb::FieldCodec.ForFloat(10);
        private readonly pbc::RepeatedField<float> data_ = new pbc::RepeatedField<float>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<float> Data {
          get { return data_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as FloatData);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(FloatData other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!data_.Equals(other.data_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= data_.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          data_.WriteTo(output, _repeated_data_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += data_.CalculateSize(_repeated_data_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(FloatData other) {
          if (other == null) {
            return;
          }
          data_.Add(other.data_);
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10:
              case 13: {
                data_.AddEntriesFrom(input, _repeated_data_codec);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
