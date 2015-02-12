using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo_3
{
   public partial class Form1 : Form
   {
      private OracleConnection oraconn = new OracleConnection();
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         Connexion();
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         oraconn.Close();
      }

      /////////////
      //Connexion//
      /////////////
      private void Connexion()
      {
         //Remplit le DSource
         string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
             "(HOST=205.237.244.251)(PORT=1521)))" +
             "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
         string user = "BROSSEAU";
         string passwd = "ORACLE1";

         string chaineconnection = "Data Source = " + Dsource + ";User Id =" + user + "; Password =" + passwd;
         try
         {
            oraconn.ConnectionString = chaineconnection;
            oraconn.Open();
         }
         catch (OracleException ex)
         {
            MessageBox.Show(ex.ToString());            
         }
      }
      //\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\
   }
}
