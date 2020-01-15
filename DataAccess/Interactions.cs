using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess {

  public class DataModel {

  }

  public class Interactions {

    public static T DataModel<T> RunStoredProc(){

      return (T)Convert.ChangeType(value, typeof(T));
    }

  }
}
