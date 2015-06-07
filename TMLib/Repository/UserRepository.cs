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
    public class UserRepository
    {
        private static IDbConnection conn = null;

        public UserRepository()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbTaskManager.accdb;";
        }

        public User getByUserNameAndPassword(string username, string password)
        {
            User result = null;
            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"
SELECT
*
FROM
  Users
WHERE
 UserName = @username AND
 Password = @password
";
            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = "@username";
            param.Value = username;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@password";
            param.Value = password;
            cmd.Parameters.Add(param);

            IDataReader reader = null;
            try
            {
                conn.Open();

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = (new User()
                      {
                          UserId = Convert.ToInt32(reader["UserId"]),
                          UserName = Convert.ToString(reader["UserName"]),
                          Password = Convert.ToString(reader["Password"]),
                          FirstName = Convert.ToString(reader["FirstName"]),
                          LastName = Convert.ToString(reader["LastName"])
                      });
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                conn.Close();
            }

            return result;
        }

        public List<User> GetAll()
        {
            List<User> resultList = new List<User>();
            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"
SELECT * FROM Users";
            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.UserId = Convert.ToInt32(reader["UserId"]);
                    user.UserName = Convert.ToString(reader["UserName"]);
                    user.Password = Convert.ToString(reader["Password"]);
                    user.FirstName = Convert.ToString(reader["FirstName"]);
                    user.LastName = Convert.ToString(reader["LastName"]);

                    resultList.Add(user);
                }
            }
            finally
            {
                conn.Close();
            }
            return resultList;
        }

        private void Insert(User item)
        {
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
INSERT INTO Users
(
    [UserName],
    [Password],
    FirstName,
    LastName
) 
VALUES
(
    @username,
    @password,
    @firstname,
    @lastname
)
";
            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = "@username";
            param.Value = item.FirstName;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@password";
            param.Value = item.Password;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@firstname";
            param.Value = item.FirstName;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@lastname";
            param.Value = item.LastName;
            cmd.Parameters.Add(param);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        private void Update(User item)
        {
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
UPDATE Users SET
[UserName] = @username,
[Password] = @password,
FirstName = @firstname,
LastName = @lastname
WHERE UserId = @id";

            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = "@username";
            param.Value = item.UserName;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@password";
            param.Value = item.Password;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@firstname";
            param.Value = item.FirstName;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@lastname";
            param.Value = item.LastName;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@id";
            param.Value = item.UserId;
            cmd.Parameters.Add(param);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void Delete(User item)
        {
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
DELETE FROM Users
WHERE UserId =@id";
            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = "@id";
            param.Value = item.UserId;
            cmd.Parameters.Add(param);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void Save(User item)
        {
            if (item.UserId < 1)
            {
                Insert(item);
            }
            else
            {
                Update(item);
            }
        }
    }
}
