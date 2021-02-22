﻿using Com.Cognizant.Truyum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    interface IMenuItemDao
    {
        List<MenuItem> GetMenuItemListAdmin();
        List<MenuItem> GetMenuListCustomer();
        void ModifyMenuItem(MenuItem menuItem);
        MenuItem GetMenuItem(long menuItemId);


    }

}
