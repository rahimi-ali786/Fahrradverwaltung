using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace fahrradverwaltung
{

    public class Datenbank
    {
        private MySqlConnection conn;
        private string connstr = "SERVER=localhost; UID='root';PASSWORD='';DATABASE=fahrradverwaltung";

        public Datenbank(){
        conn = new MySqlConnection(connstr);
       }

        public List<Fertigwaren> fertigwarenEinlesen()
        {
            List<Fertigwaren> list = new List<Fertigwaren>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM fertigwaren;";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   Fertigwaren f = new Fertigwaren(
                        reader.GetInt32(0),
                        reader.IsDBNull(1) ? "" : reader.GetString(1)
                        );
                    list.Add(f);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        public void fertigwareInsert(Fertigwaren f)
        {
            int productID = f.Fertigwarenid;

            try
            {
                conn.Open();
                if (productID == -1)
                {

                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format(
                        "INSERT INTO fertigwaren VALUES(NULL, '{0}');",
                         f.Fwmodell
                        );

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format(
                        "UPDATE fertigwaren SET Bezeichnung = '{0}' WHERE fwnr = {3};",
                            f.Fwmodell, productID
                        );

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        public List<Rohstoffe> rohstoffeEinlesen()
        {
           List<Rohstoffe> list = new List<Rohstoffe>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM rohstoffe;";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Rohstoffe r = new Rohstoffe(
                          reader.GetInt32(0),
                        reader.IsDBNull(1) ? 0.0 : reader.GetDouble(1),
                        reader.IsDBNull(2) ? "" : reader.GetString(2)
                     
                        );
                    list.Add(r);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        public void rohstoffInsert(Rohstoffe r)
        {
            int rohstoffID = r.Rohstoffid;

            try
            {
                conn.Open();

                //Preis als string vereinheitlichen
                //stellt sicher: "3.50" statt "3,50"
                string preisString = r.Preis.ToString(CultureInfo.InvariantCulture);

                MySqlCommand cmd = conn.CreateCommand();
                if (rohstoffID == -1)
                {
                    cmd.CommandText = string.Format(
                        "INSERT INTO rohstoffe VALUES(NULL, {0}, '{1}');",
                            preisString , r.Bezeichnung
                        );

                    cmd.ExecuteNonQuery();
                }
                else
                {       
                    cmd.CommandText = string.Format(
                        "UPDATE rohstoffe SET preis = {0}, bezeichnung = '{1}' WHERE rsnr = {2};",
                            preisString, r.Bezeichnung, rohstoffID
                        );

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        
      
        public List<fwrs> fwrsEinlesen()
        {
            List<fwrs> list = new List<fwrs>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM fwrs;";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   fwrs r = new fwrs(
                        reader.GetInt32(0),
                        reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                        reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                        reader.IsDBNull(3) ? 0 : reader.GetInt32(3)
                        );
                    list.Add(r);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        public void fwrsInsert(fwrs r)
        {
            
            try
            {
                conn.Open();
              
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format(
                        "INSERT INTO fwrs (fwnr, rsnr, rohwarenAnzahl) VALUES ({0}, {1}, {2});",
                           r.Fwid, r.Rsid, r.RohwarenAnzahl
                        );

                    cmd.ExecuteNonQuery();
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        
      
        public List<FertigwarenDetails> vfertigwarenEinlesen()
        {
            List<FertigwarenDetails> list = new List<FertigwarenDetails>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM vfertigwaren_details;";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    FertigwarenDetails r = new FertigwarenDetails(
                        
                         reader.IsDBNull(0) ? "" : reader.GetString(0),
                         reader.IsDBNull(1) ? "" : reader.GetString(1),
                         reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                         reader.IsDBNull(3) ? 0.0 : reader.GetDouble(3)
                         );
                    list.Add(r);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

      

    }
}
