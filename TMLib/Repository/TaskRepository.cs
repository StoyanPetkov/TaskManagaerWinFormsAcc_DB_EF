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
    public class TaskRepository
    {
        private IDbConnection conn = null;

        public TaskRepository()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbTaskManager.accdb";
        }

        public List<Tasks> GetAll()
        {
            List<Tasks> result = new List<Tasks>();
            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"
SELECT * FROM Tasks";
            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Tasks task = new Tasks();
                    task.TaskId = Convert.ToInt32(reader["TaskId"]);
                    task.Title = Convert.ToString(reader["Title"]);
                    task.Description = Convert.ToString(reader["Description"]);
                    task.EstimatedTime = Convert.ToInt32(reader["EsstimatedTime"]);
                    task.Createdon = Convert.ToDateTime(reader["CreatedOn"]);
                    task.CreatedBy = Convert.ToInt32(reader["CreatedBy"]);
                    task.Assignedto = Convert.ToInt32(reader["AssignedTo"]);
                    task.IsFinished = Convert.ToBoolean(reader["IsFinished"]);
                    
                    result.Add(task);
                }
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public void Save(Tasks item)
        {
            if (item.TaskId < 1)
            {
                Insert(item);
            }
            else
            {
                Update(item);
            }
        }

        private void Update(Tasks item)
        {
            IDbCommand cmd = this.conn.CreateCommand();
            cmd.CommandText = @"
UPDATE Tasks SET
Title = @title,
Description = @description,
EsstimatedTime = @esstimatedtime,
AssignedTo = @assignedto,
IsFinished = @isfinished
WHERE TaskId=@id
";
            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = "@title";
            param.Value = item.Title;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@description";
            param.Value = item.Description;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@esstimatedtime";
            param.Value = item.EstimatedTime;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@assignedto";
            param.Value = item.Assignedto;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@isfinished";
            param.Value = item.IsFinished;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@id";
            param.Value = item.TaskId;
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

        private void Insert(Tasks item)
        {
            IDbCommand cmd = this.conn.CreateCommand();
            cmd.Connection = this.conn;
            cmd.CommandText = @"
INSERT INTO Tasks
(
    [Title],
    [Description],
    [EsstimatedTime],
    [CreatedOn],
    [CreatedBy],
    [AssignedTo],
    [IsFinished]
)
VALUES
(
    @title,
    @description,
    @esstimatedtime,
    @createdon,
    @createdby,
    @assignedto,
    @isfinished
)
";
            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = "@title";
            param.Value = item.Title;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@description";
            param.Value = item.Description;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@esstimatedtime";
            param.Value = item.EstimatedTime;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@createdon";
            param.Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@createdby";
            param.Value = item.CreatedBy;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@assignedto";
            param.Value = item.Assignedto;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@isfinished";
            param.Value = item.IsFinished;
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

        public void Delete(Tasks item)
        {
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
DELETE FROM Tasks
WHERE TaskId =@id";

            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = "@id";
            param.Value = item.TaskId;
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

        public bool CheckTask(Tasks item)
        {
            bool result = false;
            if (item.IsFinished == true)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
    }
}
