// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Momentum.Mea.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RuntimeTypeHandle
    {
        /// <summary>
        /// Initializes a new instance of the RuntimeTypeHandle class.
        /// </summary>
        public RuntimeTypeHandle()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RuntimeTypeHandle class.
        /// </summary>
        public RuntimeTypeHandle(object value = default(object))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

    }
}
