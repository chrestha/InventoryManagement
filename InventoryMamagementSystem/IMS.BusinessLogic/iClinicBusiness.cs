using IMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMS.BusinessLogic
{
    public interface IClinicBusiness
    {
        List<ClinicView> GetAllClinics();
    }
}
