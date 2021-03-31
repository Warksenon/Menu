using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Presenters.Email
{
    public interface ISaveEmailData
    {
        bool Save(EmailData emailData);
    }
}
