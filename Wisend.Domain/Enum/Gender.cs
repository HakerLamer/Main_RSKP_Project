using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Wisend.Domain.Enum
{
    public enum Gen
    {
        [Display(Name = "Не выбрано")]
        Idk = 0,
        [Display(Name = "Девушка")]
        Male = 1,
        [Display(Name = "Парень")]
        Female  = 2,

    }
}
