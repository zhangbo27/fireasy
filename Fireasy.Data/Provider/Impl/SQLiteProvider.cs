﻿// -----------------------------------------------------------------------
// <copyright company="Fireasy"
//      email="faib920@126.com"
//      qq="55570729">
//   (c) Copyright Fireasy. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using Fireasy.Data.Batcher;
using Fireasy.Data.Extensions;
using Fireasy.Data.Identity;
using Fireasy.Data.RecordWrapper;
using Fireasy.Data.Schema;
using Fireasy.Data.Syntax;

namespace Fireasy.Data.Provider
{
    /// <summary>
    /// SQLite数据库提供者。无法继承此类。
    /// </summary>
    public sealed class SQLiteProvider : AssemblyProvider
    {
        /// <summary>
        /// 提供 <see cref="SQLiteProvider"/> 的静态实例。
        /// </summary>
        public readonly static SQLiteProvider Instance = new SQLiteProvider();

        /// <summary>
        /// 初始化 <see cref="SQLiteProvider"/> 类的新实例。
        /// </summary>
        public SQLiteProvider()
            : base("System.Data.SQLite.SQLiteFactory, System.Data.SQLite", null)
        {
            this.RegisterService<IGeneratorProvider, BaseSequenceGenerator>();
            this.RegisterService<ISyntaxProvider, SQLiteSyntax>();
            this.RegisterService<ISchemaProvider, SQLiteSchema>();
            this.RegisterService<IBatcherProvider, SQLiteBatcher>();
            this.RegisterService<IRecordWrapper, GeneralRecordWrapper>();
        }

        public override string DbName
        {
            get { return "sqlite"; }
        }

        /// <summary>
        /// 获取当前连接的参数。
        /// </summary>
        /// <returns></returns>
        public override ConnectionParameter GetConnectionParameter(ConnectionString connectionString)
        {
            return new ConnectionParameter
            {
                Database = connectionString.Properties["data source"],
            };
        }

        /// <summary>
        /// 使用参数更新指定的连接。
        /// </summary>
        /// <param name="connectionString">连接字符串对象。</param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public override string UpdateConnectionString(ConnectionString connectionString, ConnectionParameter parameter)
        {
            connectionString.Properties
                .TrySetValue(parameter.Database, "data source");

            return connectionString.Update();
        }
    }
}
