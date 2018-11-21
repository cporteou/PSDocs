using System.Collections.Generic;
using System.Collections.Specialized;

namespace PSDocs.Models
{
    public sealed class Document : SectionNode
    {
        public Document()
        {
            Metadata = new OrderedDictionary();
            DocumentName = null;
            Path = null;
        }

        public override DocumentNodeType Type
        {
            get { return DocumentNodeType.Document; }
        }

        public OrderedDictionary Metadata { get; set; }

        public string DocumentName { get; set; }

        public string Path { get; set; }
    }
}
