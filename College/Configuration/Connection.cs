using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Configuration
{
    internal class Connection
    {
        public static readonly string ConnectionString = @"
            Data Source=DESKTOP-A5DJ6R6;
            database = College;
            User ID=sa;
            Password=1234";
    }
}
