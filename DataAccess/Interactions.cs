using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccess {
  // further reading: https://stackoverflow.com/questions/15185985/ways-around-creating-an-instance-of-a-generic-interface-in-c-sharp
  public interface IMyProcParams { }

  public class MyProcParams : IMyProcParams { }

  public interface IMyProcResult { }

  public class Stuff {
    void runMyStuff() {
      IMyProcParams procParams = new MyProcParams();
      IDbConnection conn = new SqlConnection();
      IDbCommand cmd = new SqlCommand { CommandType = CommandType.StoredProcedure, Connection = new SqlConnection(),/* you get the idea. */  };
      var myResult = DbActions.RunStoredProc<IMyProcParams, IMyProcResult>(procParams, conn, cmd);
    }
  }



  public static class DbActions {
    public static IEnumerable<T2> RunStoredProc<T, T2>(
        T IProcParams,
        IDbConnection connection,
        IDbCommand command
    ) {
      IEnumerable<T2> retVal = Enumerable.Empty<T2>();

      using (connection) {
        using (command) {
          if (connection.State != ConnectionState.Open) {
            connection.Open();
          }
          var rdr = command.ExecuteReader();
          while (rdr.Read()) {

            retVal = retVal.Concat(new[] { new { }  });
          }
        }
      }

      return retVal;
    }
  }
}