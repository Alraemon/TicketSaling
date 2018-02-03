using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TJU.SoftCourse;

namespace TicketSaling.AccountManagement
{
    class AccountCtrl:OleDbConn
    {
        public bool addAccount(string id,string pwd,string roleName)
        {
            string sqlAccount = "INSERT INTO tblAccount(accountID,password,roleID) VALUES ('";
            sqlAccount += id + "','" + pwd +"','"+ serachRoleId(roleName) + "')";
            return execNonQuery(sqlAccount);
        }
        public bool delAccount(string id)
        {
            string sql = "DELETE FROM tblAccount WHERE accountID='";
            sql += id + "'";
            return execNonQuery(sql);
        }
        public bool addRole(int numRight,List<string> rightNo,string roleNo,string roleName)
        {
            bool ans=true;
            string sqlName = "INSERT INTO tblRole(roleName,roleID) VALUES ('";
            sqlName += roleName + "','" + roleNo + "')";
            for (int i=0;i<numRight; i++)          //通过循环将该角色的所有权限添加到表中
            {
                string sqlRole="INSERT INTO tblRight(roleID,rightID) VALUES ('";
                sqlRole += roleNo + "','" + rightNo[i] + "')";
                ans = ans && execNonQuery(sqlRole); //如果有一个语句失败了 ans就会返回false
            }
            ans = execNonQuery(sqlName) && ans;
            return ans;
        }
        public bool delRole(string roleNo)
        {
            string roleSql = "DELETE FROM tblRole WHERE roleID='";
            roleSql += roleNo + "'";
            string rightSql = "DELETE FROM tblRight WHERE roleID='";
            rightSql += roleNo + "'";
            return execNonQuery(roleSql) && execNonQuery(rightSql);
        }
        public List<object[]> loadRole()
        {
            string sql = "SELECT * FROM tblRole";
            List<object[]> roleNameList = execQuery(sql);
            return roleNameList;
        }

        public List<object[]>loadRight()
        {
            string sql = "SELECT * FROM tblRightName";
            List<object[]> rightNameList = execQuery(sql);
            return rightNameList;
        }
        public List<object[]> loadAccount()
        {
            string sql = "SELECT * FROM tblAccount";
            List<object[]> accountList = execQuery(sql);
            return accountList;
        }
        public string[] serachAccount(string acc,string pwd)
        {
            string sql1 = "SELECT roleID FROM tblAccount WHERE accountID='";
            sql1 += acc + "' AND password='" + pwd + "'";
            List<object[]> account = execQuery(sql1);
            if (account.Count == 0)
                return null;
            string roleID = account[0][0].ToString();
            string sql2 = "SELECT rightID FROM tblRight WHERE roleID='";
            sql2 += roleID + "'";
            List<object[]> right = execQuery(sql2);
            string[] rightList = new string[right.Count];
            for(int i=0;i<right.Count;i++)
            {
                rightList[i] = right[i][0].ToString();
            }
            return rightList;
        }
        public List<object[]> loadRoleRight()
        {
            string sql = "SELECT * FROM tblRight";
            List<object[]> temp = execQuery(sql);
            for (int i = 0; i < temp.Count; i++)
            {
                temp[i][0] = serachRightName(temp[i][0].ToString());
                temp[i][1] = serachRoleName(temp[i][1].ToString());
            }
            return temp;
        }
        public string serachRightId(string name)
        {
            string sql = "SELECT rightID FROM tblRightName WHERE rightName='";
            sql += name + "'";
            List<object[]> idList = execQuery(sql);
            object[] o = idList[0];
            return o[0].ToString();
        }
        public string serachRoleId(string name)
        {
            string sql = "SELECT roleID FROM tblRole WHERE roleName='";
            sql += name + "'";
            List<object[]> idList = execQuery(sql);
            object[] o = idList[0];
            return o[0].ToString();
        }
        public string serachRoleName(string id)
        {
            string sql = "SELECT roleName FROM tblRole WHERE roleID='";
            sql += id + "'";
            List<object[]> nameList = execQuery(sql);
            object[] o = nameList[0];
            return o[0].ToString();
        }
        public string serachRightName(string id)
        {
            string sql = "SELECT rightName FROM tblRightName WHERE rightID='";
            sql += id + "'";
            List<object[]> nameList = execQuery(sql);
            object[] o = nameList[0];
            return o[0].ToString();
        }
        public int loadRoleIdMax()
        {
            string sql = "SELECT MAX(roleID) FROM tblRole";
            List<object[]> temp = execQuery(sql);
            if (temp == null)
                return 0;
            else
                return int.Parse(temp[0][0].ToString());
        }
    }
}
