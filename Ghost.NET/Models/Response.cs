namespace HLStudios.Ghost
{
    public class Response<T>
    {
        public T Content { get; set; }
        public ErrorList Error { get; set; }
    }
}