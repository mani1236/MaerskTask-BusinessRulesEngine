using MaerskTask_BusinessRulesEngine.CommanUtility;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaerskTask_BusinessRulesEngine.Comman.Intefaces
{
    public interface IProcessEngine
    {
        Response Process(object param = default);
    }
}
