public interface ICarBuilder
{
    public ICarBuilder SetSeats(int seats);
    public Car Build();
}