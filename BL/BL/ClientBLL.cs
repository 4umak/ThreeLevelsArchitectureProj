using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using DAL;
namespace BLL
{
    public static class CLientBLL
    {
        public static List<Client> GetAll()
        {
            return (new ClientDAO()).GetAll();
        }
        public static Client GetById(int iD)
        {
            return (new ClientDAO()).Get(iD);
        }
        public static int Delete(int iD)
        {
            return (new ClientDAO()).Delete(iD);
        }
        public static int Update(Client client)
        {
            return (new ClientDAO()).Update(client);
        }
        public static int Add(Client client)
        {
            return (new ClientDAO()).Add(client);
        }
    }
}