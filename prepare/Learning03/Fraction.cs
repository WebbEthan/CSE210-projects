public class Fraction
{
    private int _top = 1;
    private int _bottom = 1;
    #region Constructors
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public Fraction(int top)
    {
        _top = top;
    }
    public Fraction() { }
    #endregion
    #region SetMethods
    public int SetBottom 
    {   
        set
        {
            if (value == 0)
            {
                throw new Exception("Cannot Divide By Zero");
            }
            _bottom = value;
        }
    }
    public int SetTop
    {
        set
        {
            _top = value;
        }
    }
    #endregion
    #region ReadMeathods
    public int GetTop { get {return _top; } }
    public int GetBottom { get {return _bottom; } }
    public override string ToString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue { get { return (double)_top / (double)_bottom; } }
    #endregion
}