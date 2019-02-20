using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using izibiz.SERVICES.serviceAuth;


namespace izibiz.CONTROLLER.Web_Services
{
    class AuthenticationWebService
    {

        protected SERVICES.serviceAuth.AuthenticationServicePortClient Auth = new SERVICES.serviceAuth.AuthenticationServicePortClient();



        public LoginResponse Login(string usurname, string password)
        {
            var req = new SERVICES.serviceAuth.LoginRequest
            {
                USER_NAME = usurname,
                PASSWORD = password,
                REQUEST_HEADER = new SERVICES.serviceAuth.REQUEST_HEADERType
                {
                    SESSION_ID = "-1",
                    CLIENT_TXN_ID = System.Guid.NewGuid().ToString(),
                    APPLICATION_NAME = "İZİBİZ MASAUSTU V1.0",
                    CHANNEL_NAME = "İZİBİZ",
                    HOSTNAME = "HOST-İZİBİZ-DEFAULT"
                }
            };

            SERVICES.serviceAuth.LoginResponse loginRes = Auth.Login(req);
            string sesionId = loginRes.SESSION_ID;
            return loginRes;

        }

           
           


     
        

        }
    }
