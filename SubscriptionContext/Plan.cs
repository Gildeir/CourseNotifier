
using CourseNotifier.SharedContext;

namespace CourseNotifier.SubscriptionContext
{
    public class Plan: BaseContent
    {
        public string? Title { get; set; }
        public decimal Price { get; set; }
    }
}
