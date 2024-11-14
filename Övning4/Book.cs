class Book
{
    public string name;
    public int pages;
    public int currentPage;
    void TurnPage()
    {
        currentPage ++;
        if (currentPage > pages)
        {
            currentPage = pages;
            Console.WriteLine($"You turned the book {name} to page {currentPage}.");
        }
    }
}