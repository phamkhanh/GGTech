using GGTech.Infrastructure.Enum;

namespace GGTech.Infrastructure.Interface.Entity
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}