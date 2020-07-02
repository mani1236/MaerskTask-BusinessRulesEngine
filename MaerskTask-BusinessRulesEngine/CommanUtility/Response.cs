using System;
using System.Collections.Generic;
using System.Text;

namespace MaerskTask_BusinessRulesEngine.CommanUtility
{
    public class Response
    {

        #region Public Members
        public int Status { get; set; }
        public string Error { get; set; }
        #endregion

        #region Constructors
        public Response(int status, string error = "")
        {
            Status = status;
            Error = error;
        }
        public Response()
        {
        }
        #endregion
    }
}
