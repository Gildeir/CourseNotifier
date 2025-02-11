using CourseNotifier.NotificationContext;

namespace CourseNotifier.SharedContext
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
