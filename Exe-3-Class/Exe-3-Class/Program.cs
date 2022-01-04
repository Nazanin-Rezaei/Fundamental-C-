//Design a Job class for Marold's Name Services. The class contains
// four data fields-Job description (for example, "wash windows") , time in hours to complete the job (for example, 3.5)
//,per-hour rate charged for the job (for example, $25000) , and total fee for the Job (hourly rate times hours).Include properties to get 
//and set each field except the total fee-that field will be read-only, and its value is calculated each time either the hourly fee or the number of hours 
//is set.Overload the + operatorso that two Jobs can be added. The sum of two Jobs is 
// a new Job containing the descriptions of both original Jobs (joined by "and"), the sum of the
//time in hours for the originalJobs. Write a Main( ) function that demonstrates all the methods work correctly.


using Exe_3_Class;

 Job j1 = new Job("wash dishes", 7, 14);
Console.WriteLine("{0}, {1}, {2}, {3}",j1.JobDesc, j1.TimeToComplete, j1.HourlyRate, j1.TotalFee);

 Job j2 = new Job("cleaning table", 3, 13.5);
Console.WriteLine("{0}, {1}, {2}, {3}", j2.JobDesc, j2.TimeToComplete, j2.HourlyRate, j2.TotalFee);

Job j3 = j1 + j2;
Console.WriteLine("{0}, {1}, {2}, {3}", j3.JobDesc, j3.TimeToComplete, j3.HourlyRate, j3.TotalFee);