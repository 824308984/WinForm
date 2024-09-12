using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using System.IO;
using System.Text.Json;
using System.Xml;
using Newtonsoft.Json;

namespace SQLForm.Base
{
    public static class Log
    {
        public static void Write(string log)
        {
            FileStream fs = new FileStream("log.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(log);
            sw.Close();
            fs.Close();
        }
    }
    public class Column : Attribute
    {
        public string Name { get; set; }
        public string PrimaryKey { get; set; }
        public string TableName { get; set; }
        public Column() { }
        public Column(string _name)
        {
            Name = _name;
        }
    }
    public static class Util
    {
        public static string ConvertJsonString(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            try
            {
                //格式化json字符串
                Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                TextReader tr = new StringReader(str);
                JsonTextReader jtr = new JsonTextReader(tr);
                object obj = serializer.Deserialize(jtr);
                if (obj != null)
                {
                    StringWriter textWriter = new StringWriter();
                    JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                    {
                        Formatting = Newtonsoft.Json.Formatting.Indented,
                        Indentation = 4,
                        IndentChar = ' '
                    };
                    serializer.Serialize(jsonWriter, obj);
                    return textWriter.ToString();
                }
                else
                {
                    return str;
                }
            }
            catch (Exception ex)
            {
                return str;
            }
        }
        public static T Get<T>(DataRow dr, List<string> columns) where T : new()
        {
            T model = new T();
            Type type = typeof(T);
            foreach (var item in type.GetProperties())
            {
                var attr = item.GetCustomAttribute<Column>();
                if (attr != null && !string.IsNullOrEmpty(attr.Name))
                {
                    if (columns.Contains(attr.Name))
                        item.SetValue(model, dr[attr.Name]);
                }
                else
                {
                    if (columns.Contains(item.Name))
                        item.SetValue(model, dr[item.Name]);
                }

            }
            return model;
        }

        public static List<T> Get<T>(DataTable dt) where T : new()
        {
            List<T> values = new List<T>();
            List<string> columns = new List<string>();
            foreach (DataColumn dc in dt.Columns)
            {
                columns.Add(dc.ColumnName);
            }
            foreach (DataRow dr in dt.Rows)
            {
                values.Add(Get<T>(dr, columns));
            }
            return values;
        }

        public static SqlString InsertSql<T>(this T model)
        {
            SqlString sql = new SqlString();
            List<string> columnSb = new List<string>();
            List<string> paramSb = new List<string>();
            Type type = typeof(T);
            string tableName = type.GetCustomAttribute<Column>()?.TableName ?? "";
            if (tableName == "") throw new Exception("Table Name 没有设置");
            foreach (var item in type.GetProperties())
            {
                var attr = item.GetCustomAttribute<Column>();
                if (attr != null && !string.IsNullOrEmpty(attr.PrimaryKey))
                {
                    continue;
                }

                if (attr != null && !string.IsNullOrEmpty(attr.Name))
                {
                    columnSb.Add(attr.Name);
                    paramSb.Add("@" + attr.Name);
                    sql.SetParams("@" + attr.Name, item.GetValue(model), item.PropertyType);
                }
                else
                {
                    columnSb.Add(item.Name);
                    paramSb.Add("@" + item.Name);
                    sql.SetParams("@" + item.Name, item.GetValue(model), item.PropertyType);
                }
            }
            sql.Append($"Insert Into {tableName} ({string.Join(",", columnSb)}) VALUES({string.Join(",", paramSb)})");
            return sql;
        }
        public static bool IsEnumEx(this Type type)
        {
            if (type.IsEnum)
            {
                return true;
            }

            if (!type.IsValueType)
            {
                return false;
            }

            return type.IsNumericEnum();
        }

        public static bool IsNumericEnum(this Type type)
        {
            TypeCode code = Type.GetTypeCode(type);
            return code == TypeCode.Byte ||
                   code == TypeCode.SByte ||
                   code == TypeCode.Int16 ||
                   code == TypeCode.Int32 ||
                   code == TypeCode.Int64 ||
                   code == TypeCode.UInt16 ||
                   code == TypeCode.UInt32 ||
                   code == TypeCode.UInt64;
        }

        public static bool IsInt(this Type type)
        {
            return typeof(int) == type;
        }
        public static bool IsDecimal(this Type type)
        {
            return typeof(decimal) == type ||
                typeof(double) == type ||
                typeof(float) == type;
        }
        public static bool IsLong(this Type type)
        {
            return typeof(long) == type;
        }
        public static bool IsBool(this Type type)
        {
            return typeof(bool) == type;
        }
        public static bool IsDateTime(this Type type)
        {
            return typeof(DateTime) == type;
        }
        public static bool IsGuid(this Type type)
        {
            return typeof(Guid) == type;
        }
        public static bool IsString(this Type type)
        {
            return typeof(string) == type;
        }
    }

