class Hardware
{
    protected string name = "";
    public void SetName(string n)
    {
        name = n;
    }
    public string GetName()
    {
        return name;
    }

    protected int price = 0;
    public void SetPrice(int p)
    {
        price = p;
    }
    public int GetPrice()
    {
        return price;
    }
    public Hardware(string n, int p)
    {
        name = n;
        price = p;
    }

    public virtual void Print()
    {

    }
}