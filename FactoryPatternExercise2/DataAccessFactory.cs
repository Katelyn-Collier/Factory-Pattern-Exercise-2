using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "sql":
                    return new SQLDataAccess();
                    break;
                case "mongo":
                    return new MongoDataAccess();
                    break;
                case "list":
                    return new ListDataAccess();
                    break;
                default:
                    return new ListDataAccess();
            }
        }

    }
}