    public class SqlString
    {
        public string debugSql
        {
            get
            {
                StringBuilder dbstring = new StringBuilder();

                if (parameters.Count > 0)
                {
                    foreach (var item in parameters)
                    {
                        dbstring.Append($"DECLARE {item.ParameterName} ");
                        switch (item.SqlDbType)
                        {
                            case SqlDbType.Int:
                                dbstring.AppendLine($"INT = {item.Value}");
                                break;
                            case SqlDbType.BigInt:
                                dbstring.AppendLine($"BIGINT = {item.Value}");
                                break;
                            case SqlDbType.Decimal:
                                dbstring.AppendLine($"DECIMAL = {item.Value}");
                                break;
                            case SqlDbType.VarChar:
                                dbstring.AppendLine($"VARCHAR({item.Size}) = '{item.Value}'");
                                break;
                            case SqlDbType.DateTime:
                                dbstring.AppendLine($"DateTime = '{item.Value}'");
                                break;
                            case SqlDbType.Bit:
                                dbstring.AppendLine($"INT = {Convert.ToInt32(item.Value)}");
                                break;
                            case SqlDbType.UniqueIdentifier:
                                dbstring.AppendLine($"UNIQUEIDENTIFIER = '{item.Value}'");
                                break;
                            case SqlDbType.Text:
                                dbstring.AppendLine($"TEXT = '{item.Value}'");
                                break;
                        }
                    }
                }

                if (sb != null)
                {
                    dbstring.AppendLine();
                    dbstring.AppendLine(sb.ToString());
                }

                return dbstring.ToString();
            }


        }
        StringBuilder sb = new StringBuilder();
        List<SqlParameter> parameters = new List<SqlParameter>();
        public SqlString()
        {
            sb = new StringBuilder();
        }
        public SqlString(string sql)
        {
            sb = new StringBuilder(sql);
        }
        public SqlString Append(string sql)
        {
            sb.AppendLine(sql);
            return this;
        }

        public SqlString SetParams(string key, object value, Type tp)
        {
            if (tp.IsInt() || tp.IsEnumEx())
            {
                SetInt32(key, Convert.ToInt32(value));
            }
            if (tp.IsLong())
            {
                SetInt64(key, Convert.ToInt64(value));
            }
            if (tp.IsDateTime())
            {
                SetDateTime(key, Convert.ToDateTime(value));
            }
            if (tp.IsDecimal())
            {
                SetDecimal(key, Convert.ToDecimal(value));
            }
            if (tp.IsBool())
            {
                SetBool(key, Convert.ToBoolean(value));
            }
            if (tp.IsGuid())
            {
                string v = Guid.Empty.ToString();
                if (!string.IsNullOrEmpty(key))
                {
                    v = Convert.ToString(value);
                }
                SetGuid(key, new Guid(v));
            }
            if (tp.IsString())
            {
                string v = "";
                if (!string.IsNullOrEmpty(key))
                {
                    v = Convert.ToString(value);
                }
                if (v.Length > 8000)
                {
                    SetText(key, v);
                }
                else
                {
                    SetString(key, v, v.Length);
                }
            }
            return this;
        }

        public SqlString SetInt32(string key, int value)
        {
            parameters.Add(new SqlParameter(key, SqlDbType.Int, 4) { Value = value });
            return this;
        }
        public SqlString SetInt64(string key, long value)
        {
            parameters.Add(new SqlParameter(key, SqlDbType.BigInt, 8) { Value = value });
            return this;
        }
        public SqlString SetDateTime(string key, DateTime value)
        {
            parameters.Add(new SqlParameter(key, SqlDbType.DateTime) { Value = value });
            return this;
        }
        public SqlString SetDecimal(string key, decimal value)
        {
            parameters.Add(new SqlParameter(key, SqlDbType.Decimal) { Value = value });
            return this;
        }
        public SqlString SetBool(string key, bool value)
        {
            parameters.Add(new SqlParameter(key, SqlDbType.Bit) { Value = value });
            return this;
        }
        public SqlString SetString(string key, string value, int size)
        {
            if (size > 8000) size = 8000;
            parameters.Add(new SqlParameter(key, SqlDbType.VarChar, size) { Value = value });
            return this;
        }
        public SqlString SetText(string key, string value)
        {
            parameters.Add(new SqlParameter(key, SqlDbType.Text) { Value = value });
            return this;
        }
        public SqlString SetGuid(string key, Guid value)
        {
            parameters.Add(new SqlParameter(key, SqlDbType.UniqueIdentifier) { Value = value });
            return this;
        }

        public SqlParameter[] GetParameters()
        {
            return parameters.ToArray();
        }
        public override string ToString()
        {
            return sb.ToString();
        }
    }

    public class SingleLink
    {
        private SingleLink() { }

        private static SingleLink _init;
        private static object LockObj = new object();
        public static SingleLink Init()
        {

            if (_init == null)
            {
                lock (LockObj)
                {
                    if (_init == null)
                    {
                        _init = new SingleLink();
                    }
                }
            }
            return _init;
        }

        public string IP { get; set; } = "192.168.100.200";
        public string UID { get; set; } = "pc_login";
        public string PWD { get; set; } = "uYVFQy67FGJmMY7Z";
        public string DataSource { get; set; } = "PollChief_Leon";


        public string TIP { get; set; }
        public string TUID { get; set; }
        public string TPWD { get; set; }
        public string TDataSource { get; set; }

