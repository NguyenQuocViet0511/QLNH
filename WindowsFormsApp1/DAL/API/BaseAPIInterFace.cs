using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL.API
{
    interface BaseAPIInterFace
    {
        string All(string url, NameValueCollection table, string Method);
        string Get(string url);

    }
}
