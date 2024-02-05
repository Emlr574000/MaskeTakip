using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService applicantService;//Interface'ler new'lenemez
        //Referans tutucudurlar.Birbirinin alternatifi olan sistemleri miras aracılığıyla istediğimiz yerde kullanmamıza olanak sağlar.

        public PttManager(IApplicantService applicantService)
        {
            this.applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {

            if (applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
                Console.WriteLine(person.FirstName+" için maske verilemedi");
        }
    }
} 
