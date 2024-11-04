using System;

class Complaint{
    private string causeOfAction;
    private string plaintiffCitizenship;
    private string defendandCitizenship;
    private string originalStateOfFilling;
    private double amountInControversy;
    private int id;
    private static int nextId = 1;

    public string getCauseOfAction(){
        return causeOfAction;
    }
    public string getPlaintiff(){
        return plaintiffCitizenship;
    }
    public string getDefendant(){
        return defendandCitizenship;
    }
    public string getOrigionalStateOfFilling(){
        return originalStateOfFilling;
    }
    public double getAmountInControversy(){
        return amountInControversy;
    }
    public int getId(){
        return id;
    }

    public Complaint(string causeOfAction, double amountInControversy, string plaintiffCitizenship, string defendandCitizenship, string originalStateOfFilling){
        this.causeOfAction = causeOfAction;
        this.plaintiffCitizenship = plaintiffCitizenship;
        this.defendandCitizenship = defendandCitizenship;
        this.originalStateOfFilling = originalStateOfFilling;
        this.amountInControversy = amountInControversy;
        this.id = nextId;
        nextId++;
    }

}