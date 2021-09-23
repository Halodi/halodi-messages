using System.Text;
namespace halodi_msgs.msg
{


/**
          * Status of the battery
          *
          */
[System.Serializable]
public class BatteryStatus : Halodi.CDR.DataType<BatteryStatus>
{

	public Halodi.CDR.TopicDataType<BatteryStatus> Type => new BatteryStatusPubSubType();
	
   /**
                * Charge status of the battery
                * 
                * WARNING: The robot should be moved to a safe position to shutdown and charge as soon as possible. 
                * ERROR: The battery is empty. The robot will go in a safe pose to avoid falling down
                * CRITICAL: The battery management system (BMS) turned off the power and the robot fell over. Note: This is never transmitted.
                *
                */
   public halodi_msgs.msg.RobotStatusLevel battery_status_level;
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
      halodi_msgs.msg.RobotStatusLevelPubSubType.Copy(other.battery_status_level, battery_status_level);

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