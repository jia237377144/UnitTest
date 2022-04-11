using System;
namespace Practice.Models.Stub
{
    public class MailServerStub : IEMailServer
    {
        public bool SendMail(EMail mail)
        {
            return true;
        }
    }
}
