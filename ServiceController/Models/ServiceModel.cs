using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceController.Models
{
    public class ServiceModel
    {
        public string ServiceName { get; set; }
        public Label LabelService { get; set; }
        public Label LabelPID { get; set; }
        public Button ButtonAction { get; set; }
    }
}
