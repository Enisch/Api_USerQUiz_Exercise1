using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infradata.Domain_.DomainVerificatioException
{
    public class UserAuthenticator:Exception
    {

        public UserAuthenticator(string Error):base(Error) 
        {
            
        }

        public static void When(bool HAsError,string Error) 
        {
        
            if (HAsError) 
            {
                throw new Exception(Error);
            
            }
        
        }


    }
}
