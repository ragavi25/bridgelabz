using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.ProtoTypeDesignPattern
{
  public abstract class CloneablePrototype<T>
    {
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }
        public T DeepCopy()
        {
            string result = JsonConvert.SerializeObject(this);
            ////TO avoid memory referencing
            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
