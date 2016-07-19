using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Xunit;

namespace Airline
{
  public class FlightTest : IDisposable
  {
    public FlightTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=airline_test;Integrated Security=SSPI;";
    }
    [Fact]
    public void Test_FlightsEmptyAtFirst()
    {
      int flightList = Flight.GetAll().Count;
      Assert.Equal(0, flightList);
    }

    public void Dispose()
    {
      Flight.DeleteAll();
    }
  }
}
