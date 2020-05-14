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

    public partial class CaseworkerList
    {
        /// <summary>
        /// Initializes a new instance of the CaseworkerList class.
        /// </summary>
        public CaseworkerList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CaseworkerList class.
        /// </summary>
        public CaseworkerList(int? totalNoOfPages = default(int?), int? totalSearchCount = default(int?), int? pageNo = default(int?), IList<CaseworkerDataResponseModel> result = default(IList<CaseworkerDataResponseModel>))
        {
            TotalNoOfPages = totalNoOfPages;
            TotalSearchCount = totalSearchCount;
            PageNo = pageNo;
            Result = result;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalNoOfPages")]
        public int? TotalNoOfPages { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalSearchCount")]
        public int? TotalSearchCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pageNo")]
        public int? PageNo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public IList<CaseworkerDataResponseModel> Result { get; set; }

    }
}
