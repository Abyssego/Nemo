using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using Nemo;
using MySql.Data.MySqlClient;

namespace Nemo
{

    public class Bdd
    {
        private static MySqlConnection connection;
        private static string server;
        private static string database;
        private static string uid;
        private static string password;



        //Initialisation des valeurs
        public static void Initialize()
        {
            //Information de connection pour la BDD
            server = "localhost";      //Adresse du serveur 
            database = "nemo";    //Nom de la BDD
            uid = "root";              //Identifiant d'un utilisateur
            password = "root";         //Mot de passe du même utilisateur
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private static bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                Console.WriteLine("Erreur connexion BDD");
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }



        //Méthode pour insérer un nouvel enregistrement à la table NiveauPlonger
        public static void InsertNiveauPlonger(string nomNiveauPlonger, string prenomNiveauPlonger)
        {
            //Requête Insertion RendezVous
            string query = "INSERT INTO niveauplonger (nomRendezVous, prenomRendezVous) VALUES('" + nomNiveauPlonger + "','" + prenomNiveauPlonger + "')";
            MessageBox.Show(Convert.ToString(query));
            //open connection
            if (Bdd.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                Bdd.CloseConnection();
            }
        }


        public static void UpdateNiveauPlonger(int numNiveauPlonger, string descriptionNiveauPlonger)
        {
            //Update RendezVous
            string query = "UPDATE rendezvous SET IdNiveauPlonger='" + numNiveauPlonger + "', DescriptionNiveauPlonger='" + descriptionNiveauPlonger + "' WHERE IdNiveauPlonger=" + numNiveauPlonger;
            Console.WriteLine(query);
            MessageBox.Show(Convert.ToString(query));
            //Open connection
            if (Bdd.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                Bdd.CloseConnection();
            }
        }


        //Méthode pour supprimer un élément au numéro donnée de la table RendezVous
        public static void DeleteNiveauPlonger(int numNiveauPlonger)
        {
            //Delete Contrat
            string query = "DELETE FROM niveauplonger WHERE IdNiveauPlonger=" + numNiveauPlonger;

            if (Bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                Bdd.CloseConnection();
            }
        }


        //Méthode pour afficher tous les enregistrements de la table RendezVous
        public static List<NiveauPlonger> SelectNiveauPlonger()
        {
            //Select statement
            string query = "SELECT * FROM niveauplonger";

            //Create a list to store the result
            List<NiveauPlonger> dbNiveauPlonger = new List<NiveauPlonger>();

            //Ouverture connection
            if (Bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Lecture des données et stockage dans la collection
                while (dataReader.Read())
                {
                    NiveauPlonger leNiveauPlonger = new NiveauPlonger(Convert.ToInt32(dataReader["IdNiveauPlonger"]), Convert.ToString(dataReader["DescriptionNiveauPlonger"]));
                    dbNiveauPlonger.Add(leNiveauPlonger);
                }

                //fermeture du Data Reader
                dataReader.Close();

                //fermeture Connection
                Bdd.CloseConnection();

                //retour de la collection pour être affichée
                return dbNiveauPlonger;
            }
            else
            {
                return dbNiveauPlonger;
            }
        }

        //Méthode qui renvoie l'enregistrement concerné par rapport au numéro pour la table RendezVous
        public static NiveauPlonger SearchNiveauPlonger(int idNiveauPlonger)
        {
            //Select statement
            string query = "SELECT * FROM niveauplonger  WHERE IdNiveauPlonger = " + idNiveauPlonger;

            //Create a list to store the result
            List<NiveauPlonger> dbNiveauPlonger = new List<NiveauPlonger>();

            //Ouverture connection
            if (Bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmdS = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                MySqlDataReader dataReaderS = cmdS.ExecuteReader();

                //Lecture des données et stockage dans la collection
                while (dataReaderS.Read())
                {
                    NiveauPlonger leNiveauPlonger = new NiveauPlonger(Convert.ToInt32(dataReaderS["IdNiveauPlonger"]), Convert.ToString(dataReaderS["DescriptionNiveauPlonger"]));
                    dbNiveauPlonger.Add(leNiveauPlonger);
                }

                //fermeture du Data Reader
                dataReaderS.Close();

                //fermeture Connection
                Bdd.CloseConnection();

                //retour de la collection pour être affichée
                return dbNiveauPlonger[0];

            }
            else
            {
                //retour de la collection pour être affichée
                return dbNiveauPlonger[0];
            }

        }









