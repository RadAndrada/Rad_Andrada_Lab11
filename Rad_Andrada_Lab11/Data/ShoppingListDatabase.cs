using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rad_Andrada_Lab11.Models;

namespace Rad_Andrada_Lab11.Data
{
    IRestService restService;
    public ShoppingListDatabase(IRestService service)
    {
        RestService = service;
    }
    public Task<List<ShopList>> GetShopListsAsync()
    {
        return RestService.RefreshDataAsync();
    }

    public Task SaveShopListAsync(ShopList item, bool isNewItem = true)
    {
        return RestService.SaveShopListAsync(item, isNewItem);
    }
    public Task DeleteShopListAsync(ShopList item)
    {
        return RestService.DeleteShopListAsync(item.ID);
    }

}
