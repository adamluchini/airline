using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Airline
{
  public class CityTest : IDisposable
  {
    private DateTime? departureTime = new DateTime(2016, 7, 19, 5, 0, 0);
    private DateTime? arrivalTime = new DateTime(2016, 7, 19, 7, 30, 0);

    public CityTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=airline_test;Integrated Security=SSPI;";
    }

    [Fact]
    public void Test_CitiesEmptyAtFirst()
    {
      int result = City.GetAll().Count;
      Assert.Equal(0, result);
    }

    public void Dispose()
    {
      City.DeleteAll();
    }


  }
}
