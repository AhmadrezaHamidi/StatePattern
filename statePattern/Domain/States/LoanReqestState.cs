using System;
namespace Domain.States
{
	public abstract class LoanReqestState
	{
        public abstract bool canUopdateReqest();
        public virtual bool CanAccept() => false;
	}


    public class DraftSate : LoanReqestState
    {
        public override bool canUopdateReqest() => true;
    }


    public class InProgressSate : LoanReqestState
    {
        public override bool canUopdateReqest() => false;
        public override bool CanAccept() => true;

    }

    public class RejectedSate : LoanReqestState
    {
        public override bool canUopdateReqest() => false;

    }
    public class AcceptedtSate : LoanReqestState
    {
        public override bool canUopdateReqest() => false;

    }

}

