using System.Collections.Generic;

namespace MVCDemo.Models
{
    public class PrintViewModel
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentLocation { get; set; }
        public List<DocumentType> Types { get; set; }
    }

    public class DocumentType
    {
        public int DocumentId { get; set; }
        public Type DocType { get;set; }
        public DocumentExtension DocExtension { get; set; }
    }

    public enum Type
    {
        Word,
        Excel,
        PowerPoint
    }

    public enum DocumentExtension
    {
        DOCX,
        XLS,
        PPT
    }
}
