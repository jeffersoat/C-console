

class GetSet
{
    private string _model;

    public string Model 
    {
        get { return _model; }
        set { _model = value; }
    }
}

class Person
{
    private string _name;

    public string _Name
    {
        get { return _name; }
        set 
        {
            if(!string.IsNullOrEmpty(value))
            {
                _name = value; 
            }
        }
    }
}

class Short
{
    public String Cut { get; set; }
}

class BankAcount 
{
    private decimal _balence;

    public decimal _Balence
    {
        get{ return _balence; }
        set{ 
            if(value >= 0)
            {
                _balance = value;
            }
        }
    }
}