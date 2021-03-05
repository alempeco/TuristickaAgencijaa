using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencijaWebAPI.Database
{
    public class Data
    {
        public static void Seed(MyContext context)
        {
            context.Database.Migrate();

            //add init
        }
    }
}
