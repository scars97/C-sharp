namespace ExAPI.Models
{
    public class TodoItem
    {
        // 자바의 엔티티 클래스
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }    
        public string? Secret { get; set; }
    }
}
