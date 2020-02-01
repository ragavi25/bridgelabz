using System;
using System.Collections.Generic;
using System.Text;

namespace AlogrithmPrograms
{
    class Dayformat
    {
        public void dayformat()
        {
            var date = DateTime.Now.ToString("yyyy-MM-dd / HH:mm:ss:ms zzz");

            Console.WriteLine(date);



            var date2 = date.Replace("-", "").Replace(" ", "").Replace("/", "").Replace(":", "").Replace("+", "");

        }
    }
}
