using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ClientDAO : BaseDAO
    {
        public Client Get(int id)
        {
            Client client = null;
            command.CommandText = "findClient";
            SqlParameter objParam = command.Parameters.Add("@param1", SqlDbType.Int);
            objParam.Value = id;
            SqlDataReader objReader = command.ExecuteReader();
            if (objReader.Read())
            {
                client = getItem(objReader);
            }
            conn.Close();
            return client;
        }
        public List<Client> GetAll()
        {
            command.CommandText = "findAllClients";
            return getItems();
        }
        public int Add(Client ob)
        {
            command.CommandText = "addClient";
            setParameters(ob);
            var insertedRows = command.ExecuteNonQuery();
            var o = command.Parameters["RETURN VALUE"].Value;
            if (o != null)
                insertedRows = Convert.ToInt32(o);
            conn.Close();
            return insertedRows;
        }
        public int Update(Client ob)
        {
            command.CommandText = "updateClient";
            //setParameters(ob);
            SqlParameter objParam1 = command.Parameters.Add("@id", SqlDbType.Int);
            objParam1.Value = ob.id;
            SqlParameter objParam2 = command.Parameters.Add("@Fname", SqlDbType.NVarChar);
            objParam2.Value = ob.Fname;
            SqlParameter objParam3 = command.Parameters.Add("@Sname", SqlDbType.NVarChar);
            objParam3.Value = ob.Sname;
            SqlParameter objParam4 = command.Parameters.Add("@login", SqlDbType.NVarChar);
            objParam4.Value = ob.login;
            SqlParameter objParam5 = command.Parameters.Add("@password", SqlDbType.NVarChar);
            objParam5.Value = ob.password;
            var insertedRows = command.ExecuteNonQuery();
            conn.Close();
            return insertedRows;
        }
        public int Delete(int id)
        {
            command.CommandText = "deleteOneClient";
            SqlParameter objParam = command.Parameters.Add("@param1", SqlDbType.Int);
            objParam.Value = id;
            int result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }
        private List<Client> getItems()
        {
            var objReader = command.ExecuteReader();
            var list = new List<Client>();
            while (objReader.Read())
            {
                list.Add(getItem(objReader));
            }
            conn.Close();
            return list;
        }

        private Client getItem(SqlDataReader objReader)
        {
            var client = new Client();
            object ob = null;
            client.id = int.Parse(objReader.GetValue(0).ToString());
            if ((ob = objReader.GetValue(1)) != DBNull.Value)
                client.Fname = Convert.ToString(ob);
            if ((ob = objReader.GetValue(2)) != DBNull.Value)
                client.Sname = Convert.ToString(ob);
            if ((ob = objReader.GetValue(3)) != DBNull.Value)
                client.login = Convert.ToString(ob);
            if ((ob = objReader.GetValue(4)) != DBNull.Value)
                client.password = Convert.ToString(ob);
            return client;
        }
        private void setParameters(Client ob)
        {
            SqlParameter objParam1 = command.Parameters.Add("@id", SqlDbType.Int);
            objParam1.Value = ob.id;
            SqlParameter objParam2 = command.Parameters.Add("@Fname", SqlDbType.NVarChar);
            objParam2.Value = ob.Fname;
            SqlParameter objParam3 = command.Parameters.Add("@Sname", SqlDbType.NVarChar);
            objParam3.Value = ob.Sname;
            SqlParameter objParam4 = command.Parameters.Add("@login", SqlDbType.NVarChar);
            objParam4.Value = ob.login;
            SqlParameter objParam5 = command.Parameters.Add("@password", SqlDbType.NVarChar);
            objParam5.Value = ob.password;
            SqlParameter objParam13 = command.Parameters.Add("RETURN VALUE", SqlDbType.Int);
            objParam13.Direction = ParameterDirection.ReturnValue;
        }
    }
}