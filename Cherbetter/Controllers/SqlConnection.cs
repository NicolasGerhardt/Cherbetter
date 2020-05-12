namespace Cherbetter.Controllers
{
    internal class SqlConnection
    {
        private object connString;

        public SqlConnection(object connString)
        {
            this.connString = connString;
        }
    }
}