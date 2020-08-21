using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class UrlQuery
  {
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public UrlQuery()
    {
      this.PageNumber = 1;
      this.PageSize = 20;
    }
    
    public UrlQuery(int pageNumber, int pageSize)
    {
      this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
      this.PageSize = pageSize > 20 ? 20 : pageSize;
    }
    
  }
}