        //Méthode pour insérer un nouvel enregistrement à la table NiveauPlonger
        public static void InsertSitePlonger(string nomNiveauPlonger, string prenomNiveauPlonger)
        {
            //Requête Insertion RendezVous
            string query = "INSERT INTO niveauplonger (nomRendezVous, prenomRendezVous) VALUES('" + nomNiveauPlonger + "','" + prenomNiveauPlonger + "')";
            MessageBox.Show(Convert.ToString(query));
            //open connection
            if (Bdd.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                Bdd.CloseConnection();
            }
        }


        public static void UpdateSitePlonger(int numSitePlonger, string nomSitePlonger, int profondeurMaxSitePlonger)
        {
            //Update RendezVous
            string query = "UPDATE rendezvous SET IdSitePlonger='" + numSitePlonger + "', DescriptionNiveauPlonger='" + nomSitePlonger + "', ProfondeurMaxSitePlonger='" + profondeurMaxSitePlonger + "' WHERE IdSitePlonger=" + numSitePlonger;
            Console.WriteLine(query);
            MessageBox.Show(Convert.ToString(query));
            //Open connection
            if (Bdd.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                Bdd.CloseConnection();
            }
        }


        //Méthode pour supprimer un élément au numéro donnée de la table RendezVous
        public static void DeleteSitePlonger(int numSitePlonger)
        {
            //Delete Contrat
            string query = "DELETE FROM siteplonger WHERE IdSitePlonger=" + numSitePlonger;

            if (Bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                Bdd.CloseConnection();
            }
        }


        //Méthode pour afficher tous les enregistrements de la table RendezVous
        public static List<SitePlonger> SelectSitePlonger()
        {
            //Select statement
            string query = "SELECT * FROM siteplonger";

            //Create a list to store the result
            List<SitePlonger> dbSitePlonger = new List<SitePlonger>();

            //Ouverture connection
            if (Bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Lecture des données et stockage dans la collection
                while (dataReader.Read())
                {
                    SitePlonger leSitePlonger = new SitePlonger(Convert.ToInt32(dataReader["IdNiveauPlonger"]), Convert.ToString(dataReader["NomSitePlonger"]), Convert.ToInt32(dataReader["ProfondeurMaxSitePlonger"]));
                    dbSitePlonger.Add(leSitePlonger);
                }

                //fermeture du Data Reader
                dataReader.Close();

                //fermeture Connection
                Bdd.CloseConnection();

                //retour de la collection pour être affichée
                return dbSitePlonger;
            }
            else
            {
                return dbSitePlonger;
            }
        }

        //Méthode qui renvoie l'enregistrement concerné par rapport au numéro pour la table RendezVous
        public static SitePlonger SearchSitePlonger(int idSitePlonger)
        {
            //Select statement
            string query = "SELECT * FROM siteplonger  WHERE IdSitePlonger = " + idSitePlonger;

            //Create a list to store the result
            List<SitePlonger> dbSitePlonger = new List<SitePlonger>();

            //Ouverture connection
            if (Bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmdS = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                MySqlDataReader dataReaderS = cmdS.ExecuteReader();

                //Lecture des données et stockage dans la collection
                while (dataReaderS.Read())
                {
                    SitePlonger leSitePlonger = new SitePlonger(Convert.ToInt32(dataReaderS["IdSitePlonger"]), Convert.ToString(dataReaderS["NomSitePlonger"]), Convert.ToInt32(dataReaderS["ProfondeurMaxSitePlonger"]));
                    dbSitePlonger.Add(leSitePlonger);
                }

                //fermeture du Data Reader
                dataReaderS.Close();

                //fermeture Connection
                Bdd.CloseConnection();

                //retour de la collection pour être affichée
                return dbSitePlonger[0];

            }
            else
            {
                //retour de la collection pour être affichée
                return dbSitePlonger[0];
            }

        }














        //Méthode pour insérer un nouvel enregistrement à la table NiveauPlonger
        public static void InsertParticipantPlonger(string datePlonger, int numParticipantPlonger, Plongeur lePlongeur, Plonger lePlonger, Personnel lePersonnel, string materielLouerParticipantPlonger, int presentParticipantPlonger)
        {
            //Requête Insertion RendezVous
            string query = "INSERT INTO niveauplonger (nomRendezVous, prenomRendezVous) VALUES('" + nomNiveauPlonger + "','" + prenomNiveauPlonger + "')";
            MessageBox.Show(Convert.ToString(query));
            //open connection
            if (Bdd.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                Bdd.CloseConnection();
            }
        }


