using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;
using BO;

namespace ThreeLevelsProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string getAll()
        {
            var l = CLientBLL.GetAll();
            StringBuilder str = new StringBuilder("");
            Client client;
            for (int i = 0; i < l.Count; i++)
            {
                client = l[i];
                Console.WriteLine(client.login);
                str.Append("<li>");
                str.Append(client.id.ToString() + ". ");
                str.Append(client.Fname + " " + client.Sname + "   " + client.login + "   " + client.password);
                str.Append("</li>");
            }
            return str.ToString();
        }

        protected void findallClients_Click(object sender, EventArgs e)
        {
            try
            {
                ltrClients.Text = getAll();
                refreshBoxes();
            }
            catch (Exception err)
            {
                lblErrorMessage.Text = "Error " + err.Message;
            }
        }

        private int maxID()
        {
            var l = CLientBLL.GetAll();
            int max = 0;
            for (int i = 0; i < l.Count; i++)
                if (l[i].id > max)
                    max = l[i].id;
            return max+1;
        }
        protected void addClient_Click(object sender, EventArgs e)
        {
            try
            {
                Client cl = new Client();
                cl.id = maxID();
                cl.Fname = name1.Text;
                cl.Sname = sname1.Text;
                cl.login = login1.Text;
                cl.password = password1.Text;
                var i = CLientBLL.Add(cl);
                ltrClients.Text = getAll();
                refreshBoxes();
            }
            catch (Exception err)
            {
                lblErrorMessage1.Text = "Error " + err.Message;
            }
        }

        protected void deleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                var i = CLientBLL.Delete(int.Parse(id1.Text));
                ltrClients.Text = getAll();
                refreshBoxes();
            }
            catch (Exception err)
            {
                lblErrorMessage2.Text = "Error " + err.Message;
            }
        }

        protected void updateClient_Click(object sender, EventArgs e)
        {
            try
            {
                Client cl = new Client();
                cl.id = int.Parse(id2.Text);
                cl.Fname = name2.Text;
                cl.Sname = sname2.Text;
                cl.login = login2.Text;
                cl.password = password2.Text;
                var i = CLientBLL.Update(cl);
                ltrClients.Text = getAll();
                refreshBoxes();
            }
            catch (Exception err)
            {
                lblErrorMessage3.Text = "Error " + err.Message;
            }
        }

        protected void getClient_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(id3.Text);
                var l = CLientBLL.GetById(id);
                StringBuilder str = new StringBuilder("");
                str.Append("<li>");
               // str.Append(l.id.ToString() + ". ");
                str.Append(l.Fname + " " + l.Sname + "   " + l.login + "   " + l.password);
                str.Append("</li>");
                clientInfo.Text = str.ToString();
                refreshBoxes();
            }
            catch(Exception err)
            {
                lblErrorMessage4.Text = "Error " + err.Message;
            }
        }

        private void refreshBoxes()
        {
            name1.Text = "";
            name2.Text = "";
            sname1.Text = "";
            sname2.Text = "";
            login1.Text = "";
            login2.Text = "";
            password1.Text = "";
            password2.Text = "";
            id1.Text = "";
            id2.Text = "";
            id3.Text = "";
            lblErrorMessage.Text = "";
            lblErrorMessage1.Text = "";
            lblErrorMessage2.Text = "";
            lblErrorMessage3.Text = "";
            lblErrorMessage4.Text = "";
        }
    }
}