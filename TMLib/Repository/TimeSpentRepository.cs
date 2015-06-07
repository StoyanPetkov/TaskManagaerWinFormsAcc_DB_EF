using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMLib.Entities;

namespace TMLib.Repository
{
    public class TimeSpentRepository
    {
        private IDbConnection conn = null;
        
        public TimeSpentRepository()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = dbTaskManager.accdb";
        }

        public void Insert(Tasks task,TimeSpent tSpent)
        {
            IDbCommand cmd = this.conn.CreateCommand();
            cmd.CommandText = @"
INSERT INTO TimeSpent
(
    [UserId],
    TaskId,
    TimeSpent,
    [Date],
    IsFinished
)
VALUES
(
    @userid,
    @taskid,
    @timespent,
    @date,
    @isfinished
)
";
            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = "@userid";
            param.Value = tSpent.Userid;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@taskid";
            param.Value = task.TaskId;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@timespent";
            param.Value = tSpent.LogTime;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@date";
            param.Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@isfinished";
            param.Value = task.IsFinished;
            cmd.Parameters.Add(param);

            try
            {
                this.conn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                this.conn.Close();
            }
        }

        public List<TimeSpent> GetAllTimeSpentById(int id)
        {
            List<TimeSpent> tSpentList = new List<TimeSpent>();
            IDbCommand cmd = this.conn.CreateCommand();
            cmd.CommandText = @"
SELECT * FROM TimeSpent
WHERE TaskId =@id";

            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = "@id";
            param.Value = id;
            cmd.Parameters.Add(param);

            try
            {
                this.conn.Open();
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TimeSpent tSpent = new TimeSpent();
                    tSpent.Userid = Convert.ToInt32(reader["UserId"]);
                    tSpent.Taskid = Convert.ToInt32(reader["TaskId"]);
                    tSpent.LogTime = Convert.ToInt32(reader["TimeSpent"]);
                    tSpent.Date = Convert.ToDateTime(reader["Date"]);
                    tSpent.IsFinished = Convert.ToBoolean(reader["IsFinished"]);

                    tSpentList.Add(tSpent);
                }
            }
            finally
            {
                this.conn.Close();
            }
            return tSpentList;
        }
    }
}
