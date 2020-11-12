using System.Text;
namespace halodi_msgs.msg
{


/**
          * Status of the battery
          *
          */
[System.Serializable]
public class BatteryStatus
{
   /**
                * Charge status of the battery
                * 
                * WARNING: The robot should be moved to a safe position to shutdown and charge as soon as possible. 
                * ERROR: Note, this shutdown happens even if the battery voltage drops momentary due to fast motions. 
                *
                */
   public byte battery_status_level;
   /**
                * Current estimate of the battery voltage in Volts
                *
                */
   public double battery_voltage;
   /**
                * Battery voltage when the robot will emit a warning
                * 
                * 
                *
                */
   public double low_battery_voltage;
   /**
                * Battery voltage when the robot will shutdown
                * 
                */
   public double shutdown_battery_voltage;


   public void Set(BatteryStatus other)
   {
      battery_status_level = other.battery_status_level;

      battery_voltage = other.battery_voltage;

      low_battery_voltage = other.low_battery_voltage;

      shutdown_battery_voltage = other.shutdown_battery_voltage;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("BatteryStatus {");
      builder.Append("battery_status_level=");
      builder.Append(this.battery_status_level);      builder.Append(", ");
      builder.Append("battery_voltage=");
      builder.Append(this.battery_voltage);      builder.Append(", ");
      builder.Append("low_battery_voltage=");
      builder.Append(this.low_battery_voltage);      builder.Append(", ");
      builder.Append("shutdown_battery_voltage=");
      builder.Append(this.shutdown_battery_voltage);
      builder.Append("}");
      return builder.ToString();
   }
}


}