using System.Text;
namespace halodi_msgs.msg
{


/**
          * Command to stop the robot
          *
          * Allows trigging different stop modes and clearing the stop status
          *
          */
[System.Serializable]
public class StopCommand : Halodi.CDR.DataType<StopCommand>
{

	public Halodi.CDR.TopicDataType<StopCommand> Type => new StopCommandPubSubType();
	
   /**
                * Freeze the robot.
                *
                * Valid from all control input states
                */
   public const int FREEZE_ROBOT = 0;
   /**
                * Clear the motor faults and go to default pose.
                *
                * Valid from all control input states
                * 
                */
   public const int CLEAR_MOTOR_FAULTS_AND_GO_TO_DEFAULT_POSE = 1;
   /**
                * Resume listing for control messages
                *
                * Valid from the input state DEFAULT_POSE 
                */
   public const int RESUME_CONTROL = 2;
   /**
                * Turn off all motors
                * 
                * Valid from the input state FREEZE and DEFAULT_POSE
                *
                */
   public const int SHUTDOWN_ROBOT = 3;
   public int stop_command;


   public void Set(StopCommand other)
   {
      stop_command = other.stop_command;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("StopCommand {");
      builder.Append("stop_command=");
      builder.Append(this.stop_command);
      builder.Append("}");
      return builder.ToString();
   }
}


}