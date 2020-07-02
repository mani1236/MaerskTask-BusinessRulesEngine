using MaerskTask_BusinessRulesEngine.CommanUtility;
using MaerskTask_BusinessRulesEngine.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaerskTask_BusinessRulesEngine
{
    public class ProcessEngine
    {

        public Response RunBusinessRuleEngine(PaymentType type)
        {
            switch (type)
            {
                case PaymentType.PHYSICAL_PRODUCT:
                    {
                        var createCommissionPayment = new ProcessCommissionPayment();
                        var packingSlip = new PhysicalProductPackingSlip(createCommissionPayment);
                        return packingSlip.Process();
                    }
                case PaymentType.BOOK:
                    {
                        var createCommissionPayment = new ProcessCommissionPayment();
                        var GeneratePackingSlipForRoyaltyDepartment = new CreateDuplicateSlipForRoyaldepartment(createCommissionPayment);
                        return GeneratePackingSlipForRoyaltyDepartment.Process();
                    }
                case PaymentType.MEMBERSHIP_ACTIVATE:
                    {
                        var sendEmailNotifification = new NotifyEmail();
                        var activateMemberShip = new ActivateMemeberShip(sendEmailNotifification);
                        return activateMemberShip.Process();
                    }
                case PaymentType.MEMBERSHIP_UPGRADE:
                    {
                        var sendEmailNotifification = new NotifyEmail();
                        var applyUpgrade = new UpgradeMembership(sendEmailNotifification);
                        return applyUpgrade.Process();
                    }
                case PaymentType.VIDEO:
                    {
                        var addFirstAidVideo = new AddFirstAidVideo();
                        var packingSlip = new PhysicalProductPackingSlip(addFirstAidVideo);
                        return packingSlip.Process();
                    }
                default:
                    return new Response((int)Status.FAIL, "payment type is not found");
            }
        }
    }

}
