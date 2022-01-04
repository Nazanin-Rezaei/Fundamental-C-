using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_3_Class
{
    internal class Job
    {
        private string jobDesc;
        private double timeToComplete;
        private double hourlyRate;
        private double totalFee;

        public Job(string jobDesc, double timeToComplete, double hourlyRate)
        {
            this.jobDesc = jobDesc;
            this.timeToComplete = timeToComplete;
            this.hourlyRate = hourlyRate;

        }
        public string JobDesc
        {
            get
            {
                return jobDesc;
            }
            set
            {
                jobDesc = value;
            }
        }
        public double TimeToComplete
        {
            get
            {
                return timeToComplete;
            }
            set
            {
                timeToComplete = value;
                calcTotalFee();
            }
        }

        public double HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                hourlyRate = value;
                calcTotalFee();
            }
        }
        public double TotalFee
        {
            get
            {
                return totalFee;
            }
        }


        public static Job operator + (Job j1, Job j2)
        {
            string newJobDesc = j1.JobDesc + " and " + j2.JobDesc;
            double newTimeToComplete = j1.TimeToComplete + j2.TimeToComplete;   
            double newhourlyRated = (j1.HourlyRate + j2.HourlyRate)/2;

            Job addedJob = new Job(newJobDesc, newTimeToComplete, newhourlyRated);
            return addedJob;

        }




        private void calcTotalFee()
        {
            totalFee = timeToComplete * hourlyRate;
            
        }



    }   
}
