using System;
class Driver
{

    private static StreamWriter sw = new StreamWriter("accepted.txt");
    private static StreamWriter swRemanded = new StreamWriter("remanded.txt");
    
    public static void writeComplaint(StreamWriter sw, Complaint c){
            sw.WriteLine("Case ID: " + c.getId());
            sw.WriteLine("Cause of action: " + c.getCauseOfAction());
            sw.WriteLine("Amount in Controversy: $" + c.getAmountInControversy());
            sw.WriteLine("Plaintiff’s Citizenship: " + c.getPlaintiff());
            sw.WriteLine("Defendant’s Citizenship: " + c.getDefendant());
            sw.WriteLine("Originally filled in: " + c.getDefendant());
            sw.WriteLine("==============================");
    }

    public static void processComplaint(Complaint c){
        List<string> validCauses = new List<string>();


        validCauses.Add("Equal Protection Challenge");
        validCauses.Add("Title IX Workplace Discrimination");
        validCauses.Add("Prisoner Civil Rights Claim");
        validCauses.Add("Fair Labor Standard Act Claim");


        if(!validCauses.Contains(c.getCauseOfAction())){
            writeComplaint(swRemanded, c);
            throw new StateComplaintException("Not a valid cause of action");
        }
        else if(c.getPlaintiff().ToUpper() == c.getDefendant().ToUpper()){
            writeComplaint(swRemanded, c);
            throw new StateComplaintException("Lack of diversity");
        }
        else if(c.getAmountInControversy() <= 75000){
            writeComplaint(swRemanded, c);
            throw new StateComplaintException("Amount in controversy less than or equal to $75000");
        }
        else if(c.getDefendant() == c.getOrigionalStateOfFilling()){
            writeComplaint(swRemanded, c);
            throw new StateComplaintException("No prejudice through diversity");
        }
        else{
            writeComplaint(sw, c);
        }

    }

    public static void Main(string[] args)
    {
        Console.WriteLine("[Federal Court Complaint Processor]");

        Console.Write("Enter the name of the file: ");
        string fileName = Console.ReadLine();


        StreamReader sr;
        int countOfAcceptedCases = 0;
        int countOfTotalCases = 0;
        try
        {
            sr = new StreamReader(fileName);
            string line;

            while((line = sr.ReadLine()) != null){
                countOfTotalCases++;
                string[] complaintInfo = line.Split(",");

                string causeOfAction = complaintInfo[0];
                double amountInControversy = Double.Parse(complaintInfo[1]);
                string plaintiffCitizenship = complaintInfo[2]; 
                string defendandCitizenship = complaintInfo[3];
                string originalStateOfFilling = complaintInfo[4];

                try{
                    Complaint complaint = new Complaint(causeOfAction,amountInControversy,plaintiffCitizenship,defendandCitizenship,originalStateOfFilling);
                    processComplaint(complaint);
                    countOfAcceptedCases++;
                }
                catch{}

            }
            Console.WriteLine("Processing complete. Accepted cases written to accepted.txt and remanded cases written to remanded.txt");
            Console.WriteLine("Number of remanded cases: " + (countOfTotalCases - countOfAcceptedCases));
            Console.WriteLine("Number of accepted cases: " + countOfAcceptedCases);
        }
        catch{
            Console.WriteLine("No file with name \"" + fileName + "\"");
        }
        finally{
            Console.WriteLine("Shutting down...");
        }
        
        
    }
}