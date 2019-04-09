/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using System;

namespace REvE.Configuration
{
    /// <summary>
    /// Class for resolving a Configuration Model from a SQL Database.
    /// </summary>
    /// <typeparam name="TResult">The Configuration Model.</typeparam>
    public class SqlConfigProvider<TResult> : ConfigProvider<TResult>
    {
        /// <summary>
        /// Basic constructor for specifying the application configuration connection string name pointing to the database source.
        /// </summary>
        /// <param name="dataSourceKey">The connection string name in the Application Configuration.</param>
        public SqlConfigProvider(string dataSourceKey) : base(dataSourceKey)
        {
        }

        /// <summary>
        /// TODO
        /// </summary>
        protected override void CloseConnection() => throw new NotImplementedException();

        /// <summary>
        /// TODO
        /// </summary>
        /// <returns></returns>
        protected override TResult Extract() => throw new NotImplementedException();

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="source"></param>
        protected override void OpenConnection(string source) => throw new NotImplementedException();
    }
}
