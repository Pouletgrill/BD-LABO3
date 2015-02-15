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
        private DataSet monDataSet = new DataSet();
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
        //Insertion
        private void BTN_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand oraAjout = new OracleCommand("GESTIONEMPLOYES", oraconn);
                oraAjout.CommandText = "GESTIONEMPLOYES.INSERTION";
                oraAjout.CommandType = CommandType.StoredProcedure;

                //Déclaration des paramettres
                OracleParameter oraPnumEmp = new OracleParameter("PNUMEMP", OracleDbType.Int32);
                oraPnumEmp.Direction = ParameterDirection.Input;
                oraPnumEmp.Value = TB_InsertNumEmp.Text;
                oraAjout.Parameters.Add(oraPnumEmp);

                OracleParameter oraPnomEmp = new OracleParameter("PNOMEMP", OracleDbType.Varchar2, 50);
                oraPnomEmp.Direction = ParameterDirection.Input;
                oraPnomEmp.Value = TB_InsertNomEmp.Text;
                oraAjout.Parameters.Add(oraPnomEmp);

                OracleParameter oraPprenomEmp = new OracleParameter("PPRENOMEMP", OracleDbType.Varchar2, 50);
                oraPprenomEmp.Direction = ParameterDirection.Input;
                oraPprenomEmp.Value = TB_InsertPrenomEmp.Text;
                oraAjout.Parameters.Add(oraPprenomEmp);

                OracleParameter oraPSalaireEmp = new OracleParameter("PSALAIREEMP", OracleDbType.Int32);
                oraPSalaireEmp.Direction = ParameterDirection.Input;
                oraPSalaireEmp.Value = TB_InsertSalEmp.Text;
                oraAjout.Parameters.Add(oraPSalaireEmp);

                OracleParameter OraDesc = new OracleParameter("PCODEDEP", OracleDbType.Char, 3);
                OraDesc.Direction = ParameterDirection.Input;
                OraDesc.Value = TB_InsertCodeDep.Text;
                oraAjout.Parameters.Add(OraDesc);
                //Execution de la requête
                oraAjout.ExecuteNonQuery();
                MessageBox.Show("Insertion réusit");
            }
            catch (OracleException Oe)
            {
                MessageBox.Show(Oe.Message);
            }
        }

        //Lister
        private void BTN_Lister_Click(object sender, EventArgs e)
        {

            try
            {
                // //déclaration de OracleCommand pour appeler la fonction avec la
                //connection conn.
                OracleCommand oraliste = new OracleCommand("GESTIONPRODUITS",
                oraconn);
                oraliste.CommandText = "GESTIONEMPLOYES.LISTER";
                oraliste.CommandType = CommandType.StoredProcedure;
                // pour une fonction, le paramètre de retour doit être déclaré en
                //premier.
                OracleParameter OrapameResultat = new
                OracleParameter("ENREMPLOYE", OracleDbType.RefCursor);
                OrapameResultat.Direction = ParameterDirection.ReturnValue;
                oraliste.Parameters.Add(OrapameResultat);

                // déclaration du paramètre en IN
                OracleParameter oraPcodeDep = new
                OracleParameter("PCODEDEP", OracleDbType.Char, 3);
                oraPcodeDep.Value = TB_ListerCodeDep.Text;
                oraPcodeDep.Direction = ParameterDirection.Input;
                oraliste.Parameters.Add(oraPcodeDep);

                // Pour remplir le DataSet, on déclare un OracleDataAdapter pour lequel
                // on passe notre OracleCommand qui contient TOUS les paramètres.

                OracleDataAdapter orAdater = new OracleDataAdapter(oraliste);
                if (monDataSet.Tables.Contains("ENREMPLOYE"))
                {
                    monDataSet.Tables["ENREMPLOYE"].Clear();
                }
                orAdater.Fill(monDataSet, "ENREMPLOYE");
                oraliste.Dispose();
                BindingSource maSource;
                maSource = new BindingSource(monDataSet, "ENREMPLOYE");
                DGV_Lister.DataSource = maSource;
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message.ToString());
            }
        }

        //Recherche
        private void BTN_Recherche_Click(object sender, EventArgs e)
        {
            try
            {
                // //déclaration de OracleCommand pour appeler la fonction avec la
                //connection conn.
                OracleCommand Oracmd = new OracleCommand("GESTIONPRODUITS",
                oraconn);
                Oracmd.CommandText = "GESTIONEMPLOYES.RECHERCHE";
                Oracmd.CommandType = CommandType.StoredProcedure;

                OracleParameter OraDesc = new
                OracleParameter("NOM", OracleDbType.Varchar2,30);
                OraDesc.Value = TB_RechercheNom.Text;
                OraDesc.Direction = ParameterDirection.Input;
                Oracmd.Parameters.Add(OraDesc);

                OracleParameter orapamres = new OracleParameter("ENREMPLOYE",
                OracleDbType.RefCursor);
                orapamres.Direction = ParameterDirection.Output;
                Oracmd.Parameters.Add(orapamres);

                // Pour remplir le DataSet, on déclare un OracleDataAdapter pour lequel
                // on passe notre OracleCommand qui contient TOUS les paramètres.

                OracleDataAdapter orAdater = new OracleDataAdapter(Oracmd);
                if (monDataSet.Tables.Contains("PARnom"))
                {
                    monDataSet.Tables["PARnom"].Clear();
                }
                orAdater.Fill(monDataSet, "PARnom");
                Oracmd.Dispose();
                BindingSource maSource;
                maSource = new BindingSource(monDataSet, "PARnom");
                DGV_Recherche.DataSource = maSource;
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message.ToString());
            }
        }

        //Count
        private void BTN_Count_Click(object sender, EventArgs e)
        {
            try
            {
                // //déclaration de OracleCommand pour appeler la fonction avec la
                //connection conn.
                OracleCommand OraCmdTotal = new OracleCommand("GESTIONPRODUITS", oraconn);
                OraCmdTotal.CommandText = "GESTIONEMPLOYES.COUNTEMPLOYES";
                OraCmdTotal.CommandType = CommandType.StoredProcedure;


                // déclaration du paramètre en OUT
                OracleParameter OraResultat = new
                OracleParameter("RESULTAT", OracleDbType.Int32);
                OraResultat.Direction = ParameterDirection.ReturnValue;
                OraCmdTotal.Parameters.Add(OraResultat);

                //comme on retourne un INT, on peut utiliser la méthode ExecuteScalar
                //de l'objet OracleCommande
                OraCmdTotal.ExecuteScalar();
                TB_Count.Text = OraResultat.Value.ToString();
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message.ToString());
            }
        }

        //Supprimer
        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // //déclaration de OracleCommand pour appeler la fonction avec la
                //connection conn.
                OracleCommand Oracmd = new OracleCommand("GESTIONPRODUITS",
                oraconn);
                Oracmd.CommandText = "GESTIONEMPLOYES.SUPPRIMER";
                Oracmd.CommandType = CommandType.StoredProcedure;

                //Déclaration des paramettres
                OracleParameter oraPnumEmp = new OracleParameter("PNUMEMP", OracleDbType.Int32);
                oraPnumEmp.Direction = ParameterDirection.Input;
                oraPnumEmp.Value = TB_SupprimerNumEmp.Text;
                Oracmd.Parameters.Add(oraPnumEmp);

                Oracmd.ExecuteNonQuery();
                MessageBox.Show("suppression réussie!");
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message.ToString());
            }
        }
    }
}
