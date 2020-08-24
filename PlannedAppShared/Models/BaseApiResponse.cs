namespace PlannerAppShared.Models
{
    public abstract class BaseApiResponse {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
