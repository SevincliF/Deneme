using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;

namespace Deneme
{
    public class UserOperations
    {
        private string connectionString;

        public UserOperations(string connString)
        {
            connectionString = connString;
        }

        public void RunTypeAUser(IsolationLevel isolationLevel, List<SimulationResults> results)
        {
            Stopwatch stopwatch = new Stopwatch();
            int deadlockCount = 0;

            stopwatch.Start();
            for (int i = 0; i < 100; i++)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        using (SqlTransaction transaction = conn.BeginTransaction(isolationLevel))
                        {
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            try
                            {
                                Random rnd = new Random();
                                if (rnd.NextDouble() < 0.5) ExecuteUpdateQuery(cmd, "20110101", "20111231");
                                if (rnd.NextDouble() < 0.5) ExecuteUpdateQuery(cmd, "20120101", "20121231");
                                if (rnd.NextDouble() < 0.5) ExecuteUpdateQuery(cmd, "20130101", "20131231");
                                if (rnd.NextDouble() < 0.5) ExecuteUpdateQuery(cmd, "20140101", "20141231");
                                if (rnd.NextDouble() < 0.5) ExecuteUpdateQuery(cmd, "20150101", "20151231");
                                transaction.Commit();
                            }
                            catch (SqlException ex) when (ex.Number == 1205)
                            {
                                deadlockCount++;
                                transaction.Rollback();
                            }
                            catch
                            {
                                transaction.Rollback();
                            }
                        }
                    }
                }
            }
            stopwatch.Stop();
            results.Add(new SimulationResults
            {
                TypeAUserCount = 1,
                AverageDurationTypeA = stopwatch.ElapsedMilliseconds / 100,
                DeadlocksTypeA = deadlockCount
            });
        }

        private void ExecuteUpdateQuery(SqlCommand cmd, string beginDate, string endDate)
        {
            cmd.CommandText = "UPDATE Sales.SalesOrderDetail " +
                              "SET UnitPrice = UnitPrice * 10.0 / 10.0 " +
                              "WHERE UnitPrice > 100 " +
                              "AND EXISTS (SELECT * FROM Sales.SalesOrderHeader " +
                              "WHERE Sales.SalesOrderHeader.SalesOrderID = Sales.SalesOrderDetail.SalesOrderID " +
                              "AND Sales.SalesOrderHeader.OrderDate BETWEEN @BeginDate AND @EndDate " +
                              "AND Sales.SalesOrderHeader.OnlineOrderFlag = 1)";
            cmd.Parameters.AddWithValue("@BeginDate", beginDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);
            cmd.ExecuteNonQuery();
        }

        public void RunTypeBUser(IsolationLevel isolationLevel, List<SimulationResults> results)
        {
            Stopwatch stopwatch = new Stopwatch();
            int deadlockCount = 0;

            stopwatch.Start();
            for (int i = 0; i < 100; i++)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        using (SqlTransaction transaction = conn.BeginTransaction(isolationLevel))
                        {
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            try
                            {
                                Random rnd = new Random();
                                if (rnd.NextDouble() < 0.5) ExecuteSelectQuery(cmd, "20110101", "20111231");
                                if (rnd.NextDouble() < 0.5) ExecuteSelectQuery(cmd, "20120101", "20121231");
                                if (rnd.NextDouble() < 0.5) ExecuteSelectQuery(cmd, "20130101", "20131231");
                                if (rnd.NextDouble() < 0.5) ExecuteSelectQuery(cmd, "20140101", "20141231");
                                if (rnd.NextDouble() < 0.5) ExecuteSelectQuery(cmd, "20150101", "20151231");
                                transaction.Commit();
                            }
                            catch (SqlException ex) when (ex.Number == 1205)
                            {
                                deadlockCount++;
                                transaction.Rollback();
                            }
                            catch
                            {
                                transaction.Rollback();
                            }
                        }
                    }
                }
            }
            stopwatch.Stop();
            results.Add(new SimulationResults
            {
                TypeBUserCount = 1,
                AverageDurationTypeB = stopwatch.ElapsedMilliseconds / 100,
                DeadlocksTypeB = deadlockCount
            });
        }

        private void ExecuteSelectQuery(SqlCommand cmd, string beginDate, string endDate)
        {
            cmd.CommandText = "SELECT SUM(Sales.SalesOrderDetail.OrderQty) " +
                              "FROM Sales.SalesOrderDetail " +
                              "WHERE UnitPrice > 100 " +
                              "AND EXISTS (SELECT * FROM Sales.SalesOrderHeader " +
                              "WHERE Sales.SalesOrderHeader.SalesOrderID = Sales.SalesOrderDetail.SalesOrderID " +
                              "AND Sales.SalesOrderHeader.OrderDate BETWEEN @BeginDate AND @EndDate " +
                              "AND Sales.SalesOrderHeader.OnlineOrderFlag = 1)";
            cmd.Parameters.AddWithValue("@BeginDate", beginDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);
            cmd.ExecuteScalar();
        }
    }
}
