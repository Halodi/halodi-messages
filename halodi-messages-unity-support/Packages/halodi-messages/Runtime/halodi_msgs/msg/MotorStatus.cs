using System.Text;
namespace halodi_msgs.msg
{


/**
          * Status of a motor
          *
          * This message is a custom type instead of DiagnosticsArray, due to the overhead of String based values inside the controller
          *
          */
[System.Serializable]
public class MotorStatus
{
   public const byte NO_ERROR = (byte) 0;
   public const byte FAULTED = (byte) 1;
   public const byte MISSED_DEADLINE = (byte) 2;
   public const byte AUX_ENCODER_WARNING = (byte) 3;
   public const byte AUX_ENCODER_ERROR = (byte) 4;
   public const byte MOTOR_ENCODER_WARNING = (byte) 5;
   public const byte MOTOR_ENCODER_ERROR = (byte) 6;
   public const byte OVER_TEMPERATURE = (byte) 7;
   public const byte OVER_VOLTAGE = (byte) 8;
   public const byte UNDER_VOLTAGE = (byte) 9;
   public const byte ETHERCAT_FAULT = (byte) 10;
   public const byte INVALID_STATE_TRANSITION = (byte) 11;
   /**
                * Current status level of the motor
                *
                * As described in diagnostic_msgs/DiagnosticStatus
                *
                */
   public byte status_level;
   /**
                * Joints controlled by this motor
                *
                */
   public System.Collections.Generic.List<halodi_msgs.msg.JointName> joints;
   /**
                * ID of the motor with respect to the transmission 
                * 
                * This is either 0 or 1
                *
                */
   public byte motor_id;
   /**
                *
                * Safe Torque Off (STO) enabled status.
                *
                * If STO is enabled, the motor driver is unable to turn on.
                */
   public bool sto_enabled;
   /**
                * If statusLevel == WARNING: The motor exceeds the warning temperature
                * If statusLevel == ERROR: The motor exceeds the error temperature and has been shutdown.
                */
   public bool over_temperature;
   /**
                *
                * Serial number of the motor.
                *
                */
   public uint motor_serial_number;
   /**
                * Serial number of the driver.
                *
                */
   public uint driver_serial_number;
   /**
                * Set to true when the motor is initialized and reporting data
                *
                */
   public bool motor_initialized;
   /**
                * Current temperature of the motor
                *
                */
   public double motor_temperature;
   /**
                * Current temperature of the motor driver
                *
                */
   public double driver_temperature;
   /**
                * Error state from the motor driver board.
                *
                */
   public byte motor_error;


   public void Set(MotorStatus other)
   {
      status_level = other.status_level;


      if(other.joints == null)
      {
      	joints = null;
      }
      else
      {
      	joints = new System.Collections.Generic.List<halodi_msgs.msg.JointName>(other.joints.Count);
      	for(int i1 = 0; i1 < other.joints.Count; i1++)
      	{
      		if(other.joints[i1] == null)
      		{
      			joints.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.JointName newElement = halodi_msgs.msg.JointNamePubSubType.Create();
      	   		halodi_msgs.msg.JointNamePubSubType.Copy(other.joints[i1], newElement);
      	   		joints.Add(newElement);
      		}	}
      }
      motor_id = other.motor_id;

      sto_enabled = other.sto_enabled;

      over_temperature = other.over_temperature;

      motor_serial_number = other.motor_serial_number;

      driver_serial_number = other.driver_serial_number;

      motor_initialized = other.motor_initialized;

      motor_temperature = other.motor_temperature;

      driver_temperature = other.driver_temperature;

      motor_error = other.motor_error;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MotorStatus {");
      builder.Append("status_level=");
      builder.Append(this.status_level);      builder.Append(", ");
      builder.Append("joints=");
      builder.Append(this.joints);      builder.Append(", ");
      builder.Append("motor_id=");
      builder.Append(this.motor_id);      builder.Append(", ");
      builder.Append("sto_enabled=");
      builder.Append(this.sto_enabled);      builder.Append(", ");
      builder.Append("over_temperature=");
      builder.Append(this.over_temperature);      builder.Append(", ");
      builder.Append("motor_serial_number=");
      builder.Append(this.motor_serial_number);      builder.Append(", ");
      builder.Append("driver_serial_number=");
      builder.Append(this.driver_serial_number);      builder.Append(", ");
      builder.Append("motor_initialized=");
      builder.Append(this.motor_initialized);      builder.Append(", ");
      builder.Append("motor_temperature=");
      builder.Append(this.motor_temperature);      builder.Append(", ");
      builder.Append("driver_temperature=");
      builder.Append(this.driver_temperature);      builder.Append(", ");
      builder.Append("motor_error=");
      builder.Append(this.motor_error);
      builder.Append("}");
      return builder.ToString();
   }
}


}