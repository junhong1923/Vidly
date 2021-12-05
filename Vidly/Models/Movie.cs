using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie /// this class is a POCO(Plain-Old CLR Objects)，代表 state and behavior of our application interms of its problem domain.
    {
        /// 這邊只有幾個 properties 代表 state
        public int Id { get; set; }
        public string Name { get; set; }


    }
}