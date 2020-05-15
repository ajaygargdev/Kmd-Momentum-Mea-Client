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

    public partial class MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the MethodBase class.
        /// </summary>
        public MethodBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MethodBase class.
        /// </summary>
        /// <param name="attributes">Possible values include: 'ReuseSlot',
        /// 'ReuseSlot', 'Private', 'FamANDAssem', 'Assembly', 'Family',
        /// 'FamORAssem', 'Public', 'MemberAccessMask', 'UnmanagedExport',
        /// 'Static', 'Final', 'Virtual', 'HideBySig', 'VtableLayoutMask',
        /// 'VtableLayoutMask', 'CheckAccessOnOverride', 'Abstract',
        /// 'SpecialName', 'RTSpecialName', 'PinvokeImpl', 'HasSecurity',
        /// 'RequireSecObject', 'ReservedMask'</param>
        /// <param name="methodImplementationFlags">Possible values include:
        /// 'Managed', 'Managed', 'Native', 'OPTIL', 'CodeTypeMask',
        /// 'CodeTypeMask', 'Unmanaged', 'Unmanaged', 'NoInlining',
        /// 'ForwardRef', 'Synchronized', 'NoOptimization', 'PreserveSig',
        /// 'AggressiveInlining', 'AggressiveOptimization', 'InternalCall',
        /// 'MaxMethodImplVal'</param>
        /// <param name="callingConvention">Possible values include:
        /// 'Standard', 'VarArgs', 'Any', 'HasThis', 'ExplicitThis'</param>
        /// <param name="isAbstract"></param>
        /// <param name="isConstructor"></param>
        /// <param name="isFinal"></param>
        /// <param name="isHideBySig"></param>
        /// <param name="isSpecialName"></param>
        /// <param name="isStatic"></param>
        /// <param name="isVirtual"></param>
        /// <param name="isAssembly"></param>
        /// <param name="isFamily"></param>
        /// <param name="isFamilyAndAssembly"></param>
        /// <param name="isFamilyOrAssembly"></param>
        /// <param name="isPrivate"></param>
        /// <param name="isPublic"></param>
        /// <param name="isConstructedGenericMethod"></param>
        /// <param name="isGenericMethod"></param>
        /// <param name="isGenericMethodDefinition"></param>
        /// <param name="containsGenericParameters"></param>
        /// <param name="methodHandle"></param>
        /// <param name="isSecurityCritical"></param>
        /// <param name="isSecuritySafeCritical"></param>
        /// <param name="isSecurityTransparent"></param>
        /// <param name="memberType">Possible values include: 'Constructor',
        /// 'Event', 'Field', 'Method', 'Property', 'TypeInfo', 'Custom',
        /// 'NestedType', 'All'</param>
        /// <param name="name"></param>
        /// <param name="declaringType"></param>
        /// <param name="reflectedType"></param>
        /// <param name="module"></param>
        /// <param name="customAttributes"></param>
        /// <param name="isCollectible"></param>
        /// <param name="metadataToken"></param>
        public MethodBase(string attributes = default(string), string methodImplementationFlags = default(string), string callingConvention = default(string), bool? isAbstract = default(bool?), bool? isConstructor = default(bool?), bool? isFinal = default(bool?), bool? isHideBySig = default(bool?), bool? isSpecialName = default(bool?), bool? isStatic = default(bool?), bool? isVirtual = default(bool?), bool? isAssembly = default(bool?), bool? isFamily = default(bool?), bool? isFamilyAndAssembly = default(bool?), bool? isFamilyOrAssembly = default(bool?), bool? isPrivate = default(bool?), bool? isPublic = default(bool?), bool? isConstructedGenericMethod = default(bool?), bool? isGenericMethod = default(bool?), bool? isGenericMethodDefinition = default(bool?), bool? containsGenericParameters = default(bool?), RuntimeMethodHandle methodHandle = default(RuntimeMethodHandle), bool? isSecurityCritical = default(bool?), bool? isSecuritySafeCritical = default(bool?), bool? isSecurityTransparent = default(bool?), string memberType = default(string), string name = default(string), Type declaringType = default(Type), Type reflectedType = default(Type), Module module = default(Module), IList<CustomAttributeData> customAttributes = default(IList<CustomAttributeData>), bool? isCollectible = default(bool?), int? metadataToken = default(int?))
        {
            Attributes = attributes;
            MethodImplementationFlags = methodImplementationFlags;
            CallingConvention = callingConvention;
            IsAbstract = isAbstract;
            IsConstructor = isConstructor;
            IsFinal = isFinal;
            IsHideBySig = isHideBySig;
            IsSpecialName = isSpecialName;
            IsStatic = isStatic;
            IsVirtual = isVirtual;
            IsAssembly = isAssembly;
            IsFamily = isFamily;
            IsFamilyAndAssembly = isFamilyAndAssembly;
            IsFamilyOrAssembly = isFamilyOrAssembly;
            IsPrivate = isPrivate;
            IsPublic = isPublic;
            IsConstructedGenericMethod = isConstructedGenericMethod;
            IsGenericMethod = isGenericMethod;
            IsGenericMethodDefinition = isGenericMethodDefinition;
            ContainsGenericParameters = containsGenericParameters;
            MethodHandle = methodHandle;
            IsSecurityCritical = isSecurityCritical;
            IsSecuritySafeCritical = isSecuritySafeCritical;
            IsSecurityTransparent = isSecurityTransparent;
            MemberType = memberType;
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
        /// Gets or sets possible values include: 'ReuseSlot', 'ReuseSlot',
        /// 'Private', 'FamANDAssem', 'Assembly', 'Family', 'FamORAssem',
        /// 'Public', 'MemberAccessMask', 'UnmanagedExport', 'Static', 'Final',
        /// 'Virtual', 'HideBySig', 'VtableLayoutMask', 'VtableLayoutMask',
        /// 'CheckAccessOnOverride', 'Abstract', 'SpecialName',
        /// 'RTSpecialName', 'PinvokeImpl', 'HasSecurity', 'RequireSecObject',
        /// 'ReservedMask'
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public string Attributes { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Managed', 'Managed',
        /// 'Native', 'OPTIL', 'CodeTypeMask', 'CodeTypeMask', 'Unmanaged',
        /// 'Unmanaged', 'NoInlining', 'ForwardRef', 'Synchronized',
        /// 'NoOptimization', 'PreserveSig', 'AggressiveInlining',
        /// 'AggressiveOptimization', 'InternalCall', 'MaxMethodImplVal'
        /// </summary>
        [JsonProperty(PropertyName = "methodImplementationFlags")]
        public string MethodImplementationFlags { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Standard', 'VarArgs', 'Any',
        /// 'HasThis', 'ExplicitThis'
        /// </summary>
        [JsonProperty(PropertyName = "callingConvention")]
        public string CallingConvention { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isAbstract")]
        public bool? IsAbstract { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isConstructor")]
        public bool? IsConstructor { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isFinal")]
        public bool? IsFinal { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isHideBySig")]
        public bool? IsHideBySig { get; private set; }

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
        [JsonProperty(PropertyName = "isVirtual")]
        public bool? IsVirtual { get; private set; }

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
        [JsonProperty(PropertyName = "isConstructedGenericMethod")]
        public bool? IsConstructedGenericMethod { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isGenericMethod")]
        public bool? IsGenericMethod { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isGenericMethodDefinition")]
        public bool? IsGenericMethodDefinition { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "containsGenericParameters")]
        public bool? ContainsGenericParameters { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "methodHandle")]
        public RuntimeMethodHandle MethodHandle { get; set; }

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
        /// Gets or sets possible values include: 'Constructor', 'Event',
        /// 'Field', 'Method', 'Property', 'TypeInfo', 'Custom', 'NestedType',
        /// 'All'
        /// </summary>
        [JsonProperty(PropertyName = "memberType")]
        public string MemberType { get; set; }

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
