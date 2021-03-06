// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Momentum.Mea.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class FieldInfo
    {
        /// <summary>
        /// Initializes a new instance of the FieldInfo class.
        /// </summary>
        public FieldInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FieldInfo class.
        /// </summary>
        /// <param name="memberType">Possible values include: 'Constructor',
        /// 'Event', 'Field', 'Method', 'Property', 'TypeInfo', 'Custom',
        /// 'NestedType', 'All'</param>
        /// <param name="attributes">Possible values include: 'PrivateScope',
        /// 'Private', 'FamANDAssem', 'Assembly', 'Family', 'FamORAssem',
        /// 'Public', 'FieldAccessMask', 'Static', 'InitOnly', 'Literal',
        /// 'NotSerialized', 'HasFieldRVA', 'SpecialName', 'RTSpecialName',
        /// 'HasFieldMarshal', 'PinvokeImpl', 'HasDefault',
        /// 'ReservedMask'</param>
        /// <param name="fieldType"></param>
        /// <param name="isInitOnly"></param>
        /// <param name="isLiteral"></param>
        /// <param name="isNotSerialized"></param>
        /// <param name="isPinvokeImpl"></param>
        /// <param name="isSpecialName"></param>
        /// <param name="isStatic"></param>
        /// <param name="isAssembly"></param>
        /// <param name="isFamily"></param>
        /// <param name="isFamilyAndAssembly"></param>
        /// <param name="isFamilyOrAssembly"></param>
        /// <param name="isPrivate"></param>
        /// <param name="isPublic"></param>
        /// <param name="isSecurityCritical"></param>
        /// <param name="isSecuritySafeCritical"></param>
        /// <param name="isSecurityTransparent"></param>
        /// <param name="fieldHandle"></param>
        /// <param name="name"></param>
        /// <param name="declaringType"></param>
        /// <param name="reflectedType"></param>
        /// <param name="module"></param>
        /// <param name="customAttributes"></param>
        /// <param name="isCollectible"></param>
        /// <param name="metadataToken"></param>
        public FieldInfo(string memberType = default(string), string attributes = default(string), Type fieldType = default(Type), bool? isInitOnly = default(bool?), bool? isLiteral = default(bool?), bool? isNotSerialized = default(bool?), bool? isPinvokeImpl = default(bool?), bool? isSpecialName = default(bool?), bool? isStatic = default(bool?), bool? isAssembly = default(bool?), bool? isFamily = default(bool?), bool? isFamilyAndAssembly = default(bool?), bool? isFamilyOrAssembly = default(bool?), bool? isPrivate = default(bool?), bool? isPublic = default(bool?), bool? isSecurityCritical = default(bool?), bool? isSecuritySafeCritical = default(bool?), bool? isSecurityTransparent = default(bool?), RuntimeFieldHandle fieldHandle = default(RuntimeFieldHandle), string name = default(string), Type declaringType = default(Type), Type reflectedType = default(Type), Module module = default(Module), IList<CustomAttributeData> customAttributes = default(IList<CustomAttributeData>), bool? isCollectible = default(bool?), int? metadataToken = default(int?))
        {
            MemberType = memberType;
            Attributes = attributes;
            FieldType = fieldType;
            IsInitOnly = isInitOnly;
            IsLiteral = isLiteral;
            IsNotSerialized = isNotSerialized;
            IsPinvokeImpl = isPinvokeImpl;
            IsSpecialName = isSpecialName;
            IsStatic = isStatic;
            IsAssembly = isAssembly;
            IsFamily = isFamily;
            IsFamilyAndAssembly = isFamilyAndAssembly;
            IsFamilyOrAssembly = isFamilyOrAssembly;
            IsPrivate = isPrivate;
            IsPublic = isPublic;
            IsSecurityCritical = isSecurityCritical;
            IsSecuritySafeCritical = isSecuritySafeCritical;
            IsSecurityTransparent = isSecurityTransparent;
            FieldHandle = fieldHandle;
            Name = name;
            DeclaringType = declaringType;
            ReflectedType = reflectedType;
            Module = module;
            CustomAttributes = customAttributes;
            IsCollectible = isCollectible;
            MetadataToken = metadataToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Constructor', 'Event',
        /// 'Field', 'Method', 'Property', 'TypeInfo', 'Custom', 'NestedType',
        /// 'All'
        /// </summary>
        [JsonProperty(PropertyName = "memberType")]
        public string MemberType { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'PrivateScope', 'Private',
        /// 'FamANDAssem', 'Assembly', 'Family', 'FamORAssem', 'Public',
        /// 'FieldAccessMask', 'Static', 'InitOnly', 'Literal',
        /// 'NotSerialized', 'HasFieldRVA', 'SpecialName', 'RTSpecialName',
        /// 'HasFieldMarshal', 'PinvokeImpl', 'HasDefault', 'ReservedMask'
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public string Attributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fieldType")]
        public Type FieldType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isInitOnly")]
        public bool? IsInitOnly { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isLiteral")]
        public bool? IsLiteral { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isNotSerialized")]
        public bool? IsNotSerialized { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isPinvokeImpl")]
        public bool? IsPinvokeImpl { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isSpecialName")]
        public bool? IsSpecialName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isStatic")]
        public bool? IsStatic { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isAssembly")]
        public bool? IsAssembly { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isFamily")]
        public bool? IsFamily { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isFamilyAndAssembly")]
        public bool? IsFamilyAndAssembly { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isFamilyOrAssembly")]
        public bool? IsFamilyOrAssembly { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isPrivate")]
        public bool? IsPrivate { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isPublic")]
        public bool? IsPublic { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isSecurityCritical")]
        public bool? IsSecurityCritical { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isSecuritySafeCritical")]
        public bool? IsSecuritySafeCritical { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isSecurityTransparent")]
        public bool? IsSecurityTransparent { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fieldHandle")]
        public RuntimeFieldHandle FieldHandle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "declaringType")]
        public Type DeclaringType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reflectedType")]
        public Type ReflectedType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "module")]
        public Module Module { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customAttributes")]
        public IList<CustomAttributeData> CustomAttributes { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isCollectible")]
        public bool? IsCollectible { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadataToken")]
        public int? MetadataToken { get; private set; }

    }
}
