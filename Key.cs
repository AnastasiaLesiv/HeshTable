namespace Laboratorna_3
{
public class Key
{
    private string stock; //значення
    private int dayOfYear;//день

    public Key(string stock, int dayOfYear)
    {
        this.stock = stock;
        this.dayOfYear = dayOfYear;
    }

    public int Hash()
    {
        return dayOfYear;
    }
    //порівнює даний ключ з ключем в таблиці та повертає true
    public bool Equals(Key other)
    {
        return (other.stock == stock && other.dayOfYear == dayOfYear);
    }
 }
}