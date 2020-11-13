package DAO;

import Shared.Airplane;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

public class AirplanesDAOImplementation implements AirplanesDAO
{
  private DatabaseHelper<Airplane> helper;

  public AirplanesDAOImplementation(String jdbcURL, String username, String password)
  {
    helper = new DatabaseHelper<>(jdbcURL, username, password);
  }
  public static class AirplaneMapper implements DataMapper<Airplane>
  {

    @Override public Airplane create(ResultSet rs) throws SQLException
    {
      int registrationNumber = rs.getInt("registrationnumber");
      String planeType = rs.getString("planetype");
      int numberOfSeats = rs.getInt("numberofseats");
      return new Airplane(registrationNumber,planeType,numberOfSeats);
    }
  }

  @Override public List<Airplane> getPlanes()
  {
    return helper.map(new AirplaneMapper(),"SELECT * FROM Airplane");
  }

  @Override public Airplane getAirplaneByType(String type)
  {
    return helper.mapSingle(new AirplaneMapper(),"SELECT * FROM Airplane WHERE planetype = ?",type);
  }
}
