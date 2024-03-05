using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlProject
{
   /* internal class SqlCrud
    {

        public void CreateTable(SqlConnection con)
        {
            try
            {
                string table = "create table Employee1(id int,name varchar(10),salary int)";
                SqlCommand command = new SqlCommand(table, con);
                command.ExecuteNonQuery();
                Console.WriteLine("table is created successfully");
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("do u want another option");
            string op=Console.ReadLine();
            if(op=="yes")
            {
                Main(new string[] { });
            }
        }
        public void InsertValues(SqlConnection con)
        {
            try
            {
                string insertion = "insert into employee1 values(1,'Lakshmi',2000),(2,'Padma',3000),(2,'Jaanu',5000)";
                SqlCommand command = new SqlCommand(insertion, con);
                command.ExecuteNonQuery();
                Console.WriteLine("insertion done successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("do u want another option");
            string op = Console.ReadLine();
            if (op == "yes")
            {
                Main(new string[] { });
            }
        }
        public void Select(SqlConnection con)
        {
            try
            {
                string selection = "select * from Employee1";
                SqlCommand command = new SqlCommand(selection, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"EmployeeId={reader["id"]}  EmployeeName={reader["name"]}  EmployeeSalary={reader["salary"]} ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("do u want another option");
            string op = Console.ReadLine();
            if (op == "yes")
            {
                Main(new string[] { });
            }
        }
        public void UpdateRows(SqlConnection con)
        {
            try
            {
                string update = "update Employee1 set salary=3500 where name='padma' ";
                SqlCommand command = new SqlCommand(update, con);
                command.ExecuteNonQuery();
                Console.WriteLine("updation done successfully");

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("do u want another option");
            string op = Console.ReadLine();
            if (op == "yes")
            {
                Main(new string[] { });
            }
        }
        public void DeleteRows(SqlConnection con)
        {
            try
            {
                string update = "delete from Employee1 where name='padma' ";
                SqlCommand command = new SqlCommand(update, con);
                command.ExecuteNonQuery();
                Console.WriteLine("deletion done successfully");
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("do u want another option");
            string op = Console.ReadLine();
            if (op == "yes")
            {
                Main(new string[] { });
            }
        }

        public void close(SqlConnection con)
        {
            con.Close();

        }
        public static void Main(string[] args)
        {
            string path = "server=PADMAVATHI\\SQLEXPRESS; Initial Catalog=payroll_service; Integrated Security=SSPI";
            SqlConnection con=new SqlConnection(path);
            con.Open();

            SqlCrud s = new SqlCrud();
            Console.WriteLine("1.create 2.insert 3.select 4.update 5.delete 6.close connection");
            Console.WriteLine("enter choice:");
            int c=int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    s.CreateTable(con);
                    break;
                case 2:
                    s.InsertValues(con);
                    break;
                case 3:
                    s.Select(con);
                    break;
                case 4:
                    s.UpdateRows(con);
                    break;
                case 5:
                    s.DeleteRows(con);
                    break;
                case 6:
                    s.close(con);
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }

        }
    }*/
}
