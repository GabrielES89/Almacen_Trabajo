using MySqlConnector;

namespace Almacen1.Class
{
    class ClsGlobales
    {
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection("server=127.0.0.1;PORT=3306;database=db_almacen;Uid=root;pwd=;");
            //return new MySqlConnection("server=189.204.133.38;PORT=3306;database=db_almacen;Uid=mlegalmacenburgos;pwd=12mL3GN4jane;");
        }
    }
}
