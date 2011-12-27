using System.ServiceModel;

namespace Hitachi.MVVM.Services.Spec
{
    [ServiceContract]
    public interface ICustomerService
    {
        /// <remarks />
        [OperationContract]
        string StartAnnouncementWorkflow(string request);
    }
}
