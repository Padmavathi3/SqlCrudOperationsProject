using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlProject
{
    internal class ProcedureCrud
    {
        public void Insert(SqlConnection con)
        {
            try
            {

                Console.WriteLine("enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("enter age:");
                int age = int.Parse(Console.ReadLine());

                SqlCommand cmd = new SqlCommand("spInsertValues", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ename", name);
                cmd.Parameters.AddWithValue("@eage", age);
                int r = cmd.ExecuteNonQuery();
                Console.WriteLine($"{r} rows effected");
                Console.WriteLine();
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
                SqlCommand cmd = new SqlCommand("spSelect", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["id"]} {reader["name"]} {reader["age"]}");
                }

                Console.WriteLine();
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

        public void UpdateById(SqlConnection con)
        {
            try
            {
                Console.WriteLine("enter the id to to update");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the name to update the name");
                string e = Console.ReadLine();

                SqlCommand cmd = new SqlCommand("spUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", i);
                cmd.Parameters.AddWithValue("@ename", e);
                cmd.ExecuteNonQuery();
                Console.WriteLine("updated .......");
                Console.WriteLine();
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

        public void Delete(SqlConnection con)
        {
            try
            {
                Console.WriteLine("enter id to delete:");
                int i = int.Parse(Console.ReadLine());

                SqlCommand cmd = new SqlCommand("spDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", i);
                cmd.ExecuteNonQuery();
                Console.WriteLine("deletio done ......");
                Console.WriteLine();
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
            string path = "server=PADMAVATHI\\SQLEXPRESS; Initial Catalog=stored;Integrated Security=SSPI;MultipleActiveResultSets=True;";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            ProcedureCrud p= new ProcedureCrud();
            Console.WriteLine("1.insert 2.select 3.update 4.delete 5.close connection");
            Console.WriteLine("enter choice:");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    p.Insert(con);
                    break;
                case 2:
                    p.Select(con);
                    break;
                case 3:
                    p.UpdateById(con);
                    break;
                case 4:
                    p.Delete(con);
                    break;
                case 5:
                    p.close(con);
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
           

        }
    }
}
