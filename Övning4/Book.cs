class Book
{
    private string name;
    string GetName()
    {
        return name;
    }
    private int pages;
    int GetPages()
    {
        return pages;
    }
    private int currentPage;
    int GetCurrentPage()
    {
        return currentPage;
    }
    public void TurnPage()
    {
        currentPage ++;
        if (currentPage > pages)
        {
            currentPage = pages;
            Console.WriteLine($"You turned the book {name} to page {currentPage}.");
        }
    }
    public Book(string n, int p)
    {
        name = n;
        pages = p;
    }
}