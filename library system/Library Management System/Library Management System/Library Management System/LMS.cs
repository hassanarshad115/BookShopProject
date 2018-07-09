using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Library_Management_System
{
    class LMS
    {
        public DataTable GettingMemberTable()
        {
            string Query = "Select * from Member";
            SqlCommand sc = new SqlCommand(Query,ConnectionString.GetConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sds = new SqlDataAdapter(sc);
            sds.Fill(dt);
            return dt;
        }
        public DataTable GettingPublisherTable()
        {
            string Query = "Select * from Publisher";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sds = new SqlDataAdapter(sc);
            sds.Fill(dt);
            return dt;
        }
        public DataTable GettingAuthorTable()
        {
        string Query="Select * from Author";
            SqlCommand sc=new SqlCommand(Query,ConnectionString.GetConnection());
            DataTable dt=new DataTable();
            SqlDataAdapter sds =new SqlDataAdapter(sc);
            sds.Fill(dt);
            return dt;
        }
       
        public int InsertMember(string MemberRegistrationID, string MemberName, string MemberUserName, string MemberPassword, string MemberEmail, string MemberBookIssued)
        {
            string Query = "Insert into Member(MemberRegistrationID,MemberName,MemberUserName,MemberPassword,MemberEmail,MemberBookIssue) values('" + MemberRegistrationID + "','" + MemberName + "','" + MemberUserName + "','" + MemberPassword + "','" + MemberEmail + "','" + MemberBookIssued + "')";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            int Val = sc.ExecuteNonQuery();
            return Val;
        
        }
        public int InsertPublisher(string PublisherRegistrationID, string PublisherName, string PublisherYear, string PublisherHouse, string PublisherEdition)
        {
            string Query = "INSERT INTO Publisher(PublisherReg,PublisherName,PublisherYear,PublisherHouse,PublisherEdition) VALUES('" + PublisherRegistrationID + "','" + PublisherName + "','" + PublisherYear + "','" + PublisherHouse + "','" + PublisherEdition + "')";
            SqlCommand SC = new SqlCommand(Query, ConnectionString.GetConnection());
            int VAL = SC.ExecuteNonQuery();
            return VAL;
        }
        public int InstertAuthor(string AuthorReg, string AuthorName, string AuthorAddress, string AuthorPhone, string AuthorEmail)
        {
            string Query = "Insert into Author(AuthorReg,AuthorName,AuthorAddress,AuthorPhone,AuthorEmail) Values('" + AuthorReg + "','" + AuthorName + "','" + AuthorAddress + "','" + AuthorPhone + "','" + AuthorEmail + "')";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            int val = sc.ExecuteNonQuery();
            return val;
        }
        public int UpdatePublisher(int PublishingRegistrationID,string PublisherName, string PublisherYear, string PublisherHouse, string PublisherEdition)
        {
            string Query = "UPDATE Publisher SET PublisherName='" + PublisherName + "',PublisherYear='" + PublisherYear + "',PublisherHouse='" + PublisherHouse + "',PublisherEdition='" + PublisherEdition + "' WHERE PublisherID=" + PublishingRegistrationID + "";
            SqlCommand SC = new SqlCommand(Query, ConnectionString.GetConnection());
            int VAL = SC.ExecuteNonQuery();
            return VAL;
        }
    }
}
