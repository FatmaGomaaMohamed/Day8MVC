namespace Day8MVC.ServiceLifeTime
{
    public class ScopedService : IScopedService
    {
        public string Message { get; set; }
        public ScopedService()
        {
            Message = Guid.NewGuid().ToString();
        }
    }
}
