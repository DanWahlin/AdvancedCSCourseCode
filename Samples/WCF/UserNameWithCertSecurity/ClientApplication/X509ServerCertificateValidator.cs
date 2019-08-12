using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IdentityModel;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;

namespace ClientApplication
{
    public class X509ServerCertificateValidator : X509CertificateValidator
    {
            public override void Validate(X509Certificate2 certificate)
            {
                // Check if we found a server cert
                if (certificate == null) throw new ArgumentNullException("Server certificate not found");

                // check if the name of the certifcate matches
                if (certificate.SubjectName.Name != "CN=TestServerCert")
                {
                    throw new SecurityTokenException("Server certificate not valid!");
                }
            }
    }
}
