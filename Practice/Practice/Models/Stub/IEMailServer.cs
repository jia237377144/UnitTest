using System;
namespace Practice.Models.Stub
{
    public interface IEMailServer
    {
        bool SendMail(EMail mail);
    }
}
