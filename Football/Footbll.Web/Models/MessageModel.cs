using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Footbll.Web.Models
{
    public class MessageModel
    {
        public MessageType MessageType { get; set; }

        public string Messages { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public object ObjValue { get; set; }
    }

    public enum MessageType
    {
        Success = 0,

        Fail = 1,

        Exception = 2,

        ValidateCodeError = 3

    }
}