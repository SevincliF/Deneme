using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Deneme
{
    public class SimulationManager
    {
        private UserOperations userOperations;

        public SimulationManager(string connectionString)
        {
            userOperations = new UserOperations(connectionString);
        }

        public List<SimulationResults> StartSimulation(int numTypeAUsers, int numTypeBUsers, IsolationLevel isolationLevel)
        {
            List<SimulationResults> results = new List<SimulationResults>();
            Thread[] threads = new Thread[numTypeAUsers + numTypeBUsers];

            for (int i = 0; i < numTypeAUsers; i++)
            {
                threads[i] = new Thread(() => userOperations.RunTypeAUser(isolationLevel, results));
                threads[i].Start();
            }

            for (int i = numTypeAUsers; i < numTypeAUsers + numTypeBUsers; i++)
            {
                threads[i] = new Thread(() => userOperations.RunTypeBUser(isolationLevel, results));
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            MessageBox.Show("Simulation completed!");
            return results;
        }
    }
}