        public static void UpdateParticipantPlonger(string datePlonger, int numParticipantPlonger, Plongeur lePlongeur, Plonger lePlonger, Personnel lePersonnel, string materielLouerParticipantPlonger, int presentParticipantPlonger)
        {
            //Update RendezVous
            string query = "UPDATE rendezvous SET IdSitePlonger='" + numSitePlonger + "', DescriptionNiveauPlonger='" + nomSitePlonger + "', ProfondeurMaxSitePlonger='" + profondeurMaxSitePlonger + "' WHERE IdSitePlonger=" + numSitePlonger;
            Console.WriteLine(query);
            MessageBox.Show(Convert.ToString(query));
            //Open connection
            if (Bdd.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                Bdd.CloseConnection();
            }
        }


        //Méthode pour supprimer un élément au numéro donnée de la table RendezVous
        public static void DeleteParticipantPlonger(int numSitePlonger)
        {
            //Delete Contrat
            string query = "DELETE FROM siteplonger WHERE IdSitePlonger=" + numSitePlonger;

            if (Bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                Bdd.CloseConnection();
            }
        }


        //Méthode pour afficher tous les enregistrements de la table RendezVous
        public static List<ParticipantPlonger> SelectParticipantPlonger()
        {
            //Select statement
            string query = "SELECT * FROM siteplonger";

            //Create a list to store the result
            List<SitePlonger> dbSitePlonger = new List<SitePlonger>();

            //Ouverture connection
            if (Bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Lecture des données et stockage dans la collection
                while (dataReader.Read())
                {
                    SitePlonger leSitePlonger = new SitePlonger(Convert.ToInt32(dataReader["IdNiveauPlonger"]), Convert.ToString(dataReader["NomSitePlonger"]), Convert.ToInt32(dataReader["ProfondeurMaxSitePlonger"]));
                    dbSitePlonger.Add(leSitePlonger);
                }

                //fermeture du Data Reader
                dataReader.Close();

                //fermeture Connection
                Bdd.CloseConnection();

                //retour de la collection pour être affichée
                return dbSitePlonger;
            }
            else
            {
                return dbSitePlonger;
            }
        }

        //Méthode qui renvoie l'enregistrement concerné par rapport au numéro pour la table RendezVous
        public static ParticipantPlonger SearchParticipantPlonger(int idParticipantPlonger)
        {
            //Select statement
            string query = "SELECT * FROM siteplonger  WHERE IdSitePlonger = " + idParticipantPlonger;

            //Create a list to store the result
            List<ParticipantPlonger> dbParticipantPlonger = new List<ParticipantPlonger>();

            //Ouverture connection
            if (Bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmdS = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                MySqlDataReader dataReaderS = cmdS.ExecuteReader();

                //Lecture des données et stockage dans la collection
                while (dataReaderS.Read())
                {
                    SitePlonger leSitePlonger = new SitePlonger(Convert.ToInt32(dataReaderS["IdNiveauPlonger"]), Convert.ToString(dataReaderS["NomSitePlonger"]), Convert.ToInt32(dataReaderS["ProfondeurMaxSitePlonger"]));
                    Plonger lePlonger = new Plonger(Convert.ToInt32(dataReaderS["IdPlonger"]), leSitePlonger, Convert.ToString(dataReaderS["DatePlonger"]), Convert.ToString(dataReaderS["DurerPlonger"]), Convert.ToString(dataReaderS["TypePlonger"]));
                    Plongeur
                    Personnel
                    ParticipantPlonger leParticipantPlonger = new ParticipantPlonger(Convert.ToInt32(dataReaderS["IdParticipantPlonger"]), Convert.ToString(dataReaderS["NomSitePlonger"]), Convert.ToInt32(dataReaderS["ProfondeurMaxSitePlonger"]));
                    dbParticipantPlonger.Add(leParticipantPlonger);
                }

                //fermeture du Data Reader
                dataReaderS.Close();

                //fermeture Connection
                Bdd.CloseConnection();

                //retour de la collection pour être affichée
                return dbParticipantPlonger[0];

            }
            else
            {
                //retour de la collection pour être affichée
                return dbParticipantPlonger[0];
            }

        }

    }

}
