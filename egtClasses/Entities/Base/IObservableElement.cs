using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egt.Classes.Entities
{
    interface IObservableElement
    {
        //string CreatedBy { get; set; }
        DateTime? CreatedOn { get; set; }
        //string UpdatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
    }
}
