using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public DataTable SelectAllEmp()
        {
            string query = "SELECT * FROM Employee;";
            return dbMan.ExecuteReader(query);
        }


        public int InsertProject(string Pname, int pnumber, string Plocation, int Dnum)
        {
            string query = "INSERT INTO Project (Pname, Pnumber, Plocation, Dnum)" +
                            "Values ('" + Pname + "'," + pnumber + ",'" + Plocation + "'," + Dnum + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectDepNum()
        {
            string query= "SELECT Dnumber FROM Department;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDepLoc()
        {
            string query = "SELECT DISTINCT Dlocation FROM Dept_Locations;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectProject(string location)
        {
            string query = "SELECT Pname,Dname FROM Department D, Project P, Dept_Locations L"
             +" where P.Dnum=D.Dnumber and L.Dnumber=D.Dnumber and L.Dlocation='"+location+"';"; 
            
            return dbMan.ExecuteReader(query);
        }

        public DataTable EmployeeFunc(int op)
        {
            string query;
            switch(op)
            {
                case 1:
                    query = "SELECT SSN, Address FROM Employee WHERE Salary < 40000;";
                    break;
                case 2:
                    query = "SELECT * FROM Employee WHERE Dno = 4 and Sex = 'F';";
                    break;
                case 4:
                    query = "SELECT DISTINCT Fname, Minit, Lname, Salary FROM " +
                        "(Employee JOIN Works_On ON Employee.SSN = Works_On.Essn and Works_On.Hours < 35) " +
                        "Join Project ON Works_On.Pno = Project.Pnumber and " +
                        "(Project.Plocation = 'Houston' or Project.Plocation = 'Stafford');";
                    break;
                case 5:
                    query = "SELECT DISTINCT Fname, Minit, Lname, SSN FROM " +
                        "(Employee JOIN Works_On ON Employee.SSN = Works_On.Essn) " +
                        "Join Project ON Works_On.Pno = Project.Pnumber and " +
                        "(Project.Dnum = 5 or Employee.Dno = 5);";
                    break;
                case 6:
                    query = "select max(Salary) as MaxValue, " +
                        "avg(Salary) as AvgValue, " +
                        "min(Salary) as MinValue from  Employee;";
                    break;
                default:
                    query = "";
                    break;
            }
            return dbMan.ExecuteReader(query);
        }

        public int UpdateEmployeeSalary(int SSN, int Salary)
        {
            string query = "UPDATE Employee SET Salary = " + Salary + " WHERE SSN = " + SSN + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertDepartment(int Dnumber, int Mgr_SSN, string Mgr_Start_Date, string Dlocation, string Dname)
        {
            string query = "INSERT INTO Department (Dname, Dnumber, Mgr_SSN, Mgr_Start_Date)" +
                            "Values ('" + Dname + "'," + Dnumber + "," + Mgr_SSN + ",CONVERT(DATETIME, " 
                            + Mgr_Start_Date + ")" + "); ";
            dbMan.ExecuteNonQuery(query);

            query = "INSERT INTO Dept_Locations (Dnumber, Dlocation)" +
                            "Values (" + Dnumber + ",'" + Dlocation + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable DeptFunc(int op)
        {
            string query;
            switch (op)
            {
                case 1:
                    query = "SELECT Dname FROM Department " +
                        "JOIN Dept_Locations " +
                        "ON Department.Dnumber = Dept_Locations.Dnumber " +
                        "and Dept_Locations.Dlocation = 'Houston';";
                    break;
                case 2:
                    query = "SELECT Employee.Lname, Employee.Salary " +
                        "FROM Employee " +
                        "JOIN Department " +
                        "ON Department.Mgr_SSN = Employee.SSN;";
                    break;
                default:
                    query = "";
                    break;
            }
            return dbMan.ExecuteReader(query);
        }
    }
}
