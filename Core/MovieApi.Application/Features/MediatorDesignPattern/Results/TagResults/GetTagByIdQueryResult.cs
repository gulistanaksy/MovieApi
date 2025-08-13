namespace MovieApi.Application.Features.MediatorDesignPattern.Results.TagResults
{
    public class GetTagByIdQueryResult
    {
        public int TagId { get; set; }  // Primary key
        public string Title { get; set; }
    }
}