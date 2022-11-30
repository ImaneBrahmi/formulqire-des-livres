using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace formulqire_des_livres
{
    public partial class Form1 : Form
    {
         
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C75HHEU\\SQLEXPRESS;Initial Catalog=bebliotheque;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btninsert.Enabled = true;
            btnUpdate.Enabled = false;
            btndelete.Enabled = false;
            btnConfirmer.Enabled = false;
            btnAnnuler.Enabled = false;
            SqlConnection conn=new SqlConnection("Data Source = DESKTOP-C75HHEU\\SQLEXPRESS; Initial Catalog = bebliotheque; Integrated Security = True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select titre from livre ", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            //selection des livres
            DataRow ligne = dt.NewRow();
            ligne[0] = "selectionner un livre";
            dt.Rows.InsertAt(ligne, 0);
            ListeLivre.DataSource = dt;
            ListeLivre.DisplayMember = "titre";
        }

        private void ListeLivre_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C75HHEU\\SQLEXPRESS;Initial Catalog=bebliotheque;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from livre where titre='" + ListeLivre.Text + "'", conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dataRow in dt.Rows)
            {
                titre.Text = dataRow["titre"].ToString();
                prix.Text = dataRow["prix"].ToString();
            }
            conn.Close();
            titre.Enabled = true;
            prix.Enabled = true;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (titre.Text == "" || prix.Text == "")
            {
                MessageBox.Show("remplir les champs");
                return;
            }

            // ouvrire de connection
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C75HHEU\\SQLEXPRESS;Initial Catalog=bebliotheque;Integrated Security=True");
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "insert into livre(titre,prix) values('" + titre.Text + "','" + prix.Text + "') ";
            // enable les button
            btndelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnConfirmer.Enabled = true;
            btnAnnuler.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // remplire des champs
            if (titre.Text == "" || prix.Text == "")
            {
                MessageBox.Show("remplir les champs");
                return;
            }

            if (titre.Text == "")
            {
                MessageBox.Show("errour");
                return;
            }
            btndelete.Enabled = false;
            btninsert.Enabled = false;
            btnConfirmer.Enabled = true;
            btnAnnuler.Enabled = true;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C75HHEU\\SQLEXPRESS;Initial Catalog=bebliotheque;Integrated Security=True");
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "update livre set prix='" + prix.Text + "' where titre='" + titre.Text + "' ";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            btninsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnConfirmer.Enabled = true;
            btnAnnuler.Enabled = true;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C75HHEU\\SQLEXPRESS;Initial Catalog=bebliotheque;Integrated Security=True");
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "delete from livre where titre='" + titre.Text + "' ";
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-C75HHEU\\SQLEXPRESS; Initial Catalog = bebliotheque; Integrated Security = True");
            conn.Open();
            SqlCommand commande = new SqlCommand("select titre from livre ", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = commande;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            //selection des livres
            DataRow ligne = dt.NewRow();
            ligne[0] = "selectionner un livre";
            dt.Rows.InsertAt(ligne, 0);
            ListeLivre.DataSource = dt;
            ListeLivre.DisplayMember = "titre";
            cmd.ExecuteNonQuery();
            conn.Close();
            btninsert.Enabled = true;
            btnUpdate.Enabled = true;
            btndelete.Enabled = true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            titre.Text = "";
            prix.Text = "";
        }
    }
}


