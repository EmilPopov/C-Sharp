using System;


namespace GSM_TestArea
{
    public enum BatteryType
    {
        Null,
        Li_Ion, 
        NiMH, 
        NiCd,
        LiPol,
    }
    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType type = BatteryType.Null;
        public Battery(string batteryModel, double batteryHoursIdle, double batteryHoursTalk, BatteryType type)
        {
            this.Model = batteryModel;
            this.HoursIdle = batteryHoursIdle;
            this.HoursTalk = batteryHoursTalk;
            this.Type = type;
        }

        public double HoursTalk 
        {
            get { return hoursTalk; }
            set { this.hoursTalk = value; }
        }
        
        public double HoursIdle
        {
            get { return hoursIdle; }
            set { this.hoursIdle = value; }
        }
        
        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }


        public BatteryType Type { get; set; }
    }
}
