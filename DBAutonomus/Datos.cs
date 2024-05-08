using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
namespace DBAutonomus
{
    internal class Datos
    {
        OracleConnection con;
        string cadenaConexion = "User Id=ADMIN;Password=JOSEluis1981;Data Source=jldb_high";
        

        private OracleConnection abrirConexion()
        {
            OracleConfiguration.TnsAdmin = @"C:\Users\Jose Luis\Downloads\Wallet_JLDB";
            OracleConfiguration.WalletLocation=OracleConfiguration.TnsAdmin;
            try {
                con = new OracleConnection(cadenaConexion);
                con.Open();
                return con;
            }
            catch (Exception ex){
                return null;
            }
        }

        public bool cmd(string command)
        {
            try {
                OracleCommand cmdd= new OracleCommand(command,abrirConexion());
                cmdd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }

        public DataSet all(string cmd)
        {
            DataSet ds=new DataSet();
            OracleDataAdapter da;
            try {
                da= new OracleDataAdapter(cmd,abrirConexion());
                da.Fill(ds);
                return ds;       

            }
            catch (Exception ex) { return null; }
        }




    }
}

