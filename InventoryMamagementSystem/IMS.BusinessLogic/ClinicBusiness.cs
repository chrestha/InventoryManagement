using IMS.Model;
using IMS.Service;
using System.Collections.Generic;
using System.Linq;

namespace IMS.BusinessLogic
{
    public class ClinicBusiness : IClinicBusiness
    {
        public List<ClinicView> GetAllClinics()
        {
            using (var clinicrepo = new ClinicRepository())
            {
                return clinicrepo.GetAllClinicView();
            }
        }
        
    }
}
