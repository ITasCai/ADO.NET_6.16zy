using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using DateAccess;

namespace ADO_Deam
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 增加

            //Console.WriteLine("请输入姓名");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入性别：1代表男，0代表女");
            //int sex = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入年龄");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入邮箱");
            //string email = Console.ReadLine();

            //string stradd = @"INSERT INTO dbo.UserInfo  ( UserName ,  UserSex ,  UserAge , UserEmail  )
            //                  VALUES  ( @UserName,@UserSex,@UserAge,@UserEmail)";


            //SqlParameter[] pa = new SqlParameter[] {
            //    new SqlParameter("@UserName",name),
            //    new SqlParameter("@UserSex",sex),
            //    new SqlParameter("@UserAge",age),
            //    new SqlParameter("@UserEmail",email)

            //};


            //int count = SqlHelper.ExecuteNonQuery(CommandType.Text,stradd,pa);

            //if (count>0)
            //{
            //    Console.WriteLine("添加成功！");
            //}
            //else
            //{
            //    Console.WriteLine("添加失败！");
            //}


            #endregion

            #region 删除

            //Console.WriteLine("请输入你要删除的id");
            //int id = Convert.ToInt32(Console.ReadLine());

            //string strDelete = "DELETE dbo.UserInfo WHERE UserId = @UserId";

            //SqlParameter[] pa = new SqlParameter[] {
            //    new SqlParameter("@UserId",id)
            //};
            //int count= SqlHelper.ExecuteNonQuery(CommandType.Text,strDelete,pa);

            //if (count>0)
            //{
            //    Console.WriteLine("删除成功！");
            //}
            //else
            //{
            //    Console.WriteLine("删除失败！");
            //}

            #endregion

            #region 修改

            //Console.WriteLine("请输你要修改的Id");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入姓名");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入性别（0表示女，1表示男）：");
            //int sex = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入年龄：");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入邮箱地址：");
            //string email = Console.ReadLine();

            //string strxg = "UPDATE dbo.UserInfo SET  UserName=@UserName,UserSex=@UserSex,UserAge=@UserAge,UserEmail=@UserEmail WHERE UserId=@UserId";

            //SqlParameter[] pa = new SqlParameter[] {
            //                    new SqlParameter("@UserName",name),
            //                    new SqlParameter("@UserSex",sex),
            //                    new SqlParameter("@UserAge",age),
            //                    new SqlParameter("@UserEmail",email),
            //                    new SqlParameter("@UserId",id)
            //};

            //int count = SqlHelper.ExecuteNonQuery(CommandType.Text, strxg, pa);

            //if (count > 0)
            //{
            //    Console.WriteLine("修改成功！");
            //}
            //else
            //{
            //    Console.WriteLine("修改失败！");
            //}

            #endregion

            #region 查询

            //Console.WriteLine("请输入你要查询的id:");
            //int id = Convert.ToInt32(Console.ReadLine());

            //string strcx =string.Format( "SELECT * FROM dbo.UserInfo WHERE UserId={0}",id);
            //DataSet ds = SqlHelper.ExecuteDataSet(CommandType.Text, strcx, null);

            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    DataRow dr = ds.Tables[0].Rows[i];
            //    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
            //    {
            //        Console.Write(dr[j] + "\t");
            //    }


            //}
            #endregion

            #region 事物

            string str1 = "INSERT INTO dbo.UserInfo( UserName ,  UserSex ,  UserAge ,  UserEmail)VALUES  ('张三',1,24,'dgfdhbf@163.com')";
            string str2 = "INSERT INTO dbo.UserInfo( UserName ,  UserSex ,  UserAge ,  UserEmail)VALUES  ('李四',1,20,'aafsbf@163.com')";

            try
            {
                //开启事务
                SqlHelper.BeginTransaction();
                SqlHelper.ExecuteTransaction(CommandType.Text, str1);
                SqlHelper.ExecuteTransaction(CommandType.Text, str2);
                //提价事务
                SqlHelper.CommitTransaction();

            }
            catch (Exception ex)
            {
                //回滚事务
                SqlHelper.RollBackTransaction();
                Console.WriteLine(ex.Message);
                throw;
            }

            #endregion
            Console.ReadKey();
        }
    }
}
