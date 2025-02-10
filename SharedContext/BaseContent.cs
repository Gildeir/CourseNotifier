using Balta.NotificationContext;

namespace Balta.SharedContext
{
    public abstract class BaseContent : Notifiable
    {
        public BaseContent()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

    }
}
