﻿using MySql.Data.MySqlClient;
using schoolmanagementdcmjain.Database;
using schoolmanagementdcmjain.Master.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmanagementdcmjain.Master.Database
{
    class User
    {
        public bool createUser(CreateUserModel createUserModel)
        {
            Connection connection = new Connection();
            try
            {
                MySqlConnection mySqlConnection = connection.getConnection();
                string qry = "insert into create_user values('" + createUserModel._id + "','" + createUserModel.userName + "','" +
                    createUserModel.password + "','" + createUserModel.name + "'," + createUserModel.userRollType + ",'" + createUserModel.designation + "',"
                    + createUserModel.isApproved + ")";
                connection.insertData(qry);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.closeConnection();
            }
        }

        public string getIdOfUser()
        {
            try
            {
                String qry = "select ifnull(max(_id),10000) _id from create_user";
                Connection connection = new Connection();
                MySqlConnection mySqlConnection = connection.getConnection();
                MySqlDataReader mySqlDataReader=connection.selectDataQuery(qry);
                if(mySqlDataReader.Read())
                {
                    int val = Int32.Parse(mySqlDataReader.GetString(0));
                    val++;
                    return val.ToString();
                }
                else
                {
                    return Utility.Constants.emptyString;
                }
            }
            catch(Exception)
            {
                return Utility.Constants.emptyString;
            }
        }
    }
}
