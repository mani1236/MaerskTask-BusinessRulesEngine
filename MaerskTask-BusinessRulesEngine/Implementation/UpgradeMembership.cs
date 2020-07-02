using MaerskTask_BusinessRulesEngine.Comman.Intefaces;
using MaerskTask_BusinessRulesEngine.CommanUtility;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaerskTask_BusinessRulesEngine.Implementation
{
    public class UpgradeMembership : IProcessEngine
    {
        #region Private Members
        private readonly IProcessEngine nextStep = null;
        #endregion

        #region Constructors
        public UpgradeMembership(IProcessEngine nextStep = null)
        {
            this.nextStep = nextStep;
        }
        #endregion

        #region Public Functions
        public Response Process(object param = default)
        {
            try
            {
                // Write Some logic here to upgrading membership
                // and process next step
                // break the chain if process failed
                if (nextStep != null)
                {
                    string message = "Dear customer, Your membership has been upgrade";
                    return nextStep.Process(message);
                }
                return new Response((int)Status.SUCCESS);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new Response((int)Status.FAIL, "Faild to upgrade membership");
        }
        #endregion
    }
}
