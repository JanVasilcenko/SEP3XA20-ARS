package DAO;

import Shared.Arrival;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Time;
import java.sql.Timestamp;
import java.time.LocalDateTime;
import java.util.List;

public class ArrivalDAOImplementation implements ArrivalDAO
{
  private DatabaseHelper<Arrival> helper;

  public ArrivalDAOImplementation(String jdbcURL, String username, String password)
  {
    helper = new DatabaseHelper<>(jdbcURL, username, password);
  }

  public static class ArrivalMapper implements DataMapper<Arrival>
  {

    @Override public Arrival create(ResultSet rs) throws SQLException
    {
      Timestamp time = rs.getTimestamp("arrivaltime");
      String fromWhere = rs.getString("comes");
      int flightId = rs.getInt("arrives");
      return new Arrival(time,fromWhere,flightId);
    }
  }

  @Override public void addArrival(Arrival newArrival, int flightID)
  {
    helper.executeUpdate("INSERT INTO Arrival(arrivaltime,comes,arrives) VALUES(?,?,?)",newArrival.arrivalTime,newArrival.fromWhere,flightID);
  }

  @Override public List<Arrival> getArrivalsByName(String name)
  {
    return helper.map(new ArrivalMapper(),"SELECT * FROM Arrival WHERE comes = ?",name);
  }
}
