using System.Text;
namespace halodi_msgs.msg
{


/**
          * Status of a robot
          *
          * This message is a custom type instead of DiagnosticsArray, due to the overhead of String based values inside the controller
          *
          */
[System.Serializable]
public class RobotStatus : Halodi.CDR.DataType<RobotStatus>
{

	public Halodi.CDR.TopicDataType<RobotStatus> Type => new RobotStatusPubSubType();
	
   /**
                * Standard ROS header
                */
   public std_msgs.msg.Header header;
   /**
                * Current status level of the robot
                *
                * As described in diagnostic_msgs/DiagnosticStatus
                *
                */
   public byte robot_status_level;
   /**
                *
                * Status of the battery
                *
                */
   public halodi_msgs.msg.BatteryStatus battery_status;
   /**
                *
                * State of the estop on the backpack of the robot. 
                * 
                * If true, power can be applied to the motors
                *
                */
   public bool backpack_estop_enabled;
   /**
                *
                * State of the wireless estop
                * 
                * If true, power can be applied to the motors
                *
                */
   public bool wireless_estop_enabled;
   /**
                * True if one of the motors in the robot is overheating.
                * 
                * This data can be read from the individual motors, but is available as an easy check here.
                *
                */
   public bool over_temperature;
   /**
                * True if due a fault, the wheels are disabled but the robot is still able to balance
                *
                */
   public bool driving_disabled;
   /**
                * Status of the joints on the robot
                *
                */
   public System.Collections.Generic.List<halodi_msgs.msg.JointStatus> joint_status;
   /**
                * Status of the motors on the robot
                * 
                * Note that motors are shared by multiple joints due to the differential drives, hence the split between motor and joint.
                *
                */
   public System.Collections.Generic.List<halodi_msgs.msg.MotorStatus> motor_status;
   /**
                * The time the robot has been running since the controller was started.
                *
                * Unit: seconds
                *
                */
   public uint runtime_since_start;
   /**
                * The time the robot has been running in total
                *
                * Unit: seconds
                *
                */
   public uint total_runtime;
   /**
                 * The nubmer of times the controller has been started.
                 *
                 */
   public uint numberOfRuns;


   public void Set(RobotStatus other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      robot_status_level = other.robot_status_level;

      halodi_msgs.msg.BatteryStatusPubSubType.Copy(other.battery_status, battery_status);

      backpack_estop_enabled = other.backpack_estop_enabled;

      wireless_estop_enabled = other.wireless_estop_enabled;

      over_temperature = other.over_temperature;

      driving_disabled = other.driving_disabled;


      if(other.joint_status == null)
      {
      	joint_status = null;
      }
      else
      {
      	joint_status = new System.Collections.Generic.List<halodi_msgs.msg.JointStatus>(other.joint_status.Count);
      	for(int i1 = 0; i1 < other.joint_status.Count; i1++)
      	{
      		if(other.joint_status[i1] == null)
      		{
      			joint_status.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.JointStatus newElement = halodi_msgs.msg.JointStatusPubSubType.Create();
      	   		halodi_msgs.msg.JointStatusPubSubType.Copy(other.joint_status[i1], newElement);
      	   		joint_status.Add(newElement);
      		}	}
      }

      if(other.motor_status == null)
      {
      	motor_status = null;
      }
      else
      {
      	motor_status = new System.Collections.Generic.List<halodi_msgs.msg.MotorStatus>(other.motor_status.Count);
      	for(int i2 = 0; i2 < other.motor_status.Count; i2++)
      	{
      		if(other.motor_status[i2] == null)
      		{
      			motor_status.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.MotorStatus newElement = halodi_msgs.msg.MotorStatusPubSubType.Create();
      	   		halodi_msgs.msg.MotorStatusPubSubType.Copy(other.motor_status[i2], newElement);
      	   		motor_status.Add(newElement);
      		}	}
      }
      runtime_since_start = other.runtime_since_start;

      total_runtime = other.total_runtime;

      numberOfRuns = other.numberOfRuns;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("RobotStatus {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("robot_status_level=");
      builder.Append(this.robot_status_level);      builder.Append(", ");
      builder.Append("battery_status=");
      builder.Append(this.battery_status);      builder.Append(", ");
      builder.Append("backpack_estop_enabled=");
      builder.Append(this.backpack_estop_enabled);      builder.Append(", ");
      builder.Append("wireless_estop_enabled=");
      builder.Append(this.wireless_estop_enabled);      builder.Append(", ");
      builder.Append("over_temperature=");
      builder.Append(this.over_temperature);      builder.Append(", ");
      builder.Append("driving_disabled=");
      builder.Append(this.driving_disabled);      builder.Append(", ");
      builder.Append("joint_status=");
      builder.Append(this.joint_status);      builder.Append(", ");
      builder.Append("motor_status=");
      builder.Append(this.motor_status);      builder.Append(", ");
      builder.Append("runtime_since_start=");
      builder.Append(this.runtime_since_start);      builder.Append(", ");
      builder.Append("total_runtime=");
      builder.Append(this.total_runtime);      builder.Append(", ");
      builder.Append("numberOfRuns=");
      builder.Append(this.numberOfRuns);
      builder.Append("}");
      return builder.ToString();
   }
}


}