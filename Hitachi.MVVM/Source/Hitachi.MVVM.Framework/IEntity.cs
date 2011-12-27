namespace Hitachi.MVVM.Framework
{
    public interface IEntity
    {
        int Id { get; set; }

        bool IsTransient { get; }
    }
}
