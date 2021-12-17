using MVCDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCDemo
{
    public class Data
    {
        public static List<PersonViewModel> GetPersons()
        {
            return new List<PersonViewModel>
            {
                new PersonViewModel
                {
                    Id=101,
                    Name="JOhn",
                    Occupation="Fireman"
                },
                new PersonViewModel
                {
                    Id=102,
                    Name="Mary",
                    Occupation="Astronaut"
                },
                new PersonViewModel
                {
                    Id=103,
                    Name="Anurag",
                    Occupation="Developer"
                }
            };
        }

        public static List<PrintViewModel> GetDocuments()
        {
            return new List<PrintViewModel>
            {
                new PrintViewModel
                {
                    DocumentId=101,
                    DocumentName="Test",
                    DocumentLocation="C:\\Users\\Documents"
                },
                 new PrintViewModel
                {
                    DocumentId=102,
                    DocumentName="Test 123",
                    DocumentLocation="C:\\Users\\Documents1"
                },

                 new PrintViewModel
                {
                    DocumentId=103,
                    DocumentName="Test 345",
                    DocumentLocation="C:\\Users\\Documents2"
                },
            };
        }

        public static List<DocumentType> GetDocumentTypes()
        {
            return new List<DocumentType>
            {
                        new DocumentType
                        {
                            DocumentId=101,
                            DocExtension=DocumentExtension.DOCX,
                            DocType=Type.Word
                        },
                        new DocumentType
                        {
                            DocumentId=101,
                            DocExtension=DocumentExtension.PPT,
                            DocType=Type.PowerPoint
                        },
                         new DocumentType
                        {
                             DocumentId=102,
                            DocExtension=DocumentExtension.DOCX,
                            DocType=Type.Word
                        },
                        new DocumentType
                        {
                             DocumentId=102,
                            DocExtension=DocumentExtension.PPT,
                            DocType=Type.PowerPoint
                        },
                        new DocumentType
                        {
                             DocumentId=102,
                            DocExtension=DocumentExtension.XLS,
                            DocType=Type.Excel
                        },
                         new DocumentType
                        {
                             DocumentId=103,
                            DocExtension=DocumentExtension.DOCX,
                            DocType=Type.Word
                        }

            };
        }

        public static List<DocumentType> GetFilteredDocumentTypes(int docId)
        {
            return GetDocumentTypes().Where(x => x.DocumentId == docId).ToList();
        }
    }
}
