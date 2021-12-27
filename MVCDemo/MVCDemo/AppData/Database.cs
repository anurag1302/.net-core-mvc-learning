using Microsoft.Extensions.Configuration;
using MVCDemo.Models;
using MVCDemo.Models.Roles;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MVCDemo.AppData
{
    public class Database
    {
        private readonly IConfiguration _configuration;

        public Database(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string DbConnection()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }

        public string CountryInfo
        {
            get
            {
                return _configuration.GetSection("Country").GetSection("India").Value;
            }
        }

        public string DbConnection1
        {
            get
            {
                return _configuration.GetConnectionString("DefaultConnection");
            }

        }

        public List<PersonModel> GetPersonsData()
        {
            var abc = CountryInfo;
            var persons = new List<PersonModel>();

            using (var connection = new SqlConnection(DbConnection()))
            {
                connection.Open();

                var query = "SELECT * FROM dbo.Person";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                var ds = new DataSet();
                da.Fill(ds);

                var dt = ds.Tables[0];

                foreach (DataRow item in dt.Rows)
                {
                    var personModel = new PersonModel
                    {
                        Id = int.Parse(item["Id"].ToString()),
                        Name = item["Name"].ToString(),
                        City = item["City"].ToString(),
                    };
                    persons.Add(personModel);
                }
            }
            return persons;
        }

        public List<RoleModel> GetRoles()
        {
            var roles = new List<RoleModel>();

            using (var connection = new SqlConnection(DbConnection()))
            {
                connection.Open();

                var query = "SELECT * FROM dbo.Roles";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                var ds = new DataSet();
                da.Fill(ds);

                var dt = ds.Tables[0];

                foreach (DataRow item in dt.Rows)
                {
                    var role = new RoleModel
                    {
                        RoleId = int.Parse(item["RoleId"].ToString()),
                        RoleName = item["RoleName"].ToString()
                    };
                    roles.Add(role);
                }
            }
            return roles;
        }
    }
}
