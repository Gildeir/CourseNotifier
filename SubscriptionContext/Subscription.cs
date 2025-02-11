using CourseNotifier.SharedContext;

namespace CourseNotifier.SubscriptionContext
{
    public class Subscription: BaseContent
    {
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; }

        public bool IsInactive => EndDate <= DateTime.Now;

    }
}
