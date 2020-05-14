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

    public partial class MemberInfo
    {
        /// <summary>
        /// Initializes a new instance of the MemberInfo class.
        /// </summary>
        public MemberInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MemberInfo class.
        /// </summary>
        /// <param name="memberType">Possible values include: 'Constructor',
        /// 'Event', 'Field', 'Method', 'Property', 'TypeInfo', 'Custom',
        /// 'NestedType', 'All'</param>
        public MemberInfo(string memberType = default(string), Type declaringType = default(Type), Type reflectedType = default(Type), string name = default(string), Module module = default(Module), IList<CustomAttributeData> customAttributes = default(IList<CustomAttributeData>), bool? isCollectible = default(bool?), int? metadataToken = default(int?))
        {
            MemberType = memberType;
            DeclaringType = declaringType;
            ReflectedType = reflectedType;
            Name = name;
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
        /// </summary>
        [JsonProperty(PropertyName = "declaringType")]
        public Type DeclaringType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reflectedType")]
        public Type ReflectedType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

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
