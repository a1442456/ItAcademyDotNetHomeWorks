using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Loger;
using System.Diagnostics;

namespace Task1.DAL
{
    class MotocycleRepositoryDB : IMotocycleRepository
    {
        private LogWorker loger = new LogWorker();
        public void CreateMotocycle(Motocycle moto)
        {
            string query = $"insert into MotocyclesGarage.dbo.Motocycles values({moto.ID},'{moto.Model}','{moto.Name}',{moto.Year},{moto.Odometr})";
            string currentMethodName = GetMethodName();
            try
            {   
                loger.TypeInLogFile($"Entering to: {currentMethodName}");
                loger.TypeInLogFile(query, LogStatus.INFO);
                ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                loger.TypeInLogFile(ex.Message, LogStatus.ERROR);
            }
            loger.TypeInLogFile($"Exiting: {currentMethodName}");
        }

        public void DeleteMotocycle(int id)
        {   
            string query = $"delete from MotocyclesGarage.dbo.Motocycles where Motocycles.ID = {id}";
            string currentMethodName = GetMethodName();
            try
            {
                loger.TypeInLogFile($"Entering to: {currentMethodName}");
                loger.TypeInLogFile(query, LogStatus.INFO);
                ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                loger.TypeInLogFile(ex.Message, LogStatus.ERROR);
            }
            loger.TypeInLogFile($"Exiting: {currentMethodName}");
        }

        public Motocycle GetMotocycle(int id)
        {   
            string currentMethodName = GetMethodName();
            loger.TypeInLogFile($"Entering to: {currentMethodName}");
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand($"select * from MotocyclesGarage.dbo.Motocycles where Motocycles.ID = {id}", con);
            Motocycle resultMoto = new Motocycle();
            con.Open();
            SqlDataReader reader = command.ExecuteReader();            
            using (reader)
            {
                while (reader.Read())
                {
                    resultMoto.ID = (int)reader["ID"];
                    resultMoto.Model = (string)reader["Model"];
                    resultMoto.Name = (string)reader["Name"];
                    resultMoto.Year = !(reader["IssueYear"] is DBNull) ? (int)reader["IssueYear"] : 1230;
                    resultMoto.Odometr = (int)reader["Odometr"];
                }
            }
            con.Close();
            loger.TypeInLogFile($"Exiting: {currentMethodName}");
            return resultMoto;
        }

        public void UpdateMotoCycleModel(int id, string model)
        {
            string currentMethodName = GetMethodName();
            loger.TypeInLogFile($"Entering to: {currentMethodName}");
            string query = $"update MotocyclesGarage.dbo.Motocycles set Motocycles.Model = '{model}' where Motocycles.ID = {id}";
            try
            {
                loger.TypeInLogFile(query, LogStatus.INFO);
                ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                loger.TypeInLogFile(ex.Message, LogStatus.ERROR);
            }
            loger.TypeInLogFile($"Exiting: {currentMethodName}");
        }

        private void ExecuteQuery(string query)
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            command.ExecuteReader();
            con.Close();
        }

        private string GetMethodName()
        {
            StackTrace st = new StackTrace();
            StackFrame sf;
            string methodName = "Default method name";
            if (st.FrameCount != 0)
            {
                sf = st.GetFrame(1);
                methodName = sf.GetMethod().Name;
            }
            return methodName;
        }
    }
}
