namespace GGTech.Infrastructure.Interface.Entity
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { set; get; }
    }
}