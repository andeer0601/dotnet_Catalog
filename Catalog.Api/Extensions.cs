using Catalog.Api.Dtos;
using Catalog.Api.Entities;

namespace Catalog.Api
{

  public static class extensions
{
  public static ItemDto AsDto( this Item item )
  {

    return new ItemDto(item.Id, item.Name, item.Description, item.Price, item.CreateDate);

  }
}

}