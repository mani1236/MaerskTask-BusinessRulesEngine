using MaerskTask_BusinessRulesEngine.Comman.Intefaces;
using MaerskTask_BusinessRulesEngine.CommanUtility;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaerskTask_BusinessRulesEngine.Implementation
{
    public class CreateDuplicateSlipForRoyaldepartment : IProcessEngine
    {
        #region Private Members
        private readonly IProcessEngine nextStep = null;
        #endregion

        #region Constructors
        public CreateDuplicateSlipForRoyaldepartment(IProcessEngine nextStep = null)
        {
            this.nextStep = nextStep;
        }
        #endregion

        #region Public Functions
        public Response Process(object param = default)
        {
            try
            {
                // Write a logic here for creating  packing duplicate slip for royalty department when it is book 
                // and process next step
                // break the chain if process failed
                if (nextStep != null)
                {
                    return nextStep.Process();
                }
                return new Response((int)Status.SUCCESS);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new Response((int)Status.FAIL, "Faild to creating packing slip for royalty department");
        }
        #endregion
    }
}
