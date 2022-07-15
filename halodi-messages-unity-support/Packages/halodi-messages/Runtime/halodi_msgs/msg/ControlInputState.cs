using System.Text;
namespace halodi_msgs.msg
{


/**
          * State of the control input listener on the robot
          *
          */
[System.Serializable]
public class ControlInputState : Halodi.CDR.DataType<ControlInputState>
{

	public Halodi.CDR.TopicDataType<ControlInputState> Type => new ControlInputStatePubSubType();
	
   /**
                * The controller is still starting. Control is not possible yet.
                *
                */
   public const int WAITING_FOR_CONTROLLER_START = 0;
   /**
                * The controller is accepting commands normally.
                */
   public const int ACCEPTING_COMMANDS = 1;
   /**
                * The robot is frozen and does not accept commands. 
                * 
                * Use the StopCommand CLEAR_MOTOR_FAULTS_AND_GO_TO_DEFAULT_POSE to exit this state to default pose
                * Use the StopCommand SHUTDOWN_ROBOT to turn off the motors and controller
                */
   public const int FROZEN = 2;
   /**
                * The robot is clearing motor errors and moving to default pose.
                *
                */
   public const int MOVING_TO_DEFAULT_POSE = 3;
   /**
                * The robot is in default pose
                * 
                * Use the StopCommand RESUME_CONTROL to accept commands again
                * Use the StopCommand SHUTDOWN_ROBOT to turn off the motors and controller
                */
   public const int DEFAULT_POSE = 4;
   /**
                * The robot has been turned off by an unrecoverable fault.
                * 
                * Note: This could be the user pressing the emergency stop.
                *
                */
   public const int FAULTED = 5;
   public int state;


   public void Set(ControlInputState other)
   {
      state = other.state;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ControlInputState {");
      builder.Append("state=");
      builder.Append(this.state);
      builder.Append("}");
      return builder.ToString();
   }
}


}