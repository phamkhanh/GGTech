namespace GGTech.Infrastructure.Interface.Entity
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }
    }
}