using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public class TestModel
    {
        public IEnumerable<SelectListItem> Ulkeler { get; set; }

        public IEnumerable<SelectListItem> Sehir { get; set; }

        public IEnumerable<SelectListItem> Eyalet { get; set; }

    }
}
