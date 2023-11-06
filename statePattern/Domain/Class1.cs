using Domain.States;

namespace Domain;
public class LoanRequest
{
public LoanReqestState State { get; private set; }
public long Amount { get; private set; }
public TimeSpan LoanDuration { get; private set; }

    public LoanRequest()
    {
        this.State = new DraftSate();
    }

public void Update(long amount, TimeSpan duration) {


        if (this.State.canUopdateReqest())
    {
        this.Amount = amount;
        this.LoanDuration = duration;
    }
       
    else
    {
        throw new Exception("!!!");
    }

}


    public void Accept()
    {

        if (this.State.CanAccept()) {
            this.State = new AcceptedtSate();
        }
        else {
            throw new Exception();
        }
       // if(State == LoanRequestState.InProgress) {
            //...
         //   this.State = LoanRequestState.Accepted;
       // }
       // else {
         //   throw new Exception("/////");
        //}
 }




