//
// BusinessTier:  business logic, acting as interface between UI and data store.
//

using System;
using System.Collections.Generic;
using System.Data;


namespace BusinessTier
{

  //
  // Business:
  //
  public class Business
  {
    //
    // Fields:
    //
    private string _DBFile;
    private DataAccessTier.Data dataTier;


    ///
    /// <summary>
    /// Constructs a new instance of the business tier.  The format
    /// of the filename should be either |DataDirectory|\filename.mdf,
    /// or a complete Windows pathname.
    /// </summary>
    /// <param name="DatabaseFilename">Name of database file</param>
    /// 
    public Business(string DatabaseFilename)
    {
      _DBFile = DatabaseFilename;

      dataTier = new DataAccessTier.Data(DatabaseFilename);
    }


    ///
    /// <summary>
    ///  Opens and closes a connection to the database, e.g. to
    ///  startup the server and make sure all is well.
    /// </summary>
    /// <returns>true if successful, false if not</returns>
    /// 
    public bool TestConnection()
    {
      return dataTier.OpenCloseConnection();
    }


    ///
    /// <summary>
    /// Returns all the CTA Stations, ordered by name.
    /// </summary>
    /// <returns>Read-only list of CTAStation objects</returns>
    /// 
    public IReadOnlyList<CTAStation> GetStations()
    {
      List<CTAStation> list = new List<CTAStation>();

      try
      {
                String sql = string.Format(@"
                    Select  *
                    From    Stations
                    Order by Name
                    ");
                DataSet stations = dataTier.ExecuteNonScalarQuery(sql);
                foreach (DataRow row in stations.Tables["TABLE"].Rows)
                {
                    var station = new BusinessTier.CTAStation(Convert.ToInt32(row["StationID"]), Convert.ToString(row["Name"]));
                    list.Add(station);
                }
      }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetStations: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

      return list;
    }


    ///
    /// <summary>
    /// Returns the CTA Stops associated with a given station,
    /// ordered by name.
    /// </summary>
    /// <returns>Read-only list of CTAStop objects</returns>
    ///
    public IReadOnlyList<CTAStop> GetStops(int stationID)
    {
      List<CTAStop> list = new List<CTAStop>();

      try
      {
                String sql = string.Format(@"
                    Select  *
                    From    Stops
                    Where   StationID = {0}
                    Order by Name
                    ", stationID);
                DataSet stops = dataTier.ExecuteNonScalarQuery(sql);
                foreach (DataRow row in stops.Tables["TABLE"].Rows)
                {
                    var stop = new BusinessTier.CTAStop(Convert.ToInt32(row["StopID"]), Convert.ToString(row["Name"]), Convert.ToInt32(row["StationID"]),
                                    Convert.ToString(row["Direction"]), Convert.ToBoolean(row["ADA"]), Convert.ToDouble(row["Latitude"]), Convert.ToDouble(row["Longitude"]));
                    list.Add(stop);
                }
      }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetStops: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

      return list;
    }


    ///
    /// <summary>
    /// Returns the top N CTA Stations by ridership, 
    /// ordered by name.
    /// </summary>
    /// <returns>Read-only list of CTAStation objects</returns>
    /// 
    public IReadOnlyList<CTAStation> GetTopStations(int N)
    {
      if (N < 1)
        throw new ArgumentException("GetTopStations: N must be positive");

      List<CTAStation> list = new List<CTAStation>();

      try
      {
                string sql = string.Format(@"
                    Select Stations.StationID, Name
                    From Stations
                    Join
                    (Select Top({0}) StationID, Sum(DailyTotal) as Total
                    From Riderships
                    Group by StationID
                    Order by Total DESC) as StationTotals
                    ON Stations.StationID = StationTotals.StationID
                    ", N);
                DataSet stations = dataTier.ExecuteNonScalarQuery(sql);
                foreach (DataRow row in stations.Tables["TABLE"].Rows)
                {
                    var station = new BusinessTier.CTAStation(Convert.ToInt32(row["StationID"]), Convert.ToString(row["Name"]));
                    list.Add(station);
                }
      }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetTopStations: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

      return list;
    } 

        // Returns station ID by name
        public int GetStationByName(string name)
        {
            int result = 0;
            name = name.Replace("'", "''");

            try
            {
                string sql = string.Format(@"
                    Select StationID
                    From Stations
                    Where Name = '{0}'
                    ", name);
                DataSet stations = dataTier.ExecuteNonScalarQuery(sql);
                DataRow row = stations.Tables[0].Rows[0];
                result = Convert.ToInt32(row["StationID"]);
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetStationByName: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }
            return result;
        }

        // Gets total ridership of entire database
        public Int64 GetTotalRidership()
        {
            Int64 result;

            try
            {
                string sql = string.Format(@"
                    Select Sum(Cast(DailyTotal as bigint))
                    From Riderships
                    ");
                result = Convert.ToInt64(dataTier.ExecuteScalarQuery(sql));
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetTotalRidership: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }

            return result;
        }

        // Gets total # of riders for a station
        public Int64 GetRiders(int ID)
        {
            Int64 result;

            try
            {
                string sql = string.Format(@"
                    Select Count(RiderID)
                    From Riderships
                    Inner Join Stations ON Stations.StationID = Riderships.StationID
                    Where Stations.StationID = '40380'
                    ");
                result = Convert.ToInt64(dataTier.ExecuteScalarQuery(sql));
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetRiders: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }

            return result;
        }

        // Gets total # of weekday riders for a station
        public Int64 GetWeekly(int ID)
        {
            Int64 result;

            try
            {
                string sql = string.Format(@"
                    Select Ridership
                    From
                    (Select TypeOfDay, Sum(DailyTotal) as Ridership
                    From Riderships
                    Where StationID = {0}
                    Group by TypeOfDay) as R
                    Where R.TypeOfDay = 'W'
                    ", ID);
                result = Convert.ToInt64(dataTier.ExecuteScalarQuery(sql));
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetWeekly: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }

            return result;
        }

        // Gets total # of saturday riders for a station
        public Int64 GetSat(int ID)
        {
            Int64 result;

            try
            {
                string sql = string.Format(@"
                    Select Ridership
                    From
                    (Select TypeOfDay, Sum(DailyTotal) as Ridership
                    From Riderships
                    Where StationID = {0}
                    Group by TypeOfDay) as R
                    Where R.TypeOfDay = 'A'
                    ", ID);
                result = Convert.ToInt64(dataTier.ExecuteScalarQuery(sql));
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetSat: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }

            return result;
        }

        // Gets total # of sunday/holiday riders for a station
        public Int64 GetSun(int ID)
        {
            Int64 result;

            try
            {
                string sql = string.Format(@"
                    Select Ridership
                    From
                    (Select TypeOfDay, Sum(DailyTotal) as Ridership
                    From Riderships
                    Where StationID = {0}
                    Group by TypeOfDay) as R
                    Where R.TypeOfDay = 'U'
                    ", ID);
                result = Convert.ToInt64(dataTier.ExecuteScalarQuery(sql));
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetSun: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }

            return result;
        }

        // Returns a dataset of all the lines a stop connects to
        public DataSet GetLines(string name)
        {
            DataSet table;
            name = name.Replace("'", "''");
            try
            {
                string sql = string.Format(@"
                    Select Lines.Color
                    From Lines
                    Inner Join StopDetails ON StopDetails.LineID = Lines.LineID
                    Inner Join Stops ON StopDetails.StopID = Stops.StopID
                    Where Stops.Name = '{0}'
                    Order by Lines.Color
                    ", name);
                table = dataTier.ExecuteNonScalarQuery(sql);
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetLines: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }
            return table;
        }

        // Returns a row of all the data for a stop
        public DataRow GetStopInfo(string name)
        {
            DataRow row;
            name = name.Replace("'", "''");
            try
            {
                string sql = string.Format(@"
                    Select *
                    From Stops
                    Where Name = '{0}'
                    ", name);
                DataSet table = dataTier.ExecuteNonScalarQuery(sql);
                row = table.Tables[0].Rows[0];
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetLines: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }
            return row;
        }

        // Returns the top 10 stations by weekday riders
        public IReadOnlyList<CTAStation> GetTopWeekly()
        {
            List<CTAStation> list = new List<CTAStation>();

            try
            {
                string sql = string.Format(@"
                    Select Stations.StationID, Name
                    From Stations
                    Join
                    (Select Top(10) StationID, Sum(DailyTotal) as Total
                    From Riderships
                    Where TypeOfDay = 'W'
                    Group by StationID
                    Order by Total DESC) as StationTotals
                    ON Stations.StationID = StationTotals.StationID
                    ");
                DataSet stations = dataTier.ExecuteNonScalarQuery(sql);
                foreach (DataRow row in stations.Tables["TABLE"].Rows)
                {
                    var station = new BusinessTier.CTAStation(Convert.ToInt32(row["StationID"]), Convert.ToString(row["Name"]));
                    list.Add(station);
                }
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetTopStations: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }

            return list;
        }

        // Returns the top 10 stations by saturday riders
        public IReadOnlyList<CTAStation> GetTopSat()
        {
            List<CTAStation> list = new List<CTAStation>();

            try
            {
                string sql = string.Format(@"
                    Select Stations.StationID, Name
                    From Stations
                    Join
                    (Select Top(10) StationID, Sum(DailyTotal) as Total
                    From Riderships
                    Where TypeOfDay = 'A'
                    Group by StationID
                    Order by Total DESC) as StationTotals
                    ON Stations.StationID = StationTotals.StationID
                    ");
                DataSet stations = dataTier.ExecuteNonScalarQuery(sql);
                foreach (DataRow row in stations.Tables["TABLE"].Rows)
                {
                    var station = new BusinessTier.CTAStation(Convert.ToInt32(row["StationID"]), Convert.ToString(row["Name"]));
                    list.Add(station);
                }
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetTopStations: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }

            return list;
        }

        // Returns the top 10 stations by sunday/holiday riders
        public IReadOnlyList<CTAStation> GetTopSun()
        {
            List<CTAStation> list = new List<CTAStation>();

            try
            {
                string sql = string.Format(@"
                    Select Stations.StationID, Name
                    From Stations
                    Join
                    (Select Top(10) StationID, Sum(DailyTotal) as Total
                    From Riderships
                    Where TypeOfDay = 'U'
                    Group by StationID
                    Order by Total DESC) as StationTotals
                    ON Stations.StationID = StationTotals.StationID
                    ");
                DataSet stations = dataTier.ExecuteNonScalarQuery(sql);
                foreach (DataRow row in stations.Tables["TABLE"].Rows)
                {
                    var station = new BusinessTier.CTAStation(Convert.ToInt32(row["StationID"]), Convert.ToString(row["Name"]));
                    list.Add(station);
                }
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetTopStations: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }

            return list;
        }

        // Finds all stations that contain the user input string in their names
        public IReadOnlyList<CTAStation> FindByName(string name)
        {
            List<CTAStation> list = new List<CTAStation>();
            name = name.Replace("'", "''");

            try
            {
                string sql = string.Format(@"
                    Select *
                    From Stations
                    Where Name LIKE '%{0}%'
                    Order by Name
                    ", name);
                DataSet stations = dataTier.ExecuteNonScalarQuery(sql);
                foreach (DataRow row in stations.Tables["TABLE"].Rows)
                {
                    var station = new BusinessTier.CTAStation(Convert.ToInt32(row["StationID"]), Convert.ToString(row["Name"]));
                    list.Add(station);
                }
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetTopStations: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }

            return list;
        }

        // Changes the handicap accessibility status of a stop
        public int ChangeADA(string name, int ada)
        {
            name = name.Replace("'", "''");
            int result = 0;
            try
            {
                string sql;
                if (ada == 1)
                {
                    sql = string.Format(@"
                        Update Stops
                        Set ADA = 'False'
                        From Stops
                        Where Name = '{0}'
                        ", name);
                }
                else
                {
                    sql = string.Format(@"
                        Update Stops
                        Set ADA = 'True'
                        From Stops
                        Where Name = '{0}'
                        ", name);
                }
                result = dataTier.ExecuteActionQuery(sql);
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetTopStations: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }

            return result;
        }

    }//class
}//namespace
