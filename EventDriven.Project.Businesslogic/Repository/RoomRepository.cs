using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class RoomRepository
    {
        private string CONNECTIONSTRING = ConfigurationHelper.GetConnectionString();
        public List<RoomModel> GetRoomModel(string RoomType)
        {
            List<RoomModel> rooms = new List<RoomModel>();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetRoomModel", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomType", RoomType);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new RoomModel()
                            {
                                RoomNumber = (int)reader["RoomNumber"],
                                BedNumbers = (int)reader["BedNumbers"],
                                OccupiedBeds = (int)reader["OccupiedBeds"],
                                AvailableBeds = (int)reader["AvailableBeds"]
                            });
                        }
                    }
                }
            }
            return rooms;
        }
        public RoomInfoModel GetRoomByRoomID(int RoomID)
        {
            RoomInfoModel room = null;
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetRoomByRoomID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomID", RoomID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            room = new RoomInfoModel()
                            {
                                RoomID = reader.GetInt32(0),
                                RoomNumber = reader.GetInt32(1),
                                RoomType = reader.GetString(2),
                                RatePerDay = reader.GetDecimal(3),
                                Capacity = reader.GetInt32(4)
                            };
                        }
                    }
                }
            }
            return room;
        }
        public List<RoomInfoModel> GetAllRooms()
        {
            List<RoomInfoModel> rooms = new List<RoomInfoModel>();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetAllRooms", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new RoomInfoModel()
                            {
                                RoomID = reader.GetInt32(0),
                                RoomNumber = reader.GetInt32(1),
                                RoomType = reader.GetString(2),
                                RatePerDay = reader.GetDecimal(3),
                                Capacity = reader.GetInt32(4)
                            });
                        }
                    }
                }
            }
            return rooms;
        }
        public RoomOccupationModel GetRoomTypeAvailability(string RoomType)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetRoomTypeAvailability", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomType", RoomType);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RoomOccupationModel()
                            {
                                RoomType = RoomType,
                                TotalAvailableBeds = reader.GetInt32(0),
                                Capacity = reader.GetInt32(1)
                            };
                        }
                        else 
                            return null;
                    }
                }
            }
        }
        public void AssignRoom(AssignedRoomModel assignedRoom)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("AssignRoom", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomID", assignedRoom.RoomID);
                    cmd.Parameters.AddWithValue("@PatientID", assignedRoom.PatientID);
                    cmd.Parameters.AddWithValue("@BedNumber", assignedRoom.BedNumber);
                    cmd.Parameters.AddWithValue("@StartDate", assignedRoom.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", (object?)assignedRoom.EndDate ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public RoomNumberModel GetRoomNumberInfo(int RoomNumber)
        {
            RoomNumberModel roomNumberInfo = null;
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetRoomNumberInfo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomNumber", RoomNumber);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            roomNumberInfo = new RoomNumberModel()
                            {
                                RoomNumber = reader.GetInt32(0),
                                OccupiedBeds = reader.GetInt32(1),
                                Capacity = reader.GetInt32(2)
                            };
                        }
                    }
                }
            }
            return roomNumberInfo;
        }
        public void DeleteAssignedRoom(int PatientID)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DeleteAssignedRoom", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    cmd.ExecuteNonQuery();
                }
            }        
        }
        public List<AssignedRoomModel> GetAssignedRoom(int PatientID)
        {
            List<AssignedRoomModel> assignedRooms = null;
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetAssignedRoom", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            assignedRooms.Add(new AssignedRoomModel()
                            {
                                RoomID = reader.GetInt32(2),
                                PatientID = reader.GetInt32(3),
                                BedNumber = reader.GetInt32(4),
                                StartDate = reader.GetDateTime(5),
                                EndDate = reader.IsDBNull(6) ? null : reader.GetDateTime(5)
                            });
                        }
                    }
                }
            }
            return assignedRooms;
        }
        public CurrentRoomModel GetCurrentRoom(int PatientID)
        {
            CurrentRoomModel currentRoom = null;
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetCurrentRoom", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentRoom = new CurrentRoomModel()
                            {
                                RoomID = reader.GetInt32(0),
                                RoomType = reader.GetString(1),
                                RoomNumber = reader.GetInt32(2),
                                BedNumber = reader.GetInt32(3),
                                StartDate = reader.GetDateTime(4),
                                EndDate = reader.IsDBNull(5) ? null : reader.GetDateTime(5)
                            };
                        }
                    }
                }
            }
            return currentRoom;
        }
    }
}