// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Momentum.Mea.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class JournalNoteDocumentRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the JournalNoteDocumentRequestModel
        /// class.
        /// </summary>
        public JournalNoteDocumentRequestModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JournalNoteDocumentRequestModel
        /// class.
        /// </summary>
        public JournalNoteDocumentRequestModel(string name = default(string), string contentType = default(string), string content = default(string))
        {
            Name = name;
            ContentType = contentType;
            Content = content;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

    }
}
