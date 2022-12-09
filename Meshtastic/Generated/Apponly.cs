// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: apponly.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Meshtastic.Protobufs {

  /// <summary>Holder for reflection information generated from apponly.proto</summary>
  public static partial class ApponlyReflection {

    #region Descriptor
    /// <summary>File descriptor for apponly.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ApponlyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1hcHBvbmx5LnByb3RvGg1jaGFubmVsLnByb3RvGgxjb25maWcucHJvdG8i",
            "WQoKQ2hhbm5lbFNldBIiCghzZXR0aW5ncxgBIAMoCzIQLkNoYW5uZWxTZXR0",
            "aW5ncxInCgtsb3JhX2NvbmZpZxgCIAEoCzISLkNvbmZpZy5Mb1JhQ29uZmln",
            "QmEKE2NvbS5nZWVrc3ZpbGxlLm1lc2hCDUFwcE9ubHlQcm90b3NIA1oiZ2l0",
            "aHViLmNvbS9tZXNodGFzdGljL2dvL2dlbmVyYXRlZKoCFE1lc2h0YXN0aWMu",
            "UHJvdG9idWZzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Meshtastic.Protobufs.ChannelReflection.Descriptor, global::Meshtastic.Protobufs.ConfigReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Meshtastic.Protobufs.ChannelSet), global::Meshtastic.Protobufs.ChannelSet.Parser, new[]{ "Settings", "LoraConfig" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  /// This is the most compact possible representation for a set of channels.
  /// It includes only one PRIMARY channel (which must be first) and
  /// any SECONDARY channels.
  /// No DISABLED channels are included.
  /// This abstraction is used only on the the 'app side' of the world (ie python, javascript and android etc) to show a group of Channels as a (long) URL
  /// </summary>
  public sealed partial class ChannelSet : pb::IMessage<ChannelSet>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChannelSet> _parser = new pb::MessageParser<ChannelSet>(() => new ChannelSet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChannelSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Meshtastic.Protobufs.ApponlyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelSet(ChannelSet other) : this() {
      settings_ = other.settings_.Clone();
      loraConfig_ = other.loraConfig_ != null ? other.loraConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelSet Clone() {
      return new ChannelSet(this);
    }

    /// <summary>Field number for the "settings" field.</summary>
    public const int SettingsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Meshtastic.Protobufs.ChannelSettings> _repeated_settings_codec
        = pb::FieldCodec.ForMessage(10, global::Meshtastic.Protobufs.ChannelSettings.Parser);
    private readonly pbc::RepeatedField<global::Meshtastic.Protobufs.ChannelSettings> settings_ = new pbc::RepeatedField<global::Meshtastic.Protobufs.ChannelSettings>();
    /// <summary>
    ///
    /// Channel list with settings
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Meshtastic.Protobufs.ChannelSettings> Settings {
      get { return settings_; }
    }

    /// <summary>Field number for the "lora_config" field.</summary>
    public const int LoraConfigFieldNumber = 2;
    private global::Meshtastic.Protobufs.Config.Types.LoRaConfig loraConfig_;
    /// <summary>
    ///
    /// LoRa config
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Meshtastic.Protobufs.Config.Types.LoRaConfig LoraConfig {
      get { return loraConfig_; }
      set {
        loraConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChannelSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChannelSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!settings_.Equals(other.settings_)) return false;
      if (!object.Equals(LoraConfig, other.LoraConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= settings_.GetHashCode();
      if (loraConfig_ != null) hash ^= LoraConfig.GetHashCode();
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
      settings_.WriteTo(output, _repeated_settings_codec);
      if (loraConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LoraConfig);
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
      settings_.WriteTo(ref output, _repeated_settings_codec);
      if (loraConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LoraConfig);
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
      size += settings_.CalculateSize(_repeated_settings_codec);
      if (loraConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LoraConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChannelSet other) {
      if (other == null) {
        return;
      }
      settings_.Add(other.settings_);
      if (other.loraConfig_ != null) {
        if (loraConfig_ == null) {
          LoraConfig = new global::Meshtastic.Protobufs.Config.Types.LoRaConfig();
        }
        LoraConfig.MergeFrom(other.LoraConfig);
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
            settings_.AddEntriesFrom(input, _repeated_settings_codec);
            break;
          }
          case 18: {
            if (loraConfig_ == null) {
              LoraConfig = new global::Meshtastic.Protobufs.Config.Types.LoRaConfig();
            }
            input.ReadMessage(LoraConfig);
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
            settings_.AddEntriesFrom(ref input, _repeated_settings_codec);
            break;
          }
          case 18: {
            if (loraConfig_ == null) {
              LoraConfig = new global::Meshtastic.Protobufs.Config.Types.LoRaConfig();
            }
            input.ReadMessage(LoraConfig);
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