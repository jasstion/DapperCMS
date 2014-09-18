using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using System.Data.SQLite;
using Dapper;

namespace DataAccessLayer.Repositories
{
	/// <summary>
	/// 存储基类
	/// </summary>
    public abstract class BaseRepository
    {
		/// <summary>
		/// 用于查询最后插入数据的自增主键值的SQL语句
		/// </summary>
		protected const string SelectIdentityCommand="SELECT last_insert_rowid() AS Id";
		/// <summary>
		/// 获取最后插入数据的自增主键的值
		/// </summary>
		/// <param name="connection">数据库连接对象.</param>
		/// <param name="setId">Set identifier.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
        protected static void SetIdentity<T>(IDbConnection connection, Action<T> setId)
        {
			dynamic identity = connection.Query(SelectIdentityCommand).Single();
            T newId = (T)identity.Id;
            setId(newId);
        }
		/// <summary>
		/// 获取一个打开连接的数据库连接对象
		/// </summary>
		/// <returns>The connection.</returns>
        protected static IDbConnection OpenConnection()
        {
			IDbConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString);
            connection.Open();
            return connection;
        }
    }
}