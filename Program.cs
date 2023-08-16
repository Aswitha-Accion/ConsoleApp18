// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using System;
using System.Data;
using System.Data.SqlClient;
namespace Application;
public class Program
{
    public void CreateTable()
    {
        SqlConnection con = null;
        try
        {
            con = new SqlConnection("data source = .; database = Employee; integrated security = SSPI");

            SqlCommand cm = new SqlCommand("create table Employee(id int not null, name varchar(50),  email varchar(50), city varchar(50)", con);

            con.Open();
            cm.ExecuteNonQuery();

            Console.WriteLine("Table created successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine("something went wrong" + ex);
        }
        finally
        {
            con.Close();
        }


    }
}

class Program1
{
    public static void Main()
    {
        new Program().CreateTable();
        Console.ReadKey();
    }
}

