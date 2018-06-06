using RiskLogic.Entity;
using RiskLogic.Model.ClientBriefingTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskLogic.Business.Interfaces
{
    public interface IBriefingAdminService
    {
        IList<BriefMasterTemplate> GetBriefingTemplateList();

        IList<BriefMasterTemplate> GetSiteReportTemplateList();

        IList<BriefCriticalStatu> GetCriticalStatusList();

        bool DeleteBriefingTemplate(Guid bId);

        BriefMasterTemplate EditBriefingTemplate(Guid bId);

        Guid SaveBriefingTemplate(BriefingAdminTemplateSaveModel model);

        IList<BriefTemplateType> GetBriefTemplateType();

        string GetUserDetails(Guid userId);

        IList<BriefingTemplateAttachment> GetTemplateAttachment(string masterTemplateId);
    }

}
