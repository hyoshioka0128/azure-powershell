// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.PowerShell;

    /// <summary>The init container definition properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(InitContainerPropertiesDefinitionTypeConverter))]
    public partial class InitContainerPropertiesDefinition
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.InitContainerPropertiesDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinition"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinition DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InitContainerPropertiesDefinition(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.InitContainerPropertiesDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinition"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinition DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InitContainerPropertiesDefinition(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InitContainerPropertiesDefinition" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="InitContainerPropertiesDefinition" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinition FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.InitContainerPropertiesDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InitContainerPropertiesDefinition(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("InstanceView"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceView = (Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInstanceView) content.GetValueForProperty("InstanceView",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceView, Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.InitContainerPropertiesDefinitionInstanceViewTypeConverter.ConvertFrom);
            }
            if (content.Contains("Image"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).Image = (string) content.GetValueForProperty("Image",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).Image, global::System.Convert.ToString);
            }
            if (content.Contains("Command"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).Command = (string[]) content.GetValueForProperty("Command",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).Command, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("EnvironmentVariable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).EnvironmentVariable = (Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IEnvironmentVariable[]) content.GetValueForProperty("EnvironmentVariable",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).EnvironmentVariable, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IEnvironmentVariable>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.EnvironmentVariableTypeConverter.ConvertFrom));
            }
            if (content.Contains("VolumeMount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).VolumeMount = (Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IVolumeMount[]) content.GetValueForProperty("VolumeMount",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).VolumeMount, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IVolumeMount>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.VolumeMountTypeConverter.ConvertFrom));
            }
            if (content.Contains("InstanceViewCurrentState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewCurrentState = (Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IContainerState) content.GetValueForProperty("InstanceViewCurrentState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewCurrentState, Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ContainerStateTypeConverter.ConvertFrom);
            }
            if (content.Contains("InstanceViewPreviousState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewPreviousState = (Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IContainerState) content.GetValueForProperty("InstanceViewPreviousState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewPreviousState, Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ContainerStateTypeConverter.ConvertFrom);
            }
            if (content.Contains("InstanceViewRestartCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewRestartCount = (int?) content.GetValueForProperty("InstanceViewRestartCount",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewRestartCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("InstanceViewEvent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewEvent = (Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IEvent[]) content.GetValueForProperty("InstanceViewEvent",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewEvent, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IEvent>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.EventTypeConverter.ConvertFrom));
            }
            if (content.Contains("CurrentState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentState = (string) content.GetValueForProperty("CurrentState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentState, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentStateStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateStartTime = (global::System.DateTime?) content.GetValueForProperty("CurrentStateStartTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CurrentStateExitCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateExitCode = (int?) content.GetValueForProperty("CurrentStateExitCode",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateExitCode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CurrentStateFinishTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateFinishTime = (global::System.DateTime?) content.GetValueForProperty("CurrentStateFinishTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateFinishTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CurrentStateDetailStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateDetailStatus = (string) content.GetValueForProperty("CurrentStateDetailStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateDetailStatus, global::System.Convert.ToString);
            }
            if (content.Contains("PreviouState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouState = (string) content.GetValueForProperty("PreviouState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouState, global::System.Convert.ToString);
            }
            if (content.Contains("PreviouStateStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateStartTime = (global::System.DateTime?) content.GetValueForProperty("PreviouStateStartTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PreviouStateExitCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateExitCode = (int?) content.GetValueForProperty("PreviouStateExitCode",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateExitCode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("PreviouStateFinishTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateFinishTime = (global::System.DateTime?) content.GetValueForProperty("PreviouStateFinishTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateFinishTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PreviouStateDetailStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateDetailStatus = (string) content.GetValueForProperty("PreviouStateDetailStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateDetailStatus, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.InitContainerPropertiesDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InitContainerPropertiesDefinition(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("InstanceView"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceView = (Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInstanceView) content.GetValueForProperty("InstanceView",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceView, Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.InitContainerPropertiesDefinitionInstanceViewTypeConverter.ConvertFrom);
            }
            if (content.Contains("Image"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).Image = (string) content.GetValueForProperty("Image",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).Image, global::System.Convert.ToString);
            }
            if (content.Contains("Command"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).Command = (string[]) content.GetValueForProperty("Command",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).Command, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("EnvironmentVariable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).EnvironmentVariable = (Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IEnvironmentVariable[]) content.GetValueForProperty("EnvironmentVariable",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).EnvironmentVariable, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IEnvironmentVariable>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.EnvironmentVariableTypeConverter.ConvertFrom));
            }
            if (content.Contains("VolumeMount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).VolumeMount = (Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IVolumeMount[]) content.GetValueForProperty("VolumeMount",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).VolumeMount, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IVolumeMount>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.VolumeMountTypeConverter.ConvertFrom));
            }
            if (content.Contains("InstanceViewCurrentState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewCurrentState = (Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IContainerState) content.GetValueForProperty("InstanceViewCurrentState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewCurrentState, Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ContainerStateTypeConverter.ConvertFrom);
            }
            if (content.Contains("InstanceViewPreviousState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewPreviousState = (Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IContainerState) content.GetValueForProperty("InstanceViewPreviousState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewPreviousState, Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ContainerStateTypeConverter.ConvertFrom);
            }
            if (content.Contains("InstanceViewRestartCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewRestartCount = (int?) content.GetValueForProperty("InstanceViewRestartCount",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewRestartCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("InstanceViewEvent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewEvent = (Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IEvent[]) content.GetValueForProperty("InstanceViewEvent",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).InstanceViewEvent, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IEvent>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.EventTypeConverter.ConvertFrom));
            }
            if (content.Contains("CurrentState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentState = (string) content.GetValueForProperty("CurrentState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentState, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentStateStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateStartTime = (global::System.DateTime?) content.GetValueForProperty("CurrentStateStartTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CurrentStateExitCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateExitCode = (int?) content.GetValueForProperty("CurrentStateExitCode",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateExitCode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CurrentStateFinishTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateFinishTime = (global::System.DateTime?) content.GetValueForProperty("CurrentStateFinishTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateFinishTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CurrentStateDetailStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateDetailStatus = (string) content.GetValueForProperty("CurrentStateDetailStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).CurrentStateDetailStatus, global::System.Convert.ToString);
            }
            if (content.Contains("PreviouState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouState = (string) content.GetValueForProperty("PreviouState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouState, global::System.Convert.ToString);
            }
            if (content.Contains("PreviouStateStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateStartTime = (global::System.DateTime?) content.GetValueForProperty("PreviouStateStartTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PreviouStateExitCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateExitCode = (int?) content.GetValueForProperty("PreviouStateExitCode",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateExitCode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("PreviouStateFinishTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateFinishTime = (global::System.DateTime?) content.GetValueForProperty("PreviouStateFinishTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateFinishTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PreviouStateDetailStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateDetailStatus = (string) content.GetValueForProperty("PreviouStateDetailStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IInitContainerPropertiesDefinitionInternal)this).PreviouStateDetailStatus, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The init container definition properties.
    [System.ComponentModel.TypeConverter(typeof(InitContainerPropertiesDefinitionTypeConverter))]
    public partial interface IInitContainerPropertiesDefinition

    {

    }
}