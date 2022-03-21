using CP_CW_8392.BLL.Contracts;
using CP_CW_8392.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace CP_CW_8392.Service
{
    //WCF swipe service implementation
    [ServiceBehavior(ConcurrencyMode =ConcurrencyMode.Multiple, InstanceContextMode =
        InstanceContextMode.Single)]
    public class SwipeCollectionService : ISwipeCollectionService
    {
        private readonly ISwipeService _service;
        private static object _lock = new object();
        //inject business logic service
        public SwipeCollectionService(ISwipeService service)
        {
            _service = service;
        }
        //retrieve all swipes from the db
        public ICollection<Swipe> GetAllSwipes()
        {
            return _service.GetAllSwipes();
        }
        //get statuses for all terminals
        public ICollection<Terminal> GetStatus()
        {
            return _service.GetStatus();
        }
        //start retrieval of swipes 
        public void StartCollectingSwipes()
        {
            //only 1 swipes retrieval request can be proceeded at a time
            lock(_lock)
            {
                _service.CollectAndSaveSwipes();
            }
        }
    }
}
