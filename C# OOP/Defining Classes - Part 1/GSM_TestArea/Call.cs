using System;
using System.Collections.Generic;


namespace GSM_TestArea
{
    public class Call
    {
        //fields
        private DateTime callDateTime = new DateTime();
        private string dialedNumber;
        private int callDuration;


        //constructors
        public Call(DateTime callDateTime,string dialedNumber,int callDuration)
        {
            this.CallDateTime = callDateTime;
            this.DialedNumber = dialedNumber;
            this.CallDuration = callDuration;
        }
        //properties
        public DateTime CallDateTime { get; set; }
        public string DialedNumber{ get; set; }
        public int CallDuration { get; set; }
        //methods
    }
}
