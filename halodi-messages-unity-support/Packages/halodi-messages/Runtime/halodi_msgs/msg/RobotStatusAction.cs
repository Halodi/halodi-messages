using System.Text;
namespace halodi_msgs.msg
{


/**
         *  Enum describing the action the robot should take based on its status
         */
[System.Serializable]
public class RobotStatusAction : Halodi.CDR.DataType<RobotStatusAction>
{

	public Halodi.CDR.TopicDataType<RobotStatusAction> Type => new RobotStatusActionPubSubType();
	
   /**
                * No action is taken
                */
   public const byte NO_ACTION = (byte) 0;
   /**
                * The robot goes to "safe pose"
                */
   public const byte SAFE_POSE = (byte) 1;
   /**
                * The robot goes to its "shutdown pose". Not implemented
                */
   public const byte SHUTDOWN_POSE = (byte) 2;
   /**
                * The robot disables motor power immediatly. 
                */
   public const byte DISABLE_MOTOR_POWER = (byte) 3;
   public byte action;


   public void Set(RobotStatusAction other)
   {
      action = other.action;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("RobotStatusAction {");
      builder.Append("action=");
      builder.Append(this.action);
      builder.Append("}");
      return builder.ToString();
   }
}


}