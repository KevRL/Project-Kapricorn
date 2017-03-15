using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Text;


namespace Kapricorn
{
    public class GetDB
    {
        public MongoClient mClient = null;
        public MongoServer globalserver = null;
        //public MongoDatabase dbMongoREAD = null;
        //public string s_Database;
        //public string s_Collection;

        public MongoDatabase GetSystemDatabase(string strDatabase, string strCollection, ref MongoDatabase dbMongoREAD, ref string s_Database, ref string s_Collection)
        {
            //Retrieve server ip or name
            string s_mongo_ip = System.Configuration.ConfigurationManager.AppSettings["mongo_ip_address"];
            StringBuilder ConnectionStringUrl = new StringBuilder();
            string url = "Server=" + s_mongo_ip;

            s_Database = strDatabase;
            s_Collection = strCollection;

            try
            {
                if (dbMongoREAD == null)
                {
                    System.Net.WebProxy wprxWS = new System.Net.WebProxy();
                    wprxWS.Credentials = System.Net.CredentialCache.DefaultCredentials;

                    mClient = new MongoClient(url);
                    globalserver = mClient.GetServer();

                    MongoServer server = mClient.GetServer();

                    //Creating network connection;
                    dbMongoREAD = server.GetDatabase(s_Database);
                    if (dbMongoREAD == null)
                    {
                        //MessageBox.Show("Snaphsot could not make a connection to server for read/write");
                        return null;
                    }
                }

                return dbMongoREAD;
            }
            catch (MongoException me)
            {
                //MessageBox.Show("ANSWER\n" + me.Message);
            }

            //Could not connect to network!
            return null;
        }
    }
}