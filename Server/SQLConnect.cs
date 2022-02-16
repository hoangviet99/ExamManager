using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class SQLConnect
    {
        //string connectionString = "Data Source=DESKTOP-PKSKSS8;Initial Catalog=baitap;Integrated Security=True";
        private static string connectionString = "Data Source=.;database=ExamManager_ListStudentInformation;Integrated Security=True";

        public static List<StudentInformation> GetListStudentInfo_FromDatabase(string className)
        {
            List<StudentInformation> listStudentInfo = new List<StudentInformation>();

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM STUDENT WHERE ClassName = '" + className + "'";

            conn.Open();

            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                var studentInfo = new StudentInformation();
                studentInfo.StudentID = dataReader["StudentId"].ToString();
                studentInfo.StudentName = dataReader["Fullname"].ToString();
                studentInfo.ClassName = dataReader["ClassName"].ToString();

                listStudentInfo.Add(studentInfo);
            }

            conn.Close();

            return listStudentInfo;
        }

        public static List<ClassInformation> GetListClassInfo_FromDatabase()
        {
            List<ClassInformation> listClassInfo = new List<ClassInformation>();

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM CLASS";

            conn.Open();

            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                var classInfo = new ClassInformation();
                classInfo.ClassName = dataReader["ClassName"].ToString();

                listClassInfo.Add(classInfo);
            }

            conn.Close();

            return listClassInfo;
        }
    }
}
