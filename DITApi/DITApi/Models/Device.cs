using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DITApi.DTOs;
using DITApi.Config.Gateway;
using System.Data.SqlClient;
using System.Data;

namespace DITApi.Models
{
    public class Device
    {
        public DeviceDTO DevDTO { get; set; }
        private DatabaseGateway db;

        public Device(string id) 
        {
            DevDTO = new DeviceDTO();
            db = new DatabaseGateway();
            SqlDataReader dev = GetDevice(id);
            while (dev.Read())
            {
                DevDTO.DeviceName = dev.GetString(dev.GetOrdinal("dev_name"));
            }
        }

        private SqlDataReader GetDevice(string id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetDeviceByID", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@dev_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
