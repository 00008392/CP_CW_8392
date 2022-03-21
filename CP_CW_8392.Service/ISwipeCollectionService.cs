using CP_CW_8392.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CP_CW_8392.Service
{
    //WCF service definition
    [ServiceContract]
    public interface ISwipeCollectionService
    {
        [OperationContract(IsOneWay =true)]
        void StartCollectingSwipes();
        [OperationContract]
        ICollection<Terminal> GetStatus();
        [OperationContract]
        ICollection<Swipe> GetAllSwipes();
    }
}
