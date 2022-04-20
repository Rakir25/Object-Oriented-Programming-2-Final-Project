using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElecShop.DataAccess;
using System.Data.SqlClient;

namespace ElecShop.DataAccess
{
    class Employeedataaccess
    {
        DataAccess da;

        public Employeedataaccess()
        {
            da = new DataAccess();
        }

        public List<Employee> GetAllEmplyee()
        {
            string sql = "SELECT * FROM employees";
            SqlDataReader reader = da.GetData(sql);
            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                Employee p = new Employee();
              //  p.id = Int32.Parse(reader["id"]);
                p.name = reader["name"].ToString();
                p.salary = reader["salary"].ToString();
                p.phone = reader["phone"].ToString();
              //  p.Details = reader["Details"].ToString();

                list.Add(p);

            }


            return list;

        }


        public List<Employee> SearchEmployee(String pda)
        {
            string sql = "SELECT * from employees where name Like '%" + pda + "%'";
            SqlDataReader reader = da.GetData(sql);
            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                Employee p = new Employee();
                p.name = reader["name"].ToString();
                p.salary = reader["salary"].ToString();
                p.phone = reader["phone"].ToString();
                list.Add(p);


            }

            return list;

        }

        public int AddEmployee(Employee p)
        {
            string sql = "INSERT INTO employees (id,name,salary,phone) VALUES('" + p.id + "','" + p.name + "','" + p.salary + "','" + p.phone + "')";

            return da.ExecuteQuery(sql);
        }
        public int DeleteEmployee(int id)
        {
            string sql = "DELETE FROM employees where id=" + id;
            return da.ExecuteQuery(sql);
        }


    }
}
