using System;
using System.Collections.Generic;
using System.Text;
using Kmd.Momentum.Mea.Client.Sample;

namespace Kmd.Momentum.Mea.Client.Sample
{
    public class CommandLineConfig
    {
        public CommandLineAction Action { get; set; }

        public string BearerToken { get; set; }

        public Uri MomentumApiBaseUri { get; set; }

        public int PageNo { get; set; }

        public string MomentumCitizenId { get; set; }

        public string TaskId { get; set; }

        public string CaseworkerId { get; set; }

        public string CprNumber { get; set; }

        public string CitizenId { get; set; }

        public string Content { get; set; }

        public string ContentType { get; set; }

        public string Name { get; set; }

        public string Body { get; set; }

        public string Cpr { get; set; }

        public string Documents { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public string TaskAction { get; set; }

        public string TaskContext { get; set; }
    }
}
