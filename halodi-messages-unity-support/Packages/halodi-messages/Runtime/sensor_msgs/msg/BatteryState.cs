using System.Text;
namespace sensor_msgs.msg
{


/**
       * Constants are chosen to match the enums in the linux kernel
       * defined in include/linux/power_supply.h as of version 3.7
       * The one difference is for style reasons the constants are
       * all uppercase not mixed case.
       */
[System.Serializable]
public class BatteryState
{
   /**
          * Power supply status constants
          */
   public const byte POWER_SUPPLY_STATUS_UNKNOWN = (byte) 0;
   public const byte POWER_SUPPLY_STATUS_CHARGING = (byte) 1;
   public const byte POWER_SUPPLY_STATUS_DISCHARGING = (byte) 2;
   public const byte POWER_SUPPLY_STATUS_NOT_CHARGING = (byte) 3;
   public const byte POWER_SUPPLY_STATUS_FULL = (byte) 4;
   /**
          * Power supply health constants
          */
   public const byte POWER_SUPPLY_HEALTH_UNKNOWN = (byte) 0;
   public const byte POWER_SUPPLY_HEALTH_GOOD = (byte) 1;
   public const byte POWER_SUPPLY_HEALTH_OVERHEAT = (byte) 2;
   public const byte POWER_SUPPLY_HEALTH_DEAD = (byte) 3;
   public const byte POWER_SUPPLY_HEALTH_OVERVOLTAGE = (byte) 4;
   public const byte POWER_SUPPLY_HEALTH_UNSPEC_FAILURE = (byte) 5;
   public const byte POWER_SUPPLY_HEALTH_COLD = (byte) 6;
   public const byte POWER_SUPPLY_HEALTH_WATCHDOG_TIMER_EXPIRE = (byte) 7;
   public const byte POWER_SUPPLY_HEALTH_SAFETY_TIMER_EXPIRE = (byte) 8;
   /**
          * Power supply technology (chemistry) constants
          */
   public const byte POWER_SUPPLY_TECHNOLOGY_UNKNOWN = (byte) 0;
   public const byte POWER_SUPPLY_TECHNOLOGY_NIMH = (byte) 1;
   public const byte POWER_SUPPLY_TECHNOLOGY_LION = (byte) 2;
   public const byte POWER_SUPPLY_TECHNOLOGY_LIPO = (byte) 3;
   public const byte POWER_SUPPLY_TECHNOLOGY_LIFE = (byte) 4;
   public const byte POWER_SUPPLY_TECHNOLOGY_NICD = (byte) 5;
   public const byte POWER_SUPPLY_TECHNOLOGY_LIMN = (byte) 6;
   public std_msgs.msg.Header header;
   /**
            * Voltage in Volts (Mandatory)
            */
   public float voltage;
   /**
            * Temperature in Degrees Celsius (If unmeasured NaN)
            */
   public float temperature;
   /**
            * Negative when discharging (A)  (If unmeasured NaN)
            */
   public float current;
   /**
            * Current charge in Ah  (If unmeasured NaN)
            */
   public float charge;
   /**
            * Capacity in Ah (last full capacity)  (If unmeasured NaN)
            */
   public float capacity;
   /**
            * Capacity in Ah (design capacity)  (If unmeasured NaN)
            */
   public float design_capacity;
   /**
            * Charge percentage on 0 to 1 range  (If unmeasured NaN)
            */
   public float percentage;
   /**
            * The charging status as reported. Values defined above
            */
   public byte power_supply_status;
   /**
            * The battery health metric. Values defined above
            */
   public byte power_supply_health;
   /**
            * The battery chemistry. Values defined above
            */
   public byte power_supply_technology;
   /**
            * True if the battery is present
            */
   public bool present;
   /**
            * An array of individual cell voltages for each cell in the pack
            */
   public System.Collections.Generic.List<float> cell_voltage;
   /**
            * If individual voltages unknown but number of cells known set each to NaN
            * An array of individual cell temperatures for each cell in the pack
            */
   public System.Collections.Generic.List<float> cell_temperature;
   /**
            * If individual temperatures unknown but number of cells known set each to NaN
            * The location into which the battery is inserted. (slot number or plug)
            */
   public string location;
   /**
            * The best approximation of the battery serial number
            */
   public string serial_number;


   public void Set(BatteryState other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      voltage = other.voltage;

      temperature = other.temperature;

      current = other.current;

      charge = other.charge;

      capacity = other.capacity;

      design_capacity = other.design_capacity;

      percentage = other.percentage;

      power_supply_status = other.power_supply_status;

      power_supply_health = other.power_supply_health;

      power_supply_technology = other.power_supply_technology;

      present = other.present;


      if(other.cell_voltage == null)
      {
      	cell_voltage = null;
      }
      else
      {
      	cell_voltage = new System.Collections.Generic.List<float>(other.cell_voltage.Count);
      	for(int i1 = 0; i1 < other.cell_voltage.Count; i1++)
      	{
         		cell_voltage.Add(other.cell_voltage[i1]);
      	}
      }

      if(other.cell_temperature == null)
      {
      	cell_temperature = null;
      }
      else
      {
      	cell_temperature = new System.Collections.Generic.List<float>(other.cell_temperature.Count);
      	for(int i2 = 0; i2 < other.cell_temperature.Count; i2++)
      	{
         		cell_temperature.Add(other.cell_temperature[i2]);
      	}
      }
      location = other.location;

      serial_number = other.serial_number;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("BatteryState {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("voltage=");
      builder.Append(this.voltage);      builder.Append(", ");
      builder.Append("temperature=");
      builder.Append(this.temperature);      builder.Append(", ");
      builder.Append("current=");
      builder.Append(this.current);      builder.Append(", ");
      builder.Append("charge=");
      builder.Append(this.charge);      builder.Append(", ");
      builder.Append("capacity=");
      builder.Append(this.capacity);      builder.Append(", ");
      builder.Append("design_capacity=");
      builder.Append(this.design_capacity);      builder.Append(", ");
      builder.Append("percentage=");
      builder.Append(this.percentage);      builder.Append(", ");
      builder.Append("power_supply_status=");
      builder.Append(this.power_supply_status);      builder.Append(", ");
      builder.Append("power_supply_health=");
      builder.Append(this.power_supply_health);      builder.Append(", ");
      builder.Append("power_supply_technology=");
      builder.Append(this.power_supply_technology);      builder.Append(", ");
      builder.Append("present=");
      builder.Append(this.present);      builder.Append(", ");
      builder.Append("cell_voltage=");
      builder.Append(this.cell_voltage);      builder.Append(", ");
      builder.Append("cell_temperature=");
      builder.Append(this.cell_temperature);      builder.Append(", ");
      builder.Append("location=");
      builder.Append(this.location);      builder.Append(", ");
      builder.Append("serial_number=");
      builder.Append(this.serial_number);
      builder.Append("}");
      return builder.ToString();
   }
}


}