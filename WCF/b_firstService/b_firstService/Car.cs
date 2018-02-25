using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace b_firstService
{
    [DataContract]
   public class Car
    {
        [DataMember]
        public int id;
        [DataMember]
        public string modelName;
        [DataMember]
        public string mark;
        [DataMember]
        public string category;
        [DataMember]
        public string regnum;
        [DataMember]
        public DateTime create;

    }




}
