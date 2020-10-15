using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filter_value.datasource.command
{
    public class command_source
    { 
        public static void Command(dynamic env)
        {
            while (true)
            {
                var con = env.input();
                env.exec(con);
            }
        }
    }
}
