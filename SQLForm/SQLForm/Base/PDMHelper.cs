using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace SQLForm.Base
{
    #region Model
    public class ColumnInfo
    {
        public ColumnInfo()
        { }

        string columnId;

        public string ColumnId
        {
            get { return columnId; }
            set { columnId = value; }
        }
        string objectID;

        public string ObjectID
        {
            get { return objectID; }
            set { objectID = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        int creationDate;

        public int CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
        string creator;

        public string Creator
        {
            get { return creator; }
            set { creator = value; }
        }
        int modificationDate;

        public int ModificationDate
        {
            get { return modificationDate; }
            set { modificationDate = value; }
        }
        string modifier;

        public string Modifier
        {
            get { return modifier; }
            set { modifier = value; }
        }
        string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        string dataType;

        public string DataType
        {
            get { return dataType; }
            set { dataType = value; }
        }
        string length;

        public string Length
        {
            get { return length; }
            set { length = value; }
        }
        //是否自增量
        bool identity;

        public bool Identity
        {
            get { return identity; }
            set { identity = value; }
        }
        bool mandatory;
        //禁止为空
        public bool Mandatory
        {
            get { return mandatory; }
            set { mandatory = value; }
        }
        string extendedAttributesText;
        //扩展属性
        public string ExtendedAttributesText
        {
            get { return extendedAttributesText; }
            set { extendedAttributesText = value; }
        }
        string physicalOptions;

        public string PhysicalOptions
        {
            get { return physicalOptions; }
            set { physicalOptions = value; }
        }

        public void SetColumns(string name, string value)
        {
            switch (name)
            {
                case "a:ObjectID":
                    this.ObjectID = value;
                    break;
                case "a:Name":
                    this.Name = value;
                    break;
                case "a:Code":
                    this.Code = value;
                    break;
                case "a:CreationDate":
                    this.CreationDate = Convert.ToInt32(value);
                    break;
                case "a:Creator":
                    this.Creator = value;
                    break;
                case "a:ModificationDate":
                    this.ModificationDate = Convert.ToInt32(value);
                    break;
                case "a:Modifier":
                    this.Modifier = value;
                    break;
                case "a:Comment":
                    this.Comment = value;
                    break;
                case "a:DataType":
                    this.DataType = value;
                    break;
                case "a:Length":
                    this.Length = value;
                    break;
                case "a:Identity":
                    this.Identity = value.DataConvertToBool();
                    break;
                case "a:Mandatory":
                    this.Mandatory = value.DataConvertToBool();
                    break;
                case "a:PhysicalOptions":
                    this.PhysicalOptions = value;
                    break;
                case "a:ExtendedAttributesText":
                    this.ExtendedAttributesText = value;
                    break;
            }
        }

        public void SetXml(XmlNodeList xmlNodeList)
        {
            foreach (XmlNode xmlNode in xmlNodeList)
                switch (xmlNode.Name)
                {
                    case "a:ObjectID":
                        xmlNode.InnerText = this.objectID;
                        break;
                    case "a:Name":
                        xmlNode.InnerText = this.Name;
                        break;
                    case "a:Code":
                        xmlNode.InnerText = this.Code;
                        break;
                    case "a:CreationDate":
                        xmlNode.InnerText = this.CreationDate.ToString();
                        break;
                    case "a:Creator":
                        xmlNode.InnerText = this.Creator;
                        break;
                    case "a:ModificationDate":
                        xmlNode.InnerText = this.ModificationDate.ToString();
                        break;
                    case "a:Modifier":
                        xmlNode.InnerText = this.Modifier;
                        break;
                    case "a:Comment":
                        xmlNode.InnerText = this.Comment;
                        break;
                    case "a:DataType":
                        xmlNode.InnerText = this.DataType;
                        break;
                    case "a:Length":
                        xmlNode.InnerText = this.Length;
                        break;
                    case "a:Identity":
                        xmlNode.InnerText = this.Identity.ToString();
                        break;
                    case "a:Mandatory":
                        xmlNode.InnerText = this.Mandatory.ToString();
                        break;
                    case "a:PhysicalOptions":
                        xmlNode.InnerText = this.PhysicalOptions;
                        break;
                    case "a:ExtendedAttributesText":
                        xmlNode.InnerText = this.ExtendedAttributesText;
                        break;
                }
        }

    }
    public class PdmKey
    {
        public PdmKey()
        {
        }

        string keyId;

        public string KeyId
        {
            get { return keyId; }
            set { keyId = value; }
        }
        string objectID;

        public string ObjectID
        {
            get { return objectID; }
            set { objectID = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        int creationDate;

        public int CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
        string creator;

        public string Creator
        {
            get { return creator; }
            set { creator = value; }
        }
        int modificationDate;

        public int ModificationDate
        {
            get { return modificationDate; }
            set { modificationDate = value; }
        }
        string modifier;

        public string Modifier
        {
            get { return modifier; }
            set { modifier = value; }
        }

        IList<ColumnInfo> columns;

        public IList<ColumnInfo> Columns
        {
            get { return columns; }
        }

        public void AddColumn(ColumnInfo mColumn)
        {
            if (columns == null)
                columns = new List<ColumnInfo>();
            columns.Add(mColumn);
        }
    }

    public class TableInfo
    {
        public TableInfo()
        {
        }
        string tableId;

        public string TableId
        {
            get { return tableId; }
            set { tableId = value; }
        }
        string objectID;

        public string ObjectID
        {
            get { return objectID; }
            set { objectID = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        int creationDate;

        public int CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
        string creator;

        public string Creator
        {
            get { return creator; }
            set { creator = value; }
        }
        int modificationDate;

        public int ModificationDate
        {
            get { return modificationDate; }
            set { modificationDate = value; }
        }
        string modifier;

        public string Modifier
        {
            get { return modifier; }
            set { modifier = value; }
        }
        string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        string physicalOptions;

        public string PhysicalOptions
        {
            get { return physicalOptions; }
            set { physicalOptions = value; }
        }


        IList<ColumnInfo> columns;

        public IList<ColumnInfo> Columns
        {
            get { return columns; }
        }

        IList<PdmKey> keys;

        public IList<PdmKey> Keys
        {
            get { return keys; }
        }

        public void AddColumn(ColumnInfo mColumn)
        {
            if (columns == null)
                columns = new List<ColumnInfo>();
            columns.Add(mColumn);
        }

        public void AddKey(PdmKey mKey)
        {
            if (keys == null)
                keys = new List<PdmKey>();
            keys.Add(mKey);
        }

        public void SetTable(XmlNode xnP)
        {
            switch (xnP.Name)
            {
                case "a:ObjectID":
                    this.ObjectID = xnP.InnerText;
                    break;
                case "a:Name":
                    this.Name = xnP.InnerText;
                    break;
                case "a:Code":
                    this.Code = xnP.InnerText;
                    break;
                case "a:CreationDate":
                    this.CreationDate = Convert.ToInt32(xnP.InnerText);
                    break;
                case "a:Creator":
                    this.Creator = xnP.InnerText;
                    break;
                case "a:ModificationDate":
                    this.ModificationDate = Convert.ToInt32(xnP.InnerText);
                    break;
                case "a:Modifier":
                    this.Modifier = xnP.InnerText;
                    break;
                case "a:Comment":
                    this.Comment = xnP.InnerText;
                    break;
                case "a:PhysicalOptions":
                    this.PhysicalOptions = xnP.InnerText;
                    break;
                case "c:Columns":
                    PDMHelper.InitColumns(xnP, this);
                    break;
                case "c:Keys":
                    PDMHelper.InitKeys(xnP, this);
                    break;
            }
        }
    }

    public static class TableListExtensions
    {
        public static void SetXml(this List<TableInfo> list, XmlNodeList nodeList)
        {
            TableInfo model = null;

            foreach (XmlNode node in nodeList)
            {
                if (node.Name == "a:Name")
                {
                    model = list.FirstOrDefault(o => o.Name == node.InnerText);
                }
            }
            if (model == null) return;
            foreach (XmlNode node in nodeList)
            {
                switch (node.Name)
                {
                    case "a:ObjectID":
                        node.InnerText = model.ObjectID;
                        break;
                    case "a:Name":
                        node.InnerText = model.Name;
                        break;
                    case "a:Code":
                        node.InnerText = model.Code;
                        break;
                    case "a:CreationDate":
                        node.InnerText = model.CreationDate.ToString();
                        break;
                    case "a:Creator":
                        node.InnerText = model.Creator;
                        break;
                    case "a:ModificationDate":
                        node.InnerText = model.ModificationDate.ToString();
                        break;
                    case "a:Modifier":
                        node.InnerText = model.Modifier;
                        break;
                    case "a:Comment":
                        node.InnerText = model.Comment;
                        break;
                    case "a:PhysicalOptions":
                        node.InnerText = model.PhysicalOptions;
                        break;
                    case "c:Columns":
                        foreach (XmlNode xnColumn in node)
                        {
                            XmlElement xe = (XmlElement)xnColumn;
                            XmlNodeList xnCProperty = xe.ChildNodes;
                            foreach (XmlNode xnP in xnCProperty)
                            {
                                if (xnP.Name == "a:Name")
                                {
                                    model.Columns.FirstOrDefault(o => o.Name == xnP.InnerText)?.SetXml(xnCProperty);
                                    break;
                                }
                            }
                        }
                        break;
                }
            }

        }

        public static bool DataConvertToBool(this object val)
        { 
            bool.TryParse(val.ToString(), out bool result);

            return result;
        }
    }

    #endregion

    internal class PDMHelper
    {
        public const string a = "attribute", c = "collection", o = "object";

        public const string cClasses = "c:Classes";
        public const string oClass = "o:Class";

        public const string cAttributes = "c:Attributes";
        public const string oAttribute = "o:Attribute";

        public const string cTables = "c:Tables";
        public const string oTable = "o:Table";
        public const string oModel = "o:Model";

        public const string cColumns = "c:Columns";
        public const string oColumn = "o:Column";


        XmlDocument xmlDoc;
        XmlNamespaceManager xmlnsManager;

        /// <summary>
        /// 加载文件
        /// </summary>
        /// <param name="pdm_file"></param>
        public PDMHelper(string pdm_file)
        {
            PdmFile = pdm_file;
            Init();
        }

        string pdmFile;

        public string PdmFile
        {
            get { return pdmFile; }
            set
            {
                pdmFile = value;
                if (xmlDoc == null)
                {
                    xmlDoc = new XmlDocument();
                    xmlDoc.Load(pdmFile);
                    xmlnsManager = new XmlNamespaceManager(xmlDoc.NameTable);
                    xmlnsManager.AddNamespace("a", "attribute");
                    xmlnsManager.AddNamespace("c", "collection");
                    xmlnsManager.AddNamespace("o", "object");
                }
            }
        }

        public IList<TableInfo> Tables { get; set; }
        public IList<TableInfo> UpdateTable { get; set; } = new List<TableInfo>();

        void Init()
        {
            IList<TableInfo> tables = new List<TableInfo>();
            XmlNode xmList = xmlDoc.SelectSingleNode("//" + oModel, xmlnsManager);
            XmlNode xnTables = null;
            foreach (XmlNode x in xmList.ChildNodes)
            {
                if (x.Name == cTables)
                {
                    xnTables = x;
                    break;
                }
            }
            if (xnTables == null)
            {
                return;
            }

            foreach (XmlNode xnTable in xnTables.ChildNodes)
            {
                tables.Add(GetTable(xnTable));
            }
            Tables = tables;
        }

        //初始化"o:Table"的节点
        private TableInfo GetTable(XmlNode xnTable)
        {
            TableInfo mTable = new TableInfo();
            XmlElement xe = (XmlElement)xnTable;
            mTable.TableId = xe.GetAttribute("Id");
            XmlNodeList xnTProperty = xe.ChildNodes;
            foreach (XmlNode xnP in xnTProperty)
            {
                mTable.SetTable(xnP);
            }
            return mTable;
        }
        //初始化"c:Columns"的节点
        public static void InitColumns(XmlNode xnColumns, TableInfo pTable)
        {
            foreach (XmlNode xnColumn in xnColumns)
            {
                pTable.AddColumn(GetColumn(xnColumn));
            }
        }

        //初始化c:Keys"的节点
        public static void InitKeys(XmlNode xnKeys, TableInfo pTable)
        {
            foreach (XmlNode xnKey in xnKeys)
            {
                pTable.AddKey(GetKey(xnKey));
            }
        }

        public static ColumnInfo GetColumn(XmlNode xnColumn)
        {
            ColumnInfo mColumn = new ColumnInfo();
            XmlElement xe = (XmlElement)xnColumn;
            mColumn.ColumnId = xe.GetAttribute("Id");
            XmlNodeList xnCProperty = xe.ChildNodes;
            foreach (XmlNode xnP in xnCProperty)
            {
                mColumn.SetColumns(xnP.Name, xnP.InnerText);
            }
            return mColumn;
        }

        public static PdmKey GetKey(XmlNode xnKey)
        {
            PdmKey mKey = new PdmKey();
            XmlElement xe = (XmlElement)xnKey;
            mKey.KeyId = xe.GetAttribute("Id");
            XmlNodeList xnKProperty = xe.ChildNodes;
            foreach (XmlNode xnP in xnKProperty)
            {
                switch (xnP.Name)
                {
                    case "a:ObjectID":
                        mKey.ObjectID = xnP.InnerText;
                        break;
                    case "a:Name":
                        mKey.Name = xnP.InnerText;
                        break;
                    case "a:Code":
                        mKey.Code = xnP.InnerText;
                        break;
                    case "a:CreationDate":
                        mKey.CreationDate = Convert.ToInt32(xnP.InnerText);
                        break;
                    case "a:Creator":
                        mKey.Creator = xnP.InnerText;
                        break;
                    case "a:ModificationDate":
                        mKey.ModificationDate = Convert.ToInt32(xnP.InnerText);
                        break;
                    case "a:Modifier":
                        mKey.Modifier = xnP.InnerText;
                        break;
                        //还差 <c:Key.Columns>
                }
            }
            return mKey;
        }


        public void Save()
        {
            XmlNode xmList = xmlDoc.SelectSingleNode("//" + oModel, xmlnsManager);
            XmlNode xnTables = null;
            foreach (XmlNode x in xmList.ChildNodes)
            {
                if (x.Name == cTables)
                {
                    xnTables = x;
                    break;
                }
            }
            if (xnTables == null)
            {
                return;
            }
            foreach (XmlNode xnTable in xnTables.ChildNodes)
            {
                DetailTable(xnTable);
            }
            xmlDoc.Save(pdmFile);
        }

        /// <summary>
        /// 单个字段的注释
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="column"></param>
        /// <param name="comment"></param>
        public void SetComment(string tableName, string column, string comment)
        {
            if (Tables == null || Tables.Count == 0 || Tables.FirstOrDefault(o => o.Name == tableName)?.Columns?.FirstOrDefault(o => o.Name == column) == null) return;
            var model = UpdateTable.FirstOrDefault(o => o.Name == tableName) ?? Tables.FirstOrDefault(o => o.Name == tableName);
            if (model != null)
                model.Columns.FirstOrDefault(o => o.Name == column).Comment = comment;
            UpdateTable.Add(model);
        }
        /// <summary>
        /// 表的注释
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="comment"></param>
        public void SetComment(string tableName, string comment)
        {
            var model = UpdateTable.FirstOrDefault(o => o.Name == tableName) ?? Tables.FirstOrDefault(o => o.Name == tableName);
            if (model == null) return;
            UpdateTable.Add(model);
            model.Comment = comment;
        }
        /// <summary>
        /// 单表多字段的注释
        /// </summary>
        /// <param name="table"></param>
        /// <param name="columnsComment"></param>
        public void SetComment(string table, Dictionary<string, string> columnsComment)
        {
            foreach (var item in columnsComment)
            {
                SetComment(table, item.Key, item.Value);
            }
        }

        /// <summary>
        /// 多表多字段的注释
        /// </summary>
        /// <param name="tablesColumnsComment"></param>
        public void SetComment(Dictionary<string, Dictionary<string, string>> tablesColumnsComment)
        {
            foreach (var item in tablesColumnsComment)
            {
                SetComment(item.Key, item.Value);
            }
        }

        void DetailTable(XmlNode xnTable)
        {
            XmlElement xe = (XmlElement)xnTable;
            XmlNodeList xnTProperty = xe.ChildNodes;
            UpdateTable.ToList().SetXml(xnTProperty);
        }

    }
}
