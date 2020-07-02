using MaerskTask_BusinessRulesEngine.Comman.Intefaces;
using MaerskTask_BusinessRulesEngine.CommanUtility;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaerskTask_BusinessRulesEngine.Implementation
{
    public class AddFirstAidVideo: IProcessEngine
    {

        #region Private Members
        private readonly IProcessEngine nextStep = null;
        #endregion

        #region Constructors
        public AddFirstAidVideo(IProcessEngine nextStep = null)
        {
            this.nextStep = nextStep;
        }
        #endregion

        #region Public Functions
        public Response Process(object param = default)
        {
            try
            {
                // Write some Logic here for adding first aid video
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

            return new Response((int)Status.FAIL, "Fail to add first ad video");
        }
        #endregion
    }
}
