using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace b_firstService
{
    [ServiceContract]
    public interface IWorkCar
    {
        [OperationContract]
        void AddCars(Car machine);
        [OperationContract]
        void DelCar(int id);
        [OperationContract]
        List<Car> GetCars();

    }
}
