﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NuTrello.Pages
{
    public class BoardsModel : PageModel
    {
        public List<string> Lists;
        public void OnGet()
        {

        }
    }
}