using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ingles
{
   public interface IForm
    {
      void clearControl();
      void Initialized();
      void validate();
    }
}
