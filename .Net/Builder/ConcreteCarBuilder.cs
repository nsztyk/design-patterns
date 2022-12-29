public class ConcreteCarBuilder : ICarBuilder
{
    private Car _car;
    public ConcreteCarBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _car = new Car();
    }

    public Car Build()
    {
        var result = _car;
        Reset();
        return result;
    }

    public ICarBuilder SetSeats(int seats)
    {
        throw new NotImplementedException();
    }
}