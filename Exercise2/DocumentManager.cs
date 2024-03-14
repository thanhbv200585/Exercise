using Exercise2;

public class DocumentManager 
{ 
    private List<Document> _documents;
    public DocumentManager() 
    {
        this._documents = new List<Document>();
    }

    public DocumentManager(List<Document> documents) => _documents = documents;

    public void AddDocument(Document document)
    {
        if (this._documents == null)
        {
            throw new DocumentException("List of documents must be not null");
        }
        this._documents.Add(document??null);
    }

    public void RemoveDocument(int id)
    {
        this._documents.FindAll(document => { return document.Id == id; })
            .ForEach(removeDocument => this._documents.Remove(removeDocument));
    }

    public void DisplayAllDocument()
    {
        this._documents.ForEach(document =>
        {
            Console.WriteLine(document.ToString());
        });
    }

    void DisplayDocuments(List<Document> documents) 
    {
        documents.ForEach(document => { Console.WriteLine(document.ToString()); });
    }

    public void SearchByType(DocumentType documentType)
    {
        switch (documentType)
        {
            case DocumentType.BOOK:
                DisplayDocuments(this._documents.FindAll(document => document.GetType() == typeof(Book))); 
                break;
            case DocumentType.MAGAZINE:
                DisplayDocuments(this._documents.FindAll(document => document.GetType() == typeof(Magazine)));
                break;
            case DocumentType.NEWSPAPER:
                DisplayDocuments(this._documents.FindAll(document => document.GetType() == typeof(Newspapers)));
                break;
            default:
                throw new DocumentException("Unknown document type!");
        }
    }
}

public enum DocumentType
{
    BOOK, MAGAZINE, NEWSPAPER
}