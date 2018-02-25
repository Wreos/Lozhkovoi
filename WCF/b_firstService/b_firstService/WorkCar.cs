using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace b_firstService
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
     public class WorkCar:IWorkCar
    {
        public int global_id = 0;
        public List<Car> Cars = new List<Car>();
        public List<Car> GetCars()
        {
            return Cars;
        }


        public void AddCars(Car car)
        {
            global_id++;
            car.id = global_id;
            Cars.Add(car);
        }


        public void DelCar(int id)
        {
            Cars.Remove(Cars.Find(e => e.id.Equals(id)));
        }
    }
}
