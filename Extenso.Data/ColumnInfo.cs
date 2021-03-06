﻿using System.Data;

namespace Extenso.Data
{
    public enum KeyType : byte
    {
        None = 0,
        PrimaryKey = 1,
        ForeignKey = 2
    }

    public class ColumnInfo
    {
        public string ColumnName { get; set; }

        public long OrdinalPosition { get; set; }

        public string DefaultValue { get; set; }

        public bool IsNullable { get; set; }

        public DbType DataType { get; set; }

        public long MaximumLength { get; set; }

        public int Precision { get; set; }

        public int Scale { get; set; }

        public KeyType KeyType { get; set; }

        /// <summary>
        /// MSSQL: IDENTITY, PG: Sequence, etc..
        /// </summary>
        public bool IsAutoIncremented { get; set; }

        public override string ToString() => ColumnName;
    }
}