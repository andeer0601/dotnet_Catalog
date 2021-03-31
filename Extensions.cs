﻿using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog
{

  public static class extensions
{
  public static ItemDto AsDto( this Item item )
  {

    return new ItemDto{
        Id = item.Id,
        Name = item.Name,
        Price = item.Price,
        CreateDate = item.CreateDate
      };

  }
}

}