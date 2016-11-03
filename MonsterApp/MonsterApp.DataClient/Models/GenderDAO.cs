using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MonsterApp.DataClient.Models
{
  [DataContract]
  public class GenderDAO
  {
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string Name { get; set; }
  }
}