using makeup1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace makeup1.ViewModels
{
    public class SearchViewModel
    {
        public string UserName { get; set; }

        public SearchViewModel()
        {

        }
        public SearchViewModel(ApplicationUser user)
        {
            UserName = user.UserName;
        }
    }
}