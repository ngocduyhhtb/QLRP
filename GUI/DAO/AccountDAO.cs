using GUI.DTO;
using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;//thư viện để mã hóa mật khẩu
using System.Text;

namespace GUI.DAO
{
    public class AccountDAO
    {
        private AccountDAO() { }

        private static string PasswordEncryption(string password)
        {
            //tính năng bảo mật cho việc đăng nhập
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);//chuyển qua mảng kiểu byte từ một chuỗi
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            //tạo ra bảng has(bảng băm) chứa các mảng byte
            //từ mật khẩu được mã hóa thành mảng băm

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }

            //tính năng mã hóa nâng cao bằng việc đảo ngược mật khẩu
            char[] arr = hasPass.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static int Login(string userName, string passWord)
        {
            try
            {
                string hashPassword = PasswordEncryption(passWord);
                using(var dbContext = new QLRPEntities())
                {
                    var queryResult = dbContext.TaiKhoans.Where(tk => tk.UserName == userName).FirstOrDefault<TaiKhoan>();
                    if(queryResult != null)
                    {
                        if (queryResult.Pass == hashPassword)
                        {
                            return 1;
                        }
                        else { return 0; };
                    } else { return -1; }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                throw error;
            }

        }

        public static bool UpdatePasswordForAccount(string userName, string passWord, string newPassWord)
        {

            string oldPass = PasswordEncryption(passWord);
            string newPass = PasswordEncryption(newPassWord);

            int result = DataProvider.ExecuteNonQuery("EXEC USP_UpdatePasswordForAccount @username , @pass , @newPass", new object[] { userName, oldPass, newPass });

            return result > 0;
        }

        public static TaiKhoan GetAccountByUserName(string userName)
        {
            try
            {
                using (var dbContext = new QLRPEntities())
                {
                    var queryResult = dbContext.TaiKhoans.Where(tk => tk.UserName == userName).FirstOrDefault<TaiKhoan>();
                    if (queryResult != null)
                    {
                        return queryResult;
                    }
                    else { return null; }
                }
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
                throw error;
            }
        }

        public static void DeleteAccountByIdStaff(string idStaff)
        {
            /*DataProvider.ExecuteQuery("DELETE dbo.TaiKhoan WHERE idNV = '" + idStaff + "'");*/
            try
            {
                using (var dbContext = new QLRPEntities())
                {
                   TaiKhoan taiKhoan = dbContext.TaiKhoans.Where(tk => tk.idNV == idStaff).FirstOrDefault<TaiKhoan>();
                    if (taiKhoan != null)
                    {
                        dbContext.TaiKhoans.Remove(taiKhoan);
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                throw error;
            }
        }

		public static DataTable GetAccountList()
		{
			return DataProvider.ExecuteQuery("USP_GetAccountList");
		}

		public static bool InsertAccount(string username, int accountType, string staffID)
		{
			int result = DataProvider.ExecuteNonQuery("EXEC USP_InsertAccount @username , @loaiTK , @idnv ", new object[] { username, accountType, staffID });
			return result > 0;
		}

		public static bool UpdateAccount(string username, int accountType)
		{
			string command = string.Format("USP_UpdateAccount  @username , @loaiTK", new object[] { username, accountType});
			int result = DataProvider.ExecuteNonQuery(command);
			return result > 0;
		}

		public static bool DeleteAccount(string username)
		{
            try
            {
                using (var dbContext = new QLRPEntities())
                {
                    var taiKhoan = dbContext.TaiKhoans.Where(tk => tk.UserName == username).FirstOrDefault<TaiKhoan>();
                    if (taiKhoan != null)
                    {
                        dbContext.TaiKhoans.Remove(taiKhoan);
                        dbContext.SaveChanges();
                        Console.WriteLine("DONE BRO");
                    }
                    return taiKhoan != null;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                throw error;
            }
            /*int result = DataProvider.ExecuteNonQuery("DELETE dbo.TaiKhoan WHERE UserName = N'" + username + "'");*/
	/*		return result > 0;*/
		}

		public static DataTable SearchAccountByStaffName(string name)
		{
			return DataProvider.ExecuteQuery("EXEC USP_SearchAccount @hoten ", new object[] { name });
		}

		public static bool ResetPassword(string username)
		{
			int result = DataProvider.ExecuteNonQuery("USP_ResetPasswordtAccount @username", new object[] { username});
			return result > 0;
		}
    }
}
