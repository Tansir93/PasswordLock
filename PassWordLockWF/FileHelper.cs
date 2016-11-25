using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassWordLockWF
{
  public  class FileHelper
    {
        private static string Path = @"D:\Account.txt";


        private void FileExists()
        {
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }
        }


        internal bool AddFileText(objAccount account)
        {
            try
            {
                FileExists();
                using (FileStream fs = File.OpenWrite(Path))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(BUEncrypt(account.ToString()));
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }


        internal List<objAccount> GetFileText()
        {
            FileExists();
            StringBuilder sb = new StringBuilder();
            List<objAccount> list = new List<objAccount>();
            using (StreamReader sr = new StreamReader(Path, Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sb.Append(line);
                }
            }
            string Fileline = BUDecrypt(sb.ToString());
            string[] GroupStringFather = Fileline.Split('&');
            foreach (string item in GroupStringFather)
            {
                string[] GroupStringSon = item.Split('^');
                objAccount obj = new objAccount();
                obj.Account = GroupStringSon[0];
                obj.AppName= GroupStringSon[1];
                obj.Password= GroupStringSon[2];
                list.Add(obj);
            }
            return list;
        }





        //字符串加密
        private string BUEncrypt(string bb)
        {
            byte[] by = new byte[bb.Length];
            by = System.Text.Encoding.UTF8.GetBytes(bb);

            string r = Convert.ToBase64String(by);
            return r;
        }

        //字符串解密
        private string BUDecrypt(string aa)
        {
            try
            {
                byte[] by = Convert.FromBase64String(aa);

                string r = Encoding.UTF8.GetString(by);

                return r;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



    }
}
