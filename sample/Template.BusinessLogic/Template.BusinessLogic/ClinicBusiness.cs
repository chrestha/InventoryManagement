using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.Model;
using Template.Service;

namespace Template.BusinessLogic
{
    public class ClinicBusiness : IClinicBusiness
    {
        public List<ClinicView> GetAllClinics()
        {
            using (var clinicrepo = new ClinicRepository())
            {
                return clinicrepo.GetAll().Select(x=> new ClinicView() { ClinicId = x.ClinicId, ClinicName = x.ClinicName}).ToList();
            }
        }
    }
}
