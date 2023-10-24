using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Harvir_Pen_Ass_1.Models
{
    public class PenColorViewModel
    {
        public List<Pen> Pens { get; set; }
        public SelectList Colors { get; set; }
        public string PenColor { get; set;}
        public string SearchString { get; set; }
    }
}
