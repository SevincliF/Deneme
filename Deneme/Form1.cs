﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Deneme
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=DESKTOP-F5PN9DA\\MSSQLSERVER01;Initial Catalog=AdventureWorks2012;Integrated Security=True;TrustServerCertificate=True;Max Pool Size=200;Connection Timeout=800;";
        private SimulationManager simulationManager;

        public Form1()
        {
            InitializeComponent();
            simulationManager = new SimulationManager(connectionString);
        }

        private void BtnStartSimulation_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTypeAUsers.Text, out int numTypeAUsers) && int.TryParse(txtTypeBUsers.Text, out int numTypeBUsers))
            {
                IsolationLevel isolationLevel = IsolationLevel.ReadCommitted;

                if (comboBoxIsolationLevel.SelectedItem != null)
                {
                    switch (comboBoxIsolationLevel.SelectedItem.ToString())
                    {
                        case "Read Uncommitted":
                            isolationLevel = IsolationLevel.ReadUncommitted;
                            break;
                        case "Read Committed":
                            isolationLevel = IsolationLevel.ReadCommitted;
                            break;
                        case "Repeatable Read":
                            isolationLevel = IsolationLevel.RepeatableRead;
                            break;
                        case "Serializable":
                            isolationLevel = IsolationLevel.Serializable;
                            break;
                    }
                }

                List<SimulationResults> results = simulationManager.StartSimulation(numTypeAUsers, numTypeBUsers, isolationLevel);
                DisplayResults(results);
            }
            else
            {
                MessageBox.Show("Please enter valid integer values for both user types.");
            }
        }

        private void DisplayResults(List<SimulationResults> results)
        {
            string resultText = "Simulation Results:\n";
            foreach (var result in results)
            {
                resultText += $"Type A Users: {result.TypeAUserCount}, Avg Duration: {result.AverageDurationTypeA}, Deadlocks: {result.DeadlocksTypeA}\n";
                resultText += $"Type B Users: {result.TypeBUserCount}, Avg Duration: {result.AverageDurationTypeB}, Deadlocks: {result.DeadlocksTypeB}\n";
            }
            MessageBox.Show(resultText);
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
            }
        }
    }
}