        public string GetConnStr()
        {
            return $"Data Source={IP};Initial Catalog={DataSource};uid={UID};pwd={PWD}";
        }
        public string GetTestConnStr()
        {
            return $"Data Source={TIP};Initial Catalog={TDataSource};uid={TUID};pwd={TPWD}";
        }
    }

    public static class SqlHelper
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string ConnString
        {
            get { return SingleLink.Init().GetConnStr(); }
        }

        /// <summary>
        /// 创建数据库连接，并打开
        /// </summary>
        private static SqlConnection GetOpenConn(string conn)
        {
            SqlConnection con = null;
            if (!String.IsNullOrEmpty(conn))
            {
                con = new SqlConnection(conn);
            }
            else
            {
                con = new SqlConnection(ConnString);
            }
            try
            {
                con.Open();
            }
            catch { return null; }
            return con;
        }
        public static bool ConnectionTest()
        {
            bool IsCanConnectioned = false;
            var mySqlConnection = new SqlConnection(SingleLink.Init().GetTestConnStr());
            try
            {
                mySqlConnection.Open();
                IsCanConnectioned = true;
            }
            catch (Exception)
            {
                IsCanConnectioned = false;
            }
            finally
            {
                mySqlConnection.Close();
            }
            return IsCanConnectioned;
        }
        /// <summary>
        /// 执行一条带参数的sql语句，并返回第一行，第一列
        /// </summary>
        /// <param name="safe_sql">要执行的sql语句</param>
        /// <param name="values">参数列表</param>
        /// <returns>第一行第一列的值</returns>
        static object ExecuteScalar(string safe_sql, SqlParameter[] values = null, string conn = null)
        {
            SqlConnection con = GetOpenConn(conn);
            if (con == null) return 0;
            SqlCommand cmd = new SqlCommand(safe_sql, con);
            if (values != null)
                cmd.Parameters.AddRange(values);
            object obj = null;
            try
            {
                obj = cmd.ExecuteScalar();
            }
            catch { }
            con.Close();
            return obj;
        }

        /// <summary>
        /// 执行带参数的SQL语句
        /// </summary>
        /// <param name="safe_sql">sql语句</param>
        /// <param name="values">参数列表</param>
        /// <returns>对数据库的影响情况</returns>
        static int ExecuteNonQuery(string safe_sql, SqlParameter[] values = null, string conn = null)
        {
            SqlConnection con = GetOpenConn(conn);
            if (con == null) return 0;
            SqlCommand cmd = new SqlCommand(safe_sql, con);
            if (values != null)
                cmd.Parameters.AddRange(values);
            int result = 0;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Log.Write(e.Message);
                Log.Write(safe_sql);
            }
            con.Close();
            return result;
        }

        /// <summary>
        /// 执行带参数的SQL语句
        /// </summary>
        /// <param name="safe_sql">sql语句</param>
        /// <param name="values">参数列表</param>
        /// <returns>SqlDataReader数据库读取器</returns>
        static SqlDataReader ExecuteReader(string safe_sql, SqlParameter[] values = null, string conn = null)
        {
            SqlConnection con = GetOpenConn(conn);
            if (con == null) return null;
            SqlCommand cmd = new SqlCommand(safe_sql, con);
            if (values != null)
                cmd.Parameters.AddRange(values);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// 执行带参数的sql语句，返回执行结果
        /// </summary>
        /// <param name="safe_sql">sql语句</param>
        /// <param name="values">参数列表</param>
        /// <returns>DataTable数据表</returns>
        public static DataTable ExecuteDataTable(string safe_sql, SqlParameter[] values = null, string conn = null)
        {
            DataTable table = new DataTable();
            SqlConnection con = GetOpenConn(conn);
            if (con == null) return table;
            SqlDataAdapter sda = new SqlDataAdapter(safe_sql, con);
            if (values != null)
                sda.SelectCommand.Parameters.AddRange(values);
            try
            {
                sda.Fill(table);
            }
            catch { }
            con.Close();
            return table;
        }

        public static List<T> ExecuteDataTable<T>(SqlString sql, string conn = null) where T : new()
        {
            return Util.Get<T>(ExecuteDataTable(sql.ToString(), sql.GetParameters(), conn));
        }

        public static T GetModel<T>(SqlString sql, string conn = null) where T : new()
        {
            return Util.Get<T>(ExecuteDataTable(sql.ToString(), sql.GetParameters(), conn)).FirstOrDefault();
        }

        public static object ExecuteScalar(SqlString sql, string conn = null)
        {
            return ExecuteScalar(sql.ToString(), sql.GetParameters(), conn);
        }
        public static int ExecuteNonQuery(SqlString sql, string conn = null)
        {
            return ExecuteNonQuery(sql.ToString(), sql.GetParameters(), conn);
        }

        public static void DateReader(SqlString sql, Action<SqlDataReader> action, string conn = null)
        {
            var dr = ExecuteReader(sql.ToString(), sql.GetParameters(), conn);

            while (dr.Read())
            {
                action(dr);
            }
        }

    }
}
